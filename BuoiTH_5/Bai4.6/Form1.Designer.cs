namespace Bai4._6
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
            this.txtXuat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radbtnNhap = new System.Windows.Forms.RadioButton();
            this.radbtnGiatriNN = new System.Windows.Forms.RadioButton();
            this.radbtnLietkechan = new System.Windows.Forms.RadioButton();
            this.radbtnChancuoi = new System.Windows.Forms.RadioButton();
            this.radbtnTongle = new System.Windows.Forms.RadioButton();
            this.radbtnTongchan = new System.Windows.Forms.RadioButton();
            this.radBtnDemchan = new System.Windows.Forms.RadioButton();
            this.radBtnDemle = new System.Windows.Forms.RadioButton();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(63, 35);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(520, 28);
            this.txtNhap.TabIndex = 1;
            // 
            // txtXuat
            // 
            this.txtXuat.Location = new System.Drawing.Point(63, 149);
            this.txtXuat.Name = "txtXuat";
            this.txtXuat.Size = new System.Drawing.Size(521, 28);
            this.txtXuat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập Mảng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "In Mảng:";
            // 
            // radbtnNhap
            // 
            this.radbtnNhap.AutoSize = true;
            this.radbtnNhap.Location = new System.Drawing.Point(69, 294);
            this.radbtnNhap.Name = "radbtnNhap";
            this.radbtnNhap.Size = new System.Drawing.Size(169, 28);
            this.radbtnNhap.TabIndex = 0;
            this.radbtnNhap.TabStop = true;
            this.radbtnNhap.Text = "Hiện Thị Mảng";
            this.radbtnNhap.UseVisualStyleBackColor = true;
            this.radbtnNhap.CheckedChanged += new System.EventHandler(this.radbtnNhap_CheckedChanged);
            // 
            // radbtnGiatriNN
            // 
            this.radbtnGiatriNN.AutoSize = true;
            this.radbtnGiatriNN.Location = new System.Drawing.Point(69, 412);
            this.radbtnGiatriNN.Name = "radbtnGiatriNN";
            this.radbtnGiatriNN.Size = new System.Drawing.Size(173, 28);
            this.radbtnGiatriNN.TabIndex = 2;
            this.radbtnGiatriNN.TabStop = true;
            this.radbtnGiatriNN.Text = "Giá trị nhỏ nhất";
            this.radbtnGiatriNN.UseVisualStyleBackColor = true;
            // 
            // radbtnLietkechan
            // 
            this.radbtnLietkechan.AutoSize = true;
            this.radbtnLietkechan.Location = new System.Drawing.Point(69, 471);
            this.radbtnLietkechan.Name = "radbtnLietkechan";
            this.radbtnLietkechan.Size = new System.Drawing.Size(201, 28);
            this.radbtnLietkechan.TabIndex = 3;
            this.radbtnLietkechan.TabStop = true;
            this.radbtnLietkechan.Text = "Liệt kê giá trị chẵn";
            this.radbtnLietkechan.UseVisualStyleBackColor = true;
            // 
            // radbtnChancuoi
            // 
            this.radbtnChancuoi.AutoSize = true;
            this.radbtnChancuoi.Location = new System.Drawing.Point(63, 359);
            this.radbtnChancuoi.Name = "radbtnChancuoi";
            this.radbtnChancuoi.Size = new System.Drawing.Size(207, 28);
            this.radbtnChancuoi.TabIndex = 4;
            this.radbtnChancuoi.TabStop = true;
            this.radbtnChancuoi.Text = "Số chẵn cuối cùng";
            this.radbtnChancuoi.UseVisualStyleBackColor = true;
            // 
            // radbtnTongle
            // 
            this.radbtnTongle.AutoSize = true;
            this.radbtnTongle.Location = new System.Drawing.Point(345, 471);
            this.radbtnTongle.Name = "radbtnTongle";
            this.radbtnTongle.Size = new System.Drawing.Size(109, 28);
            this.radbtnTongle.TabIndex = 5;
            this.radbtnTongle.TabStop = true;
            this.radbtnTongle.Text = "Tổng  lẻ";
            this.radbtnTongle.UseVisualStyleBackColor = true;
            // 
            // radbtnTongchan
            // 
            this.radbtnTongchan.AutoSize = true;
            this.radbtnTongchan.Location = new System.Drawing.Point(345, 412);
            this.radbtnTongchan.Name = "radbtnTongchan";
            this.radbtnTongchan.Size = new System.Drawing.Size(132, 28);
            this.radbtnTongchan.TabIndex = 6;
            this.radbtnTongchan.TabStop = true;
            this.radbtnTongchan.Text = "Tổng chẵn";
            this.radbtnTongchan.UseVisualStyleBackColor = true;
            // 
            // radBtnDemchan
            // 
            this.radBtnDemchan.AutoSize = true;
            this.radBtnDemchan.Location = new System.Drawing.Point(345, 348);
            this.radBtnDemchan.Name = "radBtnDemchan";
            this.radBtnDemchan.Size = new System.Drawing.Size(154, 28);
            this.radBtnDemchan.TabIndex = 7;
            this.radBtnDemchan.TabStop = true;
            this.radBtnDemchan.Text = "Đếm số chẳn";
            this.radBtnDemchan.UseVisualStyleBackColor = true;
            // 
            // radBtnDemle
            // 
            this.radBtnDemle.AutoSize = true;
            this.radBtnDemle.Location = new System.Drawing.Point(345, 294);
            this.radBtnDemle.Name = "radBtnDemle";
            this.radBtnDemle.Size = new System.Drawing.Size(125, 28);
            this.radBtnDemle.TabIndex = 8;
            this.radBtnDemle.TabStop = true;
            this.radBtnDemle.Text = "Đếm số lẻ";
            this.radBtnDemle.UseVisualStyleBackColor = true;
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Location = new System.Drawing.Point(211, 201);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(161, 59);
            this.btnTaoMang.TabIndex = 9;
            this.btnTaoMang.Text = "Tạo Mảng";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(626, 618);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.radbtnChancuoi);
            this.Controls.Add(this.radbtnTongchan);
            this.Controls.Add(this.radbtnLietkechan);
            this.Controls.Add(this.radBtnDemchan);
            this.Controls.Add(this.radbtnGiatriNN);
            this.Controls.Add(this.radbtnTongle);
            this.Controls.Add(this.radbtnNhap);
            this.Controls.Add(this.radBtnDemle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtXuat);
            this.Controls.Add(this.txtNhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radbtnNhap;
        private System.Windows.Forms.RadioButton radbtnGiatriNN;
        private System.Windows.Forms.RadioButton radbtnLietkechan;
        private System.Windows.Forms.RadioButton radbtnChancuoi;
        private System.Windows.Forms.RadioButton radbtnTongle;
        private System.Windows.Forms.RadioButton radbtnTongchan;
        private System.Windows.Forms.RadioButton radBtnDemchan;
        private System.Windows.Forms.RadioButton radBtnDemle;
        private System.Windows.Forms.Button btnTaoMang;
    }
}

