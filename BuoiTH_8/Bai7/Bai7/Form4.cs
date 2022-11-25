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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public double bankinh;
        public double DienTichHT()
        {
            double dt = (this.bankinh * this.bankinh) * 3.14;
            return dt;
        }
        public double ChuViHT()
        {
            double cv = (this.bankinh * 2) * 3.14;
            return cv;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            this.txtDT.Text = this.DienTichHT().ToString();
            this.txtCv.Text = this.ChuViHT().ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
