namespace WindowsFormsApp2.Forms
{
    partial class frmConnectionConfig
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
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtDatabase = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAuth = new System.Windows.Forms.Label();
            this.rdoWindows = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoSQL = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblUserSql = new System.Windows.Forms.Label();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassSql = new System.Windows.Forms.Label();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTest = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
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
            this.lblTieuDe.Size = new System.Drawing.Size(264, 45);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Cấu hình kết nối";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.BackColor = System.Drawing.Color.Transparent;
            this.lblServer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblServer.Location = new System.Drawing.Point(30, 70);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(67, 28);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtServer.BorderRadius = 6;
            this.txtServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServer.DefaultText = "";
            this.txtServer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtServer.Location = new System.Drawing.Point(30, 94);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtServer.Name = "txtServer";
            this.txtServer.PlaceholderText = "vd: (localdb)\\MSSQLLocalDB hoặc .\\SQLEXPRESS";
            this.txtServer.SelectedText = "";
            this.txtServer.Size = new System.Drawing.Size(420, 40);
            this.txtServer.TabIndex = 2;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.BackColor = System.Drawing.Color.Transparent;
            this.lblDatabase.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblDatabase.Location = new System.Drawing.Point(30, 148);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(93, 28);
            this.lblDatabase.TabIndex = 3;
            this.lblDatabase.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtDatabase.BorderRadius = 6;
            this.txtDatabase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatabase.DefaultText = "";
            this.txtDatabase.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDatabase.Location = new System.Drawing.Point(30, 172);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.PlaceholderText = "QuanLyCuaHangSach";
            this.txtDatabase.SelectedText = "";
            this.txtDatabase.Size = new System.Drawing.Size(420, 40);
            this.txtDatabase.TabIndex = 4;
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.BackColor = System.Drawing.Color.Transparent;
            this.lblAuth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblAuth.Location = new System.Drawing.Point(30, 226);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(151, 28);
            this.lblAuth.TabIndex = 5;
            this.lblAuth.Text = "Chế độ xác thực";
            // 
            // rdoWindows
            // 
            this.rdoWindows.AutoSize = true;
            this.rdoWindows.BackColor = System.Drawing.Color.Transparent;
            this.rdoWindows.Checked = true;
            this.rdoWindows.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.rdoWindows.CheckedState.BorderThickness = 0;
            this.rdoWindows.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.rdoWindows.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rdoWindows.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoWindows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.rdoWindows.Location = new System.Drawing.Point(30, 252);
            this.rdoWindows.Name = "rdoWindows";
            this.rdoWindows.Size = new System.Drawing.Size(252, 32);
            this.rdoWindows.TabIndex = 6;
            this.rdoWindows.TabStop = true;
            this.rdoWindows.Text = "Windows Authentication";
            this.rdoWindows.UncheckedState.BorderThickness = 0;
            this.rdoWindows.UseVisualStyleBackColor = false;
            // 
            // rdoSQL
            // 
            this.rdoSQL.AutoSize = true;
            this.rdoSQL.BackColor = System.Drawing.Color.Transparent;
            this.rdoSQL.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.rdoSQL.CheckedState.BorderThickness = 0;
            this.rdoSQL.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.rdoSQL.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rdoSQL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoSQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.rdoSQL.Location = new System.Drawing.Point(30, 282);
            this.rdoSQL.Name = "rdoSQL";
            this.rdoSQL.Size = new System.Drawing.Size(266, 32);
            this.rdoSQL.TabIndex = 7;
            this.rdoSQL.Text = "SQL Server Authentication";
            this.rdoSQL.UncheckedState.BorderThickness = 0;
            this.rdoSQL.UseVisualStyleBackColor = false;
            // 
            // lblUserSql
            // 
            this.lblUserSql.AutoSize = true;
            this.lblUserSql.BackColor = System.Drawing.Color.Transparent;
            this.lblUserSql.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserSql.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblUserSql.Location = new System.Drawing.Point(30, 318);
            this.lblUserSql.Name = "lblUserSql";
            this.lblUserSql.Size = new System.Drawing.Size(94, 28);
            this.lblUserSql.TabIndex = 8;
            this.lblUserSql.Text = "Tài khoản";
            // 
            // txtUser
            // 
            this.txtUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtUser.BorderRadius = 6;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUser.Location = new System.Drawing.Point(30, 342);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "";
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(420, 40);
            this.txtUser.TabIndex = 9;
            // 
            // lblPassSql
            // 
            this.lblPassSql.AutoSize = true;
            this.lblPassSql.BackColor = System.Drawing.Color.Transparent;
            this.lblPassSql.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassSql.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblPassSql.Location = new System.Drawing.Point(30, 396);
            this.lblPassSql.Name = "lblPassSql";
            this.lblPassSql.Size = new System.Drawing.Size(94, 28);
            this.lblPassSql.TabIndex = 10;
            this.lblPassSql.Text = "Mật khẩu";
            // 
            // txtPass
            // 
            this.txtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtPass.BorderRadius = 6;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPass.Location = new System.Drawing.Point(30, 420);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPass.Name = "txtPass";
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(420, 40);
            this.txtPass.TabIndex = 11;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnTest
            // 
            this.btnTest.Animated = true;
            this.btnTest.BorderRadius = 8;
            this.btnTest.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnTest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTest.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.btnTest.Location = new System.Drawing.Point(30, 486);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(200, 44);
            this.btnTest.TabIndex = 12;
            this.btnTest.Text = "Thử kết nối";
            // 
            // btnLuu
            // 
            this.btnLuu.Animated = true;
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnLuu.Location = new System.Drawing.Point(250, 486);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(200, 44);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu cấu hình";
            // 
            // frmConnectionConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(480, 560);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.lblAuth);
            this.Controls.Add(this.rdoWindows);
            this.Controls.Add(this.rdoSQL);
            this.Controls.Add(this.lblUserSql);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPassSql);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnLuu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConnectionConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình kết nối SQL Server";
            this.Load += new System.EventHandler(this.frmConnectionConfig_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblServer;
        private Guna.UI2.WinForms.Guna2TextBox txtServer;
        private System.Windows.Forms.Label lblDatabase;
        private Guna.UI2.WinForms.Guna2TextBox txtDatabase;
        private System.Windows.Forms.Label lblAuth;
        private Guna.UI2.WinForms.Guna2RadioButton rdoWindows;
        private Guna.UI2.WinForms.Guna2RadioButton rdoSQL;
        private System.Windows.Forms.Label lblUserSql;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private System.Windows.Forms.Label lblPassSql;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2Button btnTest;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
    }
}
