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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public double daia;
        public double ronga;
        public double ChuViHCN()
        {
            double cv = (this.daia + this.ronga) * 2;
            return cv;
        }
        public double DienTichHCN()
        {
            double dt = this.daia * this.ronga;
            return dt;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.txtDT.Text = DienTichHCN().ToString();
            this.txtCv.Text = ChuViHCN().ToString();
        }
    }
}
