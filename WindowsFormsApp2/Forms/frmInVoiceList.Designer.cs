namespace WindowsFormsApp2.Forms
{
    partial class frmInVoiceList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle100 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle101 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle102 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDanhSachHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTong = new System.Windows.Forms.Label();
            this.lblDanhSachHoaDon = new System.Windows.Forms.Label();
            this.panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnInHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.pnlGap1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBoLocTimKiem = new System.Windows.Forms.Label();
            this.lblTimMaHD = new System.Windows.Forms.Label();
            this.txtTimMaHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTimKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderRadius = 10;
            this.panel2.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.panel2.Controls.Add(this.dgvDanhSachHoaDon);
            this.panel2.Controls.Add(this.lblTong);
            this.panel2.Controls.Add(this.lblDanhSachHoaDon);
            // 
            // dgvDanhSachHoaDon
            // 
            this.dgvDanhSachHoaDon.AllowUserToAddRows = false;
            this.dgvDanhSachHoaDon.AllowUserToDeleteRows = false;
            this.dgvDanhSachHoaDon.AllowUserToResizeRows = false;
            this.dgvDanhSachHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvDanhSachHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhSachHoaDon.ColumnHeadersHeight = 38;
            this.dgvDanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDanhSachHoaDon.EnableHeadersVisualStyles = false;
            this.dgvDanhSachHoaDon.GridColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.dgvDanhSachHoaDon.MultiSelect = false;
            this.dgvDanhSachHoaDon.ReadOnly = true;
            this.dgvDanhSachHoaDon.RowHeadersVisible = false;
            this.dgvDanhSachHoaDon.RowHeadersWidth = 51;
            this.dgvDanhSachHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewCellStyle100.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.dgvDanhSachHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle100;
            dataGridViewCellStyle101.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle101.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle101.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle101.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle101.SelectionBackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle101.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle101.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle101;
            dataGridViewCellStyle102.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle102.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle102.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle102.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle102.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle102.SelectionForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle102.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachHoaDon.DefaultCellStyle = dataGridViewCellStyle102;
            this.dgvDanhSachHoaDon.RowTemplate.Height = 32;
            this.dgvDanhSachHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.dgvDanhSachHoaDon.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvDanhSachHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.dgvDanhSachHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.dgvDanhSachHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhSachHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvDanhSachHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvDanhSachHoaDon.ThemeStyle.HeaderStyle.Height = 38;
            this.dgvDanhSachHoaDon.ThemeStyle.ReadOnly = true;
            this.dgvDanhSachHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvDanhSachHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvDanhSachHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.dgvDanhSachHoaDon.ThemeStyle.RowsStyle.Height = 32;
            this.dgvDanhSachHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.dgvDanhSachHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.dgvDanhSachHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colNgayLap,
            this.colTenKH,
            this.colTenNV,
            this.colTongTien,
            this.colGiamGia,
            this.colThanhTien});
            this.dgvDanhSachHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHoaDon_CellDoubleClick);
            // 
            // colMaHD
            // 
            this.colMaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaHD.DataPropertyName = "MaHD";
            this.colMaHD.HeaderText = "Mã HD";
            this.colMaHD.MinimumWidth = 8;
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.ReadOnly = true;
            // 
            // colNgayLap
            // 
            this.colNgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle9.Format = "dd/MM/yyyy HH:mm";
            this.colNgayLap.DefaultCellStyle = dataGridViewCellStyle9;
            this.colNgayLap.HeaderText = "Ngày lập";
            this.colNgayLap.MinimumWidth = 8;
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.ReadOnly = true;
            // 
            // colTenKH
            // 
            this.colTenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenKH.DataPropertyName = "TenKH";
            this.colTenKH.HeaderText = "Khách hàng";
            this.colTenKH.MinimumWidth = 8;
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.ReadOnly = true;
            // 
            // colTenNV
            // 
            this.colTenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenNV.DataPropertyName = "TenNV";
            this.colTenNV.HeaderText = "Nhân viên";
            this.colTenNV.MinimumWidth = 8;
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.ReadOnly = true;
            // 
            // colTongTien
            // 
            this.colTongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            this.colTongTien.DefaultCellStyle = dataGridViewCellStyle10;
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.MinimumWidth = 8;
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            // 
            // colGiamGia
            // 
            this.colGiamGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGiamGia.DataPropertyName = "GiamGia";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N0";
            this.colGiamGia.DefaultCellStyle = dataGridViewCellStyle11;
            this.colGiamGia.HeaderText = "Giảm giá";
            this.colGiamGia.MinimumWidth = 8;
            this.colGiamGia.Name = "colGiamGia";
            this.colGiamGia.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N0";
            this.colThanhTien.DefaultCellStyle = dataGridViewCellStyle12;
            this.colThanhTien.HeaderText = "Thanh toán";
            this.colThanhTien.MinimumWidth = 8;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = false;
            this.lblTong.BackColor = System.Drawing.Color.Transparent;
            this.lblTong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTong.ForeColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.lblTong.Size = new System.Drawing.Size(100, 40);
            this.lblTong.Text = "Số hóa đơn: 0  |  Tổng giảm giá: 0 đ  |  Tổng doanh thu: 0 đ";
            this.lblTong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDanhSachHoaDon
            // 
            this.lblDanhSachHoaDon.AutoSize = false;
            this.lblDanhSachHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhSachHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDanhSachHoaDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDanhSachHoaDon.ForeColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.lblDanhSachHoaDon.Size = new System.Drawing.Size(100, 44);
            this.lblDanhSachHoaDon.Text = "Danh sách hóa đơn";
            this.lblDanhSachHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Size = new System.Drawing.Size(1126, 64);
            this.panel3.Controls.Add(this.btnInHoaDon);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Animated = true;
            this.btnInHoaDon.BorderRadius = 8;
            this.btnInHoaDon.FillColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnInHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInHoaDon.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.Location = new System.Drawing.Point(956, 12);
            this.btnInHoaDon.Size = new System.Drawing.Size(170, 42);
            this.btnInHoaDon.HoverState.FillColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.btnInHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // pnlGap1
            // 
            this.pnlGap1.BackColor = System.Drawing.Color.Transparent;
            this.pnlGap1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGap1.Size = new System.Drawing.Size(1126, 10);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderRadius = 10;
            this.panel1.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Size = new System.Drawing.Size(1126, 136);
            this.panel1.Controls.Add(this.lblBoLocTimKiem);
            this.panel1.Controls.Add(this.lblTimMaHD);
            this.panel1.Controls.Add(this.txtTimMaHD);
            this.panel1.Controls.Add(this.lblTenKH);
            this.panel1.Controls.Add(this.txtTimKhachHang);
            this.panel1.Controls.Add(this.lblTuNgay);
            this.panel1.Controls.Add(this.dtpTuNgay);
            this.panel1.Controls.Add(this.lblDenNgay);
            this.panel1.Controls.Add(this.dtpDenNgay);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnLamMoi);
            // 
            // lblBoLocTimKiem
            // 
            this.lblBoLocTimKiem.AutoSize = true;
            this.lblBoLocTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.lblBoLocTimKiem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBoLocTimKiem.ForeColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.lblBoLocTimKiem.Location = new System.Drawing.Point(16, 8);
            this.lblBoLocTimKiem.Text = "Bộ lọc tìm kiếm";
            // 
            // lblTimMaHD
            // 
            this.lblTimMaHD.AutoSize = true;
            this.lblTimMaHD.BackColor = System.Drawing.Color.Transparent;
            this.lblTimMaHD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTimMaHD.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblTimMaHD.Location = new System.Drawing.Point(16, 56);
            this.lblTimMaHD.Text = "Mã hóa đơn";
            // 
            // txtTimMaHD
            // 
            this.txtTimMaHD.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtTimMaHD.BorderRadius = 6;
            this.txtTimMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimMaHD.DefaultText = "";
            this.txtTimMaHD.PlaceholderText = "Nhập mã hóa đơn...";
            this.txtTimMaHD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimMaHD.Location = new System.Drawing.Point(130, 48);
            this.txtTimMaHD.Size = new System.Drawing.Size(220, 34);
            this.txtTimMaHD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimMaHD_KeyDown);
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.BackColor = System.Drawing.Color.Transparent;
            this.lblTenKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenKH.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblTenKH.Location = new System.Drawing.Point(16, 98);
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // txtTimKhachHang
            // 
            this.txtTimKhachHang.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtTimKhachHang.BorderRadius = 6;
            this.txtTimKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKhachHang.DefaultText = "";
            this.txtTimKhachHang.PlaceholderText = "Nhập tên khách hàng...";
            this.txtTimKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKhachHang.Location = new System.Drawing.Point(130, 90);
            this.txtTimKhachHang.Size = new System.Drawing.Size(220, 34);
            this.txtTimKhachHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKhachHang_KeyDown);
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.BackColor = System.Drawing.Color.Transparent;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTuNgay.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblTuNgay.Location = new System.Drawing.Point(390, 56);
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.BackColor = System.Drawing.Color.Transparent;
            this.dtpTuNgay.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.dtpTuNgay.BorderRadius = 6;
            this.dtpTuNgay.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(470, 48);
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 34);
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.BackColor = System.Drawing.Color.Transparent;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDenNgay.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblDenNgay.Location = new System.Drawing.Point(390, 98);
            this.lblDenNgay.Text = "Đến ngày";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.BackColor = System.Drawing.Color.Transparent;
            this.dtpDenNgay.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.dtpDenNgay.BorderRadius = 6;
            this.dtpDenNgay.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(470, 90);
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 34);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Animated = true;
            this.btnTimKiem.BorderRadius = 8;
            this.btnTimKiem.FillColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Location = new System.Drawing.Point(720, 48);
            this.btnTimKiem.Size = new System.Drawing.Size(140, 36);
            this.btnTimKiem.HoverState.FillColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Animated = true;
            this.btnLamMoi.BorderRadius = 8;
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Location = new System.Drawing.Point(720, 90);
            this.btnLamMoi.Size = new System.Drawing.Size(140, 36);
            this.btnLamMoi.HoverState.FillColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(1126, 48);
            this.pnlTop.Controls.Add(this.lblTieuDe);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.lblTieuDe.Location = new System.Drawing.Point(0, 8);
            this.lblTieuDe.Text = "TRA CỨU HÓA ĐƠN";
            // 
            // frmInVoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tra cứu hóa đơn";
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlGap1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmInVoiceList";
            this.Load += new System.EventHandler(this.frmInVoiceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSachHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblDanhSachHoaDon;
        private Guna.UI2.WinForms.Guna2Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnInHoaDon;
        private Guna.UI2.WinForms.Guna2Panel pnlGap1;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private System.Windows.Forms.Label lblBoLocTimKiem;
        private System.Windows.Forms.Label lblTimMaHD;
        private Guna.UI2.WinForms.Guna2TextBox txtTimMaHD;
        private System.Windows.Forms.Label lblTenKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKhachHang;
        private System.Windows.Forms.Label lblTuNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDenNgay;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblTieuDe;
    }
}
