namespace Quản_Lý_Bán_Sach
{
    partial class Đăng_nhập
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Đăng_nhập));
            this.btnDN = new System.Windows.Forms.Button();
            this.lablTTK = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.lblMK = new System.Windows.Forms.Label();
            this.txtTTK = new System.Windows.Forms.TextBox();
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.Color.DarkGray;
            this.btnDN.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDN.Location = new System.Drawing.Point(292, 289);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(177, 80);
            this.btnDN.TabIndex = 0;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // lablTTK
            // 
            this.lablTTK.AutoSize = true;
            this.lablTTK.BackColor = System.Drawing.Color.DarkGray;
            this.lablTTK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lablTTK.ForeColor = System.Drawing.Color.Black;
            this.lablTTK.Location = new System.Drawing.Point(82, 100);
            this.lablTTK.Name = "lablTTK";
            this.lablTTK.Size = new System.Drawing.Size(144, 27);
            this.lablTTK.TabIndex = 1;
            this.lablTTK.Text = "Tên tài khoản";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(279, 175);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(284, 30);
            this.txtMK.TabIndex = 0;
            this.txtMK.UseSystemPasswordChar = true;
            this.txtMK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMK_KeyDown);
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.BackColor = System.Drawing.Color.DarkGray;
            this.lblMK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMK.Location = new System.Drawing.Point(82, 183);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(104, 27);
            this.lblMK.TabIndex = 1;
            this.lblMK.Text = "Mật khẩu";
            // 
            // txtTTK
            // 
            this.txtTTK.Location = new System.Drawing.Point(279, 100);
            this.txtTTK.Name = "txtTTK";
            this.txtTTK.Size = new System.Drawing.Size(284, 30);
            this.txtTTK.TabIndex = 0;
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbHienMK.Location = new System.Drawing.Point(494, 244);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(144, 26);
            this.cbHienMK.TabIndex = 4;
            this.cbHienMK.Text = "Hiện mật khẩu";
            this.cbHienMK.UseVisualStyleBackColor = false;
            this.cbHienMK.Click += new System.EventHandler(this.cbHienMK_Click);
            // 
            // Đăng_nhập
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 525);
            this.Controls.Add(this.cbHienMK);
            this.Controls.Add(this.txtTTK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.lablTTK);
            this.Controls.Add(this.btnDN);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Đăng_nhập";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng_nhập";
            this.Load += new System.EventHandler(this.Đăng_nhập_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDN;
        private Label lablTTK;
        private TextBox txtMK;
        private Label lblMK;
        private TextBox txtTTK;
        private CheckBox cbHienMK;
    }
}