using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a;
        int n;

        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < n; i++)
                chuoi += a[i] + " ";
            return chuoi;
        }
        public void TaoMang(int n)
        {
            a = new int[n];
            int num1;
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                num1 = rd.Next(-1, 100);
                a[i] = num1;
            }
        }
       public double Tong()
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += a[i];
            return sum;
        }
        public int TimMax()
        {
            int max = a[0];
            for (int i = 0; i < n; i++)
                if (a[i] > max)
                    max = a[i];
            return max;
        }
        private void btnRanDom_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Hãy Nhập số phần tử mảng", "Thông báo");
                txtNhap.Focus();
            }
            else
            {
                n = Convert.ToInt32(txtNhap.Text);
                if (n < 0)
                {
                    MessageBox.Show("Bạn vừa nhập n=" + n + ".Số phần tử mảng > 0", "Thông Báo");
                    txtNhap.Focus();
                }
                else
                {
                    TaoMang(n);
                    MessageBox.Show("Mảng với các phần tử phát sinh ngẫu nhiên vừa tạo xong");
                  
                    btnTongMang.Enabled = true;
                    brnSLN.Enabled = true;
                   
                }
            }
        }

        private void btnTongMang_Click(object sender, EventArgs e)
        {

           DialogResult s = MessageBox.Show("Các phần tử của mảng: " + InMang() + ", bạn có muốn tính tổng mảng không? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (s == DialogResult.OK)
            {
                string p = "Tong các phan tu trong mang" + Tong();
                Form2 f2 = new Form2(p);
                f2.ShowDialog();
                this.Show();
            }
        }

        private void brnSLN_Click(object sender, EventArgs e)
        {
            DialogResult g = MessageBox.Show("Các phần tử của mảng: " + InMang() + ", bạn có muốn tìm giá trị lớn nhất? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (g == DialogResult.OK)
            {
                string c = " so lon nhat: " + TimMax();
                Form3 f3 = new Form3(c);
                f3.ShowDialog();
                this.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
             
            
        }
    }
}
