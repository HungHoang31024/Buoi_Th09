namespace bai3._1
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
            this.txtx = new System.Windows.Forms.TextBox();
            this.txtf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "TINH GIA TRI HAM SO";
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(323, 146);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(100, 22);
            this.txtx.TabIndex = 1;
            this.txtx.TextChanged += new System.EventHandler(this.txtx_TextChanged);
            // 
            // txtf
            // 
            this.txtf.Location = new System.Drawing.Point(323, 191);
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(100, 22);
            this.txtf.TabIndex = 2;
            this.txtf.TextChanged += new System.EventHandler(this.txtf_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "x =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "f =";
            // 
            // txtTinh
            // 
            this.txtTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinh.Location = new System.Drawing.Point(289, 339);
            this.txtTinh.Name = "txtTinh";
            this.txtTinh.Size = new System.Drawing.Size(198, 57);
            this.txtTinh.TabIndex = 5;
            this.txtTinh.Text = "Tinh";
            this.txtTinh.UseVisualStyleBackColor = true;
            this.txtTinh.Click += new System.EventHandler(this.txtTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtf);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bai3.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txtf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txtTinh;
    }
}

