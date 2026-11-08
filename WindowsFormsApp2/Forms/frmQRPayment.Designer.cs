namespace WindowsFormsApp2.Forms
{
    partial class frmQRPayment
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
            this.pnlCard = new Guna.UI2.WinForms.Guna2Panel();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.lblTimMaHD = new System.Windows.Forms.Label();
            this.txtTimMaHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNguoiNhan = new System.Windows.Forms.Label();
            this.btnDong = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCard.BorderRadius = 10;
            this.pnlCard.Controls.Add(this.picQR);
            this.pnlCard.Controls.Add(this.lblTimMaHD);
            this.pnlCard.Controls.Add(this.txtTimMaHD);
            this.pnlCard.Controls.Add(this.lblThanhTien);
            this.pnlCard.Controls.Add(this.txtThanhTien);
            this.pnlCard.Controls.Add(this.lblNguoiNhan);
            this.pnlCard.Controls.Add(this.btnDong);
            this.pnlCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlCard.Location = new System.Drawing.Point(20, 84);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(420, 524);
            this.pnlCard.TabIndex = 0;
            // 
            // picQR
            // 
            this.picQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.picQR.Location = new System.Drawing.Point(60, 16);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(300, 300);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQR.TabIndex = 0;
            this.picQR.TabStop = false;
            // 
            // lblTimMaHD
            // 
            this.lblTimMaHD.AutoSize = true;
            this.lblTimMaHD.BackColor = System.Drawing.Color.Transparent;
            this.lblTimMaHD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTimMaHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblTimMaHD.Location = new System.Drawing.Point(20, 332);
            this.lblTimMaHD.Name = "lblTimMaHD";
            this.lblTimMaHD.Size = new System.Drawing.Size(118, 28);
            this.lblTimMaHD.TabIndex = 1;
            this.lblTimMaHD.Text = "Mã hóa đơn";
            // 
            // txtTimMaHD
            // 
            this.txtTimMaHD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtTimMaHD.BorderRadius = 6;
            this.txtTimMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimMaHD.DefaultText = "";
            this.txtTimMaHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtTimMaHD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimMaHD.Location = new System.Drawing.Point(150, 324);
            this.txtTimMaHD.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTimMaHD.Name = "txtTimMaHD";
            this.txtTimMaHD.PlaceholderText = "";
            this.txtTimMaHD.ReadOnly = true;
            this.txtTimMaHD.SelectedText = "";
            this.txtTimMaHD.Size = new System.Drawing.Size(250, 34);
            this.txtTimMaHD.TabIndex = 2;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.BackColor = System.Drawing.Color.Transparent;
            this.lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblThanhTien.Location = new System.Drawing.Point(20, 376);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(103, 28);
            this.lblThanhTien.TabIndex = 3;
            this.lblThanhTien.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtThanhTien.BorderRadius = 6;
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhTien.DefaultText = "";
            this.txtThanhTien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtThanhTien.Location = new System.Drawing.Point(150, 368);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PlaceholderText = "";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.SelectedText = "";
            this.txtThanhTien.Size = new System.Drawing.Size(250, 34);
            this.txtThanhTien.TabIndex = 4;
            // 
            // lblNguoiNhan
            // 
            this.lblNguoiNhan.BackColor = System.Drawing.Color.Transparent;
            this.lblNguoiNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNguoiNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblNguoiNhan.Location = new System.Drawing.Point(20, 412);
            this.lblNguoiNhan.Name = "lblNguoiNhan";
            this.lblNguoiNhan.Size = new System.Drawing.Size(380, 42);
            this.lblNguoiNhan.TabIndex = 5;
            this.lblNguoiNhan.Text = "Người nhận:";
            this.lblNguoiNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDong
            // 
            this.btnDong.Animated = true;
            this.btnDong.BorderRadius = 8;
            this.btnDong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDong.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnDong.Location = new System.Drawing.Point(110, 466);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(200, 42);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click_1);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(460, 64);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTieuDe.Location = new System.Drawing.Point(20, 17);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(376, 38);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THANH TOÁN QUA VIETQR";
            // 
            // frmQRPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(460, 628);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQRPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thanh toán VietQR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQRPayment_FormClosed);
            this.Load += new System.EventHandler(this.frmQRPayment_Load);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Label lblTimMaHD;
        private Guna.UI2.WinForms.Guna2TextBox txtTimMaHD;
        private System.Windows.Forms.Label lblThanhTien;
        private Guna.UI2.WinForms.Guna2TextBox txtThanhTien;
        private System.Windows.Forms.Label lblNguoiNhan;
        private Guna.UI2.WinForms.Guna2Button btnDong;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTieuDe;
    }
}
