namespace Bai1._1
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSXGIAM = new System.Windows.Forms.Button();
            this.btnSXTANG = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSoHoanHao = new System.Windows.Forms.Button();
            this.btnSoNguyenTo = new System.Windows.Forms.Button();
            this.btnTBMang = new System.Windows.Forms.Button();
            this.btnDemSoLe = new System.Windows.Forms.Button();
            this.btnDemSoChan = new System.Windows.Forms.Button();
            this.btnUCLN = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(148, 26);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(118, 22);
            this.txtNhap.TabIndex = 1;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(272, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(129, 87);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In Mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(407, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 87);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(509, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 87);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSXGIAM
            // 
            this.btnSXGIAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSXGIAM.Location = new System.Drawing.Point(628, 4);
            this.btnSXGIAM.Name = "btnSXGIAM";
            this.btnSXGIAM.Size = new System.Drawing.Size(168, 64);
            this.btnSXGIAM.TabIndex = 5;
            this.btnSXGIAM.Text = "Sắp Xếp Giảm";
            this.btnSXGIAM.UseVisualStyleBackColor = true;
            this.btnSXGIAM.Click += new System.EventHandler(this.btnSXGIAM_Click);
            // 
            // btnSXTANG
            // 
            this.btnSXTANG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSXTANG.Location = new System.Drawing.Point(628, 74);
            this.btnSXTANG.Name = "btnSXTANG";
            this.btnSXTANG.Size = new System.Drawing.Size(168, 64);
            this.btnSXTANG.TabIndex = 6;
            this.btnSXTANG.Text = "Sắp Xếp Tăng";
            this.btnSXTANG.UseVisualStyleBackColor = true;
            this.btnSXTANG.Click += new System.EventHandler(this.btnSXTANG_Click);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(628, 144);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(168, 69);
            this.btnSum.TabIndex = 7;
            this.btnSum.Text = "Tổng Mảng";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(628, 219);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(168, 74);
            this.btnMax.TabIndex = 8;
            this.btnMax.Text = "Số Lớn Nhất";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(628, 299);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(168, 69);
            this.btnMin.TabIndex = 9;
            this.btnMin.Text = "Số Nhỏ Nhất";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSoHoanHao
            // 
            this.btnSoHoanHao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoHoanHao.Location = new System.Drawing.Point(628, 374);
            this.btnSoHoanHao.Name = "btnSoHoanHao";
            this.btnSoHoanHao.Size = new System.Drawing.Size(168, 69);
            this.btnSoHoanHao.TabIndex = 10;
            this.btnSoHoanHao.Text = "Số Hoàn Hảo";
            this.btnSoHoanHao.UseVisualStyleBackColor = true;
            this.btnSoHoanHao.Click += new System.EventHandler(this.btnSoHoanHao_Click);
            // 
            // btnSoNguyenTo
            // 
            this.btnSoNguyenTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoNguyenTo.Location = new System.Drawing.Point(407, 374);
            this.btnSoNguyenTo.Name = "btnSoNguyenTo";
            this.btnSoNguyenTo.Size = new System.Drawing.Size(215, 69);
            this.btnSoNguyenTo.TabIndex = 11;
            this.btnSoNguyenTo.Text = "Số Nguyên Tố";
            this.btnSoNguyenTo.UseVisualStyleBackColor = true;
            this.btnSoNguyenTo.Click += new System.EventHandler(this.btnSoNguyenTo_Click);
            // 
            // btnTBMang
            // 
            this.btnTBMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTBMang.Location = new System.Drawing.Point(407, 299);
            this.btnTBMang.Name = "btnTBMang";
            this.btnTBMang.Size = new System.Drawing.Size(215, 69);
            this.btnTBMang.TabIndex = 12;
            this.btnTBMang.Text = "Trung Bình Mảng";
            this.btnTBMang.UseVisualStyleBackColor = true;
            this.btnTBMang.Click += new System.EventHandler(this.btnTBMang_Click);
            // 
            // btnDemSoLe
            // 
            this.btnDemSoLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemSoLe.Location = new System.Drawing.Point(199, 299);
            this.btnDemSoLe.Name = "btnDemSoLe";
            this.btnDemSoLe.Size = new System.Drawing.Size(202, 69);
            this.btnDemSoLe.TabIndex = 13;
            this.btnDemSoLe.Text = "Đếm Số Lẻ";
            this.btnDemSoLe.UseVisualStyleBackColor = true;
            this.btnDemSoLe.Click += new System.EventHandler(this.btnDemSoLe_Click);
            // 
            // btnDemSoChan
            // 
            this.btnDemSoChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemSoChan.Location = new System.Drawing.Point(10, 299);
            this.btnDemSoChan.Name = "btnDemSoChan";
            this.btnDemSoChan.Size = new System.Drawing.Size(183, 69);
            this.btnDemSoChan.TabIndex = 14;
            this.btnDemSoChan.Text = "Đếm Số Chẳn";
            this.btnDemSoChan.UseVisualStyleBackColor = true;
            this.btnDemSoChan.Click += new System.EventHandler(this.btnDemSoChan_Click);
            // 
            // btnUCLN
            // 
            this.btnUCLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUCLN.Location = new System.Drawing.Point(10, 374);
            this.btnUCLN.Name = "btnUCLN";
            this.btnUCLN.Size = new System.Drawing.Size(391, 69);
            this.btnUCLN.TabIndex = 15;
            this.btnUCLN.Text = "UCLN 2 Phần Tử Đầu Tiên";
            this.btnUCLN.UseVisualStyleBackColor = true;
            this.btnUCLN.Click += new System.EventHandler(this.btnUCLN_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.Location = new System.Drawing.Point(10, 4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(132, 87);
            this.btnNhap.TabIndex = 17;
            this.btnNhap.Text = "Nhập 1 Phần Tử";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // lblKetQua
            // 
            this.lblKetQua.BackColor = System.Drawing.Color.Fuchsia;
            this.lblKetQua.Location = new System.Drawing.Point(12, 99);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(601, 194);
            this.lblKetQua.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnUCLN);
            this.Controls.Add(this.btnDemSoChan);
            this.Controls.Add(this.btnDemSoLe);
            this.Controls.Add(this.btnTBMang);
            this.Controls.Add(this.btnSoNguyenTo);
            this.Controls.Add(this.btnSoHoanHao);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnSXTANG);
            this.Controls.Add(this.btnSXGIAM);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtNhap);
            this.Name = "Form1";
            this.Text = "Mảng Số Nguyên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSXGIAM;
        private System.Windows.Forms.Button btnSXTANG;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnSoHoanHao;
        private System.Windows.Forms.Button btnSoNguyenTo;
        private System.Windows.Forms.Button btnTBMang;
        private System.Windows.Forms.Button btnDemSoLe;
        private System.Windows.Forms.Button btnDemSoChan;
        private System.Windows.Forms.Button btnUCLN;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKetQua;
    }
}

