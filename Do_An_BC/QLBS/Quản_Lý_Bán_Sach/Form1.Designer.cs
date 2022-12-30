namespace Quản_Lý_Bán_Sach
{
    partial class frmQLBS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLBS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.grbTTSach = new System.Windows.Forms.GroupBox();
            this.dtpNNhap = new System.Windows.Forms.DateTimePicker();
            this.txtĐGia = new System.Windows.Forms.TextBox();
            this.txtMLoai = new System.Windows.Forms.TextBox();
            this.txtTGia = new System.Windows.Forms.TextBox();
            this.txtSLCon = new System.Windows.Forms.TextBox();
            this.txtNSXuat = new System.Windows.Forms.TextBox();
            this.txtTSach = new System.Windows.Forms.TextBox();
            this.txtMSach = new System.Windows.Forms.TextBox();
            this.lblSLCon = new System.Windows.Forms.Label();
            this.lblNNhap = new System.Windows.Forms.Label();
            this.lblDGia = new System.Windows.Forms.Label();
            this.lblMLoai = new System.Windows.Forms.Label();
            this.lblNSXuat = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTenS = new System.Windows.Forms.Label();
            this.lblMaS = new System.Windows.Forms.Label();
            this.btnThemS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoaS = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblQLBS = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTKSach = new System.Windows.Forms.ComboBox();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvTimSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.grbTTSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.gbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(482, 312);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 62;
            this.dgvSach.RowTemplate.Height = 33;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(1154, 307);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellContentClick);
            // 
            // grbTTSach
            // 
            this.grbTTSach.BackColor = System.Drawing.Color.Pink;
            this.grbTTSach.Controls.Add(this.dtpNNhap);
            this.grbTTSach.Controls.Add(this.txtĐGia);
            this.grbTTSach.Controls.Add(this.txtMLoai);
            this.grbTTSach.Controls.Add(this.txtTGia);
            this.grbTTSach.Controls.Add(this.txtSLCon);
            this.grbTTSach.Controls.Add(this.txtNSXuat);
            this.grbTTSach.Controls.Add(this.txtTSach);
            this.grbTTSach.Controls.Add(this.txtMSach);
            this.grbTTSach.Controls.Add(this.lblSLCon);
            this.grbTTSach.Controls.Add(this.lblNNhap);
            this.grbTTSach.Controls.Add(this.lblDGia);
            this.grbTTSach.Controls.Add(this.lblMLoai);
            this.grbTTSach.Controls.Add(this.lblNSXuat);
            this.grbTTSach.Controls.Add(this.lblTacGia);
            this.grbTTSach.Controls.Add(this.lblTenS);
            this.grbTTSach.Controls.Add(this.lblMaS);
            this.grbTTSach.Location = new System.Drawing.Point(34, 67);
            this.grbTTSach.Name = "grbTTSach";
            this.grbTTSach.Size = new System.Drawing.Size(1474, 219);
            this.grbTTSach.TabIndex = 2;
            this.grbTTSach.TabStop = false;
            this.grbTTSach.Text = "Thông Tin Sách";
            // 
            // dtpNNhap
            // 
            this.dtpNNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNNhap.Location = new System.Drawing.Point(690, 144);
            this.dtpNNhap.Name = "dtpNNhap";
            this.dtpNNhap.Size = new System.Drawing.Size(292, 30);
            this.dtpNNhap.TabIndex = 2;
            // 
            // txtĐGia
            // 
            this.txtĐGia.Location = new System.Drawing.Point(1135, 84);
            this.txtĐGia.Name = "txtĐGia";
            this.txtĐGia.Size = new System.Drawing.Size(268, 30);
            this.txtĐGia.TabIndex = 1;
            // 
            // txtMLoai
            // 
            this.txtMLoai.Location = new System.Drawing.Point(694, 81);
            this.txtMLoai.Name = "txtMLoai";
            this.txtMLoai.Size = new System.Drawing.Size(288, 30);
            this.txtMLoai.TabIndex = 1;
            // 
            // txtTGia
            // 
            this.txtTGia.Location = new System.Drawing.Point(1135, 23);
            this.txtTGia.Name = "txtTGia";
            this.txtTGia.Size = new System.Drawing.Size(268, 30);
            this.txtTGia.TabIndex = 1;
            // 
            // txtSLCon
            // 
            this.txtSLCon.Location = new System.Drawing.Point(189, 139);
            this.txtSLCon.Name = "txtSLCon";
            this.txtSLCon.Size = new System.Drawing.Size(257, 30);
            this.txtSLCon.TabIndex = 1;
            // 
            // txtNSXuat
            // 
            this.txtNSXuat.Location = new System.Drawing.Point(189, 89);
            this.txtNSXuat.Name = "txtNSXuat";
            this.txtNSXuat.Size = new System.Drawing.Size(257, 30);
            this.txtNSXuat.TabIndex = 1;
            // 
            // txtTSach
            // 
            this.txtTSach.Location = new System.Drawing.Point(694, 28);
            this.txtTSach.Name = "txtTSach";
            this.txtTSach.Size = new System.Drawing.Size(288, 30);
            this.txtTSach.TabIndex = 1;
            // 
            // txtMSach
            // 
            this.txtMSach.Location = new System.Drawing.Point(131, 35);
            this.txtMSach.Name = "txtMSach";
            this.txtMSach.Size = new System.Drawing.Size(315, 30);
            this.txtMSach.TabIndex = 1;
            // 
            // lblSLCon
            // 
            this.lblSLCon.AutoSize = true;
            this.lblSLCon.Location = new System.Drawing.Point(8, 144);
            this.lblSLCon.Name = "lblSLCon";
            this.lblSLCon.Size = new System.Drawing.Size(130, 22);
            this.lblSLCon.TabIndex = 0;
            this.lblSLCon.Text = "Số Lượng Còn:";
            // 
            // lblNNhap
            // 
            this.lblNNhap.AutoSize = true;
            this.lblNNhap.Location = new System.Drawing.Point(511, 147);
            this.lblNNhap.Name = "lblNNhap";
            this.lblNNhap.Size = new System.Drawing.Size(104, 22);
            this.lblNNhap.TabIndex = 0;
            this.lblNNhap.Text = "Ngày Nhập:";
            // 
            // lblDGia
            // 
            this.lblDGia.AutoSize = true;
            this.lblDGia.Location = new System.Drawing.Point(1027, 89);
            this.lblDGia.Name = "lblDGia";
            this.lblDGia.Size = new System.Drawing.Size(84, 22);
            this.lblDGia.TabIndex = 0;
            this.lblDGia.Text = "Đơn Giá:";
            // 
            // lblMLoai
            // 
            this.lblMLoai.AutoSize = true;
            this.lblMLoai.Location = new System.Drawing.Point(511, 89);
            this.lblMLoai.Name = "lblMLoai";
            this.lblMLoai.Size = new System.Drawing.Size(83, 22);
            this.lblMLoai.TabIndex = 0;
            this.lblMLoai.Text = "Mã Loại:";
            // 
            // lblNSXuat
            // 
            this.lblNSXuat.AutoSize = true;
            this.lblNSXuat.Location = new System.Drawing.Point(8, 92);
            this.lblNSXuat.Name = "lblNSXuat";
            this.lblNSXuat.Size = new System.Drawing.Size(124, 22);
            this.lblNSXuat.TabIndex = 0;
            this.lblNSXuat.Text = "Nhà Sản Xuất:";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(1027, 31);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(80, 22);
            this.lblTacGia.TabIndex = 0;
            this.lblTacGia.Text = "Tác Giả:";
            // 
            // lblTenS
            // 
            this.lblTenS.AutoSize = true;
            this.lblTenS.Location = new System.Drawing.Point(504, 36);
            this.lblTenS.Name = "lblTenS";
            this.lblTenS.Size = new System.Drawing.Size(89, 22);
            this.lblTenS.TabIndex = 0;
            this.lblTenS.Text = "Tên Sách:";
            // 
            // lblMaS
            // 
            this.lblMaS.AutoSize = true;
            this.lblMaS.Location = new System.Drawing.Point(6, 43);
            this.lblMaS.Name = "lblMaS";
            this.lblMaS.Size = new System.Drawing.Size(85, 22);
            this.lblMaS.TabIndex = 0;
            this.lblMaS.Text = "Mã Sách:";
            // 
            // btnThemS
            // 
            this.btnThemS.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemS.BackgroundImage")));
            this.btnThemS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemS.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemS.Location = new System.Drawing.Point(245, 325);
            this.btnThemS.Name = "btnThemS";
            this.btnThemS.Size = new System.Drawing.Size(212, 78);
            this.btnThemS.TabIndex = 3;
            this.btnThemS.Text = "Thêm Sách";
            this.btnThemS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemS.UseVisualStyleBackColor = false;
            this.btnThemS.Click += new System.EventHandler(this.btnThemS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Sách:";
            // 
            // btnXoaS
            // 
            this.btnXoaS.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoaS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaS.BackgroundImage")));
            this.btnXoaS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaS.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaS.Location = new System.Drawing.Point(34, 437);
            this.btnXoaS.Name = "btnXoaS";
            this.btnXoaS.Size = new System.Drawing.Size(199, 88);
            this.btnXoaS.TabIndex = 3;
            this.btnXoaS.Text = "Xóa Sách";
            this.btnXoaS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaS.UseVisualStyleBackColor = false;
            this.btnXoaS.Click += new System.EventHandler(this.btnXoaS_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Location = new System.Drawing.Point(34, 325);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(197, 80);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa Sách";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.Location = new System.Drawing.Point(264, 437);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(212, 88);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "         Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblQLBS
            // 
            this.lblQLBS.BackColor = System.Drawing.Color.White;
            this.lblQLBS.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQLBS.ForeColor = System.Drawing.Color.Blue;
            this.lblQLBS.Location = new System.Drawing.Point(610, -6);
            this.lblQLBS.Name = "lblQLBS";
            this.lblQLBS.Size = new System.Drawing.Size(385, 70);
            this.lblQLBS.TabIndex = 4;
            this.lblQLBS.Text = "QUẢN LÝ SÁCH";
            this.lblQLBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTKSach
            // 
            this.cmbTKSach.FormattingEnabled = true;
            this.cmbTKSach.Location = new System.Drawing.Point(114, 23);
            this.cmbTKSach.Name = "cmbTKSach";
            this.cmbTKSach.Size = new System.Drawing.Size(143, 30);
            this.cmbTKSach.TabIndex = 5;
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.BackColor = System.Drawing.Color.Pink;
            this.gbTimKiem.Controls.Add(this.cmbTKSach);
            this.gbTimKiem.Controls.Add(this.label5);
            this.gbTimKiem.Location = new System.Drawing.Point(96, 646);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(275, 88);
            this.gbTimKiem.TabIndex = 6;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Visible = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiem.Location = new System.Drawing.Point(122, 544);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(215, 85);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvTimSach
            // 
            this.dgvTimSach.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvTimSach.Location = new System.Drawing.Point(482, 636);
            this.dgvTimSach.Name = "dgvTimSach";
            this.dgvTimSach.RowHeadersWidth = 62;
            this.dgvTimSach.RowTemplate.Height = 33;
            this.dgvTimSach.Size = new System.Drawing.Size(1154, 125);
            this.dgvTimSach.TabIndex = 8;
            this.dgvTimSach.Visible = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Mã sách";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Tên sách";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Tác giả";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "Tên NSX";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "Mã loại";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column6.HeaderText = "Đơn giá";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column7.HeaderText = "Số lượng tồn";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column8.HeaderText = "Ngày nhập";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(-1, -6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 29);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmQLBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1648, 773);
            this.Controls.Add(this.dgvTimSach);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.lblQLBS);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaS);
            this.Controls.Add(this.btnThemS);
            this.Controls.Add(this.grbTTSach);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmQLBS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí sách";
            this.Load += new System.EventHandler(this.frmQLBS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.grbTTSach.ResumeLayout(false);
            this.grbTTSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvSach;
        private GroupBox grbTTSach;
        private Button button;
        private Button btnThemS;
        private DateTimePicker dtpNNhap;
        private TextBox txtĐGia;
        private TextBox txtMLoai;
        private TextBox txtTGia;
        private TextBox txtSLCon;
        private TextBox txtNSXuat;
        private TextBox txtTSach;
        private TextBox txtMSach;
        private Label lblSLCon;
        private Label lblNNhap;
        private Label lblDGia;
        private Label lblMLoai;
        private Label lblNSXuat;
        private Label lblTacGia;
        private Label lblTenS;
        private Label lblMaS;
        private Label label5;
        private Button btnXoaS;
        private Button btnSua;
        private Button btnThoat;
        private Label lblQLBS;
        private BindingSource bindingSource1;
        private ComboBox cmbTKSach;
        private GroupBox gbTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvTimSach;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button button1;
    }
}