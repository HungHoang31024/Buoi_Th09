namespace Quản_Lý_Bán_Sach
{
    partial class Người_sử_dụng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Người_sử_dụng));
            this.grb = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radNV = new System.Windows.Forms.RadioButton();
            this.radQL = new System.Windows.Forms.RadioButton();
            this.grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grb
            // 
            this.grb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grb.BackgroundImage")));
            this.grb.Controls.Add(this.pictureBox1);
            this.grb.Controls.Add(this.radNV);
            this.grb.Controls.Add(this.radQL);
            this.grb.Location = new System.Drawing.Point(562, 153);
            this.grb.Name = "grb";
            this.grb.Size = new System.Drawing.Size(346, 165);
            this.grb.TabIndex = 0;
            this.grb.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // radNV
            // 
            this.radNV.AutoSize = true;
            this.radNV.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radNV.Location = new System.Drawing.Point(150, 89);
            this.radNV.Name = "radNV";
            this.radNV.Size = new System.Drawing.Size(180, 40);
            this.radNV.TabIndex = 0;
            this.radNV.Text = "Nhân viên";
            this.radNV.UseVisualStyleBackColor = true;
            this.radNV.CheckedChanged += new System.EventHandler(this.radNV_CheckedChanged);
            // 
            // radQL
            // 
            this.radQL.AutoSize = true;
            this.radQL.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radQL.Location = new System.Drawing.Point(149, 23);
            this.radQL.Name = "radQL";
            this.radQL.Size = new System.Drawing.Size(143, 40);
            this.radQL.TabIndex = 0;
            this.radQL.Text = "Quản lí";
            this.radQL.UseVisualStyleBackColor = true;
            this.radQL.CheckedChanged += new System.EventHandler(this.radQL_CheckedChanged);
            // 
            // Người_sử_dụng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 493);
            this.Controls.Add(this.grb);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Người_sử_dụng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người_sử_dụng";
            this.Load += new System.EventHandler(this.Người_sử_dụng_Load);
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grb;
        private PictureBox pictureBox1;
        private RadioButton radNV;
        private RadioButton radQL;
    }
}