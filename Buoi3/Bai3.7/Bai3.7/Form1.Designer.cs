namespace Bai3._7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoC = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaiPt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIA PHUONG TRINH BAC 2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoC);
            this.groupBox1.Controls.Add(this.txtSoB);
            this.groupBox1.Controls.Add(this.txtSoA);
            this.groupBox1.Location = new System.Drawing.Point(227, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phuong Trinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "c:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "b:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "a:";
            // 
            // txtSoC
            // 
            this.txtSoC.Location = new System.Drawing.Point(106, 123);
            this.txtSoC.Name = "txtSoC";
            this.txtSoC.Size = new System.Drawing.Size(154, 22);
            this.txtSoC.TabIndex = 2;
            this.txtSoC.TextChanged += new System.EventHandler(this.txtSoC_TextChanged);
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(106, 79);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(154, 22);
            this.txtSoB.TabIndex = 1;
            this.txtSoB.TextChanged += new System.EventHandler(this.txtSoB_TextChanged);
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(106, 35);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(154, 22);
            this.txtSoA.TabIndex = 0;
            this.txtSoA.TextChanged += new System.EventHandler(this.txtSoA_TextChanged);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(243, 293);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(284, 22);
            this.txtKQ.TabIndex = 6;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ket qua:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtGiaiPt
            // 
            this.txtGiaiPt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaiPt.Location = new System.Drawing.Point(333, 375);
            this.txtGiaiPt.Name = "txtGiaiPt";
            this.txtGiaiPt.Size = new System.Drawing.Size(130, 44);
            this.txtGiaiPt.TabIndex = 8;
            this.txtGiaiPt.Text = "Giai";
            this.txtGiaiPt.UseVisualStyleBackColor = true;
            this.txtGiaiPt.Click += new System.EventHandler(this.txtGiaiPt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGiaiPt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bai3.7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoC;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button txtGiaiPt;
    }
}

