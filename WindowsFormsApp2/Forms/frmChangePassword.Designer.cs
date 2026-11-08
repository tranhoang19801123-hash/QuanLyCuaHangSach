namespace WindowsFormsApp2.Forms
{
    partial class frmChangePassword
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblCu = new System.Windows.Forms.Label();
            this.txtCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMoi = new System.Windows.Forms.Label();
            this.txtMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblXacNhan = new System.Windows.Forms.Label();
            this.txtXacNhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblTieuDe.Location = new System.Drawing.Point(30, 22);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(222, 45);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Đổi mật khẩu";
            // 
            // lblCu
            // 
            this.lblCu.AutoSize = true;
            this.lblCu.BackColor = System.Drawing.Color.Transparent;
            this.lblCu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblCu.Location = new System.Drawing.Point(30, 70);
            this.lblCu.Name = "lblCu";
            this.lblCu.Size = new System.Drawing.Size(119, 28);
            this.lblCu.TabIndex = 1;
            this.lblCu.Text = "Mật khẩu cũ";
            // 
            // txtCu
            // 
            this.txtCu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtCu.BorderRadius = 6;
            this.txtCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCu.DefaultText = "";
            this.txtCu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCu.Location = new System.Drawing.Point(30, 94);
            this.txtCu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCu.Name = "txtCu";
            this.txtCu.PlaceholderText = "";
            this.txtCu.SelectedText = "";
            this.txtCu.Size = new System.Drawing.Size(380, 40);
            this.txtCu.TabIndex = 2;
            this.txtCu.UseSystemPasswordChar = true;
            // 
            // lblMoi
            // 
            this.lblMoi.AutoSize = true;
            this.lblMoi.BackColor = System.Drawing.Color.Transparent;
            this.lblMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblMoi.Location = new System.Drawing.Point(30, 148);
            this.lblMoi.Name = "lblMoi";
            this.lblMoi.Size = new System.Drawing.Size(288, 28);
            this.lblMoi.TabIndex = 3;
            this.lblMoi.Text = "Mật khẩu mới (tối thiểu 6 ký tự)";
            // 
            // txtMoi
            // 
            this.txtMoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtMoi.BorderRadius = 6;
            this.txtMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoi.DefaultText = "";
            this.txtMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMoi.Location = new System.Drawing.Point(30, 172);
            this.txtMoi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMoi.Name = "txtMoi";
            this.txtMoi.PlaceholderText = "";
            this.txtMoi.SelectedText = "";
            this.txtMoi.Size = new System.Drawing.Size(380, 40);
            this.txtMoi.TabIndex = 4;
            this.txtMoi.UseSystemPasswordChar = true;
            // 
            // lblXacNhan
            // 
            this.lblXacNhan.AutoSize = true;
            this.lblXacNhan.BackColor = System.Drawing.Color.Transparent;
            this.lblXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblXacNhan.Location = new System.Drawing.Point(30, 226);
            this.lblXacNhan.Name = "lblXacNhan";
            this.lblXacNhan.Size = new System.Drawing.Size(216, 28);
            this.lblXacNhan.TabIndex = 5;
            this.lblXacNhan.Text = "Xác nhận mật khẩu mới";
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtXacNhan.BorderRadius = 6;
            this.txtXacNhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXacNhan.DefaultText = "";
            this.txtXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtXacNhan.Location = new System.Drawing.Point(30, 250);
            this.txtXacNhan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.PlaceholderText = "";
            this.txtXacNhan.SelectedText = "";
            this.txtXacNhan.Size = new System.Drawing.Size(380, 40);
            this.txtXacNhan.TabIndex = 6;
            this.txtXacNhan.UseSystemPasswordChar = true;
            // 
            // btnDoi
            // 
            this.btnDoi.Animated = true;
            this.btnDoi.BorderRadius = 8;
            this.btnDoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnDoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDoi.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnDoi.Location = new System.Drawing.Point(30, 320);
            this.btnDoi.Name = "btnDoi";
            this.btnDoi.Size = new System.Drawing.Size(200, 44);
            this.btnDoi.TabIndex = 7;
            this.btnDoi.Text = "Đổi mật khẩu";
            // 
            // btnHuy
            // 
            this.btnHuy.Animated = true;
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHuy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnHuy.Location = new System.Drawing.Point(245, 320);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(165, 44);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            // 
            // frmChangePassword
            // 
            this.AcceptButton = this.btnDoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(440, 430);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblCu);
            this.Controls.Add(this.txtCu);
            this.Controls.Add(this.lblMoi);
            this.Controls.Add(this.txtMoi);
            this.Controls.Add(this.lblXacNhan);
            this.Controls.Add(this.txtXacNhan);
            this.Controls.Add(this.btnDoi);
            this.Controls.Add(this.btnHuy);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblCu;
        private Guna.UI2.WinForms.Guna2TextBox txtCu;
        private System.Windows.Forms.Label lblMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtMoi;
        private System.Windows.Forms.Label lblXacNhan;
        private Guna.UI2.WinForms.Guna2TextBox txtXacNhan;
        private Guna.UI2.WinForms.Guna2Button btnDoi;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}
