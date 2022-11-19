namespace Bai2
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
            this.btnRanDom = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Số Phần Tử Mảng:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(408, 99);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(176, 30);
            this.txtNhap.TabIndex = 1;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // btnRanDom
            // 
            this.btnRanDom.Location = new System.Drawing.Point(604, 73);
            this.btnRanDom.Name = "btnRanDom";
            this.btnRanDom.Size = new System.Drawing.Size(237, 56);
            this.btnRanDom.TabIndex = 2;
            this.btnRanDom.Text = "Tạo Mảng RanDom";
            this.btnRanDom.UseVisualStyleBackColor = true;
            this.btnRanDom.Click += new System.EventHandler(this.btnRanDom_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.BackColor = System.Drawing.Color.Coral;
            this.lblKQ.Location = new System.Drawing.Point(185, 132);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(656, 103);
            this.lblKQ.TabIndex = 3;
            // 
            // btnIn
            // 
            this.btnIn.Enabled = false;
            this.btnIn.Location = new System.Drawing.Point(189, 279);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(163, 74);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "In Mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(671, 279);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(170, 74);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 647);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.btnRanDom);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnRanDom;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThoat;
    }
}

