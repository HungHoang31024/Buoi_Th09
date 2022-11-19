namespace Buoi3_Bai5
{
    partial class frmLenhLap
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
            this.lblM = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.grbChon = new System.Windows.Forms.GroupBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.grbChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(35, 93);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(111, 26);
            this.lblM.TabIndex = 0;
            this.lblM.Text = "Nhập m = ";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(35, 151);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(105, 26);
            this.lblN.TabIndex = 1;
            this.lblN.Text = "Nhập n = ";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(35, 238);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(114, 26);
            this.lblKetQua.TabIndex = 1;
            this.lblKetQua.Text = "kết quả là: ";
            // 
            // grbChon
            // 
            this.grbChon.Controls.Add(this.rad2);
            this.grbChon.Controls.Add(this.rad1);
            this.grbChon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChon.Location = new System.Drawing.Point(355, 56);
            this.grbChon.Name = "grbChon";
            this.grbChon.Size = new System.Drawing.Size(405, 160);
            this.grbChon.TabIndex = 2;
            this.grbChon.TabStop = false;
            this.grbChon.Text = "Chọn";
            // 
            // txtM
            // 
            this.txtM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM.Location = new System.Drawing.Point(170, 93);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(161, 30);
            this.txtM.TabIndex = 3;
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(170, 151);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(161, 30);
            this.txtN.TabIndex = 3;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(40, 277);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(701, 34);
            this.txtKetQua.TabIndex = 3;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(40, 326);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(149, 77);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính ";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(325, 326);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 77);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(597, 326);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(144, 77);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(60, 51);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(279, 30);
            this.rad1.TabIndex = 0;
            this.rad1.TabStop = true;
            this.rad1.Text = "Các ước chung của n và m";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(60, 109);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(326, 30);
            this.rad2.TabIndex = 0;
            this.rad2.TabStop = true;
            this.rad2.Text = "Ước chung lớn nhất của m và n";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // frmLenhLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.grbChon);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblM);
            this.Name = "frmLenhLap";
            this.Text = "Lệnh lặp";
            this.grbChon.ResumeLayout(false);
            this.grbChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.GroupBox grbChon;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}

