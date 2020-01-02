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
        private readonly Book book;
        private ICollection<Author> authors = new HashSet<Author>();

        public BookInfoForm(int bookId)
        {
            this.InitializeComponent();
            this.book = this.bookService.Find(bookId);
        }

        private void BookInfoForm_Load(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);

            this.txtID.Text = this.book.Id.ToString();
            this.txtName.Text = this.book.Name;
            this.txtAuthors.Text = this.HumanizeAuthor(this.book.Authors);
        }

        private void BtnSelectAuthor_Click(object sender, EventArgs e)
        {
            BookInfoAuthorSelectForm bookInfoAuthorSelectForm = new BookInfoAuthorSelectForm(this.book.Authors)
            {
                SendListAuthors = this.ListAuthors,
            };
            bookInfoAuthorSelectForm.ShowDialog();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Book updateBook = this.GetBookData();

            this.bookService.Update(updateBook);

            this.Close();
        }

        private void ListAuthors(List<Author> authors)
        {
            this.authors = authors.ToList();
            this.txtAuthors.Text = this.HumanizeAuthor(this.authors);
        }

        private string HumanizeAuthor(ICollection<Author> authors)
        {
            if (authors is null)
            {
                return string.Empty;
            }

            return string.Join(", ", authors.Select(author => author.Name));
        }

        private Book GetBookData()
        {
            Book book = this.book;
            book.Name = this.txtName.Text;
            book.Authors = this.authors.ToHashSet();

            return book;
        }
    }
}
