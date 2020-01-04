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
    public partial class BorrowBooksForm : Form
    {
        private readonly Customer customer;

        public BorrowBooksForm(Customer customer)
        {
            this.InitializeComponent();
            this.customer = customer;
            this.lblCustomerName.Text = this.customer.Name;
            this.lblBooksCount.Text = this.customer.Books.Count().ToString();
            this.lblNumberOfBooksBorrowed.Text = this.customer.Books.Where(book => book.Date_Returned is null).Count().ToString();
            this.lblNumberOfBooksReturned.Text = this.customer.Books.Where(book => book.Date_Returned != null).Count().ToString();
        }

        private void BorrowBooksForm_Load(object sender, EventArgs e)
        {
        }
    }
}
