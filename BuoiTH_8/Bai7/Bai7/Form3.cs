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
        public Form3(double d)
        {
            InitializeComponent();
            this.daia = d;
            this.ronga = d;
        }
         double daia;
         double ronga;
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close(); DialogResult thoat;
            thoat = MessageBox.Show("Bạn Muốn Đóng Chương Trình?", "Thông báo", MessageBoxButtons.YesNo);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
