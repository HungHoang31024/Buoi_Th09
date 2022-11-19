using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài4._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        int[] a = new int[10];
        
        int tmp;
        public void TaoMang()
        {
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
                a[i] = rd.Next(-1, 100);
        }
        public void XuatMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                lblNhapMangGoc.Text += "  " + a[i].ToString();
            
        }
        public int tongmang(int[] a)
        {
            int kq = 0;
            for (int i = 0; i < a.Length; i++)
                kq += a[i];
            return kq;
        }
        public int Demle()
        {
            int dem = 0;
            for(int i = 0 ; i < a.Length; i++)
            {
                if (a[i] % 2 == 1)
                {
                    dem++;
                }
            }
            return dem;
        }
        public int TongLe()
        {
            int sum = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 1)
                    sum += a[i];
            }
            return sum;
        }
        public int TimMin()
        {
            int min = a[0];
            for(int i =0; i < a.Length; i ++)
            {
                if (min > a[i])
                    min = a[i];
            }
            return min;
        }
        public void TangPtu()
        {           
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] + 2;
                lblNhapMangGoc.Text += "  " + a[i].ToString();
            }                               
        }
       public void SapxepTang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                for (int j = i + 1; j < a.Length; j++)
                    if (a[j] < a[i])
                    {
                        tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
            for (int i = 0; i < a.Length; i++)
                lblKetQua.Text += "  " + a[i].ToString();
        }
        public void Sapxepgiam(int[] a)
        {
           for(int i = 0; i < a.Length; i++)
                for(int j = i + 1; j < a.Length; j++)
                    if (a[i] < a[j])
                    {
                        tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
            for (int i = 0; i < a.Length; i++)               
            lblKetQua.Text += " " + a[i].ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnXuatMangNN_Click(object sender, EventArgs e)
        {

            this.TaoMang();
            this.XuatMang(a);
            

        }

        private void btnTongGiaTriM_Click(object sender, EventArgs e)
        {
            lblKetQua.Text = "Tổng Mảng = " + tongmang(a).ToString();
        }

        private void btnDemSoPtLe_Click(object sender, EventArgs e)
        {
            lblKetQua.Text = " So Phần tử lẻ: " + Demle();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.lblNhapMangGoc.ResetText();
            this.lblKetQua.ResetText();
        }

        private void btnTongGtPTLe_Click(object sender, EventArgs e)
        {
            lblKetQua.Text = "Tổng lẻ: " + TongLe().ToString();
        }

        private void btntimPtNhoN_Click(object sender, EventArgs e)
        {
            lblKetQua.Text = "Phần tử nhỏ nhất: " + TimMin();
        }

        private void btnMangTang_Click(object sender, EventArgs e)
        {
            this.lblKetQua.ResetText();
            this.SapxepTang(a);
            
        }

        private void btnTangPtLen2_Click(object sender, EventArgs e)
        {
            this.lblNhapMangGoc.ResetText();
            TangPtu();
           
        }

        private void btnMangGiam_Click(object sender, EventArgs e)
        {
            this.lblKetQua.ResetText();
            this.Sapxepgiam(a);
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
