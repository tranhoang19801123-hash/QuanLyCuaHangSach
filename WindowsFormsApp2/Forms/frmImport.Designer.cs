namespace WindowsFormsApp2.Forms
{
    partial class frmImport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvChiTietPhieuNhap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlChiTietHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblChiTietPN = new System.Windows.Forms.Label();
            this.btnSuaSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaSP = new Guna.UI2.WinForms.Guna2Button();
            this.pnlGapA = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlGapB = new Guna.UI2.WinForms.Guna2Panel();
            this.panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTongTienNhap = new System.Windows.Forms.Label();
            this.txtTongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuuPhieuNhap = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.pnlRow = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.cboSanPham = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.txtGiaNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoiSP = new Guna.UI2.WinForms.Guna2Button();
            this.pnlGapV = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMaPN = new System.Windows.Forms.Label();
            this.txtMaPN = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.txtNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            this.pnlChiTietHeader.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlRow.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderRadius = 10;
            this.panel3.Controls.Add(this.dgvChiTietPhieuNhap);
            this.panel3.Controls.Add(this.pnlChiTietHeader);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(12, 274);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(12);
            this.panel3.Size = new System.Drawing.Size(1126, 312);
            this.panel3.TabIndex = 0;
            // 
            // dgvChiTietPhieuNhap
            // 
            this.dgvChiTietPhieuNhap.AllowUserToAddRows = false;
            this.dgvChiTietPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvChiTietPhieuNhap.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvChiTietPhieuNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvChiTietPhieuNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvChiTietPhieuNhap.ColumnHeadersHeight = 38;
            this.dgvChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colSoLuong,
            this.colGiaNhap,
            this.colThanhTien});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietPhieuNhap.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietPhieuNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(12, 60);
            this.dgvChiTietPhieuNhap.MultiSelect = false;
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.ReadOnly = true;
            this.dgvChiTietPhieuNhap.RowHeadersVisible = false;
            this.dgvChiTietPhieuNhap.RowHeadersWidth = 51;
            this.dgvChiTietPhieuNhap.RowTemplate.Height = 32;
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(1102, 240);
            this.dgvChiTietPhieuNhap.TabIndex = 0;
            this.dgvChiTietPhieuNhap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvChiTietPhieuNhap.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvChiTietPhieuNhap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvChiTietPhieuNhap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.dgvChiTietPhieuNhap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvChiTietPhieuNhap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvChiTietPhieuNhap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChiTietPhieuNhap.ThemeStyle.HeaderStyle.Height = 38;
            this.dgvChiTietPhieuNhap.ThemeStyle.ReadOnly = true;
            this.dgvChiTietPhieuNhap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvChiTietPhieuNhap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvChiTietPhieuNhap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dgvChiTietPhieuNhap.ThemeStyle.RowsStyle.Height = 32;
            this.dgvChiTietPhieuNhap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.dgvChiTietPhieuNhap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dgvChiTietPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuNhap_CellContentClick);
            // 
            // colMaSP
            // 
            this.colMaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaSP.DataPropertyName = "MaSP";
            this.colMaSP.HeaderText = "Mã Sách";
            this.colMaSP.MinimumWidth = 8;
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;
            // 
            // colTenSP
            // 
            this.colTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSP.DataPropertyName = "TenSP";
            this.colTenSP.HeaderText = "Tên sách";
            this.colTenSP.MinimumWidth = 8;
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 8;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colGiaNhap
            // 
            this.colGiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGiaNhap.DataPropertyName = "GiaNhap";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            this.colGiaNhap.DefaultCellStyle = dataGridViewCellStyle8;
            this.colGiaNhap.HeaderText = "Giá nhập";
            this.colGiaNhap.MinimumWidth = 8;
            this.colGiaNhap.Name = "colGiaNhap";
            this.colGiaNhap.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            this.colThanhTien.DefaultCellStyle = dataGridViewCellStyle9;
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.MinimumWidth = 8;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // pnlChiTietHeader
            // 
            this.pnlChiTietHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlChiTietHeader.Controls.Add(this.lblChiTietPN);
            this.pnlChiTietHeader.Controls.Add(this.btnSuaSP);
            this.pnlChiTietHeader.Controls.Add(this.btnXoaSP);
            this.pnlChiTietHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChiTietHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlChiTietHeader.Name = "pnlChiTietHeader";
            this.pnlChiTietHeader.Size = new System.Drawing.Size(1102, 48);
            this.pnlChiTietHeader.TabIndex = 1;
            // 
            // lblChiTietPN
            // 
            this.lblChiTietPN.AutoSize = true;
            this.lblChiTietPN.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietPN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChiTietPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblChiTietPN.Location = new System.Drawing.Point(4, 12);
            this.lblChiTietPN.Name = "lblChiTietPN";
            this.lblChiTietPN.Size = new System.Drawing.Size(210, 30);
            this.lblChiTietPN.TabIndex = 0;
            this.lblChiTietPN.Text = "Chi tiết phiếu nhập";
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaSP.Animated = true;
            this.btnSuaSP.BorderRadius = 8;
            this.btnSuaSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnSuaSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSuaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuaSP.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.btnSuaSP.Location = new System.Drawing.Point(870, 6);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(110, 36);
            this.btnSuaSP.TabIndex = 1;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaSP.Animated = true;
            this.btnXoaSP.BorderRadius = 8;
            this.btnXoaSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnXoaSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoaSP.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnXoaSP.Location = new System.Drawing.Point(990, 6);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(110, 36);
            this.btnXoaSP.TabIndex = 2;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // pnlGapA
            // 
            this.pnlGapA.BackColor = System.Drawing.Color.Transparent;
            this.pnlGapA.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGapA.Location = new System.Drawing.Point(12, 264);
            this.pnlGapA.Name = "pnlGapA";
            this.pnlGapA.Size = new System.Drawing.Size(1126, 10);
            this.pnlGapA.TabIndex = 1;
            // 
            // pnlGapB
            // 
            this.pnlGapB.BackColor = System.Drawing.Color.Transparent;
            this.pnlGapB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGapB.Location = new System.Drawing.Point(12, 586);
            this.pnlGapB.Name = "pnlGapB";
            this.pnlGapB.Size = new System.Drawing.Size(1126, 10);
            this.pnlGapB.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderRadius = 10;
            this.panel4.Controls.Add(this.lblTongTienNhap);
            this.panel4.Controls.Add(this.txtTongTien);
            this.panel4.Controls.Add(this.btnLuuPhieuNhap);
            this.panel4.Controls.Add(this.btnLamMoi);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(12, 596);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1126, 72);
            this.panel4.TabIndex = 3;
            // 
            // lblTongTienNhap
            // 
            this.lblTongTienNhap.AutoSize = true;
            this.lblTongTienNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTongTienNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTongTienNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblTongTienNhap.Location = new System.Drawing.Point(16, 26);
            this.lblTongTienNhap.Name = "lblTongTienNhap";
            this.lblTongTienNhap.Size = new System.Drawing.Size(144, 28);
            this.lblTongTienNhap.TabIndex = 0;
            this.lblTongTienNhap.Text = "Tổng tiền nhập";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtTongTien.BorderRadius = 6;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.DefaultText = "";
            this.txtTongTien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTongTien.Location = new System.Drawing.Point(140, 18);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PlaceholderText = "";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.Size = new System.Drawing.Size(240, 36);
            this.txtTongTien.TabIndex = 1;
            // 
            // btnLuuPhieuNhap
            // 
            this.btnLuuPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuPhieuNhap.Animated = true;
            this.btnLuuPhieuNhap.BorderRadius = 8;
            this.btnLuuPhieuNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnLuuPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuPhieuNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuuPhieuNhap.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnLuuPhieuNhap.Location = new System.Drawing.Point(836, 16);
            this.btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            this.btnLuuPhieuNhap.Size = new System.Drawing.Size(150, 40);
            this.btnLuuPhieuNhap.TabIndex = 2;
            this.btnLuuPhieuNhap.Text = "Lưu phiếu nhập";
            this.btnLuuPhieuNhap.Click += new System.EventHandler(this.btnLuuPhieuNhap_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Animated = true;
            this.btnLamMoi.BorderRadius = 8;
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLamMoi.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnLamMoi.Location = new System.Drawing.Point(996, 16);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(114, 40);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // pnlRow
            // 
            this.pnlRow.BackColor = System.Drawing.Color.Transparent;
            this.pnlRow.Controls.Add(this.panel2);
            this.pnlRow.Controls.Add(this.pnlGapV);
            this.pnlRow.Controls.Add(this.panel1);
            this.pnlRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRow.Location = new System.Drawing.Point(12, 60);
            this.pnlRow.Name = "pnlRow";
            this.pnlRow.Size = new System.Drawing.Size(1126, 204);
            this.pnlRow.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderRadius = 10;
            this.panel2.Controls.Add(this.lblSanPham);
            this.panel2.Controls.Add(this.cboSanPham);
            this.panel2.Controls.Add(this.lblSoLuong);
            this.panel2.Controls.Add(this.numSoLuong);
            this.panel2.Controls.Add(this.lblGiaNhap);
            this.panel2.Controls.Add(this.txtGiaNhap);
            this.panel2.Controls.Add(this.lblThanhTien);
            this.panel2.Controls.Add(this.txtThanhTien);
            this.panel2.Controls.Add(this.btnThemSP);
            this.panel2.Controls.Add(this.btnLamMoiSP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(492, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 204);
            this.panel2.TabIndex = 0;
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.BackColor = System.Drawing.Color.Transparent;
            this.lblSanPham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblSanPham.Location = new System.Drawing.Point(16, 22);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(99, 28);
            this.lblSanPham.TabIndex = 0;
            this.lblSanPham.Text = "Sản phẩm";
            // 
            // cboSanPham
            // 
            this.cboSanPham.BackColor = System.Drawing.Color.Transparent;
            this.cboSanPham.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.cboSanPham.BorderRadius = 6;
            this.cboSanPham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPham.FocusedColor = System.Drawing.Color.Empty;
            this.cboSanPham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSanPham.ItemHeight = 30;
            this.cboSanPham.Location = new System.Drawing.Point(130, 14);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(370, 36);
            this.cboSanPham.TabIndex = 1;
            this.cboSanPham.SelectedIndexChanged += new System.EventHandler(this.cboSanPham_SelectedIndexChanged);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblSoLuong.Location = new System.Drawing.Point(16, 72);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(92, 28);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numSoLuong.Location = new System.Drawing.Point(130, 66);
            this.numSoLuong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(120, 37);
            this.numSoLuong.TabIndex = 3;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.ValueChanged += new System.EventHandler(this.numSoLuong_ValueChanged);
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGiaNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblGiaNhap.Location = new System.Drawing.Point(270, 72);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(90, 28);
            this.lblGiaNhap.TabIndex = 4;
            this.lblGiaNhap.Text = "Giá nhập";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtGiaNhap.BorderRadius = 6;
            this.txtGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaNhap.DefaultText = "";
            this.txtGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGiaNhap.Location = new System.Drawing.Point(350, 64);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.PlaceholderText = "";
            this.txtGiaNhap.SelectedText = "";
            this.txtGiaNhap.Size = new System.Drawing.Size(150, 34);
            this.txtGiaNhap.TabIndex = 5;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.BackColor = System.Drawing.Color.Transparent;
            this.lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblThanhTien.Location = new System.Drawing.Point(16, 120);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(103, 28);
            this.lblThanhTien.TabIndex = 6;
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
            this.txtThanhTien.Location = new System.Drawing.Point(130, 112);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PlaceholderText = "";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.SelectedText = "";
            this.txtThanhTien.Size = new System.Drawing.Size(370, 34);
            this.txtThanhTien.TabIndex = 7;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemSP.Animated = true;
            this.btnThemSP.BorderRadius = 8;
            this.btnThemSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThemSP.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnThemSP.Location = new System.Drawing.Point(100, 158);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(96, 40);
            this.btnThemSP.TabIndex = 8;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnLamMoiSP
            // 
            this.btnLamMoiSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoiSP.Animated = true;
            this.btnLamMoiSP.BorderRadius = 8;
            this.btnLamMoiSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnLamMoiSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoiSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLamMoiSP.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnLamMoiSP.Location = new System.Drawing.Point(208, 158);
            this.btnLamMoiSP.Name = "btnLamMoiSP";
            this.btnLamMoiSP.Size = new System.Drawing.Size(96, 40);
            this.btnLamMoiSP.TabIndex = 9;
            this.btnLamMoiSP.Text = "Làm mới";
            this.btnLamMoiSP.Click += new System.EventHandler(this.btnLamMoiSP_Click);
            // 
            // pnlGapV
            // 
            this.pnlGapV.BackColor = System.Drawing.Color.Transparent;
            this.pnlGapV.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGapV.Location = new System.Drawing.Point(480, 0);
            this.pnlGapV.Name = "pnlGapV";
            this.pnlGapV.Size = new System.Drawing.Size(12, 204);
            this.pnlGapV.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderRadius = 10;
            this.panel1.Controls.Add(this.lblMaPN);
            this.panel1.Controls.Add(this.txtMaPN);
            this.panel1.Controls.Add(this.lblNgayNhap);
            this.panel1.Controls.Add(this.dtpNgayNhap);
            this.panel1.Controls.Add(this.lblNhanVien);
            this.panel1.Controls.Add(this.txtNhanVien);
            this.panel1.Controls.Add(this.lblNhaCungCap);
            this.panel1.Controls.Add(this.cboNhaCungCap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 204);
            this.panel1.TabIndex = 2;
            // 
            // lblMaPN
            // 
            this.lblMaPN.AutoSize = true;
            this.lblMaPN.BackColor = System.Drawing.Color.Transparent;
            this.lblMaPN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblMaPN.Location = new System.Drawing.Point(16, 22);
            this.lblMaPN.Name = "lblMaPN";
            this.lblMaPN.Size = new System.Drawing.Size(143, 28);
            this.lblMaPN.TabIndex = 0;
            this.lblMaPN.Text = "Mã phiếu nhập";
            // 
            // txtMaPN
            // 
            this.txtMaPN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtMaPN.BorderRadius = 6;
            this.txtMaPN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPN.DefaultText = "";
            this.txtMaPN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtMaPN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaPN.Location = new System.Drawing.Point(150, 14);
            this.txtMaPN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.PlaceholderText = "";
            this.txtMaPN.ReadOnly = true;
            this.txtMaPN.SelectedText = "";
            this.txtMaPN.Size = new System.Drawing.Size(314, 34);
            this.txtMaPN.TabIndex = 1;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblNgayNhap.Location = new System.Drawing.Point(16, 66);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(108, 28);
            this.lblNgayNhap.TabIndex = 2;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgayNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.dtpNgayNhap.BorderRadius = 6;
            this.dtpNgayNhap.Checked = true;
            this.dtpNgayNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpNgayNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(150, 58);
            this.dtpNgayNhap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayNhap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(314, 34);
            this.dtpNgayNhap.TabIndex = 3;
            this.dtpNgayNhap.Value = new System.DateTime(2026, 11, 8, 11, 0, 19, 633);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblNhanVien.Location = new System.Drawing.Point(16, 110);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(100, 28);
            this.lblNhanVien.TabIndex = 4;
            this.lblNhanVien.Text = "Nhân viên";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtNhanVien.BorderRadius = 6;
            this.txtNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhanVien.DefaultText = "";
            this.txtNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNhanVien.Location = new System.Drawing.Point(150, 102);
            this.txtNhanVien.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.PlaceholderText = "";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.SelectedText = "";
            this.txtNhanVien.Size = new System.Drawing.Size(314, 34);
            this.txtNhanVien.TabIndex = 5;
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.lblNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblNhaCungCap.Location = new System.Drawing.Point(16, 154);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(132, 28);
            this.lblNhaCungCap.TabIndex = 6;
            this.lblNhaCungCap.Text = "Nhà cung cấp";
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.cboNhaCungCap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.cboNhaCungCap.BorderRadius = 6;
            this.cboNhaCungCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaCungCap.FocusedColor = System.Drawing.Color.Empty;
            this.cboNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNhaCungCap.ItemHeight = 30;
            this.cboNhaCungCap.Location = new System.Drawing.Point(150, 146);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(314, 36);
            this.cboNhaCungCap.TabIndex = 7;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.lblTieuDe);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(12, 12);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1126, 48);
            this.pnlTop.TabIndex = 5;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 8);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(339, 41);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ NHẬP HÀNG";
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlGapA);
            this.Controls.Add(this.pnlGapB);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlRow);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmImport";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý nhập hàng";
            this.Load += new System.EventHandler(this.frmImport_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            this.pnlChiTietHeader.ResumeLayout(false);
            this.pnlChiTietHeader.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlRow.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChiTietPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private Guna.UI2.WinForms.Guna2Panel pnlChiTietHeader;
        private System.Windows.Forms.Label lblChiTietPN;
        private Guna.UI2.WinForms.Guna2Button btnSuaSP;
        private Guna.UI2.WinForms.Guna2Button btnXoaSP;
        private Guna.UI2.WinForms.Guna2Panel pnlGapA;
        private Guna.UI2.WinForms.Guna2Panel pnlGapB;
        private Guna.UI2.WinForms.Guna2Panel panel4;
        private System.Windows.Forms.Label lblTongTienNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTien;
        private Guna.UI2.WinForms.Guna2Button btnLuuPhieuNhap;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Panel pnlRow;
        private Guna.UI2.WinForms.Guna2Panel panel2;
        private System.Windows.Forms.Label lblSanPham;
        private Guna.UI2.WinForms.Guna2ComboBox cboSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblGiaNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaNhap;
        private System.Windows.Forms.Label lblThanhTien;
        private Guna.UI2.WinForms.Guna2TextBox txtThanhTien;
        private Guna.UI2.WinForms.Guna2Button btnThemSP;
        private Guna.UI2.WinForms.Guna2Button btnLamMoiSP;
        private Guna.UI2.WinForms.Guna2Panel pnlGapV;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private System.Windows.Forms.Label lblMaPN;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPN;
        private System.Windows.Forms.Label lblNgayNhap;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label lblNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtNhanVien;
        private System.Windows.Forms.Label lblNhaCungCap;
        private Guna.UI2.WinForms.Guna2ComboBox cboNhaCungCap;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblTieuDe;
    }
}
