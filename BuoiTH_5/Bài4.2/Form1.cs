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

namespace Bài4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public Boolean KTSoHH(int n)
        {
            int sum= 0;
            for(int i = 1; i < n; i++)
            {
                if(n % i == 0)
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
        

        private void txtKT_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            this.txtKT.Clear();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtKT.Text, out n))
            {

                if (KTSoHH(n) == true)
                {

                    MessageBox.Show(n.ToString() + " là số hoàn hảo");


                }
                else
                {
                    MessageBox.Show(n.ToString() + " không là số hoàn hảo");

                }

            }
        }
    }
}
