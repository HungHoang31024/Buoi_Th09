using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtGiaiPt_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSoA.Text);
            double b = double.Parse(txtSoB.Text);
            double c = double.Parse(txtSoC.Text);
            double delta; 
            double x1;
            double x2;

            if (a == 0)
            {

                if (b == 0)

                {
                                                                                                
                        txtKQ.Text = "PT vo nghiem!!!";
                    
                }
                else
                {
                    

                    txtKQ.Text = "Phuong trinh co mot nghiem: x = {0}" + ((-c) / b).ToString();

                }
            }
               delta =  (b * b) - (4 * a * c);
            if (delta > 0)
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    txtKQ.Text = "PT co hai nghiem:" + " x1=" + x1 + ";x2=" + x2;

            }
                
                else if (delta == 0)
                {
                                                         
                    txtKQ.Text = "nghiem kep x1 = x2 = {0}" + (-b / (2 * a)).ToString();
                 }
                else
                {
                    txtKQ.Text = "Phuong trinh vo nghiem";
                }
            
        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
