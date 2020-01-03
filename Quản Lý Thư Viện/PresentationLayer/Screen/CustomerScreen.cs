using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Services;
using DataTransferObject;
using PresentationLayer.Screen.Childs;
using PresentationLayer.Screen.Layouts;

namespace PresentationLayer.Screen
{
    public partial class CustomerScreen
        : LayoutScreen<Customer, CustomerService>
    {
        public CustomerScreen()
            : base("Quản Lý Khách Hàng")
        {
        }

        protected override void ShowInsertForm()
        {
            var insertForm = new InsertLayoutForm<Customer, CustomerService>
            {
                Title = "Thêm Khách Hàng",
                Label = "Tên khách hàng",
                BtnText = "Thêm khách hàng",
            };
            insertForm.ShowDialog();
        }
    }
}
