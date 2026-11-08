namespace WindowsFormsApp2.Forms
{
    partial class frmEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSpacer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlForm = new Guna.UI2.WinForms.Guna2Panel();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.cboTaiKhoan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlSpacer.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersHeight = 38;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.dgv.MultiSelect = false;
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowTemplate.Height = 32;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgv.ThemeStyle.HeaderStyle.Height = 38;
            this.dgv.ThemeStyle.ReadOnly = true;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.dgv.ThemeStyle.RowsStyle.Height = 32;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colHoTen,
            this.colDienThoai,
            this.colEmail,
            this.colDiaChi,
            this.colTaiKhoan});
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.FillWeight = 60F;
            this.colMaNV.HeaderText = "Mã NV";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.FillWeight = 140F;
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colDienThoai
            // 
            this.colDienThoai.DataPropertyName = "DienThoai";
            this.colDienThoai.FillWeight = 90F;
            this.colDienThoai.HeaderText = "Điện thoại";
            this.colDienThoai.MinimumWidth = 6;
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.FillWeight = 150F;
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.FillWeight = 160F;
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            // 
            // colTaiKhoan
            // 
            this.colTaiKhoan.DataPropertyName = "TenDangNhap";
            this.colTaiKhoan.FillWeight = 90F;
            this.colTaiKhoan.HeaderText = "Tài khoản";
            this.colTaiKhoan.MinimumWidth = 6;
            this.colTaiKhoan.Name = "colTaiKhoan";
            this.colTaiKhoan.ReadOnly = true;
            this.dgv.Name = "dgv";
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // pnlSpacer
            // 
            this.pnlSpacer.BackColor = System.Drawing.Color.Transparent;
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpacer.Size = new System.Drawing.Size(12, 656);
            this.pnlSpacer.Name = "pnlSpacer";
            // 
            // pnlForm
            // 
            this.pnlForm.AutoScroll = true;
            this.pnlForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlForm.BorderRadius = 10;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlForm.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlForm.Size = new System.Drawing.Size(360, 656);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Controls.Add(this.lblThongTin);
            this.pnlForm.Controls.Add(this.lblMaNV);
            this.pnlForm.Controls.Add(this.txtMaNV);
            this.pnlForm.Controls.Add(this.lblHoTen);
            this.pnlForm.Controls.Add(this.txtHoTen);
            this.pnlForm.Controls.Add(this.lblDienThoai);
            this.pnlForm.Controls.Add(this.txtDienThoai);
            this.pnlForm.Controls.Add(this.lblEmail);
            this.pnlForm.Controls.Add(this.txtEmail);
            this.pnlForm.Controls.Add(this.lblDiaChi);
            this.pnlForm.Controls.Add(this.txtDiaChi);
            this.pnlForm.Controls.Add(this.lblTaiKhoan);
            this.pnlForm.Controls.Add(this.cboTaiKhoan);
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.BackColor = System.Drawing.Color.Transparent;
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblThongTin.ForeColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.lblThongTin.Location = new System.Drawing.Point(16, 14);
            this.lblThongTin.Text = "Thông tin chi tiết";
            this.lblThongTin.Name = "lblThongTin";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaNV.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblMaNV.Location = new System.Drawing.Point(16, 50);
            this.lblMaNV.Text = "Mã nhân viên *";
            this.lblMaNV.Name = "lblMaNV";
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtMaNV.BorderRadius = 6;
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNV.DefaultText = "";
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaNV.Location = new System.Drawing.Point(16, 72);
            this.txtMaNV.Size = new System.Drawing.Size(328, 34);
            this.txtMaNV.MaxLength = 20;
            this.txtMaNV.Name = "txtMaNV";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblHoTen.Location = new System.Drawing.Point(16, 116);
            this.lblHoTen.Text = "Họ tên *";
            this.lblHoTen.Name = "lblHoTen";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtHoTen.BorderRadius = 6;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHoTen.Location = new System.Drawing.Point(16, 138);
            this.txtHoTen.Size = new System.Drawing.Size(328, 34);
            this.txtHoTen.MaxLength = 100;
            this.txtHoTen.Name = "txtHoTen";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.BackColor = System.Drawing.Color.Transparent;
            this.lblDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDienThoai.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblDienThoai.Location = new System.Drawing.Point(16, 182);
            this.lblDienThoai.Text = "Điện thoại";
            this.lblDienThoai.Name = "lblDienThoai";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtDienThoai.BorderRadius = 6;
            this.txtDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDienThoai.DefaultText = "";
            this.txtDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDienThoai.Location = new System.Drawing.Point(16, 204);
            this.txtDienThoai.Size = new System.Drawing.Size(328, 34);
            this.txtDienThoai.MaxLength = 15;
            this.txtDienThoai.Name = "txtDienThoai";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblEmail.Location = new System.Drawing.Point(16, 248);
            this.lblEmail.Text = "Email";
            this.lblEmail.Name = "lblEmail";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtEmail.BorderRadius = 6;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(16, 270);
            this.txtEmail.Size = new System.Drawing.Size(328, 34);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblDiaChi.Location = new System.Drawing.Point(16, 314);
            this.lblDiaChi.Text = "Địa chỉ";
            this.lblDiaChi.Name = "lblDiaChi";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtDiaChi.BorderRadius = 6;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDiaChi.Location = new System.Drawing.Point(16, 336);
            this.txtDiaChi.Size = new System.Drawing.Size(328, 34);
            this.txtDiaChi.MaxLength = 255;
            this.txtDiaChi.Name = "txtDiaChi";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblTaiKhoan.Location = new System.Drawing.Point(16, 380);
            this.lblTaiKhoan.Text = "Tài khoản đăng nhập";
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            // 
            // cboTaiKhoan
            // 
            this.cboTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.cboTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.cboTaiKhoan.BorderRadius = 6;
            this.cboTaiKhoan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTaiKhoan.ItemHeight = 30;
            this.cboTaiKhoan.Location = new System.Drawing.Point(16, 402);
            this.cboTaiKhoan.Size = new System.Drawing.Size(328, 36);
            this.cboTaiKhoan.Name = "cboTaiKhoan";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Size = new System.Drawing.Size(1126, 64);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Controls.Add(this.btnThem);
            this.pnlBottom.Controls.Add(this.btnSua);
            this.pnlBottom.Controls.Add(this.btnXoa);
            this.pnlBottom.Controls.Add(this.btnLamMoi);
            this.pnlBottom.Controls.Add(this.btnXuatExcel);
            // 
            // btnThem
            // 
            this.btnThem.Animated = true;
            this.btnThem.BorderRadius = 8;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(0, 12);
            this.btnThem.Size = new System.Drawing.Size(110, 40);
            this.btnThem.HoverState.FillColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.btnThem.Name = "btnThem";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Animated = true;
            this.btnSua.BorderRadius = 8;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(217, 119, 6);
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(120, 12);
            this.btnSua.Size = new System.Drawing.Size(110, 40);
            this.btnSua.HoverState.FillColor = System.Drawing.Color.FromArgb(180, 83, 9);
            this.btnSua.Name = "btnSua";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Animated = true;
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(240, 12);
            this.btnXoa.Size = new System.Drawing.Size(110, 40);
            this.btnXoa.HoverState.FillColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Animated = true;
            this.btnLamMoi.BorderRadius = 8;
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Location = new System.Drawing.Point(360, 12);
            this.btnLamMoi.Size = new System.Drawing.Size(110, 40);
            this.btnLamMoi.HoverState.FillColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Animated = true;
            this.btnXuatExcel.BorderRadius = 8;
            this.btnXuatExcel.FillColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.Location = new System.Drawing.Point(976, 12);
            this.btnXuatExcel.Size = new System.Drawing.Size(150, 40);
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnXuatExcel.HoverState.FillColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(1126, 64);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Controls.Add(this.lblTieuDe);
            this.pnlTop.Controls.Add(this.lblTongSo);
            this.pnlTop.Controls.Add(this.txtTimKiem);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.lblTieuDe.Location = new System.Drawing.Point(0, 6);
            this.lblTieuDe.Text = "QUẢN LÝ NHÂN VIÊN";
            this.lblTieuDe.Name = "lblTieuDe";
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.BackColor = System.Drawing.Color.Transparent;
            this.lblTongSo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTongSo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblTongSo.Location = new System.Drawing.Point(2, 40);
            this.lblTongSo.Text = "Tổng: 0";
            this.lblTongSo.Name = "lblTongSo";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtTimKiem.BorderRadius = 6;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.PlaceholderText = "Tìm kiếm theo mã hoặc tên...";
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(806, 14);
            this.txtTimKiem.Size = new System.Drawing.Size(320, 36);
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý nhân viên";
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlSpacer);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlSpacer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaiKhoan;
        private Guna.UI2.WinForms.Guna2Panel pnlSpacer;
        private Guna.UI2.WinForms.Guna2Panel pnlForm;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblMaNV;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
        private System.Windows.Forms.Label lblHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private System.Windows.Forms.Label lblDienThoai;
        private Guna.UI2.WinForms.Guna2TextBox txtDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private System.Windows.Forms.Label lblTaiKhoan;
        private Guna.UI2.WinForms.Guna2ComboBox cboTaiKhoan;
        private Guna.UI2.WinForms.Guna2Panel pnlBottom;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcel;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTongSo;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
    }
}
