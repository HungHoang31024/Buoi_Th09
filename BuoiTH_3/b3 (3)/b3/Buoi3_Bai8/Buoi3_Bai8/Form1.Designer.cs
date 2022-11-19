namespace Buoi3_Bai8
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
            this.cmbten = new System.Windows.Forms.ComboBox();
            this.lblHoten = new System.Windows.Forms.Label();
            this.btnHTLoichao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbten
            // 
            this.cmbten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbten.FormattingEnabled = true;
            this.cmbten.Items.AddRange(new object[] {
            "Nguyen Van A",
            "Tran Van B",
            "Ly Thi D"});
            this.cmbten.Location = new System.Drawing.Point(441, 116);
            this.cmbten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbten.Name = "cmbten";
            this.cmbten.Size = new System.Drawing.Size(235, 35);
            this.cmbten.TabIndex = 0;
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoten.Location = new System.Drawing.Point(342, 119);
            this.lblHoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(77, 27);
            this.lblHoten.TabIndex = 1;
            this.lblHoten.Text = "Họ tên";
            // 
            // btnHTLoichao
            // 
            this.btnHTLoichao.Location = new System.Drawing.Point(425, 192);
            this.btnHTLoichao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHTLoichao.Name = "btnHTLoichao";
            this.btnHTLoichao.Size = new System.Drawing.Size(167, 37);
            this.btnHTLoichao.TabIndex = 2;
            this.btnHTLoichao.Text = "Hien loi chao";
            this.btnHTLoichao.UseVisualStyleBackColor = true;
            this.btnHTLoichao.Click += new System.EventHandler(this.btnHTLoichao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1040, 486);
            this.Controls.Add(this.btnHTLoichao);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.cmbten);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbten;
        private Label lblHoten;
        private Button btnHTLoichao;
    }
}