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
using Core;
using DataTransferObject;
using Guna.UI.Lib;

namespace PresentationLayer.Screen.Childs
{
    public partial class InsertBookForm : Form
    {
        private readonly BookService bookService = new BookService();
        private readonly PublisherService publisherService = new PublisherService();
        private ICollection<Author> authors;
        private ICollection<Category> categories;

        public InsertBookForm()
        {
            this.InitializeComponent();
        }

        private async void BookInfoForm_Load(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);

            this.cmbPublisher.DataSource = (await this.publisherService.All()).ToList();
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            Book updateBook = this.GetBookData();

            this.bookService.Insert(updateBook);

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
            Book book = new Book
            {
                Name = this.txtName.Text,
                Authors = this.authors,
                Categories = this.categories,
                Publisher = this.cmbPublisher.SelectedItem as Publisher,
            };
            return book;
        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            string name = this.txtName.Text;

            if (string.IsNullOrEmpty(name))
            {
                Validation.SetErrorTextBox(this.txtName, this.lblNameError, "Tên sách không được để trống");
                e.Cancel = true;
                return;
            }

            if (this.bookService.FindByName(name) != null)
            {
                Validation.SetErrorTextBox(this.txtName, this.lblNameError, "Tên sách đã tồn tại");
                e.Cancel = true;
            }
        }

        private void TxtName_Validated(object sender, EventArgs e)
        {
            Validation.ClearErrorTextBox(this.txtName, this.lblNameError, hideLabelError: true);
        }

        private void TxtAuthors_Validating(object sender, CancelEventArgs e)
        {
            int count = this.authors?.Count() ?? 0;

            if (count == 0)
            {
                Validation.SetErrorTextBox(this.txtAuthors, this.lblAuthorsError, "Tác giả không được để trống");
                e.Cancel = true;
            }
        }

        private void TxtAuthors_Validated(object sender, EventArgs e)
        {
            Validation.ClearErrorTextBox(this.txtAuthors, this.lblAuthorsError, hideLabelError: true);
        }

        private void TxtCategories_Validating(object sender, CancelEventArgs e)
        {
            int count = this.categories?.Count() ?? 0;

            if (count == 0)
            {
                Validation.SetErrorTextBox(this.txtCategories, this.lblCategoriesError, "Thể loại không được để trống");
                e.Cancel = true;
            }
        }

        private void TxtCategories_Validated(object sender, EventArgs e)
        {
            Validation.ClearErrorTextBox(this.txtCategories, this.lblCategoriesError, hideLabelError: true);
        }
    }
}
