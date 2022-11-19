using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void tongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double sum;
            sum = a + b;
            txtKQ.Text = sum.ToString();
        }

        private void hieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double hieu;
            hieu = a - b;
            txtKQ.Text = hieu.ToString();
        }

        private void tichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double tich;
            tich = a * b;
            txtKQ.Text = tich.ToString();
        }

        private void thuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double thuong;
            thuong = a / b;
            txtKQ.Text = thuong.ToString();
        }
    }
}
