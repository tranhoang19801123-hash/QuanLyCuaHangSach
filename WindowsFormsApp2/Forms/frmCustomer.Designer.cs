namespace WindowsFormsApp2.Forms
{
    partial class frmCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSpacer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlForm = new Guna.UI2.WinForms.Guna2Panel();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiem = new System.Windows.Forms.Label();
            this.nudDiem = new System.Windows.Forms.NumericUpDown();
            this.lblHang = new System.Windows.Forms.Label();
            this.cboHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnFileMau = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiem)).BeginInit();
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
            this.colMaKH,
            this.colHoTen,
            this.colDienThoai,
            this.colDiem,
            this.colHang,
            this.colGiam});
            // 
            // colMaKH
            // 
            this.colMaKH.DataPropertyName = "MaKH";
            this.colMaKH.FillWeight = 70F;
            this.colMaKH.HeaderText = "Mã KH";
            this.colMaKH.MinimumWidth = 6;
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.FillWeight = 170F;
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colDienThoai
            // 
            this.colDienThoai.DataPropertyName = "DienThoai";
            this.colDienThoai.FillWeight = 100F;
            this.colDienThoai.HeaderText = "Điện thoại";
            this.colDienThoai.MinimumWidth = 6;
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.ReadOnly = true;
            // 
            // colDiem
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDiem.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDiem.DataPropertyName = "DiemTichLuy";
            this.colDiem.FillWeight = 60F;
            this.colDiem.HeaderText = "Điểm";
            this.colDiem.MinimumWidth = 6;
            this.colDiem.Name = "colDiem";
            this.colDiem.ReadOnly = true;
            // 
            // colHang
            // 
            this.colHang.DataPropertyName = "TenHang";
            this.colHang.FillWeight = 90F;
            this.colHang.HeaderText = "Hạng";
            this.colHang.MinimumWidth = 6;
            this.colHang.Name = "colHang";
            this.colHang.ReadOnly = true;
            // 
            // colGiam
            // 
            dataGridViewCellStyle5.Format = "0.##";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colGiam.DefaultCellStyle = dataGridViewCellStyle5;
            this.colGiam.DataPropertyName = "PhanTramGiam";
            this.colGiam.FillWeight = 80F;
            this.colGiam.HeaderText = "Giảm giá (%)";
            this.colGiam.MinimumWidth = 6;
            this.colGiam.Name = "colGiam";
            this.colGiam.ReadOnly = true;
            this.dgv.Name = "dgv";
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // pnlSpacer
            // 
            this.pnlSpacer.BackColor = System.Drawing.Color.Transparent;
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpacer.Size = new System.Drawing.Size(12, 636);
            this.pnlSpacer.Name = "pnlSpacer";
            // 
            // pnlForm
            // 
            this.pnlForm.AutoScroll = true;
            this.pnlForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlForm.BorderRadius = 10;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlForm.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlForm.Size = new System.Drawing.Size(360, 636);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Controls.Add(this.lblThongTin);
            this.pnlForm.Controls.Add(this.lblMaKH);
            this.pnlForm.Controls.Add(this.txtMaKH);
            this.pnlForm.Controls.Add(this.lblHoTen);
            this.pnlForm.Controls.Add(this.txtHoTen);
            this.pnlForm.Controls.Add(this.lblDienThoai);
            this.pnlForm.Controls.Add(this.txtDienThoai);
            this.pnlForm.Controls.Add(this.lblDiem);
            this.pnlForm.Controls.Add(this.nudDiem);
            this.pnlForm.Controls.Add(this.lblHang);
            this.pnlForm.Controls.Add(this.cboHang);
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
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.BackColor = System.Drawing.Color.Transparent;
            this.lblMaKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaKH.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblMaKH.Location = new System.Drawing.Point(16, 50);
            this.lblMaKH.Text = "Mã khách hàng *";
            this.lblMaKH.Name = "lblMaKH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtMaKH.BorderRadius = 6;
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.DefaultText = "";
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaKH.Location = new System.Drawing.Point(16, 72);
            this.txtMaKH.Size = new System.Drawing.Size(328, 34);
            this.txtMaKH.MaxLength = 20;
            this.txtMaKH.Name = "txtMaKH";
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
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.BackColor = System.Drawing.Color.Transparent;
            this.lblDiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiem.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblDiem.Location = new System.Drawing.Point(16, 248);
            this.lblDiem.Text = "Điểm tích lũy";
            this.lblDiem.Name = "lblDiem";
            // 
            // nudDiem
            // 
            this.nudDiem.DecimalPlaces = 0;
            this.nudDiem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nudDiem.Location = new System.Drawing.Point(16, 270);
            this.nudDiem.Maximum = new decimal(new int[] {100000000, 0, 0, 0});
            this.nudDiem.Size = new System.Drawing.Size(328, 32);
            this.nudDiem.ThousandsSeparator = true;
            this.nudDiem.Name = "nudDiem";
            this.nudDiem.ValueChanged += new System.EventHandler(this.nudDiem_ValueChanged);
            // 
            // lblHang
            // 
            this.lblHang.AutoSize = true;
            this.lblHang.BackColor = System.Drawing.Color.Transparent;
            this.lblHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHang.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblHang.Location = new System.Drawing.Point(16, 314);
            this.lblHang.Text = "Hạng thành viên";
            this.lblHang.Name = "lblHang";
            // 
            // cboHang
            // 
            this.cboHang.BackColor = System.Drawing.Color.Transparent;
            this.cboHang.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.cboHang.BorderRadius = 6;
            this.cboHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboHang.ItemHeight = 30;
            this.cboHang.Location = new System.Drawing.Point(16, 336);
            this.cboHang.Size = new System.Drawing.Size(328, 36);
            this.cboHang.Name = "cboHang";
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
            this.pnlBottom.Controls.Add(this.btnQuanLyHang);
            this.pnlBottom.Controls.Add(this.btnNhapExcel);
            this.pnlBottom.Controls.Add(this.btnFileMau);
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
            // btnQuanLyHang
            // 
            this.btnQuanLyHang.Animated = true;
            this.btnQuanLyHang.BorderRadius = 8;
            this.btnQuanLyHang.FillColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.btnQuanLyHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuanLyHang.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnQuanLyHang.Text = "Quản lý hạng";
            this.btnQuanLyHang.Location = new System.Drawing.Point(480, 12);
            this.btnQuanLyHang.Size = new System.Drawing.Size(140, 40);
            this.btnQuanLyHang.HoverState.FillColor = System.Drawing.Color.FromArgb(23, 37, 84);
            this.btnQuanLyHang.Name = "btnQuanLyHang";
            this.btnQuanLyHang.Click += new System.EventHandler(this.btnQuanLyHang_Click);
            // 
            // btnNhapExcel
            // 
            this.btnNhapExcel.Animated = true;
            this.btnNhapExcel.BorderRadius = 8;
            this.btnNhapExcel.FillColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnNhapExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNhapExcel.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnNhapExcel.Text = "Nhập Excel";
            this.btnNhapExcel.Location = new System.Drawing.Point(630, 12);
            this.btnNhapExcel.Size = new System.Drawing.Size(130, 40);
            this.btnNhapExcel.HoverState.FillColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.btnNhapExcel.Name = "btnNhapExcel";
            this.btnNhapExcel.Click += new System.EventHandler(this.btnNhapExcel_Click);
            // 
            // btnFileMau
            // 
            this.btnFileMau.Animated = true;
            this.btnFileMau.BorderRadius = 8;
            this.btnFileMau.FillColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnFileMau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFileMau.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnFileMau.Text = "File mẫu";
            this.btnFileMau.Location = new System.Drawing.Point(770, 12);
            this.btnFileMau.Size = new System.Drawing.Size(110, 40);
            this.btnFileMau.HoverState.FillColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnFileMau.Name = "btnFileMau";
            this.btnFileMau.Click += new System.EventHandler(this.btnFileMau_Click);
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
            this.lblTieuDe.Text = "QUẢN LÝ KHÁCH HÀNG & HẠNG THÀNH VIÊN";
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
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ClientSize = new System.Drawing.Size(1150, 660);
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý khách hàng";
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlSpacer);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiem)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiam;
        private Guna.UI2.WinForms.Guna2Panel pnlSpacer;
        private Guna.UI2.WinForms.Guna2Panel pnlForm;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblMaKH;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
        private System.Windows.Forms.Label lblHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private System.Windows.Forms.Label lblDienThoai;
        private Guna.UI2.WinForms.Guna2TextBox txtDienThoai;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.NumericUpDown nudDiem;
        private System.Windows.Forms.Label lblHang;
        private Guna.UI2.WinForms.Guna2ComboBox cboHang;
        private Guna.UI2.WinForms.Guna2Panel pnlBottom;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyHang;
        private Guna.UI2.WinForms.Guna2Button btnNhapExcel;
        private Guna.UI2.WinForms.Guna2Button btnFileMau;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcel;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTongSo;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
    }
}
