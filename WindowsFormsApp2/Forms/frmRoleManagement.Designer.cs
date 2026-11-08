namespace WindowsFormsApp2.Forms
{
    partial class frmRoleManagement
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
            this.pnlChucNang = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCNTitle = new System.Windows.Forms.Label();
            this.clbChucNang = new System.Windows.Forms.CheckedListBox();
            this.btnLuuQuyen = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSpacer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlNhom = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNhomTitle = new System.Windows.Forms.Label();
            this.lstNhom = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNhom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemNhom = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaNhom = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaNhom = new Guna.UI2.WinForms.Guna2Button();
            this.pnlChucNang.SuspendLayout();
            this.pnlNhom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.BackColor = System.Drawing.Color.Transparent;
            this.pnlChucNang.BorderRadius = 10;
            this.pnlChucNang.Controls.Add(this.lblCNTitle);
            this.pnlChucNang.Controls.Add(this.clbChucNang);
            this.pnlChucNang.Controls.Add(this.btnLuuQuyen);
            this.pnlChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChucNang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlChucNang.Location = new System.Drawing.Point(444, 12);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(594, 616);
            this.pnlChucNang.TabIndex = 0;
            // 
            // lblCNTitle
            // 
            this.lblCNTitle.AutoSize = true;
            this.lblCNTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCNTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCNTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblCNTitle.Location = new System.Drawing.Point(16, 14);
            this.lblCNTitle.Name = "lblCNTitle";
            this.lblCNTitle.Size = new System.Drawing.Size(286, 30);
            this.lblCNTitle.TabIndex = 0;
            this.lblCNTitle.Text = "Chức năng được cho phép";
            // 
            // clbChucNang
            // 
            this.clbChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbChucNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbChucNang.CheckOnClick = true;
            this.clbChucNang.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.clbChucNang.FormattingEnabled = true;
            this.clbChucNang.Location = new System.Drawing.Point(16, 48);
            this.clbChucNang.Name = "clbChucNang";
            this.clbChucNang.Size = new System.Drawing.Size(558, 450);
            this.clbChucNang.TabIndex = 1;
            // 
            // btnLuuQuyen
            // 
            this.btnLuuQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuuQuyen.Animated = true;
            this.btnLuuQuyen.BorderRadius = 8;
            this.btnLuuQuyen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnLuuQuyen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuuQuyen.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnLuuQuyen.Location = new System.Drawing.Point(16, 534);
            this.btnLuuQuyen.Name = "btnLuuQuyen";
            this.btnLuuQuyen.Size = new System.Drawing.Size(220, 44);
            this.btnLuuQuyen.TabIndex = 2;
            this.btnLuuQuyen.Text = "Lưu phân quyền";
            // 
            // pnlSpacer
            // 
            this.pnlSpacer.BackColor = System.Drawing.Color.Transparent;
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpacer.Location = new System.Drawing.Point(432, 12);
            this.pnlSpacer.Name = "pnlSpacer";
            this.pnlSpacer.Size = new System.Drawing.Size(12, 616);
            this.pnlSpacer.TabIndex = 1;
            // 
            // pnlNhom
            // 
            this.pnlNhom.BackColor = System.Drawing.Color.Transparent;
            this.pnlNhom.BorderRadius = 10;
            this.pnlNhom.Controls.Add(this.lblNhomTitle);
            this.pnlNhom.Controls.Add(this.lstNhom);
            this.pnlNhom.Controls.Add(this.label1);
            this.pnlNhom.Controls.Add(this.txtTenNhom);
            this.pnlNhom.Controls.Add(this.label2);
            this.pnlNhom.Controls.Add(this.txtMoTa);
            this.pnlNhom.Controls.Add(this.btnThemNhom);
            this.pnlNhom.Controls.Add(this.btnSuaNhom);
            this.pnlNhom.Controls.Add(this.btnXoaNhom);
            this.pnlNhom.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNhom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlNhom.Location = new System.Drawing.Point(12, 12);
            this.pnlNhom.Name = "pnlNhom";
            this.pnlNhom.Size = new System.Drawing.Size(420, 616);
            this.pnlNhom.TabIndex = 2;
            // 
            // lblNhomTitle
            // 
            this.lblNhomTitle.AutoSize = true;
            this.lblNhomTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblNhomTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNhomTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblNhomTitle.Location = new System.Drawing.Point(16, 14);
            this.lblNhomTitle.Name = "lblNhomTitle";
            this.lblNhomTitle.Size = new System.Drawing.Size(146, 30);
            this.lblNhomTitle.TabIndex = 0;
            this.lblNhomTitle.Text = "Nhóm quyền";
            // 
            // lstNhom
            // 
            this.lstNhom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstNhom.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lstNhom.FormattingEnabled = true;
            this.lstNhom.ItemHeight = 30;
            this.lstNhom.Location = new System.Drawing.Point(16, 48);
            this.lstNhom.Name = "lstNhom";
            this.lstNhom.Size = new System.Drawing.Size(388, 212);
            this.lstNhom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(16, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên nhóm";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtTenNhom.BorderRadius = 6;
            this.txtTenNhom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhom.DefaultText = "";
            this.txtTenNhom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenNhom.Location = new System.Drawing.Point(16, 308);
            this.txtTenNhom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTenNhom.MaxLength = 50;
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.PlaceholderText = "";
            this.txtTenNhom.SelectedText = "";
            this.txtTenNhom.Size = new System.Drawing.Size(388, 36);
            this.txtTenNhom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(16, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtMoTa.BorderRadius = 6;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMoTa.Location = new System.Drawing.Point(16, 376);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMoTa.MaxLength = 200;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(388, 36);
            this.txtMoTa.TabIndex = 5;
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Animated = true;
            this.btnThemNhom.BorderRadius = 8;
            this.btnThemNhom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnThemNhom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemNhom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThemNhom.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnThemNhom.Location = new System.Drawing.Point(16, 430);
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(120, 42);
            this.btnThemNhom.TabIndex = 6;
            this.btnThemNhom.Text = "Thêm";
            // 
            // btnSuaNhom
            // 
            this.btnSuaNhom.Animated = true;
            this.btnSuaNhom.BorderRadius = 8;
            this.btnSuaNhom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnSuaNhom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSuaNhom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuaNhom.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.btnSuaNhom.Location = new System.Drawing.Point(146, 430);
            this.btnSuaNhom.Name = "btnSuaNhom";
            this.btnSuaNhom.Size = new System.Drawing.Size(120, 42);
            this.btnSuaNhom.TabIndex = 7;
            this.btnSuaNhom.Text = "Sửa";
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.Animated = true;
            this.btnXoaNhom.BorderRadius = 8;
            this.btnXoaNhom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnXoaNhom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaNhom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoaNhom.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnXoaNhom.Location = new System.Drawing.Point(276, 430);
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(128, 42);
            this.btnXoaNhom.TabIndex = 8;
            this.btnXoaNhom.Text = "Xóa";
            // 
            // frmRoleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1050, 640);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.pnlSpacer);
            this.Controls.Add(this.pnlNhom);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmRoleManagement";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phân quyền người dùng";
            this.Load += new System.EventHandler(this.frmRoleManagement_Load_1);
            this.pnlChucNang.ResumeLayout(false);
            this.pnlChucNang.PerformLayout();
            this.pnlNhom.ResumeLayout(false);
            this.pnlNhom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlChucNang;
        private System.Windows.Forms.Label lblCNTitle;
        private System.Windows.Forms.CheckedListBox clbChucNang;
        private Guna.UI2.WinForms.Guna2Button btnLuuQuyen;
        private Guna.UI2.WinForms.Guna2Panel pnlSpacer;
        private Guna.UI2.WinForms.Guna2Panel pnlNhom;
        private System.Windows.Forms.Label lblNhomTitle;
        private System.Windows.Forms.ListBox lstNhom;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNhom;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private Guna.UI2.WinForms.Guna2Button btnThemNhom;
        private Guna.UI2.WinForms.Guna2Button btnSuaNhom;
        private Guna.UI2.WinForms.Guna2Button btnXoaNhom;
    }
}
