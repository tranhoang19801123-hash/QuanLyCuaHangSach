namespace WindowsFormsApp2.Forms
{
    partial class frmProduct
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
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSpacer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlForm = new Guna.UI2.WinForms.Guna2Panel();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtMaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtTenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.txtTacGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.cboTheLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNCC = new System.Windows.Forms.Label();
            this.cboNCC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.nudGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.nudGiaBan = new System.Windows.Forms.NumericUpDown();
            this.lblTonKho = new System.Windows.Forms.Label();
            this.nudTonKho = new System.Windows.Forms.NumericUpDown();
            this.pnlBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnFileMau = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTonKho)).BeginInit();
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
            this.colMaSP,
            this.colTenSP,
            this.colTacGia,
            this.colTheLoai,
            this.colNCC,
            this.colGiaNhap,
            this.colGiaBan,
            this.colTon});
            // 
            // colMaSP
            // 
            this.colMaSP.DataPropertyName = "MaSP";
            this.colMaSP.FillWeight = 70F;
            this.colMaSP.HeaderText = "Mã sách";
            this.colMaSP.MinimumWidth = 6;
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;
            // 
            // colTenSP
            // 
            this.colTenSP.DataPropertyName = "TenSP";
            this.colTenSP.FillWeight = 200F;
            this.colTenSP.HeaderText = "Tên sách";
            this.colTenSP.MinimumWidth = 6;
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            // 
            // colTacGia
            // 
            this.colTacGia.DataPropertyName = "TacGia";
            this.colTacGia.FillWeight = 120F;
            this.colTacGia.HeaderText = "Tác giả";
            this.colTacGia.MinimumWidth = 6;
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.ReadOnly = true;
            // 
            // colTheLoai
            // 
            this.colTheLoai.DataPropertyName = "TheLoai";
            this.colTheLoai.FillWeight = 100F;
            this.colTheLoai.HeaderText = "Thể loại";
            this.colTheLoai.MinimumWidth = 6;
            this.colTheLoai.Name = "colTheLoai";
            this.colTheLoai.ReadOnly = true;
            // 
            // colNCC
            // 
            this.colNCC.DataPropertyName = "NhaCungCap";
            this.colNCC.FillWeight = 120F;
            this.colNCC.HeaderText = "Nhà cung cấp";
            this.colNCC.MinimumWidth = 6;
            this.colNCC.Name = "colNCC";
            this.colNCC.ReadOnly = true;
            // 
            // colGiaNhap
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colGiaNhap.DefaultCellStyle = dataGridViewCellStyle4;
            this.colGiaNhap.DataPropertyName = "GiaNhap";
            this.colGiaNhap.FillWeight = 80F;
            this.colGiaNhap.HeaderText = "Giá nhập";
            this.colGiaNhap.MinimumWidth = 6;
            this.colGiaNhap.Name = "colGiaNhap";
            this.colGiaNhap.ReadOnly = true;
            // 
            // colGiaBan
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colGiaBan.DefaultCellStyle = dataGridViewCellStyle5;
            this.colGiaBan.DataPropertyName = "GiaBan";
            this.colGiaBan.FillWeight = 80F;
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.MinimumWidth = 6;
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.ReadOnly = true;
            // 
            // colTon
            // 
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTon.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTon.DataPropertyName = "SoLuongTon";
            this.colTon.FillWeight = 55F;
            this.colTon.HeaderText = "Tồn";
            this.colTon.MinimumWidth = 6;
            this.colTon.Name = "colTon";
            this.colTon.ReadOnly = true;
            this.dgv.Name = "dgv";
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // pnlSpacer
            // 
            this.pnlSpacer.BackColor = System.Drawing.Color.Transparent;
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSpacer.Size = new System.Drawing.Size(12, 676);
            this.pnlSpacer.Name = "pnlSpacer";
            // 
            // pnlForm
            // 
            this.pnlForm.AutoScroll = true;
            this.pnlForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlForm.BorderRadius = 10;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlForm.FillColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlForm.Size = new System.Drawing.Size(380, 676);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Controls.Add(this.lblThongTin);
            this.pnlForm.Controls.Add(this.lblMaSP);
            this.pnlForm.Controls.Add(this.txtMaSP);
            this.pnlForm.Controls.Add(this.lblTenSP);
            this.pnlForm.Controls.Add(this.txtTenSP);
            this.pnlForm.Controls.Add(this.lblTacGia);
            this.pnlForm.Controls.Add(this.txtTacGia);
            this.pnlForm.Controls.Add(this.lblTheLoai);
            this.pnlForm.Controls.Add(this.cboTheLoai);
            this.pnlForm.Controls.Add(this.lblNCC);
            this.pnlForm.Controls.Add(this.cboNCC);
            this.pnlForm.Controls.Add(this.lblGiaNhap);
            this.pnlForm.Controls.Add(this.nudGiaNhap);
            this.pnlForm.Controls.Add(this.lblGiaBan);
            this.pnlForm.Controls.Add(this.nudGiaBan);
            this.pnlForm.Controls.Add(this.lblTonKho);
            this.pnlForm.Controls.Add(this.nudTonKho);
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
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.BackColor = System.Drawing.Color.Transparent;
            this.lblMaSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaSP.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblMaSP.Location = new System.Drawing.Point(16, 50);
            this.lblMaSP.Text = "Mã sách *";
            this.lblMaSP.Name = "lblMaSP";
            // 
            // txtMaSP
            // 
            this.txtMaSP.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtMaSP.BorderRadius = 6;
            this.txtMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSP.DefaultText = "";
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaSP.Location = new System.Drawing.Point(16, 72);
            this.txtMaSP.Size = new System.Drawing.Size(348, 34);
            this.txtMaSP.MaxLength = 20;
            this.txtMaSP.Name = "txtMaSP";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.BackColor = System.Drawing.Color.Transparent;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenSP.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblTenSP.Location = new System.Drawing.Point(16, 116);
            this.lblTenSP.Text = "Tên sách *";
            this.lblTenSP.Name = "lblTenSP";
            // 
            // txtTenSP
            // 
            this.txtTenSP.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtTenSP.BorderRadius = 6;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.DefaultText = "";
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenSP.Location = new System.Drawing.Point(16, 138);
            this.txtTenSP.Size = new System.Drawing.Size(348, 34);
            this.txtTenSP.MaxLength = 150;
            this.txtTenSP.Name = "txtTenSP";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.BackColor = System.Drawing.Color.Transparent;
            this.lblTacGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTacGia.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblTacGia.Location = new System.Drawing.Point(16, 182);
            this.lblTacGia.Text = "Tác giả";
            this.lblTacGia.Name = "lblTacGia";
            // 
            // txtTacGia
            // 
            this.txtTacGia.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtTacGia.BorderRadius = 6;
            this.txtTacGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTacGia.DefaultText = "";
            this.txtTacGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTacGia.Location = new System.Drawing.Point(16, 204);
            this.txtTacGia.Size = new System.Drawing.Size(348, 34);
            this.txtTacGia.MaxLength = 100;
            this.txtTacGia.Name = "txtTacGia";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.lblTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTheLoai.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblTheLoai.Location = new System.Drawing.Point(16, 248);
            this.lblTheLoai.Text = "Thể loại *";
            this.lblTheLoai.Name = "lblTheLoai";
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.cboTheLoai.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.cboTheLoai.BorderRadius = 6;
            this.cboTheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTheLoai.ItemHeight = 30;
            this.cboTheLoai.Location = new System.Drawing.Point(16, 270);
            this.cboTheLoai.Size = new System.Drawing.Size(348, 36);
            this.cboTheLoai.Name = "cboTheLoai";
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.BackColor = System.Drawing.Color.Transparent;
            this.lblNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNCC.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblNCC.Location = new System.Drawing.Point(16, 314);
            this.lblNCC.Text = "Nhà cung cấp";
            this.lblNCC.Name = "lblNCC";
            // 
            // cboNCC
            // 
            this.cboNCC.BackColor = System.Drawing.Color.Transparent;
            this.cboNCC.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.cboNCC.BorderRadius = 6;
            this.cboNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNCC.ItemHeight = 30;
            this.cboNCC.Location = new System.Drawing.Point(16, 336);
            this.cboNCC.Size = new System.Drawing.Size(348, 36);
            this.cboNCC.Name = "cboNCC";
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGiaNhap.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblGiaNhap.Location = new System.Drawing.Point(16, 380);
            this.lblGiaNhap.Text = "Giá nhập (đ)";
            this.lblGiaNhap.Name = "lblGiaNhap";
            // 
            // nudGiaNhap
            // 
            this.nudGiaNhap.DecimalPlaces = 0;
            this.nudGiaNhap.Increment = new decimal(new int[] {1000, 0, 0, 0});
            this.nudGiaNhap.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nudGiaNhap.Location = new System.Drawing.Point(16, 402);
            this.nudGiaNhap.Maximum = new decimal(new int[] {999999999, 0, 0, 0});
            this.nudGiaNhap.Size = new System.Drawing.Size(168, 32);
            this.nudGiaNhap.ThousandsSeparator = true;
            this.nudGiaNhap.Name = "nudGiaNhap";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGiaBan.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblGiaBan.Location = new System.Drawing.Point(196, 380);
            this.lblGiaBan.Text = "Giá bán (đ)";
            this.lblGiaBan.Name = "lblGiaBan";
            // 
            // nudGiaBan
            // 
            this.nudGiaBan.DecimalPlaces = 0;
            this.nudGiaBan.Increment = new decimal(new int[] {1000, 0, 0, 0});
            this.nudGiaBan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nudGiaBan.Location = new System.Drawing.Point(196, 402);
            this.nudGiaBan.Maximum = new decimal(new int[] {999999999, 0, 0, 0});
            this.nudGiaBan.Size = new System.Drawing.Size(168, 32);
            this.nudGiaBan.ThousandsSeparator = true;
            this.nudGiaBan.Name = "nudGiaBan";
            // 
            // lblTonKho
            // 
            this.lblTonKho.AutoSize = true;
            this.lblTonKho.BackColor = System.Drawing.Color.Transparent;
            this.lblTonKho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTonKho.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblTonKho.Location = new System.Drawing.Point(16, 446);
            this.lblTonKho.Text = "Tồn kho";
            this.lblTonKho.Name = "lblTonKho";
            // 
            // nudTonKho
            // 
            this.nudTonKho.DecimalPlaces = 0;
            this.nudTonKho.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nudTonKho.Location = new System.Drawing.Point(16, 468);
            this.nudTonKho.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            this.nudTonKho.Size = new System.Drawing.Size(348, 32);
            this.nudTonKho.ThousandsSeparator = true;
            this.nudTonKho.Name = "nudTonKho";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Size = new System.Drawing.Size(1176, 64);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Controls.Add(this.btnThem);
            this.pnlBottom.Controls.Add(this.btnSua);
            this.pnlBottom.Controls.Add(this.btnXoa);
            this.pnlBottom.Controls.Add(this.btnLamMoi);
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
            // btnNhapExcel
            // 
            this.btnNhapExcel.Animated = true;
            this.btnNhapExcel.BorderRadius = 8;
            this.btnNhapExcel.FillColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnNhapExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNhapExcel.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnNhapExcel.Text = "Nhập Excel";
            this.btnNhapExcel.Location = new System.Drawing.Point(480, 12);
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
            this.btnFileMau.Location = new System.Drawing.Point(620, 12);
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
            this.btnXuatExcel.Location = new System.Drawing.Point(1026, 12);
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
            this.pnlTop.Size = new System.Drawing.Size(1176, 64);
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
            this.lblTieuDe.Text = "QUẢN LÝ SÁCH";
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
            this.txtTimKiem.Location = new System.Drawing.Point(856, 14);
            this.txtTimKiem.Size = new System.Drawing.Size(320, 36);
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý sách";
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlSpacer);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaNhap)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTon;
        private Guna.UI2.WinForms.Guna2Panel pnlSpacer;
        private Guna.UI2.WinForms.Guna2Panel pnlForm;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblMaSP;
        private Guna.UI2.WinForms.Guna2TextBox txtMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSP;
        private System.Windows.Forms.Label lblTacGia;
        private Guna.UI2.WinForms.Guna2TextBox txtTacGia;
        private System.Windows.Forms.Label lblTheLoai;
        private Guna.UI2.WinForms.Guna2ComboBox cboTheLoai;
        private System.Windows.Forms.Label lblNCC;
        private Guna.UI2.WinForms.Guna2ComboBox cboNCC;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.NumericUpDown nudGiaNhap;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.NumericUpDown nudGiaBan;
        private System.Windows.Forms.Label lblTonKho;
        private System.Windows.Forms.NumericUpDown nudTonKho;
        private Guna.UI2.WinForms.Guna2Panel pnlBottom;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnNhapExcel;
        private Guna.UI2.WinForms.Guna2Button btnFileMau;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcel;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTongSo;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
    }
}
