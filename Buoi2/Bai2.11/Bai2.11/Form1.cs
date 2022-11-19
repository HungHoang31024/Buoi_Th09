using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai2._11
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

        private void button1_Click(object sender, EventArgs e)
        {
            int cv;
            cv = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            MessageBox.Show("Chu vi: " + cv.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float dt;
            dt = float.Parse(textBox1.Text) * float.Parse(textBox2.Text);
            MessageBox.Show("Dien tich: " + dt.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Math.Pow(double.Parse(textBox1.Text), 2);
            double b = Math.Pow(double.Parse(textBox2.Text), 2);
            double dc = Math.Sqrt(b + a);
            MessageBox.Show("Duong cheo: " + dc.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
