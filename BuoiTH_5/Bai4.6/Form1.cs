using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = new int[10];
        int sopt = 0;

        public void TaoMang()
        {
            string t = this.txtNhap.Text;
            string[]arr = t.Split(' ');
            foreach (string word in arr)
            {
                a[sopt] = Convert.ToInt32(word);
                sopt++;
            }
        }
        public void XuatMAng()
        {
            for (int i = 0; i < sopt; i++){
                txtXuat.Text += a[i].ToString() + "  ";
            }
        }
        public int Demle()
        {
            int dem = 0;
            for(int i = 0; i< sopt; i++)
            {
                if (a[i] % 2 == 1)
                {
                    dem++;
                }
            }
            return dem;
        }
        public int DemChan()
        {
            int dem = 0;
            for(int i = 0; i < sopt; i++)
            {
                if (a[i] % 2 == 0)
                {
                    dem++;
                }
            }
            return dem;
        }
        public int tongle()
        {
            int sum = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] % 2 == 1)
                    sum += a[i];
            }
            return sum;
        }
        public int Tongchan()
        {
            int sum = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] % 2 == 0)
                    sum += a[i];
            }
            return sum;
        }
        public int Chancuoi()

        {
            for(int i = sopt - 1; i< sopt; i--)
            {
                if (a[i] % 2 == 0)
                {
                    return a[i];
                    
                }               
            }
            return -1;
        }
        public void LietkeChan()
        {
            for(int i = 0; i < sopt; i++)
            {
                if (a[i] % 2 == 0)
                {
                    txtXuat.Text += "  " + a[i].ToString();
                }
            }
        }
        public int GiatriNN()
        {
            int min = a[0];
            for(int i = 1; i < sopt; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void radbtnNhap_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            if(radbtnNhap.Checked == true)
            {
                this.TaoMang();
                this.XuatMAng();
            }
            else if (this.radBtnDemle.Checked == true)
            {
                txtXuat.Text = Demle().ToString() + " số lẻ";
            }
            else if (this.radBtnDemchan.Checked == true)
            {

                txtXuat.Text = DemChan().ToString() + " số chẵn";
            }
            else if (this.radbtnTongle.Checked == true)
            {
                txtXuat.ResetText();
                txtXuat.Text = "tổng lẻ: " + tongle().ToString();
            }
            else if(radbtnTongchan.Checked == true)
            {
                txtXuat.Text = "tổng chẳn: " + Tongchan().ToString();
            }
            else if(radbtnChancuoi.Checked == true)
            {
                txtXuat.Text = "Chẵn cuối: " + Chancuoi().ToString();
            }
            else if(radbtnLietkechan.Checked == true)
            {
                this.txtXuat.ResetText();
                LietkeChan();
            }
            else if(radbtnGiatriNN.Checked == true)
            {                
                txtXuat.Text = "Min: " + GiatriNN().ToString();
            }

        }
    }
 }
