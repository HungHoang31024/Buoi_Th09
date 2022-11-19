namespace Buoi3_Bai9
{
    partial class frmBai9
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
            this.lblThongTinCaNhan = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.datetpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.ckbDangDiLam = new System.Windows.Forms.CheckBox();
            this.ckBDangDiHoc = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.btnHienThongTin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbHinhAnh = new System.Windows.Forms.GroupBox();
            this.pctHinhAnh = new System.Windows.Forms.PictureBox();
            this.grbThongTin.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.grbHinhAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongTinCaNhan
            // 
            this.lblThongTinCaNhan.AutoSize = true;
            this.lblThongTinCaNhan.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinCaNhan.Location = new System.Drawing.Point(353, 21);
            this.lblThongTinCaNhan.Name = "lblThongTinCaNhan";
            this.lblThongTinCaNhan.Size = new System.Drawing.Size(355, 45);
            this.lblThongTinCaNhan.TabIndex = 0;
            this.lblThongTinCaNhan.Text = "Thong Tin Ca Nhan";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.datetpNgaySinh);
            this.grbThongTin.Controls.Add(this.ckbDangDiLam);
            this.grbThongTin.Controls.Add(this.ckBDangDiHoc);
            this.grbThongTin.Controls.Add(this.flowLayoutPanel1);
            this.grbThongTin.Controls.Add(this.txtSoDienThoai);
            this.grbThongTin.Controls.Add(this.txtDiaChi);
            this.grbThongTin.Controls.Add(this.txtEmail);
            this.grbThongTin.Controls.Add(this.txtHoTen);
            this.grbThongTin.Controls.Add(this.lblTinhTrang);
            this.grbThongTin.Controls.Add(this.lblEmail);
            this.grbThongTin.Controls.Add(this.lblDienThoai);
            this.grbThongTin.Controls.Add(this.lblDiaChi);
            this.grbThongTin.Controls.Add(this.lblNgaySinh);
            this.grbThongTin.Controls.Add(this.lblGioiTinh);
            this.grbThongTin.Controls.Add(this.lblHoTen);
            this.grbThongTin.Location = new System.Drawing.Point(110, 79);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(553, 380);
            this.grbThongTin.TabIndex = 1;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thong tin";
            // 
            // datetpNgaySinh
            // 
            this.datetpNgaySinh.CustomFormat = "";
            this.datetpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetpNgaySinh.Location = new System.Drawing.Point(124, 135);
            this.datetpNgaySinh.Name = "datetpNgaySinh";
            this.datetpNgaySinh.Size = new System.Drawing.Size(398, 35);
            this.datetpNgaySinh.TabIndex = 5;
            this.datetpNgaySinh.ValueChanged += new System.EventHandler(this.datetpNgaySinh_ValueChanged);
            // 
            // ckbDangDiLam
            // 
            this.ckbDangDiLam.AutoSize = true;
            this.ckbDangDiLam.Location = new System.Drawing.Point(332, 321);
            this.ckbDangDiLam.Name = "ckbDangDiLam";
            this.ckbDangDiLam.Size = new System.Drawing.Size(154, 31);
            this.ckbDangDiLam.TabIndex = 16;
            this.ckbDangDiLam.Text = "Dang di lam";
            this.ckbDangDiLam.UseVisualStyleBackColor = true;
            // 
            // ckBDangDiHoc
            // 
            this.ckBDangDiHoc.AutoSize = true;
            this.ckBDangDiHoc.Location = new System.Drawing.Point(169, 321);
            this.ckBDangDiHoc.Name = "ckBDangDiHoc";
            this.ckBDangDiHoc.Size = new System.Drawing.Size(154, 31);
            this.ckBDangDiHoc.TabIndex = 15;
            this.ckBDangDiHoc.Text = "Dang di hoc";
            this.ckBDangDiHoc.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radNam);
            this.flowLayoutPanel1.Controls.Add(this.radNu);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(127, 82);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(303, 37);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(3, 3);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(83, 31);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(92, 3);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(66, 31);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nu";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(127, 228);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(395, 35);
            this.txtSoDienThoai.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(127, 182);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(398, 35);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(127, 269);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(395, 35);
            this.txtEmail.TabIndex = 8;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(124, 30);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(398, 35);
            this.txtHoTen.TabIndex = 7;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(6, 325);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(122, 27);
            this.lblTinhTrang.TabIndex = 6;
            this.lblTinhTrang.Text = "Tinh trang: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 277);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 27);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email: ";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(6, 231);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(124, 27);
            this.lblDienThoai.TabIndex = 4;
            this.lblDienThoai.Text = "Dien thoai: ";
            this.lblDienThoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(6, 190);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(81, 27);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Dia chi";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(6, 141);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(120, 27);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngay sinh: ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(6, 89);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(108, 27);
            this.lblGioiTinh.TabIndex = 1;
            this.lblGioiTinh.Text = "Gioi tinh: ";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(6, 38);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(89, 27);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Ho ten: ";
            // 
            // btnHienThongTin
            // 
            this.btnHienThongTin.Location = new System.Drawing.Point(110, 507);
            this.btnHienThongTin.Name = "btnHienThongTin";
            this.btnHienThongTin.Size = new System.Drawing.Size(198, 54);
            this.btnHienThongTin.TabIndex = 2;
            this.btnHienThongTin.Text = "Hien Thong Tin";
            this.btnHienThongTin.UseVisualStyleBackColor = true;
            this.btnHienThongTin.Click += new System.EventHandler(this.btnHienThongTin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(391, 507);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(174, 54);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbHinhAnh
            // 
            this.grbHinhAnh.Controls.Add(this.pctHinhAnh);
            this.grbHinhAnh.Location = new System.Drawing.Point(770, 79);
            this.grbHinhAnh.Name = "grbHinhAnh";
            this.grbHinhAnh.Size = new System.Drawing.Size(292, 289);
            this.grbHinhAnh.TabIndex = 4;
            this.grbHinhAnh.TabStop = false;
            this.grbHinhAnh.Text = "Hình ảnh";
            // 
            // pctHinhAnh
            // 
            this.pctHinhAnh.Location = new System.Drawing.Point(31, 30);
            this.pctHinhAnh.Name = "pctHinhAnh";
            this.pctHinhAnh.Size = new System.Drawing.Size(239, 235);
            this.pctHinhAnh.TabIndex = 0;
            this.pctHinhAnh.TabStop = false;
            // 
            // frmBai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.grbHinhAnh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHienThongTin);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.lblThongTinCaNhan);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBai9";
            this.Text = "Bai 9 ";
            this.Load += new System.EventHandler(this.frmBai9_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.grbHinhAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinCaNhan;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.CheckBox ckbDangDiLam;
        private System.Windows.Forms.CheckBox ckBDangDiHoc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button btnHienThongTin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbHinhAnh;
        private System.Windows.Forms.PictureBox pctHinhAnh;
        private System.Windows.Forms.DateTimePicker datetpNgaySinh;
    }
}

