using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = new int[20];
        int sopt = 0;
        int tmp;                
        public void TaoMang()
        {
            string t = this.txtNhap.Text;
            string[] arr = t.Split(' ');
            foreach (string word in arr)
            {
                a[sopt] = Convert.ToInt32(word);
                sopt++;
            }
        }
        public void XuatMang()
        {
            for (int i = 0; i < sopt; i++)
                txtKetQua.Text += " " + a[i].ToString();
        }
        public int TongMang()
        {
            int sum = 0;
            for (int i = 0; i < sopt; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        public int TongLe()
        {
            int sum = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] % 2 == 1)
                {
                    sum += a[i];
                }
            }
            return sum;
        }
        public int TongChan()
        {
            int sum = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum += a[i];
                }
            }
            return sum;
        }
        public int Max()
        {
            int max = a[0];
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }

            }
            return max;
        }
        public int Min()
        {
            int min = a[0];
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }

            }
            return min;
        }
        public void SapXepTang()
        {
            for (int i = 0; i < sopt; i++)
                for (int j = i + 1; j < sopt; j++)
                {
                    if (a[j] < a[i])
                    {
                        tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            for (int i = 0; i < sopt; i++)
                txtKetQua.Text += " " + a[i].ToString();

        }
        public void SapXepGiam()
        {
            for (int i = 0; i < sopt; i++)
                for (int j = i + 1; j < sopt; j++)
                {
                    if (a[i] < a[j])
                    {
                        tmp = a[j];
                        a[j] = a[i];
                        a[i] = tmp;
                    }
                }
            for (int i = 0; i < sopt; i++)
                txtKetQua.Text += " " + a[i].ToString();

        }
        public bool TimThayThe(int[] a, int sopt, int Old ,int New) 
        {

            bool Tim = false;
            for (int i = 0; i < sopt; i++) 
            {                
                if (Old == a[i])
                {
                    a[i] = New;
                    Tim = true;
                }                                        
            }
            return Tim;
        } 
        public void Thaythe()
        {
            int n = int.Parse(txtVitri.Text);
            int value = int.Parse(txtSoThayThe.Text);
            a[n] = value;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grbTong_Enter(object sender, EventArgs e)
        {

        }

        private void txtTongChan_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbThayThe_Enter(object sender, EventArgs e)
        {

        }

        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            TaoMang();
            XuatMang();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            this.txtNhap.ResetText();
            this.txtKetQua.ResetText();
            this.txtTongLe.ResetText();
            this.txtTongChan.ResetText();
            this.txtTongMang.ResetText();
            this.txtmax.ResetText();
            this.txtMin.ResetText();
            this.txtSoThayThe.ResetText();
            this.txtVitri.ResetText();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            txtTongMang.Text = " " + TongMang().ToString();
            txtTongChan.Text = " " + TongChan().ToString();
            txtTongLe.Text = " " + TongLe().ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            txtmax.Text = " " + Max().ToString();
            txtMin.Text = " " + Min().ToString();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if(radbTang.Checked == true)
            {
                this.txtKetQua.ResetText();
                SapXepTang();
            }
            if(radbGiam.Checked == true)
            {
                this.txtKetQua.ResetText();
                SapXepGiam();
            }
        }

        private void btnThayThe_Click(object sender, EventArgs e)
        {
            this.txtKetQua.ResetText();
            Thaythe();
            XuatMang();
            
        }
    }
}
