namespace PresentationLayer.Screen.Childs
{
    partial class BorrowBooksForm
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
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.drgTitleBar = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btnMaximize = new Guna.UI.WinForms.GunaControlBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNumberOfBooksReturned = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberOfBooksBorrowed = new System.Windows.Forms.Label();
            this.gnResize = new Guna.UI.WinForms.GunaResize(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBooksCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dtTo = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lblToError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dtFrom = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lblFromError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBookNameError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBookName = new Guna.UI.WinForms.GunaComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI.WinForms.GunaGradientButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(3, 3);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(654, 72);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Thông Tin Mượn Sách";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnClose.Location = new System.Drawing.Point(612, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.btnClose.Size = new System.Drawing.Size(45, 47);
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = false;
            // 
            // drgTitleBar
            // 
            this.drgTitleBar.TargetControl = this.lblTitle;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Animated = true;
            this.btnMaximize.AnimationHoverSpeed = 0.07F;
            this.btnMaximize.AnimationSpeed = 0.03F;
            this.btnMaximize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(39)))));
            this.btnMaximize.IconSize = 15F;
            this.btnMaximize.Location = new System.Drawing.Point(568, 3);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(180)))), ((int)(((byte)(39)))));
            this.btnMaximize.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMaximize.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(180)))), ((int)(((byte)(39)))));
            this.btnMaximize.Size = new System.Drawing.Size(45, 47);
            this.btnMaximize.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 33);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.lblNumberOfBooksReturned);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(327, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(306, 33);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // lblNumberOfBooksReturned
            // 
            this.lblNumberOfBooksReturned.AutoSize = true;
            this.lblNumberOfBooksReturned.Location = new System.Drawing.Point(284, 0);
            this.lblNumberOfBooksReturned.Name = "lblNumberOfBooksReturned";
            this.lblNumberOfBooksReturned.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblNumberOfBooksReturned.Size = new System.Drawing.Size(19, 33);
            this.lblNumberOfBooksReturned.TabIndex = 1;
            this.lblNumberOfBooksReturned.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label4.Size = new System.Drawing.Size(122, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số sách đã trả:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.lblNumberOfBooksBorrowed);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(21, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(306, 33);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(166, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số sách đang mượn:";
            // 
            // lblNumberOfBooksBorrowed
            // 
            this.lblNumberOfBooksBorrowed.AutoSize = true;
            this.lblNumberOfBooksBorrowed.Location = new System.Drawing.Point(175, 0);
            this.lblNumberOfBooksBorrowed.Name = "lblNumberOfBooksBorrowed";
            this.lblNumberOfBooksBorrowed.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblNumberOfBooksBorrowed.Size = new System.Drawing.Size(19, 33);
            this.lblNumberOfBooksBorrowed.TabIndex = 1;
            this.lblNumberOfBooksBorrowed.Text = "0";
            // 
            // gnResize
            // 
            this.gnResize.TargetForm = this;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 75);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(654, 33);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.lblBooksCount);
            this.flowLayoutPanel5.Controls.Add(this.label9);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(327, 0);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(327, 33);
            this.flowLayoutPanel5.TabIndex = 11;
            // 
            // lblBooksCount
            // 
            this.lblBooksCount.AutoSize = true;
            this.lblBooksCount.Location = new System.Drawing.Point(284, 0);
            this.lblBooksCount.Name = "lblBooksCount";
            this.lblBooksCount.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblBooksCount.Size = new System.Drawing.Size(19, 33);
            this.lblBooksCount.TabIndex = 0;
            this.lblBooksCount.Text = "0";
            this.lblBooksCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label9.Size = new System.Drawing.Size(265, 33);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tổng số sách (đã mượn + đã trả):";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.label6);
            this.flowLayoutPanel4.Controls.Add(this.lblCustomerName);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(327, 33);
            this.flowLayoutPanel4.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label6.Size = new System.Drawing.Size(134, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên khách hàng:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(164, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblCustomerName.Size = new System.Drawing.Size(136, 33);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Chu Cẩm Phong";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 141);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.panel1.Size = new System.Drawing.Size(654, 250);
            this.panel1.TabIndex = 12;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.37563F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.62437F));
            this.tableLayoutPanel5.Controls.Add(this.dtTo, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblToError, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(24, 160);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(606, 70);
            this.tableLayoutPanel5.TabIndex = 15;
            // 
            // dtTo
            // 
            this.dtTo.BackColor = System.Drawing.Color.Transparent;
            this.dtTo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dtTo.BorderSize = 0;
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtTo.FocusedColor = System.Drawing.Color.WhiteSmoke;
            this.dtTo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(156, 3);
            this.dtTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTo.Name = "dtTo";
            this.dtTo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtTo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtTo.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtTo.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.dtTo.Radius = 3;
            this.dtTo.Size = new System.Drawing.Size(447, 31);
            this.dtTo.TabIndex = 15;
            this.dtTo.Text = "04/01/2020";
            this.dtTo.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.dtTo.Value = new System.DateTime(2020, 1, 4, 19, 29, 17, 681);
            this.dtTo.Validating += new System.ComponentModel.CancelEventHandler(this.DtTo_Validating);
            this.dtTo.Validated += new System.EventHandler(this.DtTo_Validated);
            // 
            // lblToError
            // 
            this.lblToError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToError.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.lblToError.Location = new System.Drawing.Point(156, 37);
            this.lblToError.Name = "lblToError";
            this.lblToError.Size = new System.Drawing.Size(447, 33);
            this.lblToError.TabIndex = 13;
            this.lblToError.Text = "Ngày trả không được để trống";
            this.lblToError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblToError.Visible = false;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 37);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày trả";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.37563F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.62437F));
            this.tableLayoutPanel4.Controls.Add(this.dtFrom, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblFromError, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(24, 90);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(606, 70);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // dtFrom
            // 
            this.dtFrom.BackColor = System.Drawing.Color.Transparent;
            this.dtFrom.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dtFrom.BorderSize = 0;
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtFrom.FocusedColor = System.Drawing.Color.WhiteSmoke;
            this.dtFrom.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(156, 3);
            this.dtFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtFrom.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtFrom.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtFrom.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.dtFrom.Radius = 3;
            this.dtFrom.Size = new System.Drawing.Size(447, 31);
            this.dtFrom.TabIndex = 15;
            this.dtFrom.Text = "04/01/2020";
            this.dtFrom.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.dtFrom.Value = new System.DateTime(2020, 1, 4, 19, 29, 17, 681);
            this.dtFrom.Validating += new System.ComponentModel.CancelEventHandler(this.DtFrom_Validating);
            this.dtFrom.Validated += new System.EventHandler(this.DtFrom_Validated);
            // 
            // lblFromError
            // 
            this.lblFromError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFromError.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.lblFromError.Location = new System.Drawing.Point(156, 37);
            this.lblFromError.Name = "lblFromError";
            this.lblFromError.Size = new System.Drawing.Size(447, 33);
            this.lblFromError.TabIndex = 13;
            this.lblFromError.Text = "Ngày mượn không được để trống";
            this.lblFromError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFromError.Visible = false;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày mượn";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.37563F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.62437F));
            this.tableLayoutPanel3.Controls.Add(this.lblBookNameError, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmbBookName, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(24, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(606, 70);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // lblBookNameError
            // 
            this.lblBookNameError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBookNameError.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookNameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.lblBookNameError.Location = new System.Drawing.Point(156, 37);
            this.lblBookNameError.Name = "lblBookNameError";
            this.lblBookNameError.Size = new System.Drawing.Size(447, 33);
            this.lblBookNameError.TabIndex = 13;
            this.lblBookNameError.Text = "Vui lòng chọn sách";
            this.lblBookNameError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBookNameError.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBookName
            // 
            this.cmbBookName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbBookName.BackColor = System.Drawing.Color.Transparent;
            this.cmbBookName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbBookName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbBookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBookName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBookName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookName.FocusedColor = System.Drawing.Color.WhiteSmoke;
            this.cmbBookName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBookName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbBookName.FormattingEnabled = true;
            this.cmbBookName.Location = new System.Drawing.Point(156, 3);
            this.cmbBookName.Name = "cmbBookName";
            this.cmbBookName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbBookName.OnHoverItemForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbBookName.Radius = 3;
            this.cmbBookName.Size = new System.Drawing.Size(447, 31);
            this.cmbBookName.Sorted = true;
            this.cmbBookName.TabIndex = 12;
            this.cmbBookName.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.cmbBookName.Validating += new System.ComponentModel.CancelEventHandler(this.CmbBookName_Validating);
            this.cmbBookName.Validated += new System.EventHandler(this.CmbBookName_Validated);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 391);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(24, 5, 24, 5);
            this.panel2.Size = new System.Drawing.Size(654, 56);
            this.panel2.TabIndex = 13;
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
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(489, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.btnAdd.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(254)))), ((int)(((byte)(191)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Radius = 3;
            this.btnAdd.Size = new System.Drawing.Size(141, 46);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BorrowBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(660, 450);
            this.Name = "BorrowBooksForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowBooksForm";
            this.Load += new System.EventHandler(this.BorrowBooksForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaDragControl drgTitleBar;
        private Guna.UI.WinForms.GunaControlBox btnMaximize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblNumberOfBooksBorrowed;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblNumberOfBooksReturned;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaResize gnResize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label lblBooksCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Guna.UI.WinForms.GunaComboBox cmbBookName;
        private System.Windows.Forms.Label lblBookNameError;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblFromError;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaDateTimePicker dtFrom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Guna.UI.WinForms.GunaDateTimePicker dtTo;
        private System.Windows.Forms.Label lblToError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaGradientButton btnAdd;
    }
}