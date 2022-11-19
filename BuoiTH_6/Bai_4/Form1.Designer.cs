namespace Bai_4
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Sv01876",
            "Phan Văn Thành",
            "67 Trần Hưng Đạo",
            "02/12/1999",
            "Lớp D"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Sv3276",
            "Lê Xuân Hà",
            "89 Nguyễn Trãi",
            "12/22/1998",
            "Lớp D"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.listDanhSachSV = new System.Windows.Forms.ListView();
            this.msv = new System.Windows.Forms.ColumnHeader();
            this.hoten = new System.Windows.Forms.ColumnHeader();
            this.diachi = new System.Windows.Forms.ColumnHeader();
            this.ngaysinh = new System.Windows.Forms.ColumnHeader();
            this.lop = new System.Windows.Forms.ColumnHeader();
            this.btnThêm = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Sinh Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.dtpngaysinh);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtmasv);
            this.groupBox1.Location = new System.Drawing.Point(33, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Họ Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã SV:";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "Lớp A",
            "Lớp B",
            "Lớp C",
            "Lớp D",
            "Lớp E",
            "Lớp F"});
            this.cboLop.Location = new System.Drawing.Point(122, 216);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(157, 31);
            this.cboLop.TabIndex = 4;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.CustomFormat = "MM/dd/yyyy";
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaysinh.Location = new System.Drawing.Point(118, 168);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(162, 30);
            this.dtpngaysinh.TabIndex = 3;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(122, 122);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(160, 30);
            this.txtdiachi.TabIndex = 2;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(119, 80);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(163, 30);
            this.txthoten.TabIndex = 1;
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(118, 37);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(164, 30);
            this.txtmasv.TabIndex = 0;
            // 
            // listDanhSachSV
            // 
            this.listDanhSachSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.msv,
            this.hoten,
            this.diachi,
            this.ngaysinh,
            this.lop});
            this.listDanhSachSV.FullRowSelect = true;
            this.listDanhSachSV.GridLines = true;
            this.listDanhSachSV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listDanhSachSV.Location = new System.Drawing.Point(155, 328);
            this.listDanhSachSV.Name = "listDanhSachSV";
            this.listDanhSachSV.Size = new System.Drawing.Size(727, 178);
            this.listDanhSachSV.TabIndex = 2;
            this.listDanhSachSV.UseCompatibleStateImageBehavior = false;
            this.listDanhSachSV.View = System.Windows.Forms.View.Details;
            this.listDanhSachSV.SelectedIndexChanged += new System.EventHandler(this.listDanhSachSV_SelectedIndexChanged);
            // 
            // msv
            // 
            this.msv.Text = "Mã SV";
            this.msv.Width = 150;
            // 
            // hoten
            // 
            this.hoten.Text = "Họ Vs Tên";
            this.hoten.Width = 190;
            // 
            // diachi
            // 
            this.diachi.Text = "Địa Chỉ";
            this.diachi.Width = 150;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Text = "Ngày Sinh";
            this.ngaysinh.Width = 150;
            // 
            // lop
            // 
            this.lop.Text = "Lớp";
            this.lop.Width = 150;
            // 
            // btnThêm
            // 
            this.btnThêm.Location = new System.Drawing.Point(724, 65);
            this.btnThêm.Name = "btnThêm";
            this.btnThêm.Size = new System.Drawing.Size(184, 55);
            this.btnThêm.TabIndex = 3;
            this.btnThêm.Text = "Thêm";
            this.btnThêm.UseVisualStyleBackColor = true;
            this.btnThêm.Click += new System.EventHandler(this.btnThêm_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(725, 134);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(187, 50);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(725, 204);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(188, 39);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(730, 262);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(185, 50);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 518);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnThêm);
            this.Controls.Add(this.listDanhSachSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cboLop;
        private DateTimePicker dtpngaysinh;
        private TextBox txtdiachi;
        private TextBox txthoten;
        private TextBox txtmasv;
        private ListView listDanhSachSV;
        private ColumnHeader msv;
        private ColumnHeader hoten;
        private ColumnHeader diachi;
        private ColumnHeader ngaysinh;
        private ColumnHeader lop;
        private Button btnThêm;
        private Button btnluu;
        private Button btnXoa;
        private Button btnthoat;
        private SaveFileDialog saveFileDialog1;
    }
}