using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a;
        int n;

        public void TaoMang(int n)
        {
            a = new int[n];
            int num1;
            Random rd = new Random();
            for (int i = 0; i < a.Length; i ++)
            {
                num1 = rd.Next(-1, 100);
                a[i] = num1;
            }
        }
        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < a.Length; i++)
                chuoi += a[i] + " ";
            return chuoi;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRanDom_Click(object sender, EventArgs e)
        {       
            if(txtNhap.Text == "")
            {
                MessageBox.Show("Hãy Nhập số phần tử mảng", "Thông báo");
                txtNhap.Focus();
            }
            else
            {
                n = Convert.ToInt32(txtNhap.Text);
                if(n<0)
                {
                    MessageBox.Show("Bạn vừa nhập n=" + n + ".Số phần tử mảng > 0", "Thông Báo");
                    txtNhap.Focus();
                }
                else
                {
                    TaoMang(n);
                    lblKQ.Text = "Mảng với các phần tử phát sinh ngẫu nhiên vừa tạo xong: ";
                    btnIn.Enabled = true;
                }
            }
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            lblKQ.Text = "các phần tử của mảng: " + InMang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
