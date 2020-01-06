using System;
using System.ComponentModel;
using System.Security.Authentication;
using System.Windows.Forms;
using BusinessLogicLayer;
using Core;
using Guna.UI.Lib;

namespace PresentationLayer.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IUserService userService = new UserService();
        private readonly Form loadingForm = new LoadingForm();

        public LoginForm()
        {
            this.InitializeComponent();
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);
        }

        /// <summary>
        /// Thực hiện kiểm tra đăng nhập.
        /// </summary>
        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            try
            {
                this.btnLogin.Enabled = false;

                this.loadingForm.Show();

                AuthService.User = await this.userService.Login(this.txtUsername.Text, this.txtPassword.Text);

                this.Hide();

                this.loadingForm.Close();

                new MainForm().ShowDialog();

                this.Close();
            }
            catch (AuthenticationException exception)
            {
                this.loadingForm.Hide();
                MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.btnLogin.Enabled = true;
            }
        }

        /// <summary>
        /// Kiểm tra username có phải là một email hợp lệ.
        /// </summary>
        private void TxtUsername_Validating(object sender, CancelEventArgs e)
        {
            string email = this.txtUsername.Text;

            if (string.IsNullOrEmpty(email))
            {
                Validation.SetErrorTextBox(this.txtUsername, this.lblUsernameError, "Địa chỉ email không được để trống");
                e.Cancel = true;
                return;
            }

            if (!Validation.IsEmail(email))
            {
                Validation.SetErrorTextBox(this.txtUsername, this.lblUsernameError, "Địa chỉ email không hợp lệ");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Xóa báo lỗi khi địa chỉ email hợp lệ.
        /// </summary>
        private void TxtUsername_Validated(object sender, EventArgs e)
        {
            Validation.ClearErrorTextBox(this.txtUsername, this.lblUsernameError, hideLabelError: true);
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ của password.
        /// </summary>
        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            string password = this.txtPassword.Text;

            if (string.IsNullOrEmpty(password))
            {
                Validation.SetErrorTextBox(this.txtPassword, this.lblPasswordError, "Mật khẩu không được để trống");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Xóa báo lỗi khi mật khẩu hợp lệ.
        /// </summary>
        private void TxtPassword_Validated(object sender, EventArgs e)
        {
            Validation.ClearErrorTextBox(this.txtPassword, this.lblPasswordError);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
