namespace Bai4._7
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXuatMang = new System.Windows.Forms.Button();
            this.grbTong = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.txtTongMang = new System.Windows.Forms.TextBox();
            this.grbTimMAxMin = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.grbSapXep = new System.Windows.Forms.GroupBox();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.radbGiam = new System.Windows.Forms.RadioButton();
            this.radbTang = new System.Windows.Forms.RadioButton();
            this.grbThayThe = new System.Windows.Forms.GroupBox();
            this.btnThayThe = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoThayThe = new System.Windows.Forms.TextBox();
            this.txtVitri = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.grbTong.SuspendLayout();
            this.grbTimMAxMin.SuspendLayout();
            this.grbSapXep.SuspendLayout();
            this.grbThayThe.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mảng Số Nguyên";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(180, 108);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(582, 26);
            this.txtNhap.TabIndex = 1;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(180, 171);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(579, 26);
            this.txtKetQua.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập Mảng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết Quả:";
            // 
            // btnXuatMang
            // 
            this.btnXuatMang.BackColor = System.Drawing.Color.Cyan;
            this.btnXuatMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatMang.Location = new System.Drawing.Point(805, 42);
            this.btnXuatMang.Name = "btnXuatMang";
            this.btnXuatMang.Size = new System.Drawing.Size(208, 92);
            this.btnXuatMang.TabIndex = 6;
            this.btnXuatMang.Text = "Xuất Mảng";
            this.btnXuatMang.UseVisualStyleBackColor = false;
            this.btnXuatMang.Click += new System.EventHandler(this.btnXuatMang_Click);
            // 
            // grbTong
            // 
            this.grbTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grbTong.Controls.Add(this.label6);
            this.grbTong.Controls.Add(this.label5);
            this.grbTong.Controls.Add(this.label4);
            this.grbTong.Controls.Add(this.btnTinhTong);
            this.grbTong.Controls.Add(this.txtTongLe);
            this.grbTong.Controls.Add(this.txtTongChan);
            this.grbTong.Controls.Add(this.txtTongMang);
            this.grbTong.Location = new System.Drawing.Point(49, 230);
            this.grbTong.Name = "grbTong";
            this.grbTong.Size = new System.Drawing.Size(332, 159);
            this.grbTong.TabIndex = 7;
            this.grbTong.TabStop = false;
            this.grbTong.Text = "Tổng";
            this.grbTong.Enter += new System.EventHandler(this.grbTong_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tổng Chẳn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng Lẻ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng Mảng:";
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTong.Location = new System.Drawing.Point(241, 30);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(91, 94);
            this.btnTinhTong.TabIndex = 5;
            this.btnTinhTong.Text = "Tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // txtTongLe
            // 
            this.txtTongLe.Location = new System.Drawing.Point(115, 98);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.Size = new System.Drawing.Size(120, 26);
            this.txtTongLe.TabIndex = 4;
            // 
            // txtTongChan
            // 
            this.txtTongChan.Location = new System.Drawing.Point(115, 65);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.Size = new System.Drawing.Size(120, 26);
            this.txtTongChan.TabIndex = 3;
            this.txtTongChan.TextChanged += new System.EventHandler(this.txtTongChan_TextChanged);
            // 
            // txtTongMang
            // 
            this.txtTongMang.Location = new System.Drawing.Point(115, 25);
            this.txtTongMang.Name = "txtTongMang";
            this.txtTongMang.Size = new System.Drawing.Size(120, 26);
            this.txtTongMang.TabIndex = 2;
            // 
            // grbTimMAxMin
            // 
            this.grbTimMAxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grbTimMAxMin.Controls.Add(this.btnTim);
            this.grbTimMAxMin.Controls.Add(this.label8);
            this.grbTimMAxMin.Controls.Add(this.label7);
            this.grbTimMAxMin.Controls.Add(this.txtMin);
            this.grbTimMAxMin.Controls.Add(this.txtmax);
            this.grbTimMAxMin.Location = new System.Drawing.Point(397, 230);
            this.grbTimMAxMin.Name = "grbTimMAxMin";
            this.grbTimMAxMin.Size = new System.Drawing.Size(363, 159);
            this.grbTimMAxMin.TabIndex = 8;
            this.grbTimMAxMin.TabStop = false;
            this.grbTimMAxMin.Text = "Tìm Max , Min";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(284, 46);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(77, 77);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Min:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Max:";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(89, 96);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(188, 26);
            this.txtMin.TabIndex = 1;
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(89, 42);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(189, 26);
            this.txtmax.TabIndex = 0;
            // 
            // grbSapXep
            // 
            this.grbSapXep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grbSapXep.Controls.Add(this.btnSapXep);
            this.grbSapXep.Controls.Add(this.radbGiam);
            this.grbSapXep.Controls.Add(this.radbTang);
            this.grbSapXep.Location = new System.Drawing.Point(49, 399);
            this.grbSapXep.Name = "grbSapXep";
            this.grbSapXep.Size = new System.Drawing.Size(331, 155);
            this.grbSapXep.TabIndex = 9;
            this.grbSapXep.TabStop = false;
            this.grbSapXep.Text = "Sắp Xếp";
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(218, 25);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(93, 68);
            this.btnSapXep.TabIndex = 2;
            this.btnSapXep.Text = "Sắp Xếp ";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // radbGiam
            // 
            this.radbGiam.AutoSize = true;
            this.radbGiam.Location = new System.Drawing.Point(30, 69);
            this.radbGiam.Name = "radbGiam";
            this.radbGiam.Size = new System.Drawing.Size(150, 24);
            this.radbGiam.TabIndex = 1;
            this.radbGiam.TabStop = true;
            this.radbGiam.Text = "Sắp Xếp Giảm";
            this.radbGiam.UseVisualStyleBackColor = true;
            // 
            // radbTang
            // 
            this.radbTang.AutoSize = true;
            this.radbTang.Location = new System.Drawing.Point(30, 25);
            this.radbTang.Name = "radbTang";
            this.radbTang.Size = new System.Drawing.Size(147, 24);
            this.radbTang.TabIndex = 0;
            this.radbTang.TabStop = true;
            this.radbTang.Text = "Sắp Xếp Tăng";
            this.radbTang.UseVisualStyleBackColor = true;
            // 
            // grbThayThe
            // 
            this.grbThayThe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grbThayThe.Controls.Add(this.btnThayThe);
            this.grbThayThe.Controls.Add(this.label10);
            this.grbThayThe.Controls.Add(this.label9);
            this.grbThayThe.Controls.Add(this.txtSoThayThe);
            this.grbThayThe.Controls.Add(this.txtVitri);
            this.grbThayThe.Location = new System.Drawing.Point(397, 399);
            this.grbThayThe.Name = "grbThayThe";
            this.grbThayThe.Size = new System.Drawing.Size(362, 155);
            this.grbThayThe.TabIndex = 10;
            this.grbThayThe.TabStop = false;
            this.grbThayThe.Text = "Thay Thế";
            this.grbThayThe.Enter += new System.EventHandler(this.grbThayThe_Enter);
            // 
            // btnThayThe
            // 
            this.btnThayThe.Location = new System.Drawing.Point(164, 101);
            this.btnThayThe.Name = "btnThayThe";
            this.btnThayThe.Size = new System.Drawing.Size(153, 48);
            this.btnThayThe.TabIndex = 4;
            this.btnThayThe.Text = "Thay Thế";
            this.btnThayThe.UseVisualStyleBackColor = true;
            this.btnThayThe.Click += new System.EventHandler(this.btnThayThe_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Số Thay Thế:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Vị Trí Thay Thế:";
            // 
            // txtSoThayThe
            // 
            this.txtSoThayThe.Location = new System.Drawing.Point(164, 70);
            this.txtSoThayThe.Name = "txtSoThayThe";
            this.txtSoThayThe.Size = new System.Drawing.Size(153, 26);
            this.txtSoThayThe.TabIndex = 1;
            // 
            // txtVitri
            // 
            this.txtVitri.Location = new System.Drawing.Point(164, 28);
            this.txtVitri.Name = "txtVitri";
            this.txtVitri.Size = new System.Drawing.Size(152, 26);
            this.txtVitri.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Cyan;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(847, 319);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(147, 144);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamLai.Location = new System.Drawing.Point(805, 153);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(207, 77);
            this.btnLamLai.TabIndex = 12;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(1034, 624);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbThayThe);
            this.Controls.Add(this.grbSapXep);
            this.Controls.Add(this.grbTimMAxMin);
            this.Controls.Add(this.grbTong);
            this.Controls.Add(this.btnXuatMang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Mảng Số Nguyên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbTong.ResumeLayout(false);
            this.grbTong.PerformLayout();
            this.grbTimMAxMin.ResumeLayout(false);
            this.grbTimMAxMin.PerformLayout();
            this.grbSapXep.ResumeLayout(false);
            this.grbSapXep.PerformLayout();
            this.grbThayThe.ResumeLayout(false);
            this.grbThayThe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXuatMang;
        private System.Windows.Forms.GroupBox grbTong;
        private System.Windows.Forms.GroupBox grbTimMAxMin;
        private System.Windows.Forms.GroupBox grbSapXep;
        private System.Windows.Forms.GroupBox grbThayThe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTongMang;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.TextBox txtTongLe;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.RadioButton radbGiam;
        private System.Windows.Forms.RadioButton radbTang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoThayThe;
        private System.Windows.Forms.TextBox txtVitri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThayThe;
        private System.Windows.Forms.Button btnLamLai;
    }
}

