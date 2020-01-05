using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObject;

namespace PresentationLayer.Screen.Childs
{
    public partial class HistoryForm : Form
    {
        private readonly Customer customer;

        public HistoryForm(Customer customer)
        {
            this.InitializeComponent();
            this.customer = customer;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            if (this.customer.Books.Count() == 0)
            {
                this.lblNoHistory.Visible = true;
                return;
            }

            this.bindingSource.DataSource = this.customer.Books.Select(book =>
            {
                return new
                {
                    Id = book.Book_Id,
                    book.Book.Name,
                    book.From,
                    book.To,
                    book.Date_Returned,
                };
            });
        }
    }
}
