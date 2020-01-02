using System;
using System.ComponentModel;
using System.Drawing;
using System.Security.Authentication;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;
using Guna.UI.Lib;
using Guna.UI.WinForms;

namespace PresentationLayer.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserService userService = new UserService();

        public LoginForm()
        {
            this.InitializeComponent();
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);
            this.txtUsername.Text = "chucamphong@gmail.com";
            this.txtPassword.Text = "123456";
        }

        /// <summary>
        /// Thực hiện kiểm tra đăng nhập.
        /// </summary>
        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            Control btnLogin = sender as Control;
            LoadingForm loadingForm = new LoadingForm();

            try
            {
                btnLogin.Enabled = false;
                loadingForm.Show();

                User user = await this.userService.Login(this.txtUsername.Text, this.txtPassword.Text);

                this.Hide();

                loadingForm.Close();

                AuthService.User = user;

                new MainForm().ShowDialog();

                this.Close();
            }
            catch (ArgumentException exception)
            {
                loadingForm.Close();
                MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (AuthenticationException exception)
            {
                loadingForm.Close();
                MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }

        /// <summary>
        /// Kiểm tra username có phải là một email hợp lệ.
        /// </summary>
        private void TxtUsername_Validating(object sender, CancelEventArgs e)
        {
            GunaTextBox txtUsername = sender as GunaTextBox;
            string email = txtUsername.Text;

            try
            {
                this.userService.CheckEmail(email);
                this.ClearErrorTextBox(txtUsername, this.lblUsernameError);
            }
            catch (ArgumentException exception)
            {
                this.SetErrorTextBox(txtUsername, this.lblUsernameError, exception.Message);
            }
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ của password.
        /// </summary>
        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            GunaTextBox txtPassword = sender as GunaTextBox;
            string password = txtPassword.Text;

            try
            {
                this.userService.CheckPassword(password);
                this.ClearErrorTextBox(txtPassword, this.lblPasswordError);
            }
            catch (ArgumentException exception)
            {
                this.SetErrorTextBox(txtPassword, this.lblPasswordError, exception.Message);
            }
        }

        /// <summary>
        /// Báo lỗi cho người dùng.
        /// </summary>
        /// <param name="textBox">Textbox cần đổi màu.</param>
        /// <param name="lblError">Label để hiển thị tin nhắn lỗi.</param>
        /// <param name="message">Tin nhắn lỗi.</param>
        private void SetErrorTextBox(GunaTextBox textBox, Label lblError, string message)
        {
            textBox.BorderColor = textBox.FocusedBorderColor = Color.FromArgb(233, 75, 98);
            lblError.Text = message;
        }

        /// <summary>
        /// Xóa báo lỗi.
        /// </summary>
        /// <param name="textBox">Textbox cần xóa màu.</param>
        /// <param name="lblError">Label cần xóa tin nhắn lỗi.</param>
        private void ClearErrorTextBox(GunaTextBox textBox, Label lblError)
        {
            textBox.BorderColor = textBox.FocusedBorderColor = Color.FromArgb(43, 43, 43);
            lblError.Text = string.Empty;
        }
    }
}
