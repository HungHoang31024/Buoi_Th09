using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean SNT(int n)
        {
            if (n <= 0)
                return false;
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                        return false;
                }
            }
            return true;
        }
       

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            
            this.txtNhap.ResetText();
            this.txtKT.ResetText();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            
        

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            int n;
            int.TryParse(txtNhap.Text, out n);
             

            if (SNT(n))
                txtKT.Text = n.ToString() + " la so nguyen to";
            else
                txtKT.Text = n.ToString() + " ko phai la so nguyen to";

            string ketqua = "";
            for (int i = 1; i < n; i++)
                if (SNT(i))
                    ketqua = ketqua + i.ToString() + " ";
            txtTimSNT.Text = ketqua;

        }

        private void txtKT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTimSNT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
