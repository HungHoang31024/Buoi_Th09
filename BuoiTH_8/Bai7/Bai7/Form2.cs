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
    public partial class Form2 : Form
    {

        public Form2(double c)
        {
            InitializeComponent();
            this.canha = c;
        }
        //
        double canha;
        public double DienTich()
        {
            double dientich = this.canha * this.canha;
            return dientich;
        }
        public double ChuVi()
        {
            double cv = this.canha * 4;
            return cv;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.txtDT.Text = DienTich().ToString();
            this.txtCv.Text = ChuVi().ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn Muốn Đóng Chương Trình ?", "Thông báo", MessageBoxButtons.YesNo);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
