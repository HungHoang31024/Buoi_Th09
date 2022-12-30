namespace Quản_Lý_Bán_Sach
{
    partial class Chức_năng_nhân_viên
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chức_năng_nhân_viên));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmQLSach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDonBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHDBH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHDan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(-27, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(994, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHÀO MỪNG BẠN ĐẾN VỚI CỬA HÀNG SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQLSach,
            this.tsmHDBH,
            this.tsmHDan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmQLSach
            // 
            this.tsmQLSach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDonBanHang});
            this.tsmQLSach.Image = ((System.Drawing.Image)(resources.GetObject("tsmQLSach.Image")));
            this.tsmQLSach.Name = "tsmQLSach";
            this.tsmQLSach.Size = new System.Drawing.Size(148, 29);
            this.tsmQLSach.Text = "Quản lí sách";
            this.tsmQLSach.Click += new System.EventHandler(this.tsmQLSach_Click);
            // 
            // tsmDonBanHang
            // 
            this.tsmDonBanHang.Name = "tsmDonBanHang";
            this.tsmDonBanHang.Size = new System.Drawing.Size(102, 34);
            // 
            // tsmHDBH
            // 
            this.tsmHDBH.Image = ((System.Drawing.Image)(resources.GetObject("tsmHDBH.Image")));
            this.tsmHDBH.Name = "tsmHDBH";
            this.tsmHDBH.Size = new System.Drawing.Size(166, 29);
            this.tsmHDBH.Text = "Đơn bán hàng";
            this.tsmHDBH.Click += new System.EventHandler(this.tsmHDBH_Click);
            // 
            // tsmHDan
            // 
            this.tsmHDan.Image = ((System.Drawing.Image)(resources.GetObject("tsmHDan.Image")));
            this.tsmHDan.Name = "tsmHDan";
            this.tsmHDan.Size = new System.Drawing.Size(143, 29);
            this.tsmHDan.Text = "Hướng dẫn";
            this.tsmHDan.Click += new System.EventHandler(this.tsmHDan_Click);
            // 
            // Chức_năng_nhân_viên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Chức_năng_nhân_viên";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức_năng_nhân_viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmQLSach;
        private ToolStripMenuItem tsmDonBanHang;
        private ToolStripMenuItem tsmHDBH;
        private ToolStripMenuItem tsmHDan;
    }
}