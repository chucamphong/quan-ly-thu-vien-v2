using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;
using Guna.UI.Lib;

namespace PresentationLayer.Screen.Childs
{
    public partial class InsertBookForm : Form
    {
        private readonly BookService bookService = new BookService();
        private readonly PublisherService publisherService = new PublisherService();
        private readonly Book book;
        private ICollection<Author> authors;
        private ICollection<Category> categories;

        public InsertBookForm()
        {
            this.InitializeComponent();
            //this.book = this.bookService.Find(bookId);
            //this.authors = this.book.Authors.ToHashSet();
            //this.categories = this.book.Categories.ToHashSet();
        }

        private async void BookInfoForm_Load(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);

            //this.txtID.Text = this.book.Id.ToString();
            //this.txtName.Text = this.book.Name;
            //this.txtAuthors.Text = this.HumanizeAuthor(this.book.Authors);
            //this.txtCategories.Text = this.HumanizeCategory(this.book.Categories);
            this.cmbPublisher.DataSource = (await this.publisherService.All()).ToList();
            //this.cmbPublisher.SelectedItem = this.book.Publisher;
            this.cmbPublisher.DisplayMember = "Name";
            this.cmbPublisher.ValueMember = "Name";
        }

        private void BtnSelectAuthor_Click(object sender, EventArgs e)
        {
            BookInfoAuthorSelectForm bookInfoAuthorSelectForm = new BookInfoAuthorSelectForm(this.authors)
            {
                SendListAuthors = this.ListAuthors,
            };
            bookInfoAuthorSelectForm.ShowDialog();
        }

        private void BtnAddCategories_Click(object sender, EventArgs e)
        {
            BookInfoCategorySelectForm bookInfoCategorySelectForm = new BookInfoCategorySelectForm(this.categories)
            {
                SendListCategories = this.ListCategories,
            };
            bookInfoCategorySelectForm.ShowDialog();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Book updateBook = this.GetBookData();

            this.bookService.Update(updateBook);

            this.Close();
        }

        private void ListAuthors(ICollection<Author> authors)
        {
            this.authors = authors.ToHashSet();
            this.txtAuthors.Text = this.Humanize(this.authors);
        }

        private void ListCategories(ICollection<Category> categories)
        {
            this.categories = categories.ToHashSet();
            this.txtCategories.Text = this.Humanize(this.categories);
        }

        private string Humanize<TEntity>(ICollection<TEntity> entities)
            where TEntity : IEntity
        {
            if (entities is null)
            {
                return string.Empty;
            }

            return string.Join(", ", entities.Select(entity => entity.Name));
        }

        private Book GetBookData()
        {
            Book book = this.book;
            book.Name = this.txtName.Text;
            book.Authors = this.authors.ToHashSet();
            book.Categories = this.categories.ToHashSet();
            book.Publisher = this.cmbPublisher.SelectedItem as Publisher;
            return book;
        }
    }
}
