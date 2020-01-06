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

namespace PresentationLayer.Screen
{
    public partial class HomeScreen : Form
    {
        private readonly IBookService bookService = new BookService();
        private readonly IPublisherService publisherService = new PublisherService();
        private readonly ICustomerService customerService = new CustomerService();
        private readonly IAuthorService authorService = new AuthorService();

        public HomeScreen()
        {
            this.InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.lblHello.Text = $"Xin chào {AuthService.User.Name}!";
            this.grdCardTongSoSach.Content = this.bookService.Count().ToString();
            this.grdCardTongSoNhaPhatHanh.Content = this.publisherService.Count().ToString();
            this.grdCardTongSoKhachHang.Content = this.customerService.Count().ToString();
            this.grdCardTongSoTacGia.Content = this.authorService.Count().ToString();
        }
    }
}
