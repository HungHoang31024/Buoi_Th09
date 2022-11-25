namespace _6_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboChonHinhVe = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.txtmauvien = new System.Windows.Forms.TextBox();
            this.txtmau = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn hình vẽ";
            // 
            // cboChonHinhVe
            // 
            this.cboChonHinhVe.FormattingEnabled = true;
            this.cboChonHinhVe.Items.AddRange(new object[] {
            "Hình Chữ Nhật",
            "Hình Tròn",
            "Hình Vuông",
            "Hình Elip"});
            this.cboChonHinhVe.Location = new System.Drawing.Point(23, 75);
            this.cboChonHinhVe.Name = "cboChonHinhVe";
            this.cboChonHinhVe.Size = new System.Drawing.Size(151, 32);
            this.cboChonHinhVe.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmauvien);
            this.groupBox1.Controls.Add(this.num);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Border";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(111, 91);
            this.num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(150, 32);
            this.num.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmau);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(23, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fill";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Color";
            // 
            // txtmauvien
            // 
            this.txtmauvien.Location = new System.Drawing.Point(111, 40);
            this.txtmauvien.Name = "txtmauvien";
            this.txtmauvien.Size = new System.Drawing.Size(150, 32);
            this.txtmauvien.TabIndex = 3;
            this.txtmauvien.Click += new System.EventHandler(this.txtmauvien_Click);
            // 
            // txtmau
            // 
            this.txtmau.Location = new System.Drawing.Point(111, 56);
            this.txtmau.Name = "txtmau";
            this.txtmau.Size = new System.Drawing.Size(125, 32);
            this.txtmau.TabIndex = 1;
            this.txtmau.Click += new System.EventHandler(this.txtmau_Click);
            this.txtmau.TextChanged += new System.EventHandler(this.txtmauvien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 540);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboChonHinhVe);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cboChonHinhVe;
        private GroupBox groupBox1;
        private NumericUpDown num;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label4;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private TextBox txtmauvien;
        private TextBox txtmau;
    }
}