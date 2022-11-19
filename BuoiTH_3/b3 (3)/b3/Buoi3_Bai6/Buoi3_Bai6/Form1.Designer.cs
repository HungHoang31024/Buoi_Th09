namespace Buoi3_Bai6
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
            this.grbNchuoi = new System.Windows.Forms.GroupBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lstChuoi = new System.Windows.Forms.ListBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.btnCmaunen = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnCmauchu = new System.Windows.Forms.Button();
            this.btnĐong = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.grbNchuoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNchuoi
            // 
            this.grbNchuoi.Controls.Add(this.txtNhap);
            this.grbNchuoi.Location = new System.Drawing.Point(12, 25);
            this.grbNchuoi.Name = "grbNchuoi";
            this.grbNchuoi.Size = new System.Drawing.Size(300, 78);
            this.grbNchuoi.TabIndex = 0;
            this.grbNchuoi.TabStop = false;
            this.grbNchuoi.Text = "Nhập chuỗi";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(6, 34);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(282, 35);
            this.txtNhap.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Menu;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Location = new System.Drawing.Point(18, 132);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Menu;
            this.btnXoa.Location = new System.Drawing.Point(168, 132);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lstChuoi
            // 
            this.lstChuoi.FormattingEnabled = true;
            this.lstChuoi.ItemHeight = 27;
            this.lstChuoi.Location = new System.Drawing.Point(21, 200);
            this.lstChuoi.Name = "lstChuoi";
            this.lstChuoi.Size = new System.Drawing.Size(279, 139);
            this.lstChuoi.TabIndex = 2;
            this.lstChuoi.SelectedIndexChanged += new System.EventHandler(this.lstChuoi_SelectedIndexChanged);
            // 
            // txtKq
            // 
            this.txtKq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtKq.ForeColor = System.Drawing.Color.Red;
            this.txtKq.Location = new System.Drawing.Point(318, 12);
            this.txtKq.Multiline = true;
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(525, 220);
            this.txtKq.TabIndex = 0;
            this.txtKq.TextChanged += new System.EventHandler(this.txtKq_TextChanged);
            // 
            // btnCmaunen
            // 
            this.btnCmaunen.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCmaunen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCmaunen.Location = new System.Drawing.Point(508, 271);
            this.btnCmaunen.Name = "btnCmaunen";
            this.btnCmaunen.Size = new System.Drawing.Size(183, 68);
            this.btnCmaunen.TabIndex = 1;
            this.btnCmaunen.Text = "Chọn màu nền";
            this.btnCmaunen.UseVisualStyleBackColor = false;
            this.btnCmaunen.Click += new System.EventHandler(this.btnCmaunen_Click);
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.SystemColors.Menu;
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChon.Location = new System.Drawing.Point(697, 271);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(146, 68);
            this.btnChon.TabIndex = 1;
            this.btnChon.Text = "Chọn Font";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnCmauchu
            // 
            this.btnCmauchu.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCmauchu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCmauchu.Location = new System.Drawing.Point(318, 271);
            this.btnCmauchu.Name = "btnCmauchu";
            this.btnCmauchu.Size = new System.Drawing.Size(174, 68);
            this.btnCmauchu.TabIndex = 1;
            this.btnCmauchu.Text = "Chon màu chữ";
            this.btnCmauchu.UseVisualStyleBackColor = true;
            this.btnCmauchu.Click += new System.EventHandler(this.btnCmauchu_Click);
            // 
            // btnĐong
            // 
            this.btnĐong.BackColor = System.Drawing.SystemColors.Menu;
            this.btnĐong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnĐong.Location = new System.Drawing.Point(508, 363);
            this.btnĐong.Name = "btnĐong";
            this.btnĐong.Size = new System.Drawing.Size(166, 73);
            this.btnĐong.TabIndex = 1;
            this.btnĐong.Text = "Đóng";
            this.btnĐong.UseVisualStyleBackColor = false;
            this.btnĐong.Click += new System.EventHandler(this.btnĐong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1040, 486);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.lstChuoi);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnCmauchu);
            this.Controls.Add(this.btnĐong);
            this.Controls.Add(this.btnCmaunen);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbNchuoi);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbNchuoi.ResumeLayout(false);
            this.grbNchuoi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grbNchuoi;
        private TextBox txtNhap;
        private Button btnThem;
        private Button btnXoa;
        private ListBox lstChuoi;
        private TextBox txtKq;
        private Button btnCmaunen;
        private Button btnChon;
        private Button btnCmauchu;
        private Button btnĐong;
        private ColorDialog colorDialog;
        private FontDialog fontDialog;
    }
}