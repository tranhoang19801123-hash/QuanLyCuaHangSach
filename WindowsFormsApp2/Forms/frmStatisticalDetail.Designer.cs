namespace WindowsFormsApp2.Forms
{
    partial class frmStatisticalDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatisticalDetail));
            this.dgvThongKeChiTiet = new Guna.UI2.WinForms.Guna2DataGridView();
            this.spacerB = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.spacerT2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLoc = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDenNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLocNhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLocKhachHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLocTheLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.spacerT1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblPhuDe = new System.Windows.Forms.Label();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeChiTiet)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlLoc.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongKeChiTiet
            // 
            this.dgvThongKeChiTiet.AllowUserToAddRows = false;
            this.dgvThongKeChiTiet.AllowUserToDeleteRows = false;
            this.dgvThongKeChiTiet.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvThongKeChiTiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongKeChiTiet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongKeChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongKeChiTiet.ColumnHeadersHeight = 38;
            this.dgvThongKeChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.NgayLap,
            this.KhachHang,
            this.NhanVien,
            this.ThanhTien});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongKeChiTiet.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvThongKeChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKeChiTiet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvThongKeChiTiet.Location = new System.Drawing.Point(12, 248);
            this.dgvThongKeChiTiet.MultiSelect = false;
            this.dgvThongKeChiTiet.Name = "dgvThongKeChiTiet";
            this.dgvThongKeChiTiet.ReadOnly = true;
            this.dgvThongKeChiTiet.RowHeadersVisible = false;
            this.dgvThongKeChiTiet.RowHeadersWidth = 51;
            this.dgvThongKeChiTiet.RowTemplate.Height = 32;
            this.dgvThongKeChiTiet.Size = new System.Drawing.Size(1076, 334);
            this.dgvThongKeChiTiet.TabIndex = 0;
            this.dgvThongKeChiTiet.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvThongKeChiTiet.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvThongKeChiTiet.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvThongKeChiTiet.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.dgvThongKeChiTiet.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvThongKeChiTiet.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvThongKeChiTiet.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvThongKeChiTiet.ThemeStyle.HeaderStyle.Height = 38;
            this.dgvThongKeChiTiet.ThemeStyle.ReadOnly = true;
            this.dgvThongKeChiTiet.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvThongKeChiTiet.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvThongKeChiTiet.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dgvThongKeChiTiet.ThemeStyle.RowsStyle.Height = 32;
            this.dgvThongKeChiTiet.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.dgvThongKeChiTiet.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            // 
            // spacerB
            // 
            this.spacerB.BackColor = System.Drawing.Color.Transparent;
            this.spacerB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spacerB.Location = new System.Drawing.Point(12, 582);
            this.spacerB.Name = "spacerB";
            this.spacerB.Size = new System.Drawing.Size(1076, 12);
            this.spacerB.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.BorderRadius = 10;
            this.pnlFooter.Controls.Add(this.lblTongTien);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlFooter.Location = new System.Drawing.Point(12, 594);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1076, 54);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BackColor = System.Drawing.Color.Transparent;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblTongTien.Location = new System.Drawing.Point(16, 17);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(184, 30);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng doanh thu:";
            // 
            // spacerT2
            // 
            this.spacerT2.BackColor = System.Drawing.Color.Transparent;
            this.spacerT2.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacerT2.Location = new System.Drawing.Point(12, 236);
            this.spacerT2.Name = "spacerT2";
            this.spacerT2.Size = new System.Drawing.Size(1076, 12);
            this.spacerT2.TabIndex = 3;
            // 
            // pnlLoc
            // 
            this.pnlLoc.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoc.BorderRadius = 10;
            this.pnlLoc.Controls.Add(this.label1);
            this.pnlLoc.Controls.Add(this.dtpTuNgay);
            this.pnlLoc.Controls.Add(this.label2);
            this.pnlLoc.Controls.Add(this.dtpDenNgay);
            this.pnlLoc.Controls.Add(this.btnThongKe);
            this.pnlLoc.Controls.Add(this.label3);
            this.pnlLoc.Controls.Add(this.cboLocNhanVien);
            this.pnlLoc.Controls.Add(this.label4);
            this.pnlLoc.Controls.Add(this.cboLocKhachHang);
            this.pnlLoc.Controls.Add(this.label5);
            this.pnlLoc.Controls.Add(this.cboLocTheLoai);
            this.pnlLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlLoc.Location = new System.Drawing.Point(12, 80);
            this.pnlLoc.Name = "pnlLoc";
            this.pnlLoc.Size = new System.Drawing.Size(1076, 156);
            this.pnlLoc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.dtpTuNgay.BorderRadius = 6;
            this.dtpTuNgay.Checked = true;
            this.dtpTuNgay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTuNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTuNgay.Location = new System.Drawing.Point(20, 36);
            this.dtpTuNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTuNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(250, 36);
            this.dtpTuNgay.TabIndex = 1;
            this.dtpTuNgay.Value = new System.DateTime(2026, 11, 7, 20, 19, 14, 556);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(290, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.dtpDenNgay.BorderRadius = 6;
            this.dtpDenNgay.Checked = true;
            this.dtpDenNgay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDenNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDenNgay.Location = new System.Drawing.Point(290, 36);
            this.dtpDenNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDenNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(250, 36);
            this.dtpDenNgay.TabIndex = 3;
            this.dtpDenNgay.Value = new System.DateTime(2026, 11, 7, 20, 19, 14, 652);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Animated = true;
            this.btnThongKe.BorderRadius = 8;
            this.btnThongKe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThongKe.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnThongKe.Location = new System.Drawing.Point(560, 36);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(150, 36);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhân viên:";
            // 
            // cboLocNhanVien
            // 
            this.cboLocNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cboLocNhanVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.cboLocNhanVien.BorderRadius = 6;
            this.cboLocNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLocNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocNhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.cboLocNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLocNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLocNhanVien.ItemHeight = 30;
            this.cboLocNhanVien.Location = new System.Drawing.Point(20, 106);
            this.cboLocNhanVien.Name = "cboLocNhanVien";
            this.cboLocNhanVien.Size = new System.Drawing.Size(250, 36);
            this.cboLocNhanVien.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label4.Location = new System.Drawing.Point(290, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Khách hàng:";
            // 
            // cboLocKhachHang
            // 
            this.cboLocKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.cboLocKhachHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.cboLocKhachHang.BorderRadius = 6;
            this.cboLocKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLocKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocKhachHang.FocusedColor = System.Drawing.Color.Empty;
            this.cboLocKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLocKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLocKhachHang.ItemHeight = 30;
            this.cboLocKhachHang.Location = new System.Drawing.Point(290, 106);
            this.cboLocKhachHang.Name = "cboLocKhachHang";
            this.cboLocKhachHang.Size = new System.Drawing.Size(250, 36);
            this.cboLocKhachHang.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label5.Location = new System.Drawing.Point(560, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thể loại:";
            // 
            // cboLocTheLoai
            // 
            this.cboLocTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.cboLocTheLoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.cboLocTheLoai.BorderRadius = 6;
            this.cboLocTheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLocTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTheLoai.FocusedColor = System.Drawing.Color.Empty;
            this.cboLocTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLocTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLocTheLoai.ItemHeight = 30;
            this.cboLocTheLoai.Location = new System.Drawing.Point(560, 106);
            this.cboLocTheLoai.Name = "cboLocTheLoai";
            this.cboLocTheLoai.Size = new System.Drawing.Size(250, 36);
            this.cboLocTheLoai.TabIndex = 10;
            // 
            // spacerT1
            // 
            this.spacerT1.BackColor = System.Drawing.Color.Transparent;
            this.spacerT1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacerT1.Location = new System.Drawing.Point(12, 76);
            this.spacerT1.Name = "spacerT1";
            this.spacerT1.Size = new System.Drawing.Size(1076, 4);
            this.spacerT1.TabIndex = 5;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.lblTieuDe);
            this.pnlTop.Controls.Add(this.lblPhuDe);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(12, 12);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1076, 64);
            this.pnlTop.TabIndex = 6;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 6);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(492, 41);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THỐNG KÊ CHI TIẾT DOANH THU";
            // 
            // lblPhuDe
            // 
            this.lblPhuDe.AutoSize = true;
            this.lblPhuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblPhuDe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPhuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblPhuDe.Location = new System.Drawing.Point(2, 40);
            this.lblPhuDe.Name = "lblPhuDe";
            this.lblPhuDe.Size = new System.Drawing.Size(530, 25);
            this.lblPhuDe.TabIndex = 1;
            this.lblPhuDe.Text = "Lọc hóa đơn theo thời gian, nhân viên, khách hàng và thể loại";
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "TenSach";
            dataGridViewCellStyle3.Format = "NO";
            this.MaHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy HH:mm";
            this.NgayLap.DefaultCellStyle = dataGridViewCellStyle4;
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.MinimumWidth = 8;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // KhachHang
            // 
            this.KhachHang.DataPropertyName = "KhachHang";
            this.KhachHang.HeaderText = "Khách Hàng";
            this.KhachHang.MinimumWidth = 8;
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.ReadOnly = true;
            // 
            // NhanVien
            // 
            this.NhanVien.DataPropertyName = "NhanVien";
            this.NhanVien.HeaderText = "Nhân Viên";
            this.NhanVien.MinimumWidth = 8;
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền (VNĐ)";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // frmStatisticalDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.dgvThongKeChiTiet);
            this.Controls.Add(this.spacerB);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.spacerT2);
            this.Controls.Add(this.pnlLoc);
            this.Controls.Add(this.spacerT1);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStatisticalDetail";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo chi tiết doanh thu";
            this.Load += new System.EventHandler(this.frmStatisticalDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeChiTiet)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlLoc.ResumeLayout(false);
            this.pnlLoc.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvThongKeChiTiet;
        private Guna.UI2.WinForms.Guna2Panel spacerB;
        private Guna.UI2.WinForms.Guna2Panel pnlFooter;
        private System.Windows.Forms.Label lblTongTien;
        private Guna.UI2.WinForms.Guna2Panel spacerT2;
        private Guna.UI2.WinForms.Guna2Panel pnlLoc;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDenNgay;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cboLocNhanVien;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cboLocKhachHang;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cboLocTheLoai;
        private Guna.UI2.WinForms.Guna2Panel spacerT1;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}
