namespace PresentationLayer.Forms
{
    partial class SplashForm
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
            this.pnlLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblCopyRight = new Guna.UI.WinForms.GunaLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLoading = new Guna.UI.WinForms.GunaPictureBox();
            this.pnlLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLayout
            // 
            this.pnlLayout.ColumnCount = 1;
            this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlLayout.Controls.Add(this.lblCopyRight, 0, 1);
            this.pnlLayout.Controls.Add(this.lblTitle, 0, 0);
            this.pnlLayout.Controls.Add(this.picLoading, 0, 2);
            this.pnlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlLayout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.RowCount = 3;
            this.pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.23913F));
            this.pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.pnlLayout.Size = new System.Drawing.Size(784, 411);
            this.pnlLayout.TabIndex = 0;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCopyRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCopyRight.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCopyRight.Location = new System.Drawing.Point(3, 185);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(778, 15);
            this.lblCopyRight.TabIndex = 3;
            this.lblCopyRight.Text = "Copyright © Cẩm Phong, Duy Anh";
            this.lblCopyRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(0, 138);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(784, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đồ Án Quản Lý Thư Viện";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLoading
            // 
            this.picLoading.BaseColor = System.Drawing.Color.White;
            this.picLoading.Image = global::PresentationLayer.Properties.Resources.Loading;
            this.picLoading.Location = new System.Drawing.Point(3, 226);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(757, 23);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoading.TabIndex = 4;
            this.picLoading.TabStop = false;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.pnlLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Form";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.pnlLayout.ResumeLayout(false);
            this.pnlLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel pnlLayout;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaLabel lblCopyRight;
        private Guna.UI.WinForms.GunaPictureBox picLoading;
    }
}