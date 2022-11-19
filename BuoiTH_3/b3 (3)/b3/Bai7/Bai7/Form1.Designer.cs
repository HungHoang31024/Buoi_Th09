namespace Bai7
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
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tinhToanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHEP TOAN DON GIAN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(294, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong Tin";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(47, 58);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(119, 22);
            this.txtB.TabIndex = 3;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(47, 27);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(119, 22);
            this.txtA.TabIndex = 2;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "b:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "a:";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(294, 326);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(200, 22);
            this.txtKQ.TabIndex = 2;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ket Qua:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tinhToanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tinhToanToolStripMenuItem
            // 
            this.tinhToanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tongToolStripMenuItem,
            this.hieuToolStripMenuItem,
            this.tichToolStripMenuItem,
            this.thuongToolStripMenuItem});
            this.tinhToanToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tinhToanToolStripMenuItem.Name = "tinhToanToolStripMenuItem";
            this.tinhToanToolStripMenuItem.Size = new System.Drawing.Size(101, 27);
            this.tinhToanToolStripMenuItem.Text = "Tinh Toan";
            // 
            // tongToolStripMenuItem
            // 
            this.tongToolStripMenuItem.Name = "tongToolStripMenuItem";
            this.tongToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.tongToolStripMenuItem.Text = "Tong";
            this.tongToolStripMenuItem.Click += new System.EventHandler(this.tongToolStripMenuItem_Click);
            // 
            // hieuToolStripMenuItem
            // 
            this.hieuToolStripMenuItem.Name = "hieuToolStripMenuItem";
            this.hieuToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.hieuToolStripMenuItem.Text = "Hieu";
            this.hieuToolStripMenuItem.Click += new System.EventHandler(this.hieuToolStripMenuItem_Click);
            // 
            // tichToolStripMenuItem
            // 
            this.tichToolStripMenuItem.Name = "tichToolStripMenuItem";
            this.tichToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.tichToolStripMenuItem.Text = "Tich";
            this.tichToolStripMenuItem.Click += new System.EventHandler(this.tichToolStripMenuItem_Click);
            // 
            // thuongToolStripMenuItem
            // 
            this.thuongToolStripMenuItem.Name = "thuongToolStripMenuItem";
            this.thuongToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.thuongToolStripMenuItem.Text = "Thuong";
            this.thuongToolStripMenuItem.Click += new System.EventHandler(this.thuongToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bai7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tinhToanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuongToolStripMenuItem;
    }
}

