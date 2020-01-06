using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BusinessLogicLayer;
using Core;
using DataTransferObject;
using Guna.UI.Lib;

namespace PresentationLayer.Screen.Childs
{
    public partial class InsertCustomerForm : Form
    {
        private readonly ICustomerService customerService = new CustomerService();

        public InsertCustomerForm()
        {
            this.InitializeComponent();
        }

        private void InsertCustomerForm_Load(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool validated = this.ValidateChildren();

            if (!validated)
            {
                return;
            }

            Customer customer = this.GetCustomer();

            this.customerService.Insert(customer);

            this.Close();
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
                return;
            }

            if (this.customerService.FindByEmail(email).Count() != 0)
            {
                Validation.SetErrorTextBox(this.txtEmail, this.lblEmailError, "Địa chỉ email đã được sử dụng");
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

            if (!Validation.IsPhoneNumber(phone))
            {
                Validation.SetErrorTextBox(this.txtPhone, this.lblPhoneError, "Số điện thoại không hợp lệ");
                e.Cancel = true;
            }

            if (this.customerService.FindByPhone(phone).Count() != 0)
            {
                Validation.SetErrorTextBox(this.txtPhone, this.lblPhoneError, "Số điện thoại đã được sử dụng");
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

        private Customer GetCustomer()
        {
            return new Customer
            {
                Name = this.txtName.Text,
                Email = this.txtEmail.Text,
                Phone = this.txtPhone.Text,
                Birthday = this.dtBirthDay.Value.Date,
                Address = this.txtAddress.Text,
            };
        }
    }
}
