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
    public partial class BookInfoForm : Form
    {
        private readonly BookService bookService = new BookService();
        private readonly PublisherService publisherService = new PublisherService();
        private readonly Book book;
        private ICollection<Author> authors = new HashSet<Author>();
        private ICollection<Category> categories = new HashSet<Category>();

        public BookInfoForm(int bookId)
        {
            this.InitializeComponent();
            this.book = this.bookService.Find(bookId);
            this.authors = this.book.Authors.ToHashSet();
            this.categories = this.book.Categories.ToHashSet();
        }

        private async void BookInfoForm_Load(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);

            this.txtID.Text = this.book.Id.ToString();
            this.txtName.Text = this.book.Name;
            this.txtAuthors.Text = this.HumanizeAuthor(this.book.Authors);
            this.txtCategories.Text = this.HumanizeCategory(this.book.Categories);
            this.cmbPublisher.DataSource = (await this.publisherService.All()).ToList();
            this.cmbPublisher.SelectedItem = this.book.Publisher;
            this.cmbPublisher.DisplayMember = "Name";
            this.cmbPublisher.ValueMember = "Name";
        }

        private void BtnSelectAuthor_Click(object sender, EventArgs e)
        {
            BookInfoAuthorSelectForm bookInfoAuthorSelectForm = new BookInfoAuthorSelectForm(this.book.Authors)
            {
                SendListAuthors = this.ListAuthors,
            };
            bookInfoAuthorSelectForm.ShowDialog();
        }

        private void BtnAddCategories_Click(object sender, EventArgs e)
        {
            BookInfoCategorySelectForm bookInfoCategorySelectForm = new BookInfoCategorySelectForm(this.book.Categories)
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

        private void ListAuthors(List<Author> authors)
        {
            this.authors = authors.ToHashSet();
            this.txtAuthors.Text = this.HumanizeAuthor(this.authors);
        }

        private void ListCategories(List<Category> categories)
        {
            this.categories = categories.ToHashSet();
            this.txtCategories.Text = this.HumanizeCategory(this.categories);
        }

        private string HumanizeAuthor(ICollection<Author> authors)
        {
            if (authors is null)
            {
                return string.Empty;
            }

            return string.Join(", ", authors.Select(author => author.Name));
        }

        private string HumanizeCategory(ICollection<Category> categories)
        {
            if (categories is null)
            {
                return string.Empty;
            }

            return string.Join(", ", categories.Select(category => category.Name));
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
