namespace PresentationLayer.Screen.Childs
{
    partial class InsertCustomerForm
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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI.WinForms.GunaGradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBirthdayError = new System.Windows.Forms.Label();
            this.dtBirthDay = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drgTitleBar = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnlTitleBar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(400, 72);
            this.pnlTitleBar.TabIndex = 7;
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
            this.lblTitle.Text = "Thêm Khách Hàng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 604);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 66);
            this.panel3.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.btnAdd.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(191)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(245, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.btnAdd.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(254)))), ((int)(((byte)(191)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Radius = 3;
            this.btnAdd.Size = new System.Drawing.Size(141, 42);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblAddressError);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblBirthdayError);
            this.panel2.Controls.Add(this.dtBirthDay);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblPhoneError);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblEmailError);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblNameError);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(14);
            this.panel2.Size = new System.Drawing.Size(400, 598);
            this.panel2.TabIndex = 9;
            // 
            // lblAddressError
            // 
            this.lblAddressError.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddressError.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.lblAddressError.Location = new System.Drawing.Point(14, 494);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(372, 35);
            this.lblAddressError.TabIndex = 15;
            this.lblAddressError.Text = "Địa chỉ không được để trống";
            this.lblAddressError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddressError.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddress.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtAddress.FocusedForeColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(14, 461);
            this.txtAddress.MaxLength = 255;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.Radius = 5;
            this.txtAddress.Size = new System.Drawing.Size(372, 33);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.TextOffsetX = 5;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAddress_Validating);
            this.txtAddress.Validated += new System.EventHandler(this.TxtAddress_Validated);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(14, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(372, 35);
            this.label8.TabIndex = 8;
            this.label8.Text = "Địa chỉ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBirthdayError
            // 
            this.lblBirthdayError.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBirthdayError.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdayError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.lblBirthdayError.Location = new System.Drawing.Point(14, 391);
            this.lblBirthdayError.Name = "lblBirthdayError";
            this.lblBirthdayError.Size = new System.Drawing.Size(372, 35);
            this.lblBirthdayError.TabIndex = 16;
            this.lblBirthdayError.Text = "Ngày sinh không được để trống";
            this.lblBirthdayError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBirthdayError.Visible = false;
            // 
            // dtBirthDay
            // 
            this.dtBirthDay.BackColor = System.Drawing.Color.Transparent;
            this.dtBirthDay.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtBirthDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dtBirthDay.BorderSize = 0;
            this.dtBirthDay.CustomFormat = "dd/MM/yyyy";
            this.dtBirthDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtBirthDay.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtBirthDay.FocusedColor = System.Drawing.Color.WhiteSmoke;
            this.dtBirthDay.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthDay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirthDay.Location = new System.Drawing.Point(14, 358);
            this.dtBirthDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtBirthDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtBirthDay.Name = "dtBirthDay";
            this.dtBirthDay.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtBirthDay.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtBirthDay.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtBirthDay.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.dtBirthDay.Radius = 3;
            this.dtBirthDay.Size = new System.Drawing.Size(372, 33);
            this.dtBirthDay.TabIndex = 7;
            this.dtBirthDay.Text = "04/01/2020";
            this.dtBirthDay.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.dtBirthDay.Value = new System.DateTime(2020, 1, 4, 19, 29, 17, 681);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(14, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày sinh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhoneError.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.lblPhoneError.Location = new System.Drawing.Point(14, 288);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(372, 35);
            this.lblPhoneError.TabIndex = 11;
            this.lblPhoneError.Text = "Số điện thoại không được để trống";
            this.lblPhoneError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhoneError.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPhone.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtPhone.FocusedForeColor = System.Drawing.Color.White;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(14, 255);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Radius = 5;
            this.txtPhone.Size = new System.Drawing.Size(372, 33);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.TextOffsetX = 5;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPhone_Validating);
            this.txtPhone.Validated += new System.EventHandler(this.TxtPhone_Validated);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(14, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(372, 35);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số điện thoại";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmailError
            // 
            this.lblEmailError.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmailError.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.lblEmailError.Location = new System.Drawing.Point(14, 185);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(372, 35);
            this.lblEmailError.TabIndex = 6;
            this.lblEmailError.Text = "Địa chỉ email không được để trống";
            this.lblEmailError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmailError.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtEmail.FocusedForeColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(14, 152);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 5;
            this.txtEmail.Size = new System.Drawing.Size(372, 33);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextOffsetX = 5;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            this.txtEmail.Validated += new System.EventHandler(this.TxtEmail_Validated);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(14, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNameError
            // 
            this.lblNameError.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNameError.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.lblNameError.Location = new System.Drawing.Point(14, 82);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(372, 35);
            this.lblNameError.TabIndex = 9;
            this.lblNameError.Text = "Tên khách hàng không được để trống";
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
            this.txtName.Location = new System.Drawing.Point(14, 49);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Radius = 5;
            this.txtName.Size = new System.Drawing.Size(372, 33);
            this.txtName.TabIndex = 1;
            this.txtName.TextOffsetX = 5;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtName_Validating);
            this.txtName.Validated += new System.EventHandler(this.TxtName_Validated);
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
            this.label1.Text = "Tên khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drgTitleBar
            // 
            this.drgTitleBar.TargetControl = this.lblTitle;
            // 
            // InsertCustomerForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(400, 670);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertCustomerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertCustomerForm";
            this.pnlTitleBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaGradientButton btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDateTimePicker dtBirthDay;
        private System.Windows.Forms.Label lblEmailError;
        private Guna.UI.WinForms.GunaDragControl drgTitleBar;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAddressError;
        private Guna.UI.WinForms.GunaTextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPhoneError;
        private System.Windows.Forms.Label lblBirthdayError;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
    }
}