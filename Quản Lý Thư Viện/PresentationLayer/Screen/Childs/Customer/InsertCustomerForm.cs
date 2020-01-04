using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace PresentationLayer.Screen.Childs
{
    public partial class InsertCustomerForm : Form
    {
        public InsertCustomerForm()
        {
            this.InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            string name = this.txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                Validation.SetErrorTextBox(this.txtName, this.lblNameError, "Họ tên khách hàng không được để trống");
                e.Cancel = true;
            }
        }

        private void TxtName_Validated(object sender, EventArgs e)
        {
            Validation.ClearErrorTextBox(this.txtName, this.lblNameError, true);
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = this.txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                Validation.SetErrorTextBox(this.txtEmail, this.lblEmailError, "Địa chỉ email không được để trống");
                e.Cancel = true;
                return;
            }

            if (!Validation.IsEmail(email))
            {
                Validation.SetErrorTextBox(this.txtEmail, this.lblEmailError, "Địa chỉ email không hợp lệ");
                e.Cancel = true;
            }
        }

        private void TxtEmail_Validated(object sender, EventArgs e)
        {
            Validation.ClearErrorTextBox(this.txtEmail, this.lblEmailError, true);
        }

        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {
            string phone = this.txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(phone))
            {
                Validation.SetErrorTextBox(this.txtPhone, this.lblPhoneError, "Số điện thoại không được để trống");
                e.Cancel = true;
                return;
            }

            if (!Regex.IsMatch(phone, @"^\(?([0-9]{3})\)?([0-9]{3})([0-9]{4,5})$"))
            {
                Validation.SetErrorTextBox(this.txtPhone, this.lblPhoneError, "Số điện thoại không hợp lệ");
                e.Cancel = true;
            }
        }

        private void TxtPhone_Validated(object sender, EventArgs e)
        {
            Validation.ClearErrorTextBox(this.txtPhone, this.lblPhoneError, true);
        }

        private void TxtAddress_Validating(object sender, CancelEventArgs e)
        {
            string address = this.txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(address))
            {
                Validation.SetErrorTextBox(this.txtAddress, this.lblAddressError, "Địa chỉ không được để trống");
                e.Cancel = true;
            }
        }

        private void TxtAddress_Validated(object sender, EventArgs e)
        {
            Validation.ClearErrorTextBox(this.txtAddress, this.lblAddressError, true);
        }
    }
}
