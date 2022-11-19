using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float tu, mau, tu1, tu2, mau1, mau2, usc;
        public static float USCLN(float a, float b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return USCLN(b, a % b);
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            this.grpKq.Text = " phép cộng";
            tu = (tu1 * mau2) + (tu2 * mau1);
            mau = (mau1 * mau2);
            usc = USCLN(tu , mau);

            txtKQTu.Text = Convert.ToString(tu / usc);
            txtKQMau.Text = Convert.ToString(mau / usc);



        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            this.grpKq.Text = " phép trừ";
            tu = (tu1 * mau2) - (tu2 * mau1);
            mau = (mau1 * mau2);
            usc = USCLN(tu, mau);

            txtKQTu.Text = Convert.ToString(tu / usc);
            txtKQMau.Text = Convert.ToString(mau / usc);
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            this.grpKq.Text = " phép nhân";
            tu = tu1 * tu2;
            mau = mau1 * mau2;
            usc = USCLN(tu, mau);

            txtKQTu.Text = Convert.ToString(tu / usc);
            txtKQMau.Text = Convert.ToString(mau / usc);
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            this.grpKq.Text = " phép chia";
            tu = tu1 * mau2;
            mau = mau1 * tu2;
            usc = USCLN(tu, mau);

            txtKQTu.Text = Convert.ToString(tu / usc);
            txtKQMau.Text = Convert.ToString(mau / usc);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTuSo1.ResetText();
            txtTuso2.ResetText();
            txtMauSo1.ResetText();
            txtMauso2.ResetText();
            txtKQTu.ResetText();
            txtKQMau.ResetText();
            grpKq.Text = "Kết quả";
            tu = tu1 = tu2 = mau = mau1 = mau2 = usc = 0;
            
        }

        private void grpKq_Enter(object sender, EventArgs e)
        {

        }

        private void txtTuSo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMauSo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTuso2_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpPhepTinh_Enter(object sender, EventArgs e)
        {
            tu1 = float.Parse(txtTuSo1.Text);
            tu2 = float.Parse(txtTuso2.Text);
            mau1 = float.Parse(txtMauSo1.Text);
            mau2 = float.Parse(txtMauso2.Text);
            
            
        }

        private void txtMauso2_TextChanged(object sender, EventArgs e)
        {

        }
      
    }
}
