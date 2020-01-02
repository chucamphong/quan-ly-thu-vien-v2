namespace PresentationLayer.Screen
{
    partial class HomeScreen
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
            this.pnlHello = new System.Windows.Forms.Panel();
            this.lblHello = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grdCardTongSoSach = new PresentationLayer.Controls.GradientCard();
            this.grdCardTongSoTacGia = new PresentationLayer.Controls.GradientCard();
            this.grdCardTongSoNhaPhatHanh = new PresentationLayer.Controls.GradientCard();
            this.grdCardTongSoNguoiDung = new PresentationLayer.Controls.GradientCard();
            this.pnlHello.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHello
            // 
            this.pnlHello.Controls.Add(this.lblHello);
            this.pnlHello.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHello.Location = new System.Drawing.Point(14, 0);
            this.pnlHello.Name = "pnlHello";
            this.pnlHello.Size = new System.Drawing.Size(1105, 72);
            this.pnlHello.TabIndex = 0;
            // 
            // lblHello
            // 
            this.lblHello.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHello.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(0, 0);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(1105, 72);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Xin chào Chu Cẩm Phong!";
            this.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.grdCardTongSoSach);
            this.flowLayoutPanel1.Controls.Add(this.grdCardTongSoTacGia);
            this.flowLayoutPanel1.Controls.Add(this.grdCardTongSoNhaPhatHanh);
            this.flowLayoutPanel1.Controls.Add(this.grdCardTongSoNguoiDung);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1105, 131);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // grdCardTongSoSach
            // 
            this.grdCardTongSoSach.BackColor = System.Drawing.Color.Transparent;
            this.grdCardTongSoSach.BackgroundGradientColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(126)))), ((int)(((byte)(227)))));
            this.grdCardTongSoSach.BackgroundGradientColor_2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(175)))), ((int)(((byte)(253)))));
            this.grdCardTongSoSach.Content = "2.000.000";
            this.grdCardTongSoSach.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.grdCardTongSoSach.Header = "Tổng số sách";
            this.grdCardTongSoSach.Location = new System.Drawing.Point(3, 3);
            this.grdCardTongSoSach.Name = "grdCardTongSoSach";
            this.grdCardTongSoSach.Size = new System.Drawing.Size(270, 125);
            this.grdCardTongSoSach.TabIndex = 0;
            // 
            // grdCardTongSoTacGia
            // 
            this.grdCardTongSoTacGia.BackColor = System.Drawing.Color.Transparent;
            this.grdCardTongSoTacGia.BackgroundGradientColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(73)))), ((int)(((byte)(255)))));
            this.grdCardTongSoTacGia.BackgroundGradientColor_2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(76)))), ((int)(((byte)(227)))));
            this.grdCardTongSoTacGia.Content = "2.000.000";
            this.grdCardTongSoTacGia.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.grdCardTongSoTacGia.Header = "Tổng số tác giả";
            this.grdCardTongSoTacGia.Location = new System.Drawing.Point(279, 3);
            this.grdCardTongSoTacGia.Name = "grdCardTongSoTacGia";
            this.grdCardTongSoTacGia.Size = new System.Drawing.Size(270, 125);
            this.grdCardTongSoTacGia.TabIndex = 3;
            // 
            // grdCardTongSoNhaPhatHanh
            // 
            this.grdCardTongSoNhaPhatHanh.BackColor = System.Drawing.Color.Transparent;
            this.grdCardTongSoNhaPhatHanh.BackgroundGradientColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.grdCardTongSoNhaPhatHanh.BackgroundGradientColor_2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(102)))), ((int)(((byte)(187)))));
            this.grdCardTongSoNhaPhatHanh.Content = "2.000.000";
            this.grdCardTongSoNhaPhatHanh.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.grdCardTongSoNhaPhatHanh.Header = "Tổng số nhà phát hành";
            this.grdCardTongSoNhaPhatHanh.Location = new System.Drawing.Point(555, 3);
            this.grdCardTongSoNhaPhatHanh.Name = "grdCardTongSoNhaPhatHanh";
            this.grdCardTongSoNhaPhatHanh.Size = new System.Drawing.Size(270, 125);
            this.grdCardTongSoNhaPhatHanh.TabIndex = 1;
            // 
            // grdCardTongSoNguoiDung
            // 
            this.grdCardTongSoNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.grdCardTongSoNguoiDung.BackgroundGradientColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(174)))), ((int)(((byte)(204)))));
            this.grdCardTongSoNguoiDung.BackgroundGradientColor_2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.grdCardTongSoNguoiDung.Content = "2.000.000";
            this.grdCardTongSoNguoiDung.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.grdCardTongSoNguoiDung.Header = "Tổng số người dùng";
            this.grdCardTongSoNguoiDung.Location = new System.Drawing.Point(831, 3);
            this.grdCardTongSoNguoiDung.Name = "grdCardTongSoNguoiDung";
            this.grdCardTongSoNguoiDung.Size = new System.Drawing.Size(270, 125);
            this.grdCardTongSoNguoiDung.TabIndex = 2;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1133, 590);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlHello);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeScreen";
            this.Padding = new System.Windows.Forms.Padding(14, 0, 14, 14);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.pnlHello.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHello;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.GradientCard grdCardTongSoSach;
        private Controls.GradientCard grdCardTongSoTacGia;
        private Controls.GradientCard grdCardTongSoNhaPhatHanh;
        private Controls.GradientCard grdCardTongSoNguoiDung;
    }
}