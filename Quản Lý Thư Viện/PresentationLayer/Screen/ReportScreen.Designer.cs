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
            this.label1 = new System.Windows.Forms.Label();
            this.dtMonth = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.reportViewer.Location = new System.Drawing.Point(0, 114);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.ShowToolBar = false;
            this.reportViewer.Size = new System.Drawing.Size(913, 577);
            this.reportViewer.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaDateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtMonth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.panel1.Size = new System.Drawing.Size(913, 42);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(21, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Theo tháng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dtMonth.Location = new System.Drawing.Point(121, 0);
            this.dtMonth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtMonth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtMonth.Name = "dtMonth";
            this.dtMonth.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtMonth.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtMonth.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtMonth.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.dtMonth.Radius = 3;
            this.dtMonth.Size = new System.Drawing.Size(148, 42);
            this.dtMonth.TabIndex = 8;
            this.dtMonth.Text = "01/2020";
            this.dtMonth.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.dtMonth.Value = new System.DateTime(2020, 1, 4, 19, 29, 17, 681);
            this.dtMonth.ValueChanged += new System.EventHandler(this.DtMonth_ValueChanged);
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.gunaDateTimePicker1.BorderSize = 0;
            this.gunaDateTimePicker1.CustomFormat = "MM/yyyy";
            this.gunaDateTimePicker1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.WhiteSmoke;
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(393, 0);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.gunaDateTimePicker1.Radius = 3;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(148, 42);
            this.gunaDateTimePicker1.TabIndex = 10;
            this.gunaDateTimePicker1.Text = "01/2020";
            this.gunaDateTimePicker1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.gunaDateTimePicker1.Value = new System.DateTime(2020, 1, 4, 19, 29, 17, 681);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(269, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(124, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Theo năm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(913, 691);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportScreen";
            this.Text = "ReportScreen";
            this.Load += new System.EventHandler(this.ReportScreen_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDateTimePicker dtMonth;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}