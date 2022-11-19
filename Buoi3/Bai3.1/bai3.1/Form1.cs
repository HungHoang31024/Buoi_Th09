using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bai3._1
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

        private void txtTinh_Click(object sender, EventArgs e)
        {
                    
            if(double.Parse(txtx.Text) >= 2)
            {
                double y;
                double a = 8;
                double b = 12;
                double c = 1;
                y =  - a * Math.Pow(double.Parse(txtx.Text), 3) - b * double.Parse(txtx.Text) - c;               
                txtf.Text = y.ToString();
            }
            if (double.Parse(txtx.Text) > 1 & double.Parse(txtx.Text) < 2)
            {
                double y;
                double a = 1;
                double b = 6;
                double c = 19;
                y = a * Math.Pow(double.Parse(txtx.Text), 2) - b * double.Parse(txtx.Text) - c;
                txtf.Text = y.ToString();
            }
            if(double.Parse(txtx.Text) <= 1)
            {
                double y;
                double a = 7;
                y = a * double.Parse(txtx.Text);
                txtf.Text = y.ToString();
            }
        }

        private void txtx_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
