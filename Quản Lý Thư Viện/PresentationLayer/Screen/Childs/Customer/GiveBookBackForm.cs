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

namespace PresentationLayer.Screen.Childs
{
    public partial class GiveBookBackForm : Form
    {
        private readonly ICustomerService customerService = new CustomerService();
        private readonly IBookService bookService = new BookService();
        private readonly Customer customer;

        public GiveBookBackForm(Customer customer)
        {
            this.InitializeComponent();
            this.customer = customer;
            this.lblNoHistory.Visible = this.customer.Books.Count() == 0;
        }

        private void GiveBookBackForm_Load(object sender, EventArgs e)
        {
            this.BindGrid(this.customer.Books.Where(book => book.Date_Returned is null));
        }

        private void BindGrid(IEnumerable<CustomerBooks> collection)
        {
            this.bindingSource.DataSource = collection.Select(book =>
            {
                return new
                {
                    book.Book_Id,
                    book.Book.Name,
                    book.From,
                    book.To,
                    book.Date_Returned,
                };
            });
        }

        private void GiveBookBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(this.dataGridView.SelectedRows[0].Cells[0].Value.ToString());

            try
            {
                // Cập nhật ngày trả sách
                CustomerBooks customerBooks = this.customer.Books.FirstOrDefault(b => b.Book_Id == bookId);
                customerBooks.Date_Returned = DateTime.Now;
                this.customerService.Update(this.customer);

                // Tăng số lượng sách đã trả
                Book book = this.bookService.Find(customerBooks.Book_Id);
                book.NumberOfBooks++;
                this.bookService.Update(book);

                MessageBox.Show("Trả sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.InnerException.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            this.dataGridView.ClearSelection();

            if (e.RowIndex > -1)
            {
                this.dataGridView.Rows[e.RowIndex].Selected = true;
                e.ContextMenuStrip = this.contextMenuStrip;
            }
        }
    }
}
