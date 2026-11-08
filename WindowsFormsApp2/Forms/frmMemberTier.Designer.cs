namespace WindowsFormsApp2.Forms
{
    partial class frmMemberTier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSpacer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlForm = new Guna.UI2.WinForms.Guna2Panel();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.txtMaHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.txtTenHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGiam = new System.Windows.Forms.Label();
            this.nudGiam = new System.Windows.Forms.NumericUpDown();
            this.lblDiemToiThieu = new System.Windows.Forms.Label();
            this.nudDiemToiThieu = new System.Windows.Forms.NumericUpDown();
            this.pnlBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnDong = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemToiThieu)).BeginInit();
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
            this.colMaHang,
            this.colTenHang,
            this.colGiam,
            this.colDiem,
            this.colSoKhach});
            // 
            // colMaHang
            // 
            this.colMaHang.DataPropertyName = "MaHang";
            this.colMaHang.FillWeight = 70F;
            this.colMaHang.HeaderText = "Mã hạng";
            this.colMaHang.MinimumWidth = 6;
            this.colMaHang.Name = "colMaHang";
            this.colMaHang.ReadOnly = true;
            // 
            // colTenHang
            // 
            this.colTenHang.DataPropertyName = "TenHang";
            this.colTenHang.FillWeight = 140F;
            this.colTenHang.HeaderText = "Tên hạng";
            this.colTenHang.MinimumWidth = 6;
            this.colTenHang.Name = "colTenHang";
            this.colTenHang.ReadOnly = true;
            // 
            // colGiam
            // 
            dataGridViewCellStyle4.Format = "0.##";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colGiam.DefaultCellStyle = dataGridViewCellStyle4;
            this.colGiam.DataPropertyName = "PhanTramGiam";
            this.colGiam.FillWeight = 80F;
            this.colGiam.HeaderText = "Giảm giá (%)";
            this.colGiam.MinimumWidth = 6;
            this.colGiam.Name = "colGiam";
            this.colGiam.ReadOnly = true;
            // 
            // colDiem
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDiem.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDiem.DataPropertyName = "DiemToiThieu";
            this.colDiem.FillWeight = 90F;
            this.colDiem.HeaderText = "Điểm tối thiểu";
            this.colDiem.MinimumWidth = 6;
            this.colDiem.Name = "colDiem";
            this.colDiem.ReadOnly = true;
            // 
            // colSoKhach
            // 
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSoKhach.DefaultCellStyle = dataGridViewCellStyle6;
            this.colSoKhach.DataPropertyName = "SoKhach";
            this.colSoKhach.FillWeight = 60F;
            this.colSoKhach.HeaderText = "Số khách";
            this.colSoKhach.MinimumWidth = 6;
            this.colSoKhach.Name = "colSoKhach";
            this.colSoKhach.ReadOnly = true;
            this.dgv.Name = "dgv";
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // pnlSpacer
            // 
            this.pnlSpacer.BackColor = System.Drawing.Color.Transparent;
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpacer.Size = new System.Drawing.Size(12, 536);
            this.pnlSpacer.Name = "pnlSpacer";
            // 
            // pnlForm
            // 
            this.pnlForm.AutoScroll = true;
            this.pnlForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlForm.BorderRadius = 10;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlForm.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlForm.Size = new System.Drawing.Size(340, 536);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Controls.Add(this.lblThongTin);
            this.pnlForm.Controls.Add(this.lblMaHang);
            this.pnlForm.Controls.Add(this.txtMaHang);
            this.pnlForm.Controls.Add(this.lblTenHang);
            this.pnlForm.Controls.Add(this.txtTenHang);
            this.pnlForm.Controls.Add(this.lblGiam);
            this.pnlForm.Controls.Add(this.nudGiam);
            this.pnlForm.Controls.Add(this.lblDiemToiThieu);
            this.pnlForm.Controls.Add(this.nudDiemToiThieu);
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
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.BackColor = System.Drawing.Color.Transparent;
            this.lblMaHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaHang.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblMaHang.Location = new System.Drawing.Point(16, 50);
            this.lblMaHang.Text = "Mã hạng *";
            this.lblMaHang.Name = "lblMaHang";
            // 
            // txtMaHang
            // 
            this.txtMaHang.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtMaHang.BorderRadius = 6;
            this.txtMaHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHang.DefaultText = "";
            this.txtMaHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaHang.Location = new System.Drawing.Point(16, 72);
            this.txtMaHang.Size = new System.Drawing.Size(308, 34);
            this.txtMaHang.MaxLength = 20;
            this.txtMaHang.Name = "txtMaHang";
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.BackColor = System.Drawing.Color.Transparent;
            this.lblTenHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenHang.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblTenHang.Location = new System.Drawing.Point(16, 116);
            this.lblTenHang.Text = "Tên hạng *";
            this.lblTenHang.Name = "lblTenHang";
            // 
            // txtTenHang
            // 
            this.txtTenHang.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtTenHang.BorderRadius = 6;
            this.txtTenHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHang.DefaultText = "";
            this.txtTenHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenHang.Location = new System.Drawing.Point(16, 138);
            this.txtTenHang.Size = new System.Drawing.Size(308, 34);
            this.txtTenHang.MaxLength = 50;
            this.txtTenHang.Name = "txtTenHang";
            // 
            // lblGiam
            // 
            this.lblGiam.AutoSize = true;
            this.lblGiam.BackColor = System.Drawing.Color.Transparent;
            this.lblGiam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGiam.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblGiam.Location = new System.Drawing.Point(16, 182);
            this.lblGiam.Text = "Giảm giá (%)";
            this.lblGiam.Name = "lblGiam";
            // 
            // nudGiam
            // 
            this.nudGiam.DecimalPlaces = 1;
            this.nudGiam.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nudGiam.Location = new System.Drawing.Point(16, 204);
            this.nudGiam.Maximum = new decimal(new int[] {100, 0, 0, 0});
            this.nudGiam.Size = new System.Drawing.Size(148, 32);
            this.nudGiam.ThousandsSeparator = true;
            this.nudGiam.Name = "nudGiam";
            // 
            // lblDiemToiThieu
            // 
            this.lblDiemToiThieu.AutoSize = true;
            this.lblDiemToiThieu.BackColor = System.Drawing.Color.Transparent;
            this.lblDiemToiThieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiemToiThieu.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblDiemToiThieu.Location = new System.Drawing.Point(176, 182);
            this.lblDiemToiThieu.Text = "Điểm tối thiểu";
            this.lblDiemToiThieu.Name = "lblDiemToiThieu";
            // 
            // nudDiemToiThieu
            // 
            this.nudDiemToiThieu.DecimalPlaces = 0;
            this.nudDiemToiThieu.Increment = new decimal(new int[] {10, 0, 0, 0});
            this.nudDiemToiThieu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nudDiemToiThieu.Location = new System.Drawing.Point(176, 204);
            this.nudDiemToiThieu.Maximum = new decimal(new int[] {100000000, 0, 0, 0});
            this.nudDiemToiThieu.Size = new System.Drawing.Size(148, 32);
            this.nudDiemToiThieu.ThousandsSeparator = true;
            this.nudDiemToiThieu.Name = "nudDiemToiThieu";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Size = new System.Drawing.Size(956, 64);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Controls.Add(this.btnThem);
            this.pnlBottom.Controls.Add(this.btnSua);
            this.pnlBottom.Controls.Add(this.btnXoa);
            this.pnlBottom.Controls.Add(this.btnLamMoi);
            this.pnlBottom.Controls.Add(this.btnDong);
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
            // btnDong
            // 
            this.btnDong.Animated = true;
            this.btnDong.BorderRadius = 8;
            this.btnDong.FillColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnDong.Text = "Đóng";
            this.btnDong.Location = new System.Drawing.Point(836, 12);
            this.btnDong.Size = new System.Drawing.Size(120, 40);
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnDong.HoverState.FillColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnDong.Name = "btnDong";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(956, 64);
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
            this.lblTieuDe.Text = "HẠNG THÀNH VIÊN";
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
            this.txtTimKiem.Location = new System.Drawing.Point(636, 14);
            this.txtTimKiem.Size = new System.Drawing.Size(320, 36);
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // frmMemberTier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ClientSize = new System.Drawing.Size(980, 560);
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hạng thành viên";
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlSpacer);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmMemberTier";
            this.Load += new System.EventHandler(this.frmMemberTier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemToiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiam)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoKhach;
        private Guna.UI2.WinForms.Guna2Panel pnlSpacer;
        private Guna.UI2.WinForms.Guna2Panel pnlForm;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblMaHang;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHang;
        private System.Windows.Forms.Label lblTenHang;
        private Guna.UI2.WinForms.Guna2TextBox txtTenHang;
        private System.Windows.Forms.Label lblGiam;
        private System.Windows.Forms.NumericUpDown nudGiam;
        private System.Windows.Forms.Label lblDiemToiThieu;
        private System.Windows.Forms.NumericUpDown nudDiemToiThieu;
        private Guna.UI2.WinForms.Guna2Panel pnlBottom;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnDong;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTongSo;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
    }
}
