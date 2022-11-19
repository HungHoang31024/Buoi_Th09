using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cv;
            cv = int.Parse(textBox2.Text) + int.Parse(textBox3.Text);
            textBox1.Text = cv.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float dt;
            dt = float.Parse(textBox2.Text) * float.Parse(textBox3.Text);
            textBox1.Text = dt.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            double a = Math.Pow(double.Parse(textBox2.Text),2);
            double b = Math.Pow(double.Parse(textBox3.Text),2);
            double dc = Math.Sqrt(b + a);
            textBox1.Text = dc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
