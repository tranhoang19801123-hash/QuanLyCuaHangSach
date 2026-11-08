namespace WindowsFormsApp2.Forms
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlContent = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDashboard = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvSapHet = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colSHMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSHTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSHTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSHTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSapHet = new System.Windows.Forms.Label();
            this.tblCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardSach = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitleSach = new System.Windows.Forms.Label();
            this.lblTongSach = new System.Windows.Forms.Label();
            this.cardKhach = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitleKhach = new System.Windows.Forms.Label();
            this.lblTongKhach = new System.Windows.Forms.Label();
            this.cardHoaDon = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitleHoaDon = new System.Windows.Forms.Label();
            this.lblHoaDonHomNay = new System.Windows.Forms.Label();
            this.cardDoanhThu = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitleDoanhThu = new System.Windows.Forms.Label();
            this.lblDoanhThuHomNay = new System.Windows.Forms.Label();
            this.lblChaoMung = new System.Windows.Forms.Label();
            this.pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCauHinhNganHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoiMK = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhanQuyen = new Guna.UI2.WinForms.Guna2Button();
            this.btnNguoiDung = new Guna.UI2.WinForms.Guna2Button();
            this.lblNhomHeThong = new System.Windows.Forms.Label();
            this.btnBaoCao = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnBanHang = new Guna.UI2.WinForms.Guna2Button();
            this.lblNhomNghiepVu = new System.Windows.Forms.Label();
            this.btnNCC = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnTheLoai = new Guna.UI2.WinForms.Guna2Button();
            this.btnSach = new Guna.UI2.WinForms.Guna2Button();
            this.lblNhomDanhMuc = new System.Windows.Forms.Label();
            this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContent.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSapHet)).BeginInit();
            this.tblCards.SuspendLayout();
            this.cardSach.SuspendLayout();
            this.cardKhach.SuspendLayout();
            this.cardHoaDon.SuspendLayout();
            this.cardDoanhThu.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlContent.Controls.Add(this.pnlDashboard);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlContent.Location = new System.Drawing.Point(230, 64);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(12);
            this.pnlContent.Size = new System.Drawing.Size(1050, 696);
            this.pnlContent.TabIndex = 0;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.Transparent;
            this.pnlDashboard.Controls.Add(this.dgvSapHet);
            this.pnlDashboard.Controls.Add(this.lblSapHet);
            this.pnlDashboard.Controls.Add(this.tblCards);
            this.pnlDashboard.Controls.Add(this.lblChaoMung);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlDashboard.Location = new System.Drawing.Point(12, 12);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1026, 672);
            this.pnlDashboard.TabIndex = 0;
            // 
            // dgvSapHet
            // 
            this.dgvSapHet.AllowUserToAddRows = false;
            this.dgvSapHet.AllowUserToDeleteRows = false;
            this.dgvSapHet.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvSapHet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSapHet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSapHet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSapHet.ColumnHeadersHeight = 38;
            this.dgvSapHet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSHMaSP,
            this.colSHTenSP,
            this.colSHTacGia,
            this.colSHTon});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSapHet.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSapHet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSapHet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvSapHet.Location = new System.Drawing.Point(0, 234);
            this.dgvSapHet.MultiSelect = false;
            this.dgvSapHet.Name = "dgvSapHet";
            this.dgvSapHet.ReadOnly = true;
            this.dgvSapHet.RowHeadersVisible = false;
            this.dgvSapHet.RowHeadersWidth = 51;
            this.dgvSapHet.RowTemplate.Height = 32;
            this.dgvSapHet.Size = new System.Drawing.Size(1026, 438);
            this.dgvSapHet.TabIndex = 0;
            this.dgvSapHet.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvSapHet.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSapHet.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvSapHet.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.dgvSapHet.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvSapHet.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSapHet.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSapHet.ThemeStyle.HeaderStyle.Height = 38;
            this.dgvSapHet.ThemeStyle.ReadOnly = true;
            this.dgvSapHet.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSapHet.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvSapHet.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dgvSapHet.ThemeStyle.RowsStyle.Height = 32;
            this.dgvSapHet.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.dgvSapHet.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            // 
            // colSHMaSP
            // 
            this.colSHMaSP.DataPropertyName = "MaSP";
            this.colSHMaSP.FillWeight = 70F;
            this.colSHMaSP.HeaderText = "Mã sách";
            this.colSHMaSP.MinimumWidth = 6;
            this.colSHMaSP.Name = "colSHMaSP";
            this.colSHMaSP.ReadOnly = true;
            // 
            // colSHTenSP
            // 
            this.colSHTenSP.DataPropertyName = "TenSP";
            this.colSHTenSP.FillWeight = 220F;
            this.colSHTenSP.HeaderText = "Tên sách";
            this.colSHTenSP.MinimumWidth = 6;
            this.colSHTenSP.Name = "colSHTenSP";
            this.colSHTenSP.ReadOnly = true;
            // 
            // colSHTacGia
            // 
            this.colSHTacGia.DataPropertyName = "TacGia";
            this.colSHTacGia.FillWeight = 120F;
            this.colSHTacGia.HeaderText = "Tác giả";
            this.colSHTacGia.MinimumWidth = 6;
            this.colSHTacGia.Name = "colSHTacGia";
            this.colSHTacGia.ReadOnly = true;
            // 
            // colSHTon
            // 
            this.colSHTon.DataPropertyName = "SoLuongTon";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.colSHTon.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSHTon.FillWeight = 60F;
            this.colSHTon.HeaderText = "Tồn kho";
            this.colSHTon.MinimumWidth = 6;
            this.colSHTon.Name = "colSHTon";
            this.colSHTon.ReadOnly = true;
            // 
            // lblSapHet
            // 
            this.lblSapHet.BackColor = System.Drawing.Color.Transparent;
            this.lblSapHet.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSapHet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSapHet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblSapHet.Location = new System.Drawing.Point(0, 190);
            this.lblSapHet.Name = "lblSapHet";
            this.lblSapHet.Size = new System.Drawing.Size(1026, 44);
            this.lblSapHet.TabIndex = 1;
            this.lblSapHet.Text = "Sách sắp hết hàng (tồn kho dưới 10)";
            this.lblSapHet.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tblCards
            // 
            this.tblCards.BackColor = System.Drawing.Color.Transparent;
            this.tblCards.ColumnCount = 4;
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCards.Controls.Add(this.cardSach, 0, 0);
            this.tblCards.Controls.Add(this.cardKhach, 1, 0);
            this.tblCards.Controls.Add(this.cardHoaDon, 2, 0);
            this.tblCards.Controls.Add(this.cardDoanhThu, 3, 0);
            this.tblCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblCards.Location = new System.Drawing.Point(0, 50);
            this.tblCards.Name = "tblCards";
            this.tblCards.RowCount = 1;
            this.tblCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCards.Size = new System.Drawing.Size(1026, 140);
            this.tblCards.TabIndex = 2;
            // 
            // cardSach
            // 
            this.cardSach.BackColor = System.Drawing.Color.Transparent;
            this.cardSach.BorderRadius = 12;
            this.cardSach.Controls.Add(this.lblTitleSach);
            this.cardSach.Controls.Add(this.lblTongSach);
            this.cardSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardSach.Location = new System.Drawing.Point(6, 6);
            this.cardSach.Margin = new System.Windows.Forms.Padding(6);
            this.cardSach.Name = "cardSach";
            this.cardSach.Size = new System.Drawing.Size(244, 128);
            this.cardSach.TabIndex = 0;
            // 
            // lblTitleSach
            // 
            this.lblTitleSach.AutoSize = true;
            this.lblTitleSach.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleSach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTitleSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTitleSach.Location = new System.Drawing.Point(18, 16);
            this.lblTitleSach.Name = "lblTitleSach";
            this.lblTitleSach.Size = new System.Drawing.Size(138, 28);
            this.lblTitleSach.TabIndex = 0;
            this.lblTitleSach.Text = "Tổng đầu sách";
            // 
            // lblTongSach
            // 
            this.lblTongSach.AutoSize = true;
            this.lblTongSach.BackColor = System.Drawing.Color.Transparent;
            this.lblTongSach.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTongSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblTongSach.Location = new System.Drawing.Point(18, 50);
            this.lblTongSach.Name = "lblTongSach";
            this.lblTongSach.Size = new System.Drawing.Size(56, 65);
            this.lblTongSach.TabIndex = 1;
            this.lblTongSach.Text = "0";
            // 
            // cardKhach
            // 
            this.cardKhach.BackColor = System.Drawing.Color.Transparent;
            this.cardKhach.BorderRadius = 12;
            this.cardKhach.Controls.Add(this.lblTitleKhach);
            this.cardKhach.Controls.Add(this.lblTongKhach);
            this.cardKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardKhach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardKhach.Location = new System.Drawing.Point(262, 6);
            this.cardKhach.Margin = new System.Windows.Forms.Padding(6);
            this.cardKhach.Name = "cardKhach";
            this.cardKhach.Size = new System.Drawing.Size(244, 128);
            this.cardKhach.TabIndex = 1;
            // 
            // lblTitleKhach
            // 
            this.lblTitleKhach.AutoSize = true;
            this.lblTitleKhach.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleKhach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTitleKhach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTitleKhach.Location = new System.Drawing.Point(18, 16);
            this.lblTitleKhach.Name = "lblTitleKhach";
            this.lblTitleKhach.Size = new System.Drawing.Size(114, 28);
            this.lblTitleKhach.TabIndex = 0;
            this.lblTitleKhach.Text = "Khách hàng";
            // 
            // lblTongKhach
            // 
            this.lblTongKhach.AutoSize = true;
            this.lblTongKhach.BackColor = System.Drawing.Color.Transparent;
            this.lblTongKhach.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTongKhach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblTongKhach.Location = new System.Drawing.Point(18, 50);
            this.lblTongKhach.Name = "lblTongKhach";
            this.lblTongKhach.Size = new System.Drawing.Size(56, 65);
            this.lblTongKhach.TabIndex = 1;
            this.lblTongKhach.Text = "0";
            // 
            // cardHoaDon
            // 
            this.cardHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.cardHoaDon.BorderRadius = 12;
            this.cardHoaDon.Controls.Add(this.lblTitleHoaDon);
            this.cardHoaDon.Controls.Add(this.lblHoaDonHomNay);
            this.cardHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardHoaDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardHoaDon.Location = new System.Drawing.Point(518, 6);
            this.cardHoaDon.Margin = new System.Windows.Forms.Padding(6);
            this.cardHoaDon.Name = "cardHoaDon";
            this.cardHoaDon.Size = new System.Drawing.Size(244, 128);
            this.cardHoaDon.TabIndex = 2;
            // 
            // lblTitleHoaDon
            // 
            this.lblTitleHoaDon.AutoSize = true;
            this.lblTitleHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTitleHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTitleHoaDon.Location = new System.Drawing.Point(18, 16);
            this.lblTitleHoaDon.Name = "lblTitleHoaDon";
            this.lblTitleHoaDon.Size = new System.Drawing.Size(169, 28);
            this.lblTitleHoaDon.TabIndex = 0;
            this.lblTitleHoaDon.Text = "Hóa đơn hôm nay";
            // 
            // lblHoaDonHomNay
            // 
            this.lblHoaDonHomNay.AutoSize = true;
            this.lblHoaDonHomNay.BackColor = System.Drawing.Color.Transparent;
            this.lblHoaDonHomNay.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblHoaDonHomNay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lblHoaDonHomNay.Location = new System.Drawing.Point(18, 50);
            this.lblHoaDonHomNay.Name = "lblHoaDonHomNay";
            this.lblHoaDonHomNay.Size = new System.Drawing.Size(56, 65);
            this.lblHoaDonHomNay.TabIndex = 1;
            this.lblHoaDonHomNay.Text = "0";
            // 
            // cardDoanhThu
            // 
            this.cardDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.cardDoanhThu.BorderRadius = 12;
            this.cardDoanhThu.Controls.Add(this.lblTitleDoanhThu);
            this.cardDoanhThu.Controls.Add(this.lblDoanhThuHomNay);
            this.cardDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardDoanhThu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardDoanhThu.Location = new System.Drawing.Point(774, 6);
            this.cardDoanhThu.Margin = new System.Windows.Forms.Padding(6);
            this.cardDoanhThu.Name = "cardDoanhThu";
            this.cardDoanhThu.Size = new System.Drawing.Size(246, 128);
            this.cardDoanhThu.TabIndex = 3;
            // 
            // lblTitleDoanhThu
            // 
            this.lblTitleDoanhThu.AutoSize = true;
            this.lblTitleDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTitleDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTitleDoanhThu.Location = new System.Drawing.Point(18, 16);
            this.lblTitleDoanhThu.Name = "lblTitleDoanhThu";
            this.lblTitleDoanhThu.Size = new System.Drawing.Size(185, 28);
            this.lblTitleDoanhThu.TabIndex = 0;
            this.lblTitleDoanhThu.Text = "Doanh thu hôm nay";
            // 
            // lblDoanhThuHomNay
            // 
            this.lblDoanhThuHomNay.AutoSize = true;
            this.lblDoanhThuHomNay.BackColor = System.Drawing.Color.Transparent;
            this.lblDoanhThuHomNay.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThuHomNay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDoanhThuHomNay.Location = new System.Drawing.Point(18, 50);
            this.lblDoanhThuHomNay.Name = "lblDoanhThuHomNay";
            this.lblDoanhThuHomNay.Size = new System.Drawing.Size(56, 65);
            this.lblDoanhThuHomNay.TabIndex = 1;
            this.lblDoanhThuHomNay.Text = "0";
            // 
            // lblChaoMung
            // 
            this.lblChaoMung.BackColor = System.Drawing.Color.Transparent;
            this.lblChaoMung.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChaoMung.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblChaoMung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblChaoMung.Location = new System.Drawing.Point(0, 0);
            this.lblChaoMung.Name = "lblChaoMung";
            this.lblChaoMung.Size = new System.Drawing.Size(1026, 50);
            this.lblChaoMung.TabIndex = 3;
            this.lblChaoMung.Text = "Tổng quan cửa hàng";
            this.lblChaoMung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Controls.Add(this.btnCauHinhNganHang);
            this.pnlMenu.Controls.Add(this.btnDoiMK);
            this.pnlMenu.Controls.Add(this.btnPhanQuyen);
            this.pnlMenu.Controls.Add(this.btnNguoiDung);
            this.pnlMenu.Controls.Add(this.lblNhomHeThong);
            this.pnlMenu.Controls.Add(this.btnBaoCao);
            this.pnlMenu.Controls.Add(this.btnHoaDon);
            this.pnlMenu.Controls.Add(this.btnNhapHang);
            this.pnlMenu.Controls.Add(this.btnBanHang);
            this.pnlMenu.Controls.Add(this.lblNhomNghiepVu);
            this.pnlMenu.Controls.Add(this.btnNCC);
            this.pnlMenu.Controls.Add(this.btnNhanVien);
            this.pnlMenu.Controls.Add(this.btnKhachHang);
            this.pnlMenu.Controls.Add(this.btnTheLoai);
            this.pnlMenu.Controls.Add(this.btnSach);
            this.pnlMenu.Controls.Add(this.lblNhomDanhMuc);
            this.pnlMenu.Controls.Add(this.btnTrangChu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlMenu.Location = new System.Drawing.Point(0, 64);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(230, 696);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnCauHinhNganHang
            // 
            this.btnCauHinhNganHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCauHinhNganHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCauHinhNganHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCauHinhNganHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCauHinhNganHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnCauHinhNganHang.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnCauHinhNganHang.ForeColor = System.Drawing.Color.White;
            this.btnCauHinhNganHang.Location = new System.Drawing.Point(0, 654);
            this.btnCauHinhNganHang.Name = "btnCauHinhNganHang";
            this.btnCauHinhNganHang.Size = new System.Drawing.Size(230, 42);
            this.btnCauHinhNganHang.TabIndex = 16;
            this.btnCauHinhNganHang.Text = "   Cấu hình ngân hàng";
            this.btnCauHinhNganHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCauHinhNganHang.Click += new System.EventHandler(this.btnCauHinhNganHang_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Animated = true;
            this.btnDoiMK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoiMK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnDoiMK.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnDoiMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnDoiMK.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnDoiMK.Location = new System.Drawing.Point(0, 618);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(230, 39);
            this.btnDoiMK.TabIndex = 0;
            this.btnDoiMK.Text = "   Đổi mật khẩu";
            this.btnDoiMK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Animated = true;
            this.btnPhanQuyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhanQuyen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnPhanQuyen.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnPhanQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnPhanQuyen.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnPhanQuyen.Location = new System.Drawing.Point(0, 580);
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.Size = new System.Drawing.Size(230, 38);
            this.btnPhanQuyen.TabIndex = 1;
            this.btnPhanQuyen.Text = "   Phân quyền";
            this.btnPhanQuyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhanQuyen.Click += new System.EventHandler(this.btnPhanQuyen_Click);
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.Animated = true;
            this.btnNguoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNguoiDung.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnNguoiDung.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnNguoiDung.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnNguoiDung.Location = new System.Drawing.Point(0, 542);
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.Size = new System.Drawing.Size(230, 38);
            this.btnNguoiDung.TabIndex = 2;
            this.btnNguoiDung.Text = "   Quản lý người dùng";
            this.btnNguoiDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNguoiDung.Click += new System.EventHandler(this.btnNguoiDung_Click);
            // 
            // lblNhomHeThong
            // 
            this.lblNhomHeThong.BackColor = System.Drawing.Color.Transparent;
            this.lblNhomHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNhomHeThong.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNhomHeThong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblNhomHeThong.Location = new System.Drawing.Point(0, 508);
            this.lblNhomHeThong.Name = "lblNhomHeThong";
            this.lblNhomHeThong.Padding = new System.Windows.Forms.Padding(18, 0, 0, 4);
            this.lblNhomHeThong.Size = new System.Drawing.Size(230, 34);
            this.lblNhomHeThong.TabIndex = 3;
            this.lblNhomHeThong.Text = "HỆ THỐNG";
            this.lblNhomHeThong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Animated = true;
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnBaoCao.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnBaoCao.Location = new System.Drawing.Point(0, 464);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(230, 44);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "   Báo cáo thống kê";
            this.btnBaoCao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Animated = true;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnHoaDon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnHoaDon.Location = new System.Drawing.Point(0, 420);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(230, 44);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Text = "   Tra cứu hóa đơn";
            this.btnHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Animated = true;
            this.btnNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhapHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnNhapHang.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnNhapHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnNhapHang.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnNhapHang.Location = new System.Drawing.Point(0, 376);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(230, 44);
            this.btnNhapHang.TabIndex = 6;
            this.btnNhapHang.Text = "   Nhập hàng";
            this.btnNhapHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Animated = true;
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnBanHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnBanHang.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnBanHang.Location = new System.Drawing.Point(0, 332);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(230, 44);
            this.btnBanHang.TabIndex = 7;
            this.btnBanHang.Text = "   Bán hàng";
            this.btnBanHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // lblNhomNghiepVu
            // 
            this.lblNhomNghiepVu.BackColor = System.Drawing.Color.Transparent;
            this.lblNhomNghiepVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNhomNghiepVu.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNhomNghiepVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblNhomNghiepVu.Location = new System.Drawing.Point(0, 298);
            this.lblNhomNghiepVu.Name = "lblNhomNghiepVu";
            this.lblNhomNghiepVu.Padding = new System.Windows.Forms.Padding(18, 0, 0, 4);
            this.lblNhomNghiepVu.Size = new System.Drawing.Size(230, 34);
            this.lblNhomNghiepVu.TabIndex = 8;
            this.lblNhomNghiepVu.Text = "NGHIỆP VỤ";
            this.lblNhomNghiepVu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnNCC
            // 
            this.btnNCC.Animated = true;
            this.btnNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnNCC.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnNCC.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnNCC.Location = new System.Drawing.Point(0, 254);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(230, 44);
            this.btnNCC.TabIndex = 9;
            this.btnNCC.Text = "   Nhà cung cấp";
            this.btnNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Animated = true;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnNhanVien.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnNhanVien.Location = new System.Drawing.Point(0, 210);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(230, 44);
            this.btnNhanVien.TabIndex = 10;
            this.btnNhanVien.Text = "   Nhân viên";
            this.btnNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Animated = true;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnKhachHang.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnKhachHang.Location = new System.Drawing.Point(0, 166);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(230, 44);
            this.btnKhachHang.TabIndex = 11;
            this.btnKhachHang.Text = "   Khách hàng";
            this.btnKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Animated = true;
            this.btnTheLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTheLoai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnTheLoai.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnTheLoai.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnTheLoai.Location = new System.Drawing.Point(0, 122);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(230, 44);
            this.btnTheLoai.TabIndex = 12;
            this.btnTheLoai.Text = "   Thể loại sách";
            this.btnTheLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTheLoai.Click += new System.EventHandler(this.btnTheLoai_Click);
            // 
            // btnSach
            // 
            this.btnSach.Animated = true;
            this.btnSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnSach.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnSach.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnSach.Location = new System.Drawing.Point(0, 78);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(230, 44);
            this.btnSach.TabIndex = 13;
            this.btnSach.Text = "   Quản lý sách";
            this.btnSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // lblNhomDanhMuc
            // 
            this.lblNhomDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.lblNhomDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNhomDanhMuc.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNhomDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblNhomDanhMuc.Location = new System.Drawing.Point(0, 44);
            this.lblNhomDanhMuc.Name = "lblNhomDanhMuc";
            this.lblNhomDanhMuc.Padding = new System.Windows.Forms.Padding(18, 0, 0, 4);
            this.lblNhomDanhMuc.Size = new System.Drawing.Size(230, 34);
            this.lblNhomDanhMuc.TabIndex = 14;
            this.lblNhomDanhMuc.Text = "DANH MỤC";
            this.lblNhomDanhMuc.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Animated = true;
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrangChu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnTrangChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnTrangChu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnTrangChu.Location = new System.Drawing.Point(0, 0);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(230, 44);
            this.btnTrangChu.TabIndex = 15;
            this.btnTrangChu.Text = "   Trang chủ";
            this.btnTrangChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Controls.Add(this.lblUser);
            this.pnlHeader.Controls.Add(this.btnDangXuat);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1280, 64);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTieuDe.Location = new System.Drawing.Point(20, 18);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(405, 41);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ CỬA HÀNG SÁCH";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblUser.Location = new System.Drawing.Point(730, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(380, 64);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Xin chào";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.Animated = true;
            this.btnDangXuat.BorderRadius = 8;
            this.btnDangXuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDangXuat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDangXuat.Location = new System.Drawing.Point(1120, 14);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(140, 36);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSapHet)).EndInit();
            this.tblCards.ResumeLayout(false);
            this.cardSach.ResumeLayout(false);
            this.cardSach.PerformLayout();
            this.cardKhach.ResumeLayout(false);
            this.cardKhach.PerformLayout();
            this.cardHoaDon.ResumeLayout(false);
            this.cardHoaDon.PerformLayout();
            this.cardDoanhThu.ResumeLayout(false);
            this.cardDoanhThu.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlContent;
        private Guna.UI2.WinForms.Guna2Panel pnlDashboard;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSapHet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSHMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSHTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSHTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSHTon;
        private System.Windows.Forms.Label lblSapHet;
        private System.Windows.Forms.TableLayoutPanel tblCards;
        private Guna.UI2.WinForms.Guna2Panel cardSach;
        private System.Windows.Forms.Label lblTitleSach;
        private System.Windows.Forms.Label lblTongSach;
        private Guna.UI2.WinForms.Guna2Panel cardKhach;
        private System.Windows.Forms.Label lblTitleKhach;
        private System.Windows.Forms.Label lblTongKhach;
        private Guna.UI2.WinForms.Guna2Panel cardHoaDon;
        private System.Windows.Forms.Label lblTitleHoaDon;
        private System.Windows.Forms.Label lblHoaDonHomNay;
        private Guna.UI2.WinForms.Guna2Panel cardDoanhThu;
        private System.Windows.Forms.Label lblTitleDoanhThu;
        private System.Windows.Forms.Label lblDoanhThuHomNay;
        private System.Windows.Forms.Label lblChaoMung;
        private Guna.UI2.WinForms.Guna2Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Button btnDoiMK;
        private Guna.UI2.WinForms.Guna2Button btnPhanQuyen;
        private Guna.UI2.WinForms.Guna2Button btnNguoiDung;
        private System.Windows.Forms.Label lblNhomHeThong;
        private Guna.UI2.WinForms.Guna2Button btnBaoCao;
        private Guna.UI2.WinForms.Guna2Button btnHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnNhapHang;
        private Guna.UI2.WinForms.Guna2Button btnBanHang;
        private System.Windows.Forms.Label lblNhomNghiepVu;
        private Guna.UI2.WinForms.Guna2Button btnNCC;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnTheLoai;
        private Guna.UI2.WinForms.Guna2Button btnSach;
        private System.Windows.Forms.Label lblNhomDanhMuc;
        private Guna.UI2.WinForms.Guna2Button btnTrangChu;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblUser;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnCauHinhNganHang;
    }
}
