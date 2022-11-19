namespace Bài_5_2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radbLopB = new System.Windows.Forms.RadioButton();
            this.radbLopA = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listLopA = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listLopB = new System.Windows.Forms.ListBox();
            this.btnQuaPhai = new System.Windows.Forms.Button();
            this.btnQuatrai1 = new System.Windows.Forms.Button();
            this.btnQuaphaiALL = new System.Windows.Forms.Button();
            this.btnQuatraiAll = new System.Windows.Forms.Button();
            this.btnTongSv = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(127, 37);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(536, 43);
            this.txtNhap.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(802, 36);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(235, 45);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.radbLopB);
            this.groupBox1.Controls.Add(this.radbLopA);
            this.groupBox1.Location = new System.Drawing.Point(290, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Lớp";
            // 
            // radbLopB
            // 
            this.radbLopB.AutoSize = true;
            this.radbLopB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbLopB.Location = new System.Drawing.Point(311, 49);
            this.radbLopB.Name = "radbLopB";
            this.radbLopB.Size = new System.Drawing.Size(87, 28);
            this.radbLopB.TabIndex = 1;
            this.radbLopB.TabStop = true;
            this.radbLopB.Text = "Lớp B";
            this.radbLopB.UseVisualStyleBackColor = true;
            // 
            // radbLopA
            // 
            this.radbLopA.AutoSize = true;
            this.radbLopA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbLopA.Location = new System.Drawing.Point(30, 49);
            this.radbLopA.Name = "radbLopA";
            this.radbLopA.Size = new System.Drawing.Size(87, 28);
            this.radbLopA.TabIndex = 0;
            this.radbLopA.TabStop = true;
            this.radbLopA.Text = "Lớp A";
            this.radbLopA.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.listLopA);
            this.groupBox2.Location = new System.Drawing.Point(35, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 252);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp A";
            // 
            // listLopA
            // 
            this.listLopA.FormattingEnabled = true;
            this.listLopA.ItemHeight = 21;
            this.listLopA.Items.AddRange(new object[] {
            "Trần Thanh Tính",
            "Phan Văn Hồ",
            "Nguyễn Thanh Hà"});
            this.listLopA.Location = new System.Drawing.Point(12, 33);
            this.listLopA.Name = "listLopA";
            this.listLopA.Size = new System.Drawing.Size(334, 193);
            this.listLopA.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.listLopB);
            this.groupBox3.Location = new System.Drawing.Point(620, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 252);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lớp B";
            // 
            // listLopB
            // 
            this.listLopB.FormattingEnabled = true;
            this.listLopB.ItemHeight = 21;
            this.listLopB.Items.AddRange(new object[] {
            "Huỳnh Lê An",
            "Lê Văn Thành"});
            this.listLopB.Location = new System.Drawing.Point(22, 32);
            this.listLopB.Name = "listLopB";
            this.listLopB.Size = new System.Drawing.Size(394, 193);
            this.listLopB.TabIndex = 0;
            // 
            // btnQuaPhai
            // 
            this.btnQuaPhai.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaPhai.Location = new System.Drawing.Point(479, 215);
            this.btnQuaPhai.Name = "btnQuaPhai";
            this.btnQuaPhai.Size = new System.Drawing.Size(89, 59);
            this.btnQuaPhai.TabIndex = 6;
            this.btnQuaPhai.Text = ">";
            this.btnQuaPhai.UseVisualStyleBackColor = true;
            this.btnQuaPhai.Click += new System.EventHandler(this.btnQuaPhai_Click);
            // 
            // btnQuatrai1
            // 
            this.btnQuatrai1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatrai1.Location = new System.Drawing.Point(479, 291);
            this.btnQuatrai1.Name = "btnQuatrai1";
            this.btnQuatrai1.Size = new System.Drawing.Size(89, 58);
            this.btnQuatrai1.TabIndex = 7;
            this.btnQuatrai1.Text = "<";
            this.btnQuatrai1.UseVisualStyleBackColor = true;
            this.btnQuatrai1.Click += new System.EventHandler(this.btnQuatrai1_Click);
            // 
            // btnQuaphaiALL
            // 
            this.btnQuaphaiALL.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaphaiALL.Location = new System.Drawing.Point(479, 370);
            this.btnQuaphaiALL.Name = "btnQuaphaiALL";
            this.btnQuaphaiALL.Size = new System.Drawing.Size(89, 57);
            this.btnQuaphaiALL.TabIndex = 8;
            this.btnQuaphaiALL.Text = ">>";
            this.btnQuaphaiALL.UseVisualStyleBackColor = true;
            this.btnQuaphaiALL.Click += new System.EventHandler(this.btnQuaphaiALL_Click);
            // 
            // btnQuatraiAll
            // 
            this.btnQuatraiAll.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatraiAll.Location = new System.Drawing.Point(479, 445);
            this.btnQuatraiAll.Name = "btnQuatraiAll";
            this.btnQuatraiAll.Size = new System.Drawing.Size(88, 52);
            this.btnQuatraiAll.TabIndex = 9;
            this.btnQuatraiAll.Text = "<<";
            this.btnQuatraiAll.UseVisualStyleBackColor = true;
            this.btnQuatraiAll.Click += new System.EventHandler(this.btnQuatraiAll_Click);
            // 
            // btnTongSv
            // 
            this.btnTongSv.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongSv.Location = new System.Drawing.Point(35, 490);
            this.btnTongSv.Name = "btnTongSv";
            this.btnTongSv.Size = new System.Drawing.Size(359, 65);
            this.btnTongSv.TabIndex = 10;
            this.btnTongSv.Text = "Tổng Số Sinh Viên";
            this.btnTongSv.UseVisualStyleBackColor = true;
            this.btnTongSv.Click += new System.EventHandler(this.btnTongSv_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(763, 490);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(235, 64);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1078, 564);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTongSv);
            this.Controls.Add(this.btnQuatraiAll);
            this.Controls.Add(this.btnQuaphaiALL);
            this.Controls.Add(this.btnQuatrai1);
            this.Controls.Add(this.btnQuaPhai);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Danh Sách Sinh Viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radbLopB;
        private System.Windows.Forms.RadioButton radbLopA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuaPhai;
        private System.Windows.Forms.Button btnQuatrai1;
        private System.Windows.Forms.Button btnQuaphaiALL;
        private System.Windows.Forms.Button btnQuatraiAll;
        private System.Windows.Forms.Button btnTongSv;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listLopA;
        private System.Windows.Forms.ListBox listLopB;
    }
}

