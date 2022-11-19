namespace Bai3
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTongMang = new System.Windows.Forms.Button();
            this.btnRanDom = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.brnSLN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(614, 201);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(296, 92);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTongMang
            // 
            this.btnTongMang.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTongMang.Enabled = false;
            this.btnTongMang.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongMang.Location = new System.Drawing.Point(52, 201);
            this.btnTongMang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTongMang.Name = "btnTongMang";
            this.btnTongMang.Size = new System.Drawing.Size(242, 92);
            this.btnTongMang.TabIndex = 10;
            this.btnTongMang.Text = "Tong Mang";
            this.btnTongMang.UseVisualStyleBackColor = false;
            this.btnTongMang.Click += new System.EventHandler(this.btnTongMang_Click);
            // 
            // btnRanDom
            // 
            this.btnRanDom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRanDom.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanDom.Location = new System.Drawing.Point(614, 107);
            this.btnRanDom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRanDom.Name = "btnRanDom";
            this.btnRanDom.Size = new System.Drawing.Size(296, 69);
            this.btnRanDom.TabIndex = 8;
            this.btnRanDom.Text = "Tạo Mảng RanDom";
            this.btnRanDom.UseVisualStyleBackColor = false;
            this.btnRanDom.Click += new System.EventHandler(this.btnRanDom_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(334, 139);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(253, 29);
            this.txtNhap.TabIndex = 7;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập Số Phần Tử Mảng:";
            // 
            // brnSLN
            // 
            this.brnSLN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.brnSLN.Enabled = false;
            this.brnSLN.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnSLN.Location = new System.Drawing.Point(334, 200);
            this.brnSLN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brnSLN.Name = "brnSLN";
            this.brnSLN.Size = new System.Drawing.Size(253, 93);
            this.brnSLN.TabIndex = 12;
            this.brnSLN.Text = "Số Lớn Nhất";
            this.brnSLN.UseVisualStyleBackColor = false;
            this.brnSLN.Click += new System.EventHandler(this.brnSLN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(969, 398);
            this.Controls.Add(this.brnSLN);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTongMang);
            this.Controls.Add(this.btnRanDom);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTongMang;
        private System.Windows.Forms.Button btnRanDom;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brnSLN;
    }
}

