namespace WindowsFormsApp2.Forms
{
    partial class frmBankConfig
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
            this.lblBin = new System.Windows.Forms.Label();
            this.txtBin = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenNganHang = new System.Windows.Forms.Label();
            this.txtTenNganHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSoTaiKhoan = new System.Windows.Forms.Label();
            this.txtSoTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkHienSo = new System.Windows.Forms.CheckBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCard.BorderRadius = 10;
            this.pnlCard.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlCard.Location = new System.Drawing.Point(20, 84);
            this.pnlCard.Size = new System.Drawing.Size(520, 440);
            this.pnlCard.Controls.Add(this.lblBin);
            this.pnlCard.Controls.Add(this.txtBin);
            this.pnlCard.Controls.Add(this.lblTenNganHang);
            this.pnlCard.Controls.Add(this.txtTenNganHang);
            this.pnlCard.Controls.Add(this.lblSoTaiKhoan);
            this.pnlCard.Controls.Add(this.txtSoTaiKhoan);
            this.pnlCard.Controls.Add(this.lblTenTaiKhoan);
            this.pnlCard.Controls.Add(this.txtTenTaiKhoan);
            this.pnlCard.Controls.Add(this.chkHienSo);
            this.pnlCard.Controls.Add(this.lblGhiChu);
            this.pnlCard.Controls.Add(this.btnLuu);
            this.pnlCard.Controls.Add(this.btnHuy);
            // 
            // lblBin
            // 
            this.lblBin.AutoSize = true;
            this.lblBin.BackColor = System.Drawing.Color.Transparent;
            this.lblBin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBin.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblBin.Location = new System.Drawing.Point(20, 16);
            this.lblBin.Text = "Mã ngân hàng (BIN)";
            // 
            // txtBin
            // 
            this.txtBin.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtBin.BorderRadius = 6;
            this.txtBin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBin.DefaultText = "";
            this.txtBin.PlaceholderText = "Ví dụ: 970422";
            this.txtBin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBin.Location = new System.Drawing.Point(20, 38);
            this.txtBin.Size = new System.Drawing.Size(480, 34);
            this.txtBin.MaxLength = 6;
            // 
            // lblTenNganHang
            // 
            this.lblTenNganHang.AutoSize = true;
            this.lblTenNganHang.BackColor = System.Drawing.Color.Transparent;
            this.lblTenNganHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenNganHang.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblTenNganHang.Location = new System.Drawing.Point(20, 84);
            this.lblTenNganHang.Text = "Tên ngân hàng";
            // 
            // txtTenNganHang
            // 
            this.txtTenNganHang.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtTenNganHang.BorderRadius = 6;
            this.txtTenNganHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNganHang.DefaultText = "";
            this.txtTenNganHang.PlaceholderText = "Ví dụ: MB Bank";
            this.txtTenNganHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenNganHang.Location = new System.Drawing.Point(20, 106);
            this.txtTenNganHang.Size = new System.Drawing.Size(480, 34);
            this.txtTenNganHang.MaxLength = 50;
            // 
            // lblSoTaiKhoan
            // 
            this.lblSoTaiKhoan.AutoSize = true;
            this.lblSoTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblSoTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblSoTaiKhoan.Location = new System.Drawing.Point(20, 152);
            this.lblSoTaiKhoan.Text = "Số tài khoản";
            // 
            // txtSoTaiKhoan
            // 
            this.txtSoTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtSoTaiKhoan.BorderRadius = 6;
            this.txtSoTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoTaiKhoan.DefaultText = "";
            this.txtSoTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoTaiKhoan.Location = new System.Drawing.Point(20, 174);
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(480, 34);
            this.txtSoTaiKhoan.MaxLength = 19;
            this.txtSoTaiKhoan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSoTaiKhoan.UseSystemPasswordChar = true;
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(20, 220);
            this.lblTenTaiKhoan.Text = "Tên chủ tài khoản";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtTenTaiKhoan.BorderRadius = 6;
            this.txtTenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTaiKhoan.DefaultText = "";
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(20, 242);
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(480, 34);
            this.txtTenTaiKhoan.MaxLength = 100;
            this.txtTenTaiKhoan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // chkHienSo
            // 
            this.chkHienSo.AutoSize = true;
            this.chkHienSo.BackColor = System.Drawing.Color.Transparent;
            this.chkHienSo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkHienSo.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.chkHienSo.Location = new System.Drawing.Point(20, 288);
            this.chkHienSo.Text = "Hiện số tài khoản";
            this.chkHienSo.UseVisualStyleBackColor = false;
            this.chkHienSo.CheckedChanged += new System.EventHandler(this.chkHienSo_CheckedChanged);
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.BackColor = System.Drawing.Color.Transparent;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblGhiChu.Location = new System.Drawing.Point(20, 326);
            this.lblGhiChu.Text = "Thông tin sẽ được mã hóa và lưu trên máy tính này.";
            // 
            // btnLuu
            // 
            this.btnLuu.Animated = true;
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnLuu.Text = "Lưu cấu hình";
            this.btnLuu.Location = new System.Drawing.Point(250, 372);
            this.btnLuu.Size = new System.Drawing.Size(140, 42);
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Animated = true;
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Location = new System.Drawing.Point(400, 372);
            this.btnHuy.Size = new System.Drawing.Size(100, 42);
            this.btnHuy.HoverState.FillColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(560, 64);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblTieuDe.Location = new System.Drawing.Point(20, 17);
            this.lblTieuDe.Text = "TÀI KHOẢN NHẬN TIỀN VIETQR";
            // 
            // frmBankConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ClientSize = new System.Drawing.Size(560, 544);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Padding = new System.Windows.Forms.Padding(0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tài khoản VietQR";
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmBankConfig";
            this.Load += new System.EventHandler(this.frmBankConfig_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private System.Windows.Forms.Label lblBin;
        private Guna.UI2.WinForms.Guna2TextBox txtBin;
        private System.Windows.Forms.Label lblTenNganHang;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNganHang;
        private System.Windows.Forms.Label lblSoTaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox txtSoTaiKhoan;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTaiKhoan;
        private System.Windows.Forms.CheckBox chkHienSo;
        private System.Windows.Forms.Label lblGhiChu;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTieuDe;
    }
}
