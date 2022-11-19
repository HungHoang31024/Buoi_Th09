namespace bai4._4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbChon = new System.Windows.Forms.GroupBox();
            this.rdbNhat = new System.Windows.Forms.RadioButton();
            this.rdbTamGiac = new System.Windows.Forms.RadioButton();
            this.rdbVuong = new System.Windows.Forms.RadioButton();
            this.rdbTron = new System.Windows.Forms.RadioButton();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbHinhVuong = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDientichHV = new System.Windows.Forms.TextBox();
            this.txtChuvihv = new System.Windows.Forms.TextBox();
            this.txtNhapCanhA = new System.Windows.Forms.TextBox();
            this.grbTron = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDTHTron = new System.Windows.Forms.TextBox();
            this.txtCVhTRon = new System.Windows.Forms.TextBox();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.grbTamGiac = new System.Windows.Forms.GroupBox();
            this.txtKqTamGiac = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDtTamGiac = new System.Windows.Forms.TextBox();
            this.txtTgCVi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTgC = new System.Windows.Forms.TextBox();
            this.txtTgB = new System.Windows.Forms.TextBox();
            this.txtTgA = new System.Windows.Forms.TextBox();
            this.grbHinhCN = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDienTichCN = new System.Windows.Forms.TextBox();
            this.txtChuviCN = new System.Windows.Forms.TextBox();
            this.txtNhapBChuNhat = new System.Windows.Forms.TextBox();
            this.txtNhapACHunhat = new System.Windows.Forms.TextBox();
            this.grbChon.SuspendLayout();
            this.grbHinhVuong.SuspendLayout();
            this.grbTron.SuspendLayout();
            this.grbTamGiac.SuspendLayout();
            this.grbHinhCN.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Chu vi và Diện tích";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "  Hình Tròn - Hình Vuông\r\nHình Tam Giác - Chữ Nhật";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // grbChon
            // 
            this.grbChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbChon.Controls.Add(this.rdbNhat);
            this.grbChon.Controls.Add(this.rdbTamGiac);
            this.grbChon.Controls.Add(this.rdbVuong);
            this.grbChon.Controls.Add(this.rdbTron);
            this.grbChon.Location = new System.Drawing.Point(12, 108);
            this.grbChon.Name = "grbChon";
            this.grbChon.Size = new System.Drawing.Size(336, 137);
            this.grbChon.TabIndex = 2;
            this.grbChon.TabStop = false;
            this.grbChon.Text = "Chọn";
            // 
            // rdbNhat
            // 
            this.rdbNhat.AutoSize = true;
            this.rdbNhat.Location = new System.Drawing.Point(166, 80);
            this.rdbNhat.Name = "rdbNhat";
            this.rdbNhat.Size = new System.Drawing.Size(155, 26);
            this.rdbNhat.TabIndex = 3;
            this.rdbNhat.TabStop = true;
            this.rdbNhat.Text = "Hình Chữ Nhật";
            this.rdbNhat.UseVisualStyleBackColor = true;
            this.rdbNhat.CheckedChanged += new System.EventHandler(this.rdbNhat_CheckedChanged);
            // 
            // rdbTamGiac
            // 
            this.rdbTamGiac.AutoSize = true;
            this.rdbTamGiac.Location = new System.Drawing.Point(166, 28);
            this.rdbTamGiac.Name = "rdbTamGiac";
            this.rdbTamGiac.Size = new System.Drawing.Size(155, 26);
            this.rdbTamGiac.TabIndex = 2;
            this.rdbTamGiac.TabStop = true;
            this.rdbTamGiac.Text = "Hình Tam Giác";
            this.rdbTamGiac.UseVisualStyleBackColor = true;
            this.rdbTamGiac.CheckedChanged += new System.EventHandler(this.rdbTamGiac_CheckedChanged);
            // 
            // rdbVuong
            // 
            this.rdbVuong.AutoSize = true;
            this.rdbVuong.Location = new System.Drawing.Point(6, 80);
            this.rdbVuong.Name = "rdbVuong";
            this.rdbVuong.Size = new System.Drawing.Size(126, 26);
            this.rdbVuong.TabIndex = 1;
            this.rdbVuong.TabStop = true;
            this.rdbVuong.Text = "Hình Vuông";
            this.rdbVuong.UseVisualStyleBackColor = true;
            this.rdbVuong.CheckedChanged += new System.EventHandler(this.rdbVuong_CheckedChanged);
            // 
            // rdbTron
            // 
            this.rdbTron.AutoSize = true;
            this.rdbTron.Location = new System.Drawing.Point(6, 28);
            this.rdbTron.Name = "rdbTron";
            this.rdbTron.Size = new System.Drawing.Size(115, 26);
            this.rdbTron.TabIndex = 0;
            this.rdbTron.TabStop = true;
            this.rdbTron.Text = "Hình Tròn";
            this.rdbTron.UseVisualStyleBackColor = true;
            this.rdbTron.CheckedChanged += new System.EventHandler(this.rdbTron_CheckedChanged);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(12, 251);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(118, 44);
            this.btnThucHien.TabIndex = 3;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(136, 251);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 44);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(244, 251);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 44);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbHinhVuong
            // 
            this.grbHinhVuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbHinhVuong.Controls.Add(this.label5);
            this.grbHinhVuong.Controls.Add(this.label4);
            this.grbHinhVuong.Controls.Add(this.label3);
            this.grbHinhVuong.Controls.Add(this.txtDientichHV);
            this.grbHinhVuong.Controls.Add(this.txtChuvihv);
            this.grbHinhVuong.Controls.Add(this.txtNhapCanhA);
            this.grbHinhVuong.Enabled = false;
            this.grbHinhVuong.Location = new System.Drawing.Point(6, 316);
            this.grbHinhVuong.Name = "grbHinhVuong";
            this.grbHinhVuong.Size = new System.Drawing.Size(336, 214);
            this.grbHinhVuong.TabIndex = 6;
            this.grbHinhVuong.TabStop = false;
            this.grbHinhVuong.Text = "Hình Vuông";
            this.grbHinhVuong.Visible = false;
            this.grbHinhVuong.Enter += new System.EventHandler(this.grbHinhVuong_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Diện tích";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chu Vi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nhập Cạnh A:";
            // 
            // txtDientichHV
            // 
            this.txtDientichHV.Location = new System.Drawing.Point(150, 139);
            this.txtDientichHV.Name = "txtDientichHV";
            this.txtDientichHV.Size = new System.Drawing.Size(100, 29);
            this.txtDientichHV.TabIndex = 9;
            // 
            // txtChuvihv
            // 
            this.txtChuvihv.Location = new System.Drawing.Point(150, 87);
            this.txtChuvihv.Name = "txtChuvihv";
            this.txtChuvihv.Size = new System.Drawing.Size(100, 29);
            this.txtChuvihv.TabIndex = 8;
            // 
            // txtNhapCanhA
            // 
            this.txtNhapCanhA.Location = new System.Drawing.Point(150, 40);
            this.txtNhapCanhA.Name = "txtNhapCanhA";
            this.txtNhapCanhA.Size = new System.Drawing.Size(138, 29);
            this.txtNhapCanhA.TabIndex = 7;
            // 
            // grbTron
            // 
            this.grbTron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbTron.Controls.Add(this.label8);
            this.grbTron.Controls.Add(this.label7);
            this.grbTron.Controls.Add(this.label6);
            this.grbTron.Controls.Add(this.txtDTHTron);
            this.grbTron.Controls.Add(this.txtCVhTRon);
            this.grbTron.Controls.Add(this.txtBanKinh);
            this.grbTron.Enabled = false;
            this.grbTron.Location = new System.Drawing.Point(11, 316);
            this.grbTron.Name = "grbTron";
            this.grbTron.Size = new System.Drawing.Size(337, 208);
            this.grbTron.TabIndex = 7;
            this.grbTron.TabStop = false;
            this.grbTron.Text = "Hình Tròn";
            this.grbTron.Visible = false;
            this.grbTron.Enter += new System.EventHandler(this.grbTron_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "Diện Tích";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Chu Vi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nhập Bán Kính:";
            // 
            // txtDTHTron
            // 
            this.txtDTHTron.Location = new System.Drawing.Point(181, 146);
            this.txtDTHTron.Name = "txtDTHTron";
            this.txtDTHTron.Size = new System.Drawing.Size(127, 29);
            this.txtDTHTron.TabIndex = 2;
            // 
            // txtCVhTRon
            // 
            this.txtCVhTRon.Location = new System.Drawing.Point(181, 98);
            this.txtCVhTRon.Name = "txtCVhTRon";
            this.txtCVhTRon.Size = new System.Drawing.Size(127, 29);
            this.txtCVhTRon.TabIndex = 1;
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Location = new System.Drawing.Point(181, 47);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(127, 29);
            this.txtBanKinh.TabIndex = 0;
            // 
            // grbTamGiac
            // 
            this.grbTamGiac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbTamGiac.Controls.Add(this.txtKqTamGiac);
            this.grbTamGiac.Controls.Add(this.label13);
            this.grbTamGiac.Controls.Add(this.label12);
            this.grbTamGiac.Controls.Add(this.txtDtTamGiac);
            this.grbTamGiac.Controls.Add(this.txtTgCVi);
            this.grbTamGiac.Controls.Add(this.label11);
            this.grbTamGiac.Controls.Add(this.label10);
            this.grbTamGiac.Controls.Add(this.label9);
            this.grbTamGiac.Controls.Add(this.txtTgC);
            this.grbTamGiac.Controls.Add(this.txtTgB);
            this.grbTamGiac.Controls.Add(this.txtTgA);
            this.grbTamGiac.Enabled = false;
            this.grbTamGiac.Location = new System.Drawing.Point(11, 316);
            this.grbTamGiac.Name = "grbTamGiac";
            this.grbTamGiac.Size = new System.Drawing.Size(337, 214);
            this.grbTamGiac.TabIndex = 8;
            this.grbTamGiac.TabStop = false;
            this.grbTamGiac.Text = "Hình Tam Giác";
            this.grbTamGiac.Visible = false;
            this.grbTamGiac.Enter += new System.EventHandler(this.grbTamGiac_Enter);
            // 
            // txtKqTamGiac
            // 
            this.txtKqTamGiac.Location = new System.Drawing.Point(7, 179);
            this.txtKqTamGiac.Name = "txtKqTamGiac";
            this.txtKqTamGiac.Size = new System.Drawing.Size(324, 29);
            this.txtKqTamGiac.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 22);
            this.label13.TabIndex = 9;
            this.label13.Text = "Diện Tích";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 22);
            this.label12.TabIndex = 8;
            this.label12.Text = "Chu Vi";
            // 
            // txtDtTamGiac
            // 
            this.txtDtTamGiac.Location = new System.Drawing.Point(112, 143);
            this.txtDtTamGiac.Name = "txtDtTamGiac";
            this.txtDtTamGiac.Size = new System.Drawing.Size(219, 29);
            this.txtDtTamGiac.TabIndex = 7;
            // 
            // txtTgCVi
            // 
            this.txtTgCVi.Location = new System.Drawing.Point(112, 101);
            this.txtTgCVi.Name = "txtTgCVi";
            this.txtTgCVi.Size = new System.Drawing.Size(219, 29);
            this.txtTgCVi.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(227, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 22);
            this.label11.TabIndex = 5;
            this.label11.Text = "Nhập C:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nhập B:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nhập A:";
            // 
            // txtTgC
            // 
            this.txtTgC.Location = new System.Drawing.Point(231, 54);
            this.txtTgC.Name = "txtTgC";
            this.txtTgC.Size = new System.Drawing.Size(100, 29);
            this.txtTgC.TabIndex = 2;
            // 
            // txtTgB
            // 
            this.txtTgB.Location = new System.Drawing.Point(112, 54);
            this.txtTgB.Name = "txtTgB";
            this.txtTgB.Size = new System.Drawing.Size(113, 29);
            this.txtTgB.TabIndex = 1;
            // 
            // txtTgA
            // 
            this.txtTgA.Location = new System.Drawing.Point(6, 54);
            this.txtTgA.Name = "txtTgA";
            this.txtTgA.Size = new System.Drawing.Size(100, 29);
            this.txtTgA.TabIndex = 0;
            // 
            // grbHinhCN
            // 
            this.grbHinhCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbHinhCN.Controls.Add(this.label17);
            this.grbHinhCN.Controls.Add(this.label16);
            this.grbHinhCN.Controls.Add(this.label15);
            this.grbHinhCN.Controls.Add(this.label14);
            this.grbHinhCN.Controls.Add(this.txtDienTichCN);
            this.grbHinhCN.Controls.Add(this.txtChuviCN);
            this.grbHinhCN.Controls.Add(this.txtNhapBChuNhat);
            this.grbHinhCN.Controls.Add(this.txtNhapACHunhat);
            this.grbHinhCN.Enabled = false;
            this.grbHinhCN.Location = new System.Drawing.Point(12, 316);
            this.grbHinhCN.Name = "grbHinhCN";
            this.grbHinhCN.Size = new System.Drawing.Size(336, 208);
            this.grbHinhCN.TabIndex = 9;
            this.grbHinhCN.TabStop = false;
            this.grbHinhCN.Text = "Hình Chữ Nhật";
            this.grbHinhCN.Visible = false;
            this.grbHinhCN.Enter += new System.EventHandler(this.grbHinhCN_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(64, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 22);
            this.label17.TabIndex = 7;
            this.label17.Text = "Diện Tích";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(84, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 22);
            this.label16.TabIndex = 6;
            this.label16.Text = "Chu vi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(79, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 22);
            this.label15.TabIndex = 5;
            this.label15.Text = "Nhập B:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(80, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 22);
            this.label14.TabIndex = 4;
            this.label14.Text = "Nhập A:";
            // 
            // txtDienTichCN
            // 
            this.txtDienTichCN.Location = new System.Drawing.Point(162, 130);
            this.txtDienTichCN.Name = "txtDienTichCN";
            this.txtDienTichCN.Size = new System.Drawing.Size(100, 29);
            this.txtDienTichCN.TabIndex = 3;
            // 
            // txtChuviCN
            // 
            this.txtChuviCN.Location = new System.Drawing.Point(162, 95);
            this.txtChuviCN.Name = "txtChuviCN";
            this.txtChuviCN.Size = new System.Drawing.Size(100, 29);
            this.txtChuviCN.TabIndex = 2;
            // 
            // txtNhapBChuNhat
            // 
            this.txtNhapBChuNhat.Location = new System.Drawing.Point(162, 60);
            this.txtNhapBChuNhat.Name = "txtNhapBChuNhat";
            this.txtNhapBChuNhat.Size = new System.Drawing.Size(100, 29);
            this.txtNhapBChuNhat.TabIndex = 1;
            // 
            // txtNhapACHunhat
            // 
            this.txtNhapACHunhat.Location = new System.Drawing.Point(162, 25);
            this.txtNhapACHunhat.Name = "txtNhapACHunhat";
            this.txtNhapACHunhat.Size = new System.Drawing.Size(100, 29);
            this.txtNhapACHunhat.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(365, 563);
            this.Controls.Add(this.grbTamGiac);
            this.Controls.Add(this.grbTron);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbHinhVuong);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.grbChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbHinhCN);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Tìm Chu Vi và Diện Tích";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbChon.ResumeLayout(false);
            this.grbChon.PerformLayout();
            this.grbHinhVuong.ResumeLayout(false);
            this.grbHinhVuong.PerformLayout();
            this.grbTron.ResumeLayout(false);
            this.grbTron.PerformLayout();
            this.grbTamGiac.ResumeLayout(false);
            this.grbTamGiac.PerformLayout();
            this.grbHinhCN.ResumeLayout(false);
            this.grbHinhCN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbChon;
        private System.Windows.Forms.RadioButton rdbNhat;
        private System.Windows.Forms.RadioButton rdbTamGiac;
        private System.Windows.Forms.RadioButton rdbVuong;
        private System.Windows.Forms.RadioButton rdbTron;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbHinhVuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDientichHV;
        private System.Windows.Forms.TextBox txtChuvihv;
        private System.Windows.Forms.TextBox txtNhapCanhA;
        private System.Windows.Forms.GroupBox grbTron;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDTHTron;
        private System.Windows.Forms.TextBox txtCVhTRon;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.GroupBox grbTamGiac;
        private System.Windows.Forms.TextBox txtKqTamGiac;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDtTamGiac;
        private System.Windows.Forms.TextBox txtTgCVi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTgC;
        private System.Windows.Forms.TextBox txtTgB;
        private System.Windows.Forms.TextBox txtTgA;
        private System.Windows.Forms.GroupBox grbHinhCN;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDienTichCN;
        private System.Windows.Forms.TextBox txtChuviCN;
        private System.Windows.Forms.TextBox txtNhapBChuNhat;
        private System.Windows.Forms.TextBox txtNhapACHunhat;
    }
}

