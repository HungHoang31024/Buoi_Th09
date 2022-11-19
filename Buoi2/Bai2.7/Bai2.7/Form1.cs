using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum;
            sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);

            MessageBox.Show(" " + sum.ToString());
        }

        private void button2_Click(object seder, EventArgs e)
        {
            float hieu;
            hieu = float.Parse(textBox1.Text) - float.Parse(textBox2.Text);
            MessageBox.Show(" " + hieu.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float tich;
            tich = float.Parse(textBox1.Text) * float.Parse(textBox2.Text);

            MessageBox.Show(" " + tich.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float thuong;
            thuong = float.Parse(textBox1.Text) / float.Parse(textBox2.Text);

            MessageBox.Show(" " + thuong.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
