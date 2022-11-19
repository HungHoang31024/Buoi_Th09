using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b3._3
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string m = "";           
            int i = int.Parse(textBox1.Text);
            if (i >= 3 && i <= 5)
            {
                
                switch (i)
                { 
                    case 3:
                        m = "Mua Xuan";
                        break;
                    case 4:
                        m = "Mua Xuan";
                        break;
                    case 5:
                        m = "Mua Xuan";
                        break;                    
                }
                MessageBox.Show(string.Format(m));
            }
            string u = "";
            int c = int.Parse(textBox1.Text);
            if (c >= 6 && c <= 8)
            {

                switch (c)
                {
                    case 6:
                        u = "Mua He";
                        break;
                    case 7:
                        u = "Mua He";
                        break;
                    case 8:
                        u = "Mua He";
                        break;
                }
                MessageBox.Show(string.Format(u));
            }
            string thu = "";
            int v = int.Parse(textBox1.Text);
            if (v >= 9 && v <= 11)
            {
                switch (v)
                {
                    case 9:
                        thu = "Mua Thu";
                        break;
                    case 10:
                        thu = "Mua Thu";
                        break;
                    case 11:
                        thu = "Mua Thu";
                        break;
                }
                MessageBox.Show(string.Format(thu));
            }
            string dong = "";
            int d = int.Parse(textBox1.Text);
            if (d == 12 || d == 1 || d == 2)
            {
                switch (d)
                {
                    case 1:
                        dong = "Mua Dong";
                        break;
                    case 2:
                        dong = "Mua Dong";
                        break;
                    case 12:
                        dong = "Mua Dong";
                        break;
                }
                MessageBox.Show(string.Format(dong));
            }
        }
            
    }
}

