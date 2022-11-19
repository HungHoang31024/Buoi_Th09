namespace Buoi3_bai2
{
    partial class Form2
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
            this.grbTTDN = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblMK = new System.Windows.Forms.Label();
            this.lblTDN = new System.Windows.Forms.Label();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.chkNho = new System.Windows.Forms.CheckBox();
            this.grbTTDN.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTTDN
            // 
            this.grbTTDN.Controls.Add(this.txtPass);
            this.grbTTDN.Controls.Add(this.txtUser);
            this.grbTTDN.Controls.Add(this.lblMK);
            this.grbTTDN.Controls.Add(this.lblTDN);
            this.grbTTDN.Location = new System.Drawing.Point(240, 116);
            this.grbTTDN.Name = "grbTTDN";
            this.grbTTDN.Size = new System.Drawing.Size(509, 237);
            this.grbTTDN.TabIndex = 0;
            this.grbTTDN.TabStop = false;
            this.grbTTDN.Text = "Thông Tin Đăng Nhập";
            this.grbTTDN.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(225, 143);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(150, 35);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(225, 57);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(150, 35);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Location = new System.Drawing.Point(52, 151);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(109, 27);
            this.lblMK.TabIndex = 0;
            this.lblMK.Text = "Mật Khẩu";
            this.lblMK.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTDN
            // 
            this.lblTDN.AutoSize = true;
            this.lblTDN.Location = new System.Drawing.Point(43, 60);
            this.lblTDN.Name = "lblTDN";
            this.lblTDN.Size = new System.Drawing.Size(164, 27);
            this.lblTDN.TabIndex = 0;
            this.lblTDN.Text = "Tên Đăng Nhập";
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDangnhap.Location = new System.Drawing.Point(283, 408);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(137, 34);
            this.btnDangnhap.TabIndex = 1;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnXoa.Location = new System.Drawing.Point(570, 408);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 34);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // chkNho
            // 
            this.chkNho.AutoSize = true;
            this.chkNho.Location = new System.Drawing.Point(297, 358);
            this.chkNho.Name = "chkNho";
            this.chkNho.Size = new System.Drawing.Size(116, 31);
            this.chkNho.TabIndex = 2;
            this.chkNho.Text = "Ghi nhớ";
            this.chkNho.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1040, 486);
            this.Controls.Add(this.chkNho);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.grbTTDN);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.Text = "Đăng Nhập Hệ Thống";
            this.grbTTDN.ResumeLayout(false);
            this.grbTTDN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grbTTDN;
        private Label lblMK;
        private Label lblTDN;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnDangnhap;
        private Button btnXoa;
        private CheckBox chkNho;
    }
}