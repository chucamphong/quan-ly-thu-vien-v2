namespace PresentationLayer.Screen
{
    partial class ReportScreen
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDateTimeMonth = new Guna.UI.WinForms.GunaGradientButton();
            this.dtMonth = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDateTimeMonth2 = new Guna.UI.WinForms.GunaGradientButton();
            this.dtMonth2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDateTimeYear = new Guna.UI.WinForms.GunaGradientButton();
            this.dtYear = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(913, 72);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Thống Kê";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reportViewer
            // 
            this.reportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reportViewer.LocalReport.ReportEmbeddedResource = "PresentationLayer.Reports.BaoCaoSachDangMuonTrongThang.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 267);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.ShowToolBar = false;
            this.reportViewer.Size = new System.Drawing.Size(913, 424);
            this.reportViewer.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDateTimeMonth);
            this.panel1.Controls.Add(this.dtMonth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(21, 10, 21, 10);
            this.panel1.Size = new System.Drawing.Size(913, 65);
            this.panel1.TabIndex = 7;
            // 
            // btnDateTimeMonth
            // 
            this.btnDateTimeMonth.Animated = true;
            this.btnDateTimeMonth.AnimationHoverSpeed = 0.07F;
            this.btnDateTimeMonth.AnimationSpeed = 0.03F;
            this.btnDateTimeMonth.BackColor = System.Drawing.Color.Transparent;
            this.btnDateTimeMonth.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.btnDateTimeMonth.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(191)))));
            this.btnDateTimeMonth.BorderColor = System.Drawing.Color.Black;
            this.btnDateTimeMonth.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDateTimeMonth.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDateTimeMonth.FocusedColor = System.Drawing.Color.Empty;
            this.btnDateTimeMonth.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateTimeMonth.ForeColor = System.Drawing.Color.Black;
            this.btnDateTimeMonth.Image = null;
            this.btnDateTimeMonth.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDateTimeMonth.Location = new System.Drawing.Point(799, 10);
            this.btnDateTimeMonth.Name = "btnDateTimeMonth";
            this.btnDateTimeMonth.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.btnDateTimeMonth.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(254)))), ((int)(((byte)(191)))));
            this.btnDateTimeMonth.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDateTimeMonth.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDateTimeMonth.OnHoverImage = null;
            this.btnDateTimeMonth.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnDateTimeMonth.Radius = 3;
            this.btnDateTimeMonth.Size = new System.Drawing.Size(93, 45);
            this.btnDateTimeMonth.TabIndex = 12;
            this.btnDateTimeMonth.Text = "Xem";
            this.btnDateTimeMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDateTimeMonth.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btnDateTimeMonth.Click += new System.EventHandler(this.BtnDateTimeMonth_Click);
            // 
            // dtMonth
            // 
            this.dtMonth.BackColor = System.Drawing.Color.Transparent;
            this.dtMonth.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dtMonth.BorderSize = 0;
            this.dtMonth.CustomFormat = "MM/yyyy";
            this.dtMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtMonth.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtMonth.FocusedColor = System.Drawing.Color.WhiteSmoke;
            this.dtMonth.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtMonth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMonth.Location = new System.Drawing.Point(387, 10);
            this.dtMonth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtMonth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtMonth.Name = "dtMonth";
            this.dtMonth.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtMonth.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtMonth.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtMonth.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.dtMonth.Radius = 3;
            this.dtMonth.Size = new System.Drawing.Size(148, 45);
            this.dtMonth.TabIndex = 8;
            this.dtMonth.Text = "01/2020";
            this.dtMonth.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.dtMonth.Value = new System.DateTime(2020, 1, 4, 19, 29, 17, 681);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sách đang mượn trong tháng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDateTimeMonth2);
            this.panel2.Controls.Add(this.dtMonth2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 137);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(21, 10, 21, 10);
            this.panel2.Size = new System.Drawing.Size(913, 65);
            this.panel2.TabIndex = 8;
            // 
            // btnDateTimeMonth2
            // 
            this.btnDateTimeMonth2.Animated = true;
            this.btnDateTimeMonth2.AnimationHoverSpeed = 0.07F;
            this.btnDateTimeMonth2.AnimationSpeed = 0.03F;
            this.btnDateTimeMonth2.BackColor = System.Drawing.Color.Transparent;
            this.btnDateTimeMonth2.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.btnDateTimeMonth2.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(191)))));
            this.btnDateTimeMonth2.BorderColor = System.Drawing.Color.Black;
            this.btnDateTimeMonth2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDateTimeMonth2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDateTimeMonth2.FocusedColor = System.Drawing.Color.Empty;
            this.btnDateTimeMonth2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateTimeMonth2.ForeColor = System.Drawing.Color.Black;
            this.btnDateTimeMonth2.Image = null;
            this.btnDateTimeMonth2.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDateTimeMonth2.Location = new System.Drawing.Point(799, 10);
            this.btnDateTimeMonth2.Name = "btnDateTimeMonth2";
            this.btnDateTimeMonth2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.btnDateTimeMonth2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(254)))), ((int)(((byte)(191)))));
            this.btnDateTimeMonth2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDateTimeMonth2.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDateTimeMonth2.OnHoverImage = null;
            this.btnDateTimeMonth2.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnDateTimeMonth2.Radius = 3;
            this.btnDateTimeMonth2.Size = new System.Drawing.Size(93, 45);
            this.btnDateTimeMonth2.TabIndex = 13;
            this.btnDateTimeMonth2.Text = "Xem";
            this.btnDateTimeMonth2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDateTimeMonth2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btnDateTimeMonth2.Click += new System.EventHandler(this.BtnDateTimeMonth2_Click);
            // 
            // dtMonth2
            // 
            this.dtMonth2.BackColor = System.Drawing.Color.Transparent;
            this.dtMonth2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtMonth2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dtMonth2.BorderSize = 0;
            this.dtMonth2.CustomFormat = "MM/yyyy";
            this.dtMonth2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtMonth2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtMonth2.FocusedColor = System.Drawing.Color.WhiteSmoke;
            this.dtMonth2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtMonth2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtMonth2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMonth2.Location = new System.Drawing.Point(387, 10);
            this.dtMonth2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtMonth2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtMonth2.Name = "dtMonth2";
            this.dtMonth2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtMonth2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtMonth2.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtMonth2.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.dtMonth2.Radius = 3;
            this.dtMonth2.Size = new System.Drawing.Size(148, 45);
            this.dtMonth2.TabIndex = 8;
            this.dtMonth2.Text = "01/2020";
            this.dtMonth2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.dtMonth2.Value = new System.DateTime(2020, 1, 4, 19, 29, 17, 681);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(21, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 45);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sách mượn nhiều nhất trong tháng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDateTimeYear);
            this.panel3.Controls.Add(this.dtYear);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 202);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(21, 10, 21, 10);
            this.panel3.Size = new System.Drawing.Size(913, 65);
            this.panel3.TabIndex = 9;
            // 
            // btnDateTimeYear
            // 
            this.btnDateTimeYear.Animated = true;
            this.btnDateTimeYear.AnimationHoverSpeed = 0.07F;
            this.btnDateTimeYear.AnimationSpeed = 0.03F;
            this.btnDateTimeYear.BackColor = System.Drawing.Color.Transparent;
            this.btnDateTimeYear.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.btnDateTimeYear.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(191)))));
            this.btnDateTimeYear.BorderColor = System.Drawing.Color.Black;
            this.btnDateTimeYear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDateTimeYear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDateTimeYear.FocusedColor = System.Drawing.Color.Empty;
            this.btnDateTimeYear.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateTimeYear.ForeColor = System.Drawing.Color.Black;
            this.btnDateTimeYear.Image = null;
            this.btnDateTimeYear.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDateTimeYear.Location = new System.Drawing.Point(799, 10);
            this.btnDateTimeYear.Name = "btnDateTimeYear";
            this.btnDateTimeYear.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.btnDateTimeYear.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(254)))), ((int)(((byte)(191)))));
            this.btnDateTimeYear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDateTimeYear.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDateTimeYear.OnHoverImage = null;
            this.btnDateTimeYear.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnDateTimeYear.Radius = 3;
            this.btnDateTimeYear.Size = new System.Drawing.Size(93, 45);
            this.btnDateTimeYear.TabIndex = 13;
            this.btnDateTimeYear.Text = "Xem";
            this.btnDateTimeYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDateTimeYear.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btnDateTimeYear.Click += new System.EventHandler(this.BtnDateTimeYear_Click);
            // 
            // dtYear
            // 
            this.dtYear.BackColor = System.Drawing.Color.Transparent;
            this.dtYear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dtYear.BorderSize = 0;
            this.dtYear.CustomFormat = "yyyy";
            this.dtYear.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtYear.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtYear.FocusedColor = System.Drawing.Color.WhiteSmoke;
            this.dtYear.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtYear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtYear.Location = new System.Drawing.Point(387, 10);
            this.dtYear.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtYear.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtYear.Name = "dtYear";
            this.dtYear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtYear.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtYear.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtYear.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.dtYear.Radius = 3;
            this.dtYear.Size = new System.Drawing.Size(148, 45);
            this.dtYear.TabIndex = 8;
            this.dtYear.Text = "2020";
            this.dtYear.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.dtYear.Value = new System.DateTime(2020, 1, 4, 19, 29, 17, 681);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(21, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sách mượn nhiều nhất trong năm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(913, 691);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportScreen";
            this.Text = "ReportScreen";
            this.Load += new System.EventHandler(this.ReportScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDateTimePicker dtMonth;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaDateTimePicker dtMonth2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaDateTimePicker dtYear;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGradientButton btnDateTimeMonth;
        private Guna.UI.WinForms.GunaGradientButton btnDateTimeMonth2;
        private Guna.UI.WinForms.GunaGradientButton btnDateTimeYear;
    }
}