namespace Buoi3_bai4
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnKQ = new System.Windows.Forms.Button();
            this.grbCKchu = new System.Windows.Forms.GroupBox();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoten = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbCKchu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 390);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(289, 392);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(450, 35);
            this.txtKQ.TabIndex = 1;
            this.txtKQ.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(45, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(43, 133);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(147, 31);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "checkBox1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(43, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 31);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnKQ
            // 
            this.btnKQ.BackColor = System.Drawing.SystemColors.Menu;
            this.btnKQ.Location = new System.Drawing.Point(45, 390);
            this.btnKQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(146, 37);
            this.btnKQ.TabIndex = 0;
            this.btnKQ.Text = "Kết quả";
            this.btnKQ.UseVisualStyleBackColor = false;
            this.btnKQ.Click += new System.EventHandler(this.button2_Click);
            // 
            // grbCKchu
            // 
            this.grbCKchu.Controls.Add(this.rad2);
            this.grbCKchu.Controls.Add(this.rad1);
            this.grbCKchu.Location = new System.Drawing.Point(45, 170);
            this.grbCKchu.Name = "grbCKchu";
            this.grbCKchu.Size = new System.Drawing.Size(654, 200);
            this.grbCKchu.TabIndex = 2;
            this.grbCKchu.TabStop = false;
            this.grbCKchu.Text = "Chọn kiểu chữ";
            this.grbCKchu.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rad2.Location = new System.Drawing.Point(43, 132);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(185, 30);
            this.rad2.TabIndex = 0;
            this.rad2.TabStop = true;
            this.rad2.Text = "CHỮ IN HOA";
            this.rad2.UseVisualStyleBackColor = true;
            this.rad2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rad1.Location = new System.Drawing.Point(43, 60);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(160, 30);
            this.rad1.TabIndex = 0;
            this.rad1.TabStop = true;
            this.rad1.Text = "Chữ thường";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(220, 82);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(614, 35);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.BackColor = System.Drawing.SystemColors.Menu;
            this.lblHoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblHoten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblHoten.Location = new System.Drawing.Point(57, 82);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(136, 27);
            this.lblHoten.TabIndex = 3;
            this.lblHoten.Text = "Nhập họ tên:";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(722, 212);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(722, 300);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 34);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1040, 486);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.grbCKchu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKQ);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Đổi kiểu chữ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbCKchu.ResumeLayout(false);
            this.grbCKchu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox txtKQ;
        private GroupBox groupBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button btnKQ;
        private GroupBox grbCKchu;
        private TextBox txtHoTen;
        private Label lblHoten;
        private RadioButton rad2;
        private RadioButton rad1;
        private Button btnXoa;
        private Button btnThoat;
    }
}