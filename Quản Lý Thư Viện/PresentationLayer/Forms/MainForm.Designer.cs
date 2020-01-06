namespace PresentationLayer.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gnResize = new Guna.UI.WinForms.GunaResize(this.components);
            this.pnlHeader = new Guna.UI.WinForms.GunaLinePanel();
            this.btnMinimize = new Guna.UI.WinForms.GunaControlBox();
            this.pnlTitlebar_2 = new System.Windows.Forms.Panel();
            this.btnMaximize = new Guna.UI.WinForms.GunaControlBox();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.drgTitleBar = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.drgTitleBar_2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.sideBarActived = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnChart = new Guna.UI.WinForms.GunaButton();
            this.btnBorrowerManagement = new Guna.UI.WinForms.GunaButton();
            this.btnCategoryManagement = new Guna.UI.WinForms.GunaButton();
            this.btnPublisherManagement = new Guna.UI.WinForms.GunaButton();
            this.btnAuthorManagement = new Guna.UI.WinForms.GunaButton();
            this.btnUserManagement = new Guna.UI.WinForms.GunaButton();
            this.btnBookManagement = new Guna.UI.WinForms.GunaButton();
            this.btnHome = new Guna.UI.WinForms.GunaButton();
            this.btnMenu = new Guna.UI.WinForms.GunaPictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlTitlebar_2.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gnResize
            // 
            this.gnResize.TargetForm = this;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.pnlTitlebar_2);
            this.pnlHeader.Controls.Add(this.btnMaximize);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.LineColor = System.Drawing.Color.Black;
            this.pnlHeader.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(819, 47);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Animated = true;
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(205)))), ((int)(((byte)(44)))));
            this.btnMinimize.IconSize = 15F;
            this.btnMinimize.Location = new System.Drawing.Point(684, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(150)))), ((int)(((byte)(44)))));
            this.btnMinimize.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(150)))), ((int)(((byte)(44)))));
            this.btnMinimize.Size = new System.Drawing.Size(45, 47);
            this.btnMinimize.TabIndex = 3;
            // 
            // pnlTitlebar_2
            // 
            this.pnlTitlebar_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlTitlebar_2.Controls.Add(this.btnMenu);
            this.pnlTitlebar_2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTitlebar_2.Location = new System.Drawing.Point(0, 0);
            this.pnlTitlebar_2.Name = "pnlTitlebar_2";
            this.pnlTitlebar_2.Size = new System.Drawing.Size(235, 47);
            this.pnlTitlebar_2.TabIndex = 2;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Animated = true;
            this.btnMaximize.AnimationHoverSpeed = 0.07F;
            this.btnMaximize.AnimationSpeed = 0.03F;
            this.btnMaximize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(39)))));
            this.btnMaximize.IconSize = 15F;
            this.btnMaximize.Location = new System.Drawing.Point(729, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(180)))), ((int)(((byte)(39)))));
            this.btnMaximize.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMaximize.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(180)))), ((int)(((byte)(39)))));
            this.btnMaximize.Size = new System.Drawing.Size(45, 47);
            this.btnMaximize.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(98)))));
            this.btnClose.IconSize = 15F;
            this.btnClose.Location = new System.Drawing.Point(774, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.btnClose.Size = new System.Drawing.Size(45, 47);
            this.btnClose.TabIndex = 0;
            // 
            // drgTitleBar
            // 
            this.drgTitleBar.TargetControl = this.pnlHeader;
            // 
            // drgTitleBar_2
            // 
            this.drgTitleBar_2.TargetControl = this.pnlTitlebar_2;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlSidebar.Controls.Add(this.btnChart);
            this.pnlSidebar.Controls.Add(this.btnBorrowerManagement);
            this.pnlSidebar.Controls.Add(this.btnCategoryManagement);
            this.pnlSidebar.Controls.Add(this.btnPublisherManagement);
            this.pnlSidebar.Controls.Add(this.btnAuthorManagement);
            this.pnlSidebar.Controls.Add(this.btnUserManagement);
            this.pnlSidebar.Controls.Add(this.sideBarActived);
            this.pnlSidebar.Controls.Add(this.btnBookManagement);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSidebar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSidebar.Location = new System.Drawing.Point(3, 50);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(235, 547);
            this.pnlSidebar.TabIndex = 1;
            // 
            // sideBarActived
            // 
            this.sideBarActived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(161)))), ((int)(((byte)(156)))));
            this.sideBarActived.Location = new System.Drawing.Point(0, 0);
            this.sideBarActived.Margin = new System.Windows.Forms.Padding(0);
            this.sideBarActived.Name = "sideBarActived";
            this.sideBarActived.Size = new System.Drawing.Size(4, 50);
            this.sideBarActived.TabIndex = 5;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(238, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(584, 547);
            this.pnlMain.TabIndex = 2;
            // 
            // btnChart
            // 
            this.btnChart.Animated = true;
            this.btnChart.AnimationHoverSpeed = 0.07F;
            this.btnChart.AnimationSpeed = 0.03F;
            this.btnChart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnChart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChart.FocusedColor = System.Drawing.Color.Empty;
            this.btnChart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnChart.Image = global::PresentationLayer.Properties.Resources.Chart;
            this.btnChart.ImageOffsetX = 10;
            this.btnChart.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChart.Location = new System.Drawing.Point(0, 300);
            this.btnChart.Name = "btnChart";
            this.btnChart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnChart.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnChart.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnChart.OnHoverImage = null;
            this.btnChart.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnChart.Size = new System.Drawing.Size(235, 50);
            this.btnChart.TabIndex = 11;
            this.btnChart.Text = "Thống kê";
            this.btnChart.TextOffsetX = 10;
            this.btnChart.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btnChart.Click += new System.EventHandler(this.BtnChart_Click);
            // 
            // btnBorrowerManagement
            // 
            this.btnBorrowerManagement.Animated = true;
            this.btnBorrowerManagement.AnimationHoverSpeed = 0.07F;
            this.btnBorrowerManagement.AnimationSpeed = 0.03F;
            this.btnBorrowerManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBorrowerManagement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBorrowerManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrowerManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBorrowerManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrowerManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnBorrowerManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowerManagement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBorrowerManagement.Image = global::PresentationLayer.Properties.Resources.Borrower;
            this.btnBorrowerManagement.ImageOffsetX = 10;
            this.btnBorrowerManagement.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBorrowerManagement.Location = new System.Drawing.Point(0, 250);
            this.btnBorrowerManagement.Name = "btnBorrowerManagement";
            this.btnBorrowerManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBorrowerManagement.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBorrowerManagement.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBorrowerManagement.OnHoverImage = null;
            this.btnBorrowerManagement.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnBorrowerManagement.Size = new System.Drawing.Size(235, 50);
            this.btnBorrowerManagement.TabIndex = 10;
            this.btnBorrowerManagement.Text = "Người dùng";
            this.btnBorrowerManagement.TextOffsetX = 10;
            this.btnBorrowerManagement.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btnBorrowerManagement.Click += new System.EventHandler(this.BtnBorrowerManagement_Click);
            // 
            // btnCategoryManagement
            // 
            this.btnCategoryManagement.Animated = true;
            this.btnCategoryManagement.AnimationHoverSpeed = 0.07F;
            this.btnCategoryManagement.AnimationSpeed = 0.03F;
            this.btnCategoryManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCategoryManagement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCategoryManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCategoryManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoryManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnCategoryManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryManagement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCategoryManagement.Image = global::PresentationLayer.Properties.Resources.Category;
            this.btnCategoryManagement.ImageOffsetX = 10;
            this.btnCategoryManagement.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCategoryManagement.Location = new System.Drawing.Point(0, 200);
            this.btnCategoryManagement.Name = "btnCategoryManagement";
            this.btnCategoryManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCategoryManagement.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCategoryManagement.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCategoryManagement.OnHoverImage = null;
            this.btnCategoryManagement.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnCategoryManagement.Size = new System.Drawing.Size(235, 50);
            this.btnCategoryManagement.TabIndex = 9;
            this.btnCategoryManagement.Text = "Thể loại";
            this.btnCategoryManagement.TextOffsetX = 10;
            this.btnCategoryManagement.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btnCategoryManagement.Click += new System.EventHandler(this.BtnCategoryManagement_Click);
            // 
            // btnPublisherManagement
            // 
            this.btnPublisherManagement.Animated = true;
            this.btnPublisherManagement.AnimationHoverSpeed = 0.07F;
            this.btnPublisherManagement.AnimationSpeed = 0.03F;
            this.btnPublisherManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPublisherManagement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPublisherManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublisherManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPublisherManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPublisherManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnPublisherManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublisherManagement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPublisherManagement.Image = global::PresentationLayer.Properties.Resources.Publisher;
            this.btnPublisherManagement.ImageOffsetX = 10;
            this.btnPublisherManagement.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPublisherManagement.Location = new System.Drawing.Point(0, 150);
            this.btnPublisherManagement.Name = "btnPublisherManagement";
            this.btnPublisherManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPublisherManagement.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPublisherManagement.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPublisherManagement.OnHoverImage = null;
            this.btnPublisherManagement.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnPublisherManagement.Size = new System.Drawing.Size(235, 50);
            this.btnPublisherManagement.TabIndex = 8;
            this.btnPublisherManagement.Text = "Nhà phát hành";
            this.btnPublisherManagement.TextOffsetX = 10;
            this.btnPublisherManagement.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btnPublisherManagement.Click += new System.EventHandler(this.BtnPublisherManagement_Click);
            // 
            // btnAuthorManagement
            // 
            this.btnAuthorManagement.Animated = true;
            this.btnAuthorManagement.AnimationHoverSpeed = 0.07F;
            this.btnAuthorManagement.AnimationSpeed = 0.03F;
            this.btnAuthorManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAuthorManagement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAuthorManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuthorManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAuthorManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuthorManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnAuthorManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthorManagement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAuthorManagement.Image = global::PresentationLayer.Properties.Resources.Author;
            this.btnAuthorManagement.ImageOffsetX = 10;
            this.btnAuthorManagement.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAuthorManagement.Location = new System.Drawing.Point(0, 100);
            this.btnAuthorManagement.Name = "btnAuthorManagement";
            this.btnAuthorManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAuthorManagement.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAuthorManagement.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAuthorManagement.OnHoverImage = null;
            this.btnAuthorManagement.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnAuthorManagement.Size = new System.Drawing.Size(235, 50);
            this.btnAuthorManagement.TabIndex = 7;
            this.btnAuthorManagement.Text = "Tác giả";
            this.btnAuthorManagement.TextOffsetX = 10;
            this.btnAuthorManagement.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btnAuthorManagement.Click += new System.EventHandler(this.BtnAuthorManagement_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Animated = true;
            this.btnUserManagement.AnimationHoverSpeed = 0.07F;
            this.btnUserManagement.AnimationSpeed = 0.03F;
            this.btnUserManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUserManagement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUserManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUserManagement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUserManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnUserManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUserManagement.Image = global::PresentationLayer.Properties.Resources.User;
            this.btnUserManagement.ImageOffsetX = 10;
            this.btnUserManagement.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUserManagement.Location = new System.Drawing.Point(0, 497);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnUserManagement.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUserManagement.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUserManagement.OnHoverImage = null;
            this.btnUserManagement.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnUserManagement.Size = new System.Drawing.Size(235, 50);
            this.btnUserManagement.TabIndex = 6;
            this.btnUserManagement.Text = "Tài khoản";
            this.btnUserManagement.TextOffsetX = 10;
            this.btnUserManagement.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btnUserManagement.Click += new System.EventHandler(this.BtnUserManagement_Click);
            // 
            // btnBookManagement
            // 
            this.btnBookManagement.Animated = true;
            this.btnBookManagement.AnimationHoverSpeed = 0.07F;
            this.btnBookManagement.AnimationSpeed = 0.03F;
            this.btnBookManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBookManagement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBookManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBookManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnBookManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookManagement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBookManagement.Image = global::PresentationLayer.Properties.Resources.OpenBook;
            this.btnBookManagement.ImageOffsetX = 10;
            this.btnBookManagement.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBookManagement.Location = new System.Drawing.Point(0, 50);
            this.btnBookManagement.Name = "btnBookManagement";
            this.btnBookManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBookManagement.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBookManagement.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBookManagement.OnHoverImage = null;
            this.btnBookManagement.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnBookManagement.Size = new System.Drawing.Size(235, 50);
            this.btnBookManagement.TabIndex = 5;
            this.btnBookManagement.Text = "Sách";
            this.btnBookManagement.TextOffsetX = 10;
            this.btnBookManagement.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btnBookManagement.Click += new System.EventHandler(this.BtnBookManagement_Click);
            // 
            // btnHome
            // 
            this.btnHome.Animated = true;
            this.btnHome.AnimationHoverSpeed = 0.07F;
            this.btnHome.AnimationSpeed = 0.03F;
            this.btnHome.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FocusedColor = System.Drawing.Color.Empty;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Image = global::PresentationLayer.Properties.Resources.Home;
            this.btnHome.ImageOffsetX = 10;
            this.btnHome.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnHome.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnHome.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.OnHoverImage = null;
            this.btnHome.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Size = new System.Drawing.Size(235, 50);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextOffsetX = 10;
            this.btnHome.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BaseColor = System.Drawing.Color.White;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.Image = global::PresentationLayer.Properties.Resources.Menu;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(63, 47);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(825, 600);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlTitlebar_2.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaResize gnResize;
        private Guna.UI.WinForms.GunaLinePanel pnlHeader;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaControlBox btnMaximize;
        private Guna.UI.WinForms.GunaDragControl drgTitleBar;
        private Guna.UI.WinForms.GunaDragControl drgTitleBar_2;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlTitlebar_2;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel sideBarActived;
        private Guna.UI.WinForms.GunaButton btnBookManagement;
        private Guna.UI.WinForms.GunaButton btnHome;
        private Guna.UI.WinForms.GunaButton btnUserManagement;
        private Guna.UI.WinForms.GunaPictureBox btnMenu;
        private Guna.UI.WinForms.GunaControlBox btnMinimize;
        private Guna.UI.WinForms.GunaButton btnAuthorManagement;
        private Guna.UI.WinForms.GunaButton btnPublisherManagement;
        private Guna.UI.WinForms.GunaButton btnCategoryManagement;
        private Guna.UI.WinForms.GunaButton btnBorrowerManagement;
        private Guna.UI.WinForms.GunaButton btnChart;
    }
}