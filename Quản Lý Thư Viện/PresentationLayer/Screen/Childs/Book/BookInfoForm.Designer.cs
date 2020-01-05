namespace PresentationLayer.Screen.Childs
{
    partial class BookInfoForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPublisherError = new System.Windows.Forms.Label();
            this.cmbPublisher = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCategoriesError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCategories = new Guna.UI.WinForms.GunaImageButton();
            this.txtCategories = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAuthorsError = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSelectAuthor = new Guna.UI.WinForms.GunaImageButton();
            this.txtAuthors = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdate = new Guna.UI.WinForms.GunaGradientButton();
            this.drgTitleBar = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnlTitleBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(400, 72);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Thông Tin Sách";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(400, 72);
            this.pnlTitleBar.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Animated = true;
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(98)))));
            this.btnClose.IconSize = 15F;
            this.btnClose.Location = new System.Drawing.Point(355, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.btnClose.Size = new System.Drawing.Size(45, 47);
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPublisherError);
            this.panel2.Controls.Add(this.cmbPublisher);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblCategoriesError);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblAuthorsError);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblNameError);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(14);
            this.panel2.Size = new System.Drawing.Size(400, 570);
            this.panel2.TabIndex = 7;
            // 
            // lblPublisherError
            // 
            this.lblPublisherError.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPublisherError.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisherError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.lblPublisherError.Location = new System.Drawing.Point(14, 457);
            this.lblPublisherError.Name = "lblPublisherError";
            this.lblPublisherError.Size = new System.Drawing.Size(372, 35);
            this.lblPublisherError.TabIndex = 12;
            this.lblPublisherError.Text = "Quyển sách này chưa có nhà phát hành";
            this.lblPublisherError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPublisherError.Visible = false;
            // 
            // cmbPublisher
            // 
            this.cmbPublisher.BackColor = System.Drawing.Color.Transparent;
            this.cmbPublisher.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbPublisher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbPublisher.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbPublisher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPublisher.FocusedColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPublisher.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPublisher.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPublisher.FormattingEnabled = true;
            this.cmbPublisher.Location = new System.Drawing.Point(14, 426);
            this.cmbPublisher.Name = "cmbPublisher";
            this.cmbPublisher.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbPublisher.OnHoverItemForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPublisher.Radius = 3;
            this.cmbPublisher.Size = new System.Drawing.Size(372, 31);
            this.cmbPublisher.TabIndex = 11;
            this.cmbPublisher.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.cmbPublisher.SelectedIndexChanged += new System.EventHandler(this.CmbPublisher_SelectedIndexChanged);
            this.cmbPublisher.Validating += new System.ComponentModel.CancelEventHandler(this.CmbPublisher_Validating);
            this.cmbPublisher.Validated += new System.EventHandler(this.CmbPublisher_Validated);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(14, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(372, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nhà phát hành";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategoriesError
            // 
            this.lblCategoriesError.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategoriesError.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriesError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.lblCategoriesError.Location = new System.Drawing.Point(14, 356);
            this.lblCategoriesError.Name = "lblCategoriesError";
            this.lblCategoriesError.Size = new System.Drawing.Size(372, 35);
            this.lblCategoriesError.TabIndex = 15;
            this.lblCategoriesError.Text = "Thể loại không được để trống";
            this.lblCategoriesError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCategoriesError.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddCategories);
            this.panel1.Controls.Add(this.txtCategories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(14, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 33);
            this.panel1.TabIndex = 9;
            // 
            // btnAddCategories
            // 
            this.btnAddCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategories.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddCategories.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddCategories.Image = global::PresentationLayer.Properties.Resources.Plus;
            this.btnAddCategories.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddCategories.Location = new System.Drawing.Point(347, 0);
            this.btnAddCategories.Name = "btnAddCategories";
            this.btnAddCategories.OnHoverImage = global::PresentationLayer.Properties.Resources.Plus_Actived;
            this.btnAddCategories.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddCategories.Size = new System.Drawing.Size(25, 33);
            this.btnAddCategories.TabIndex = 7;
            this.btnAddCategories.Click += new System.EventHandler(this.BtnAddCategories_Click);
            // 
            // txtCategories
            // 
            this.txtCategories.BackColor = System.Drawing.Color.Transparent;
            this.txtCategories.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCategories.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtCategories.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCategories.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCategories.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtCategories.FocusedForeColor = System.Drawing.Color.White;
            this.txtCategories.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategories.ForeColor = System.Drawing.Color.White;
            this.txtCategories.Location = new System.Drawing.Point(0, 0);
            this.txtCategories.MaxLength = 255;
            this.txtCategories.Name = "txtCategories";
            this.txtCategories.PasswordChar = '\0';
            this.txtCategories.Radius = 5;
            this.txtCategories.ReadOnly = true;
            this.txtCategories.Size = new System.Drawing.Size(337, 33);
            this.txtCategories.TabIndex = 6;
            this.txtCategories.TextOffsetX = 5;
            this.txtCategories.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCategories_Validating);
            this.txtCategories.Validated += new System.EventHandler(this.TxtCategories_Validated);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(14, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thể loại";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuthorsError
            // 
            this.lblAuthorsError.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAuthorsError.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorsError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.lblAuthorsError.Location = new System.Drawing.Point(14, 253);
            this.lblAuthorsError.Name = "lblAuthorsError";
            this.lblAuthorsError.Size = new System.Drawing.Size(372, 35);
            this.lblAuthorsError.TabIndex = 14;
            this.lblAuthorsError.Text = "Tác giả không được để trống";
            this.lblAuthorsError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAuthorsError.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSelectAuthor);
            this.panel4.Controls.Add(this.txtAuthors);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(14, 220);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 33);
            this.panel4.TabIndex = 7;
            // 
            // btnSelectAuthor
            // 
            this.btnSelectAuthor.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelectAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectAuthor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSelectAuthor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectAuthor.Image = global::PresentationLayer.Properties.Resources.Plus;
            this.btnSelectAuthor.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSelectAuthor.Location = new System.Drawing.Point(347, 0);
            this.btnSelectAuthor.Name = "btnSelectAuthor";
            this.btnSelectAuthor.OnHoverImage = global::PresentationLayer.Properties.Resources.Plus_Actived;
            this.btnSelectAuthor.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnSelectAuthor.Size = new System.Drawing.Size(25, 33);
            this.btnSelectAuthor.TabIndex = 7;
            this.btnSelectAuthor.Click += new System.EventHandler(this.BtnSelectAuthor_Click);
            // 
            // txtAuthors
            // 
            this.txtAuthors.BackColor = System.Drawing.Color.Transparent;
            this.txtAuthors.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAuthors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtAuthors.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAuthors.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAuthors.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAuthors.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtAuthors.FocusedForeColor = System.Drawing.Color.White;
            this.txtAuthors.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthors.ForeColor = System.Drawing.Color.White;
            this.txtAuthors.Location = new System.Drawing.Point(0, 0);
            this.txtAuthors.MaxLength = 255;
            this.txtAuthors.Name = "txtAuthors";
            this.txtAuthors.PasswordChar = '\0';
            this.txtAuthors.Radius = 5;
            this.txtAuthors.ReadOnly = true;
            this.txtAuthors.Size = new System.Drawing.Size(337, 33);
            this.txtAuthors.TabIndex = 6;
            this.txtAuthors.TextOffsetX = 5;
            this.txtAuthors.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAuthors_Validating);
            this.txtAuthors.Validated += new System.EventHandler(this.TxtAuthors_Validated);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(14, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tác giả";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNameError
            // 
            this.lblNameError.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNameError.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.lblNameError.Location = new System.Drawing.Point(14, 150);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(372, 35);
            this.lblNameError.TabIndex = 13;
            this.lblNameError.Text = "Tên sách không được để trống";
            this.lblNameError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameError.Visible = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtName.FocusedForeColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(14, 117);
            this.txtName.MaxLength = 255;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Radius = 5;
            this.txtName.Size = new System.Drawing.Size(372, 33);
            this.txtName.TabIndex = 3;
            this.txtName.TextOffsetX = 5;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtName_Validating);
            this.txtName.Validated += new System.EventHandler(this.TxtName_Validated);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtID.Enabled = false;
            this.txtID.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtID.FocusedForeColor = System.Drawing.Color.White;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(14, 49);
            this.txtID.MaxLength = 255;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.Radius = 5;
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(372, 33);
            this.txtID.TabIndex = 1;
            this.txtID.TextOffsetX = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 576);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 66);
            this.panel3.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.btnUpdate.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(191)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(245, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.btnUpdate.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(254)))), ((int)(((byte)(191)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 3;
            this.btnUpdate.Size = new System.Drawing.Size(141, 42);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập Nhập";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // drgTitleBar
            // 
            this.drgTitleBar.TargetControl = this.lblTitle;
            // 
            // BookInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(400, 642);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookInfoForm";
            this.Load += new System.EventHandler(this.BookInfoForm_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTitleBar;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaTextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaImageButton btnSelectAuthor;
        private Guna.UI.WinForms.GunaTextBox txtAuthors;
        private Guna.UI.WinForms.GunaDragControl drgTitleBar;
        private Guna.UI.WinForms.GunaGradientButton btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaImageButton btnAddCategories;
        private Guna.UI.WinForms.GunaTextBox txtCategories;
        private Guna.UI.WinForms.GunaComboBox cmbPublisher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPublisherError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblAuthorsError;
        private System.Windows.Forms.Label lblCategoriesError;
    }
}