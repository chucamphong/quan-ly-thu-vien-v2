using System;
using System.Windows.Forms;
using Guna.UI.Lib;
using PresentationLayer.Screen;

namespace PresentationLayer.Forms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Chiều rộng mặc định của Sidebar.
        /// </summary>
        private readonly int sidebarWidth = 235;

        /// <summary>
        /// Chiều rộng thu nhỏ của Sidebar.
        /// </summary>
        private readonly int sidebarCollapsedWidth = 60;

        private Form childForm;

        public MainForm()
        {
            this.InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Mặc định mở HomeForm đầu tiên
            this.BtnHome_Click(sender, e);

            // Thêm sự kiện Click cho các nút nhấn trên Sidebar
            this.AddEventMenuItemClick();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.SetChildForm(new HomeScreen());
        }

        private void BtnBookManagement_Click(object sender, EventArgs e)
        {
            this.SetChildForm(new BookScreen());
        }

        private void BtnAuthorManagement_Click(object sender, EventArgs e)
        {
            this.SetChildForm(new AuthorScreen());
        }

        private void BtnPublisherManagement_Click(object sender, EventArgs e)
        {
            this.SetChildForm(new PublisherScreen());
        }

        private void BtnCategoryManagement_Click(object sender, EventArgs e)
        {
            this.SetChildForm(new CategoryScreen());
        }

        private void BtnBorrowerManagement_Click(object sender, EventArgs e)
        {
            this.SetChildForm(new BorrowerScreen());
        }

        private void BtnUserManagement_Click(object sender, EventArgs e)
        {
            this.SetChildForm(new UserScreen());
        }

        /// <summary>
        /// Tạo sự kiện click chuột cho các nút nhấn ở phần Sidebar.
        /// </summary>
        private void AddEventMenuItemClick()
        {
            // Đặt thanh màu xanh bên trái cho biết nút đó đã được active
            void MenuItem_Click(object sender, EventArgs e)
            {
                var button = sender as Control;
                this.sideBarActived.Top = button.Top;
                this.sideBarActived.Height = button.Height;
                this.sideBarActived.BringToFront();
            }

            // Thêm sự kiện click cho các nút nhấn
            foreach (Control control in this.pnlSidebar.Controls)
            {
                if (control is Control button)
                {
                    button.Click += new EventHandler(MenuItem_Click);
                }
            }
        }

        /// <summary>
        /// Hiển thị form con.
        /// </summary>
        /// <param name="childForm">Form con cần hiển thị.</param>
        private void SetChildForm(Form childForm)
        {
            if (this.pnlMain.Controls.Contains(this.childForm))
            {
                this.pnlMain.Controls.Remove(this.childForm);
            }

            this.childForm = childForm;
            this.childForm.TopLevel = false;
            this.childForm.Dock = DockStyle.Fill;

            this.pnlMain.Controls.Add(this.childForm);
            this.pnlMain.Tag = this.childForm;

            this.childForm.BringToFront();
            this.childForm.Show();
        }

        /// <summary>
        /// Thu gọn / Mở rộng Sidebar.
        /// </summary>
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (this.pnlSidebar.Width == this.sidebarWidth)
            {
                this.pnlSidebar.Width = this.pnlTitlebar_2.Width = this.sidebarCollapsedWidth;
            }
            else
            {
                this.pnlSidebar.Width = this.pnlTitlebar_2.Width = this.sidebarWidth;
            }
        }
    }
}
