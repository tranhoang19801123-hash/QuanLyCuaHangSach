namespace WindowsFormsApp2.Forms
{
    partial class frmCategory
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
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMaTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSpacer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlForm = new Guna.UI2.WinForms.Guna2Panel();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblMaTL = new System.Windows.Forms.Label();
            this.txtMaTL = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenTL = new System.Windows.Forms.Label();
            this.txtTenTL = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.colMaTL,
            this.colTenTL,
            this.colMoTa,
            this.colSoSach});
            // 
            // colMaTL
            // 
            this.colMaTL.DataPropertyName = "MaTL";
            this.colMaTL.FillWeight = 80F;
            this.colMaTL.HeaderText = "Mã thể loại";
            this.colMaTL.MinimumWidth = 6;
            this.colMaTL.Name = "colMaTL";
            this.colMaTL.ReadOnly = true;
            // 
            // colTenTL
            // 
            this.colTenTL.DataPropertyName = "TenTL";
            this.colTenTL.FillWeight = 160F;
            this.colTenTL.HeaderText = "Tên thể loại";
            this.colTenTL.MinimumWidth = 6;
            this.colTenTL.Name = "colTenTL";
            this.colTenTL.ReadOnly = true;
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "MoTa";
            this.colMoTa.FillWeight = 220F;
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.MinimumWidth = 6;
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.ReadOnly = true;
            // 
            // colSoSach
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSoSach.DefaultCellStyle = dataGridViewCellStyle4;
            this.colSoSach.DataPropertyName = "SoSach";
            this.colSoSach.FillWeight = 60F;
            this.colSoSach.HeaderText = "Số sách";
            this.colSoSach.MinimumWidth = 6;
            this.colSoSach.Name = "colSoSach";
            this.colSoSach.ReadOnly = true;
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
            this.pnlForm.Controls.Add(this.lblMaTL);
            this.pnlForm.Controls.Add(this.txtMaTL);
            this.pnlForm.Controls.Add(this.lblTenTL);
            this.pnlForm.Controls.Add(this.txtTenTL);
            this.pnlForm.Controls.Add(this.lblMoTa);
            this.pnlForm.Controls.Add(this.txtMoTa);
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
            // lblMaTL
            // 
            this.lblMaTL.AutoSize = true;
            this.lblMaTL.BackColor = System.Drawing.Color.Transparent;
            this.lblMaTL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaTL.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblMaTL.Location = new System.Drawing.Point(16, 50);
            this.lblMaTL.Text = "Mã thể loại *";
            this.lblMaTL.Name = "lblMaTL";
            // 
            // txtMaTL
            // 
            this.txtMaTL.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtMaTL.BorderRadius = 6;
            this.txtMaTL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTL.DefaultText = "";
            this.txtMaTL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaTL.Location = new System.Drawing.Point(16, 72);
            this.txtMaTL.Size = new System.Drawing.Size(328, 34);
            this.txtMaTL.MaxLength = 20;
            this.txtMaTL.Name = "txtMaTL";
            // 
            // lblTenTL
            // 
            this.lblTenTL.AutoSize = true;
            this.lblTenTL.BackColor = System.Drawing.Color.Transparent;
            this.lblTenTL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenTL.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblTenTL.Location = new System.Drawing.Point(16, 116);
            this.lblTenTL.Text = "Tên thể loại *";
            this.lblTenTL.Name = "lblTenTL";
            // 
            // txtTenTL
            // 
            this.txtTenTL.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtTenTL.BorderRadius = 6;
            this.txtTenTL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTL.DefaultText = "";
            this.txtTenTL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenTL.Location = new System.Drawing.Point(16, 138);
            this.txtTenTL.Size = new System.Drawing.Size(328, 34);
            this.txtTenTL.MaxLength = 100;
            this.txtTenTL.Name = "txtTenTL";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.BackColor = System.Drawing.Color.Transparent;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblMoTa.Location = new System.Drawing.Point(16, 182);
            this.lblMoTa.Text = "Mô tả";
            this.lblMoTa.Name = "lblMoTa";
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.txtMoTa.BorderRadius = 6;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMoTa.Location = new System.Drawing.Point(16, 204);
            this.txtMoTa.Size = new System.Drawing.Size(328, 90);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.MaxLength = 200;
            this.txtMoTa.Name = "txtMoTa";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Size = new System.Drawing.Size(1076, 64);
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
            this.btnXuatExcel.Location = new System.Drawing.Point(926, 12);
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
            this.pnlTop.Size = new System.Drawing.Size(1076, 64);
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
            this.lblTieuDe.Text = "QUẢN LÝ THỂ LOẠI SÁCH";
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
            this.txtTimKiem.Location = new System.Drawing.Point(756, 14);
            this.txtTimKiem.Size = new System.Drawing.Size(320, 36);
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý thể loại";
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlSpacer);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoSach;
        private Guna.UI2.WinForms.Guna2Panel pnlSpacer;
        private Guna.UI2.WinForms.Guna2Panel pnlForm;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblMaTL;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTL;
        private System.Windows.Forms.Label lblTenTL;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTL;
        private System.Windows.Forms.Label lblMoTa;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
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
