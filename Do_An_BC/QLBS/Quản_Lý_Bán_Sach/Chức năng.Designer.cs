namespace Quản_Lý_Bán_Sach
{
    partial class Chức_năng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chức_năng));
            this.lblQLCH = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.frmQLBS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTke = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHDan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQLCH
            // 
            this.lblQLCH.AutoSize = true;
            this.lblQLCH.BackColor = System.Drawing.Color.AliceBlue;
            this.lblQLCH.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQLCH.ForeColor = System.Drawing.Color.Blue;
            this.lblQLCH.Location = new System.Drawing.Point(227, 96);
            this.lblQLCH.Name = "lblQLCH";
            this.lblQLCH.Size = new System.Drawing.Size(340, 51);
            this.lblQLCH.TabIndex = 0;
            this.lblQLCH.Text = "Quản lí cửa hàng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmQLBS,
            this.tsmTke,
            this.tsmHDan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmQLBS
            // 
            this.frmQLBS.Image = ((System.Drawing.Image)(resources.GetObject("frmQLBS.Image")));
            this.frmQLBS.Name = "frmQLBS";
            this.frmQLBS.Size = new System.Drawing.Size(148, 29);
            this.frmQLBS.Text = "Quản lí sách";
            this.frmQLBS.Click += new System.EventHandler(this.frmQLBS_Click);
            // 
            // tsmTke
            // 
            this.tsmTke.Image = ((System.Drawing.Image)(resources.GetObject("tsmTke.Image")));
            this.tsmTke.Name = "tsmTke";
            this.tsmTke.Size = new System.Drawing.Size(126, 29);
            this.tsmTke.Text = "Thống kê";
            this.tsmTke.Click += new System.EventHandler(this.tsmTke_Click);
            // 
            // tsmHDan
            // 
            this.tsmHDan.Image = ((System.Drawing.Image)(resources.GetObject("tsmHDan.Image")));
            this.tsmHDan.Name = "tsmHDan";
            this.tsmHDan.Size = new System.Drawing.Size(143, 29);
            this.tsmHDan.Text = "Hướng dẫn";
            this.tsmHDan.Click += new System.EventHandler(this.tsmHDan_Click);
            // 
            // Chức_năng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 505);
            this.Controls.Add(this.lblQLCH);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Chức_năng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức_năng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblQLCH;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem frmQLBS;
        private ToolStripMenuItem tsmTke;
        private ToolStripMenuItem tsmHDan;
    }
}