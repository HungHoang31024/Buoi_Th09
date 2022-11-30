namespace Bai7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbHTron = new System.Windows.Forms.RadioButton();
            this.rdbHCN = new System.Windows.Forms.RadioButton();
            this.rdbHinhVuong = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBK = new System.Windows.Forms.TextBox();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.txtDai = new System.Windows.Forms.TextBox();
            this.txtCanh = new System.Windows.Forms.TextBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbHTron);
            this.groupBox1.Controls.Add(this.rdbHCN);
            this.groupBox1.Controls.Add(this.rdbHinhVuong);
            this.groupBox1.Location = new System.Drawing.Point(57, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // rdbHTron
            // 
            this.rdbHTron.AutoSize = true;
            this.rdbHTron.Location = new System.Drawing.Point(61, 98);
            this.rdbHTron.Name = "rdbHTron";
            this.rdbHTron.Size = new System.Drawing.Size(98, 21);
            this.rdbHTron.TabIndex = 2;
            this.rdbHTron.Text = "Hình Tròn";
            this.rdbHTron.UseVisualStyleBackColor = true;
            this.rdbHTron.Click += new System.EventHandler(this.rdbHTron_Click);
            // 
            // rdbHCN
            // 
            this.rdbHCN.AutoSize = true;
            this.rdbHCN.Location = new System.Drawing.Point(61, 59);
            this.rdbHCN.Name = "rdbHCN";
            this.rdbHCN.Size = new System.Drawing.Size(132, 21);
            this.rdbHCN.TabIndex = 1;
            this.rdbHCN.Text = "Hình Chữ Nhật";
            this.rdbHCN.UseVisualStyleBackColor = true;
            this.rdbHCN.Click += new System.EventHandler(this.rdbHCN_Click);
            // 
            // rdbHinhVuong
            // 
            this.rdbHinhVuong.AutoSize = true;
            this.rdbHinhVuong.Checked = true;
            this.rdbHinhVuong.Location = new System.Drawing.Point(61, 23);
            this.rdbHinhVuong.Name = "rdbHinhVuong";
            this.rdbHinhVuong.Size = new System.Drawing.Size(111, 21);
            this.rdbHinhVuong.TabIndex = 0;
            this.rdbHinhVuong.TabStop = true;
            this.rdbHinhVuong.Text = "Hình Vuông";
            this.rdbHinhVuong.UseVisualStyleBackColor = true;
            this.rdbHinhVuong.Click += new System.EventHandler(this.rdbHinhVuong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBK);
            this.groupBox2.Controls.Add(this.txtRong);
            this.groupBox2.Controls.Add(this.txtDai);
            this.groupBox2.Controls.Add(this.txtCanh);
            this.groupBox2.Location = new System.Drawing.Point(313, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bán Kính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rộng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dài:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cạnh:";
            // 
            // txtBK
            // 
            this.txtBK.Enabled = false;
            this.txtBK.Location = new System.Drawing.Point(335, 74);
            this.txtBK.Name = "txtBK";
            this.txtBK.Size = new System.Drawing.Size(125, 24);
            this.txtBK.TabIndex = 3;
            // 
            // txtRong
            // 
            this.txtRong.Enabled = false;
            this.txtRong.Location = new System.Drawing.Point(335, 30);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(125, 24);
            this.txtRong.TabIndex = 2;
            // 
            // txtDai
            // 
            this.txtDai.Enabled = false;
            this.txtDai.Location = new System.Drawing.Point(79, 70);
            this.txtDai.Name = "txtDai";
            this.txtDai.Size = new System.Drawing.Size(125, 24);
            this.txtDai.TabIndex = 1;
            // 
            // txtCanh
            // 
            this.txtCanh.Enabled = false;
            this.txtCanh.Location = new System.Drawing.Point(79, 30);
            this.txtCanh.Name = "txtCanh";
            this.txtCanh.Size = new System.Drawing.Size(125, 24);
            this.txtCanh.TabIndex = 0;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThucHien.Location = new System.Drawing.Point(93, 283);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(156, 65);
            this.btnThucHien.TabIndex = 2;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(465, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 65);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tính Diện Tích và Chu Vi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Bài Tập";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdbHTron;
        private RadioButton rdbHCN;
        private RadioButton rdbHinhVuong;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtBK;
        private TextBox txtRong;
        private TextBox txtDai;
        private TextBox txtCanh;
        private Button btnThucHien;
        private Button btnExit;
        private Label label1;
    }
}