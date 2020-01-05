using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
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
    public partial class BorrowBooksForm : Form
    {
        private readonly ICustomerService customerService = new CustomerService();
        private readonly IBookService bookService = new BookService();
        private readonly Customer customer;

        public BorrowBooksForm(Customer customer)
        {
            this.InitializeComponent();
            this.customer = customer;
            this.lblCustomerName.Text = customer.Name;
            this.lblBooksCount.Text = customer.Books.Count().ToString();
            this.lblNumberOfBooksBorrowed.Text = customer.Books.Where(book => book.Date_Returned is null).Count().ToString();
            this.lblNumberOfBooksReturned.Text = customer.Books.Where(book => book.Date_Returned != null).Count().ToString();
        }

        private async void BorrowBooksForm_Load(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);

            IEnumerable<Book> books = await this.bookService.All();
            this.cmbBookName.DataSource = books.ToList();
            this.cmbBookName.DisplayMember = "Name";
            this.cmbBookName.ValueMember = "Name";
        }

        /// <summary>
        /// Kiểm tra khách hàng đã mượn sách chưa, nếu mượn mà chưa trả thì không cho mượn lại.
        /// </summary>
        private void CmbBookName_Validating(object sender, CancelEventArgs e)
        {
            Book bookSelected = (Book)this.cmbBookName.SelectedItem;

            CustomerBooks customerBooks = this.customer.Books.FirstOrDefault(book => book.Book_Id == bookSelected.Id &&
                                                                                     book.Date_Returned is null);

            if (customerBooks != null)
            {
                Validation.SetErrorTextBox(null, this.lblBookNameError, "Đã mượn sách này và chưa trả");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Xóa tin nhắn báo lỗi nếu quyển sách cần mượn hợp lệ.
        /// </summary>
        private void CmbBookName_Validated(object sender, EventArgs e)
        {
            Validation.ClearErrorTextBox(null, this.lblBookNameError);
        }

        /// <summary>
        /// Kiểm tra ngày mượn có hợp lệ hay không.
        /// </summary>
        private void DtFrom_Validating(object sender, CancelEventArgs e)
        {
            if (!this.ValidateDateTime())
            {
                Validation.SetErrorTextBox(null, this.lblFromError, "Ngày mượn không được lớn hơn hoặc trùng ngày trả");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Nếu ngày mượn hợp lệ thì xóa dòng báo lỗi.
        /// </summary>
        private void DtFrom_Validated(object sender, EventArgs e)
        {
            Validation.ClearErrorTextBox(null, this.lblFromError);
        }

        /// <summary>
        /// Kiểm tra ngày sẽ trả có hợp lệ hay không.
        /// </summary>
        private void DtTo_Validating(object sender, CancelEventArgs e)
        {
            if (!this.ValidateDateTime())
            {
                Validation.SetErrorTextBox(null, this.lblToError, "Ngày sẽ trả không được nhỏ hơn hoặc trùng ngày trả");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Nếu ngày sẽ trả hợp lệ thì xóa dòng báo lỗi.
        /// </summary>
        private void DtTo_Validated(object sender, EventArgs e)
        {
            Validation.ClearErrorTextBox(null, this.lblToError);
        }

        /// <summary>
        /// Kiểm tra ngày sẽ trả có lớn hơn ngày mượn.
        /// </summary>
        /// <returns><see langword="true"/> nếu hợp lệ, <see langword="false"/> nếu không hợp lệ.</returns>
        private bool ValidateDateTime()
        {
            DateTime from = this.dtFrom.Value;
            DateTime to = this.dtTo.Value;

            return to > from;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            this.customer.Books.Add(new CustomerBooks
            {
                Book = (Book)this.cmbBookName.SelectedItem,
                From = this.dtFrom.Value.Date,
                To = this.dtTo.Value.Date,
            });

            try
            {
                this.customerService.Update(this.customer);

                MessageBox.Show("Mượn sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException exception)
            {
                MessageBox.Show(exception.InnerException.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
