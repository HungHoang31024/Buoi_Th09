namespace bài4._5
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
            this.grBMangGoc = new System.Windows.Forms.GroupBox();
            this.lblNhapMangGoc = new System.Windows.Forms.Label();
            this.grBkQua = new System.Windows.Forms.GroupBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnXuatMangNN = new System.Windows.Forms.Button();
            this.btnTongGiaTriM = new System.Windows.Forms.Button();
            this.btnDemSoPtLe = new System.Windows.Forms.Button();
            this.btnTongGtPTLe = new System.Windows.Forms.Button();
            this.btntimPtNhoN = new System.Windows.Forms.Button();
            this.btnTangPtLen2 = new System.Windows.Forms.Button();
            this.btnMangTang = new System.Windows.Forms.Button();
            this.btnMangGiam = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grBMangGoc.SuspendLayout();
            this.grBkQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBMangGoc
            // 
            this.grBMangGoc.Controls.Add(this.lblNhapMangGoc);
            this.grBMangGoc.Location = new System.Drawing.Point(174, 15);
            this.grBMangGoc.Margin = new System.Windows.Forms.Padding(4);
            this.grBMangGoc.Name = "grBMangGoc";
            this.grBMangGoc.Padding = new System.Windows.Forms.Padding(4);
            this.grBMangGoc.Size = new System.Drawing.Size(858, 103);
            this.grBMangGoc.TabIndex = 0;
            this.grBMangGoc.TabStop = false;
            this.grBMangGoc.Text = "Mảng Gốc";
            // 
            // lblNhapMangGoc
            // 
            this.lblNhapMangGoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblNhapMangGoc.Location = new System.Drawing.Point(8, 28);
            this.lblNhapMangGoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapMangGoc.Name = "lblNhapMangGoc";
            this.lblNhapMangGoc.Size = new System.Drawing.Size(843, 71);
            this.lblNhapMangGoc.TabIndex = 2;
            // 
            // grBkQua
            // 
            this.grBkQua.Controls.Add(this.lblKetQua);
            this.grBkQua.Location = new System.Drawing.Point(174, 143);
            this.grBkQua.Margin = new System.Windows.Forms.Padding(4);
            this.grBkQua.Name = "grBkQua";
            this.grBkQua.Padding = new System.Windows.Forms.Padding(4);
            this.grBkQua.Size = new System.Drawing.Size(858, 106);
            this.grBkQua.TabIndex = 1;
            this.grBkQua.TabStop = false;
            this.grBkQua.Text = "Kết Quả";
            // 
            // lblKetQua
            // 
            this.lblKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblKetQua.Location = new System.Drawing.Point(4, 28);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(847, 74);
            this.lblKetQua.TabIndex = 0;
            // 
            // btnXuatMangNN
            // 
            this.btnXuatMangNN.Location = new System.Drawing.Point(174, 303);
            this.btnXuatMangNN.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatMangNN.Name = "btnXuatMangNN";
            this.btnXuatMangNN.Size = new System.Drawing.Size(362, 65);
            this.btnXuatMangNN.TabIndex = 2;
            this.btnXuatMangNN.Text = "Xuất Mảng Ngẫu Nhiên";
            this.btnXuatMangNN.UseVisualStyleBackColor = true;
            this.btnXuatMangNN.Click += new System.EventHandler(this.btnXuatMangNN_Click);
            // 
            // btnTongGiaTriM
            // 
            this.btnTongGiaTriM.Location = new System.Drawing.Point(174, 375);
            this.btnTongGiaTriM.Margin = new System.Windows.Forms.Padding(4);
            this.btnTongGiaTriM.Name = "btnTongGiaTriM";
            this.btnTongGiaTriM.Size = new System.Drawing.Size(362, 75);
            this.btnTongGiaTriM.TabIndex = 3;
            this.btnTongGiaTriM.Text = "Tính Tổng Giá Trị Mảng";
            this.btnTongGiaTriM.UseVisualStyleBackColor = true;
            this.btnTongGiaTriM.Click += new System.EventHandler(this.btnTongGiaTriM_Click);
            // 
            // btnDemSoPtLe
            // 
            this.btnDemSoPtLe.Location = new System.Drawing.Point(174, 458);
            this.btnDemSoPtLe.Margin = new System.Windows.Forms.Padding(4);
            this.btnDemSoPtLe.Name = "btnDemSoPtLe";
            this.btnDemSoPtLe.Size = new System.Drawing.Size(362, 73);
            this.btnDemSoPtLe.TabIndex = 4;
            this.btnDemSoPtLe.Text = "Đếm số phần tử lẻ";
            this.btnDemSoPtLe.UseVisualStyleBackColor = true;
            this.btnDemSoPtLe.Click += new System.EventHandler(this.btnDemSoPtLe_Click);
            // 
            // btnTongGtPTLe
            // 
            this.btnTongGtPTLe.Location = new System.Drawing.Point(174, 537);
            this.btnTongGtPTLe.Margin = new System.Windows.Forms.Padding(4);
            this.btnTongGtPTLe.Name = "btnTongGtPTLe";
            this.btnTongGtPTLe.Size = new System.Drawing.Size(362, 77);
            this.btnTongGtPTLe.TabIndex = 5;
            this.btnTongGtPTLe.Text = "Tổng Giá Trị Phần Tử Lẻ";
            this.btnTongGtPTLe.UseVisualStyleBackColor = true;
            this.btnTongGtPTLe.Click += new System.EventHandler(this.btnTongGtPTLe_Click);
            // 
            // btntimPtNhoN
            // 
            this.btntimPtNhoN.Location = new System.Drawing.Point(658, 303);
            this.btntimPtNhoN.Margin = new System.Windows.Forms.Padding(4);
            this.btntimPtNhoN.Name = "btntimPtNhoN";
            this.btntimPtNhoN.Size = new System.Drawing.Size(374, 65);
            this.btntimPtNhoN.TabIndex = 6;
            this.btntimPtNhoN.Text = "Tìm Phần Tử Nhỏ Nhất";
            this.btntimPtNhoN.UseVisualStyleBackColor = true;
            this.btntimPtNhoN.Click += new System.EventHandler(this.btntimPtNhoN_Click);
            // 
            // btnTangPtLen2
            // 
            this.btnTangPtLen2.Location = new System.Drawing.Point(658, 375);
            this.btnTangPtLen2.Margin = new System.Windows.Forms.Padding(4);
            this.btnTangPtLen2.Name = "btnTangPtLen2";
            this.btnTangPtLen2.Size = new System.Drawing.Size(374, 75);
            this.btnTangPtLen2.TabIndex = 7;
            this.btnTangPtLen2.Text = "Tăng Mỗi Ptử Mảng Lên 2";
            this.btnTangPtLen2.UseVisualStyleBackColor = true;
            this.btnTangPtLen2.Click += new System.EventHandler(this.btnTangPtLen2_Click);
            // 
            // btnMangTang
            // 
            this.btnMangTang.Location = new System.Drawing.Point(658, 458);
            this.btnMangTang.Margin = new System.Windows.Forms.Padding(4);
            this.btnMangTang.Name = "btnMangTang";
            this.btnMangTang.Size = new System.Drawing.Size(374, 73);
            this.btnMangTang.TabIndex = 8;
            this.btnMangTang.Text = "Sắp  Mảng Tăng";
            this.btnMangTang.UseVisualStyleBackColor = true;
            this.btnMangTang.Click += new System.EventHandler(this.btnMangTang_Click);
            // 
            // btnMangGiam
            // 
            this.btnMangGiam.Location = new System.Drawing.Point(658, 537);
            this.btnMangGiam.Margin = new System.Windows.Forms.Padding(4);
            this.btnMangGiam.Name = "btnMangGiam";
            this.btnMangGiam.Size = new System.Drawing.Size(374, 77);
            this.btnMangGiam.TabIndex = 9;
            this.btnMangGiam.Text = "Sắp Mảng Giảm";
            this.btnMangGiam.UseVisualStyleBackColor = true;
            this.btnMangGiam.Click += new System.EventHandler(this.btnMangGiam_Click);
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReset.Location = new System.Drawing.Point(28, 117);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 79);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1059, 117);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 79);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1200, 648);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMangGiam);
            this.Controls.Add(this.btnMangTang);
            this.Controls.Add(this.btnTangPtLen2);
            this.Controls.Add(this.btntimPtNhoN);
            this.Controls.Add(this.btnTongGtPTLe);
            this.Controls.Add(this.btnDemSoPtLe);
            this.Controls.Add(this.btnTongGiaTriM);
            this.Controls.Add(this.btnXuatMangNN);
            this.Controls.Add(this.grBkQua);
            this.Controls.Add(this.grBMangGoc);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Working with Array";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grBMangGoc.ResumeLayout(false);
            this.grBkQua.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBMangGoc;
        private System.Windows.Forms.Label lblNhapMangGoc;
        private System.Windows.Forms.GroupBox grBkQua;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnXuatMangNN;
        private System.Windows.Forms.Button btnTongGiaTriM;
        private System.Windows.Forms.Button btnDemSoPtLe;
        private System.Windows.Forms.Button btnTongGtPTLe;
        private System.Windows.Forms.Button btntimPtNhoN;
        private System.Windows.Forms.Button btnTangPtLen2;
        private System.Windows.Forms.Button btnMangTang;
        private System.Windows.Forms.Button btnMangGiam;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
    }
}

