﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_bai2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if((this.txtUser.Text == "") || (this.txtPass.Text == ""))
                MessageBox.Show("Vui lòng nhập tên người dùng hoặc mật khẩu");
            else
            {
                if ((this.txtUser.Text == "nguyenvanhung") && (this.txtPass.Text == "abc12345"))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Tên và mật khẩu không đúng, hãy nhập lại", "Thông báo");
                    this.txtUser.Clear();
                    this.txtPass.Clear(); this.txtUser.Focus();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Bạn có muốn thoát chương trình không?");
                this.txtUser.Clear();
                this.txtPass.Clear(); this.txtUser.Focus();
                this.Close();
               
            }
        }
    }
}
