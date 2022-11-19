namespace Buoi3_bai3
{
    partial class Form3
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
            this.cbWeb = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnReSet = new System.Windows.Forms.Button();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbWeb
            // 
            this.cbWeb.FormattingEnabled = true;
            this.cbWeb.Location = new System.Drawing.Point(224, 121);
            this.cbWeb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbWeb.Name = "cbWeb";
            this.cbWeb.Size = new System.Drawing.Size(235, 35);
            this.cbWeb.TabIndex = 0;
            this.cbWeb.Text = "Liên kết website";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(506, 121);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(146, 37);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnReSet
            // 
            this.btnReSet.Location = new System.Drawing.Point(690, 121);
            this.btnReSet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReSet.Name = "btnReSet";
            this.btnReSet.Size = new System.Drawing.Size(146, 37);
            this.btnReSet.TabIndex = 1;
            this.btnReSet.Text = "ReSet";
            this.btnReSet.UseVisualStyleBackColor = true;
            this.btnReSet.Click += new System.EventHandler(this.btnReSet_Click);
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(224, 183);
            this.txtKq.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKq.Multiline = true;
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(611, 195);
            this.txtKq.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1040, 486);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.btnReSet);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbWeb);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbWeb;
        private Button btnOK;
        private Button btnReSet;
        private TextBox txtKq;
    }
}