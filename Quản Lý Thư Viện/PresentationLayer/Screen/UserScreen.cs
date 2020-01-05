using System;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer.Screen
{
    public partial class UserScreen : Form
    {
        public UserScreen()
        {
            this.InitializeComponent();
        }

        private void UserScreen_Load(object sender, EventArgs e)
        {
            this.lblName.Text = AuthService.User.Name;
            this.lblEmail.Text = AuthService.User.Email;
        }

        private void BtnUpdateInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được hỗ trợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
