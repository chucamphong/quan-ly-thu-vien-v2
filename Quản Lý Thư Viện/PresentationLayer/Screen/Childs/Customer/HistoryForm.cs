using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DataTransferObject;
using Guna.UI.Lib;

namespace PresentationLayer.Screen.Childs
{
    public partial class HistoryForm : Form
    {
        private readonly Customer customer;

        public HistoryForm(Customer customer)
        {
            this.InitializeComponent();
            this.customer = customer;
            this.cmbFilter.Text = "Tất cả";
            this.lblMessage.Visible = this.customer.Books.Count() == 0;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);
            this.BindGrid(this.customer.Books);
        }

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            switch (control.Text)
            {
                case "Tất cả":
                    this.BindGrid(this.customer.Books);
                    break;
                case "Chưa trả sách":
                    this.BindGrid(this.customer.Books.Where(book => book.Date_Returned is null));
                    break;
                default:
                    this.BindGrid(this.customer.Books.Where(book => book.Date_Returned != null));
                    break;
            }
        }

        private void BindGrid(IEnumerable<CustomerBooks> collection)
        {
            if (collection.Count() == 0)
            {
                this.lblMessage.Text = "Không có thông tin";
                this.lblMessage.Visible = true;
                this.bindingSource.DataSource = null;
                return;
            }

            this.lblMessage.Visible = false;
            this.bindingSource.DataSource = collection.OrderByDescending(book => book.Date_Returned).Select(book =>
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
    }
}
