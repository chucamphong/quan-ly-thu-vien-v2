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
    public partial class BorrowBooksForm : Form
    {
        public BorrowBooksForm(Customer customer)
        {
            this.InitializeComponent();
        }
    }
}
