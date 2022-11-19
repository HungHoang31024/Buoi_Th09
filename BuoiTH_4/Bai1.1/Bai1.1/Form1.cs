using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = new int[10];
        int sopt = 0;
        public string InMang()
        {
            string chuoi = "";
            for (int i = 0; i < sopt; i++)
                chuoi += a[i] + "";
            return chuoi;
        }
        public int TimMax()
        {
            int max = a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] > max)
                    max = a[i];
            return max;
        }
        public int TimMin()
        {
            int min = int.MaxValue;
            for(int i = 0; i< sopt; i++)
            {
                if(min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }
        public double TrungBinhMang()
        {
            int sum = 0;
            double tb;
            for (int i = 0; i < sopt; i++)
                sum += a[i];
            tb = (double)sum / (double)sopt;
            return tb;
        }
        public void SapXepTang()
        {
            Array.Sort(a, 0, sopt);
        }
        public int TimUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b) 
                {
                    a = a - b;
                }
                else 
                { 
                    b = b - a; 
                }
            }
            return a;
        }
        public Boolean kiemTraSNT(int so)
        {
            if (so <= 0)
                return false;
            else
            {
                for (int i = 2; i <= so / 2; i++)
                {
                    if (so % i == 0)
                        return false;
                }
            }
            return true;
        }


        public int demSNT()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSNT(a[i]))
                    dem++;
            }
            return dem;
        }
        public String inSNT()
        {
            String chuoi = "";
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSNT(a[i]) == true)
                    chuoi += a[i] + " ";
                dem++;
            }
            if(dem == 0 )
            {
                chuoi += "khong co";
            }
            return chuoi;
        }
        public void SapXepGiam()
        {
            Array.Sort(a);
            Array.Reverse(a);
        }
        public double TinhTongMang()
        {
            int sum = 0;
            for(int i = 0; i < sopt; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        public bool KiemTraSOHH(int n)
        {
            int sum = 0;
            for(int i = 1; i < sopt; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;

                }
            }
            if(sum == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public String InSoHoanHao()
        {
            String chuoi = "";
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] > 0)
                {
                    if (KiemTraSOHH(a[i]) == true)
                    {
                        chuoi += a[i] + "  ";
                        dem++;
                    }
                }
            }
            if (dem == 0)
            {
                chuoi += "khong co";
            }
            return chuoi;

        }
        
        public int DemSoChan()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] % 2 == 0)
                {
                    dem++;
                }
            }
            return dem;
        }
        public int DemSoLe()
        {
            int dem = 0;
            for(int i = 0; i < sopt; i++)
            {
                if (a[i] %2 == 1)
                {
                    dem++;
                }
            }
            return dem;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (this.sopt == a.Length)
            {
                this.txtNhap.Text = "";
                MessageBox.Show("mang day", "Thong bao");
            }
            else
            {
                if (this.txtNhap.Text == "")
                    MessageBox.Show("Hay nhap phan tu mang", "Thong bao");
                else
                {
                    a[sopt] = int.Parse(this.txtNhap.Text);
                    sopt++;
                    this.lblKetQua.Text += this.txtNhap.Text + " ";
                    this.txtNhap.Clear();
                    this.txtNhap.Focus();
                    if (sopt > 0)
                        this.btnIn.Enabled = true;
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKetQua.Text = "Mang rong!";
            else
                lblKetQua.Text = "Cac phan tu trong mang la: \n\r" + InMang();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /* Form1 NewForm = new Form1();
             NewForm.Show();
             this.Dispose(false);*/
            sopt = 0;
            this.lblKetQua.ResetText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
                Application.Exit();
            

        }

        private void btnSXGIAM_Click(object sender, EventArgs e)
        {
            if (sopt == 1)
                lblKetQua.Text = "Mang Rong!";
            else
            {
                SapXepGiam();
                this.lblKetQua.Text = "Da sap xep mang giam: " + InMang(); 
            }
        }

        private void btnSXTANG_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKetQua.Text = "Mang rong!";
            else
            {
                SapXepTang();
                this.lblKetQua.Text = "Da sap xep mang tang dan: " + InMang();
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if(sopt == 0)
            {
                MessageBox.Show("Mang rong");
                this.txtNhap.Focus();
            }
            else
            {
                this.lblKetQua.Text = " tong mang la: " + TinhTongMang();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                MessageBox.Show("Mang rong");
                this.txtNhap.Focus();
            }
            else
            {
                this.lblKetQua.Text = " So lon nhat la la: " + TimMax();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                MessageBox.Show("Mang rong");
                this.txtNhap.Focus();
            }
            else
            {
                this.lblKetQua.Text = " So nho nhat la la: " + TimMin();
            }
        }

        private void btnSoHoanHao_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                MessageBox.Show("Mang rong");
                this.txtNhap.Focus();
            }
            else
            {
                this.lblKetQua.Text = " So Hoan hao trong mang la: " + InSoHoanHao();
            }
        }

        private void btnSoNguyenTo_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                MessageBox.Show("Mang rong");
                this.txtNhap.Focus();
            }
            else
            {
                this.lblKetQua.Text = "Mang co " + demSNT().ToString() +  " so nguyen to la " + inSNT();
            }
        }

        private void btnTBMang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                MessageBox.Show("Mang rong");
                this.txtNhap.Focus();
            }
            else
            {
                this.lblKetQua.Text = " trung binh mang la: " + TrungBinhMang();
            }
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            lblKetQua.Text = "uoc chung lon nhat 2 phan tu dau " + a[0] + " va " + a[1] + " la " + TimUCLN(a[0],a[1]).ToString();
        }

        private void btnDemSoLe_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                MessageBox.Show("Mang rong");
                this.txtNhap.Focus();
            }
            else
            {
                this.lblKetQua.Text = "Mang co: " + DemSoLe() + " So le";
            }
            
        }

        private void btnDemSoChan_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                MessageBox.Show("Mang rong");
                this.txtNhap.Focus();

            }
            else
            {
                this.lblKetQua.Text = "Mang co: " + DemSoChan() + " So chan";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


 }
