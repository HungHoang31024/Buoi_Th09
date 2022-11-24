namespace Bai_6._2
{
    partial class Bài02
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
            this.tvThuMuc = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // tvThuMuc
            // 
            this.tvThuMuc.Location = new System.Drawing.Point(10, 9);
            this.tvThuMuc.Name = "tvThuMuc";
            this.tvThuMuc.Size = new System.Drawing.Size(287, 502);
            this.tvThuMuc.TabIndex = 0;
            this.tvThuMuc.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvThuMuc_BeforeExpand);
            this.tvThuMuc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvThuMuc_AfterSelect);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(315, 305);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(665, 201);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Click += new System.EventHandler(this.flowLayoutPanel1_Click);
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.ErrorImage = null;
            this.picHinhAnh.InitialImage = null;
            this.picHinhAnh.Location = new System.Drawing.Point(315, 13);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(665, 286);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinhAnh.TabIndex = 2;
            this.picHinhAnh.TabStop = false;
            this.picHinhAnh.WaitOnLoad = true;
            this.picHinhAnh.Click += new System.EventHandler(this.picHinhAnh_Click);
            // 
            // Bài02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 518);
            this.Controls.Add(this.picHinhAnh);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tvThuMuc);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Bài02";
            this.Load += new System.EventHandler(this.Bài02_Load);
            this.Click += new System.EventHandler(this.Bài02_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView tvThuMuc;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox picHinhAnh;
    }
}