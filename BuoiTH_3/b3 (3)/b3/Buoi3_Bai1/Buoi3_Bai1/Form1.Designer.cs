namespace Buoi3_Bai1
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
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblTDN = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.ckbGN = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDangnhap.Location = new System.Drawing.Point(239, 329);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(136, 34);
            this.btnDangnhap.TabIndex = 0;
            this.btnDangnhap.Text = "Đăng Nhập";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXoa.Location = new System.Drawing.Point(436, 329);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDung
            // 
            this.btnDung.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDung.Location = new System.Drawing.Point(616, 329);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(112, 34);
            this.btnDung.TabIndex = 0;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = false;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtUser.Location = new System.Drawing.Point(441, 162);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(287, 35);
            this.txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Info;
            this.txtPass.Location = new System.Drawing.Point(441, 235);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(287, 35);
            this.txtPass.TabIndex = 1;
            // 
            // lblTDN
            // 
            this.lblTDN.AutoSize = true;
            this.lblTDN.Location = new System.Drawing.Point(239, 170);
            this.lblTDN.Name = "lblTDN";
            this.lblTDN.Size = new System.Drawing.Size(164, 27);
            this.lblTDN.TabIndex = 2;
            this.lblTDN.Text = "Tên Đăng Nhập";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Location = new System.Drawing.Point(239, 243);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(109, 27);
            this.lblMK.TabIndex = 2;
            this.lblMK.Text = "Mật Khẩu";
            // 
            // ckbGN
            // 
            this.ckbGN.AutoSize = true;
            this.ckbGN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbGN.Location = new System.Drawing.Point(245, 285);
            this.ckbGN.Name = "ckbGN";
            this.ckbGN.Size = new System.Drawing.Size(121, 31);
            this.ckbGN.TabIndex = 3;
            this.ckbGN.Text = "Ghi Nhớ";
            this.ckbGN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1040, 486);
            this.Controls.Add(this.ckbGN);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.lblTDN);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDangnhap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDangnhap;
        private Button btnXoa;
        private Button btnDung;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label lblTDN;
        private Label lblMK;
        private CheckBox ckbGN;
    }
}