using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._8
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
            int tong;
            tong = int.Parse(textBox2.Text) + int.Parse(textBox3.Text);
            textBox1.Text = tong.ToString();
            

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

        private void button2_Click(object sender, EventArgs e)
        {
            float hieu;
            hieu = float.Parse(textBox2.Text) - float.Parse(textBox3.Text);
            textBox1.Text = hieu.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float tich;
            tich = float.Parse(textBox2.Text) * float.Parse(textBox3.Text);
            textBox1.Text = tich.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            float thuong;
            thuong = float.Parse(textBox2.Text) / float.Parse(textBox3.Text);
            textBox1.Text = thuong.ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
