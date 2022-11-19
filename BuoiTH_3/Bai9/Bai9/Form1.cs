using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string thongtin;
            thongtin = "\n Ho Ten:";
            thongtin += this.txtHoTen.Text;
            thongtin = " \n Nam:";
            thongtin += this.rdbNam.Text;
            thongtin = "\n Nữ:";
            thongtin += this.rdbNu.Text;
            thongtin += "\n Ngày sinh:";
            thongtin += this.dateTimePicker1.Text;
            thongtin += "\n Địa chỉ:";
            thongtin += this.txtDC.Text;
            thongtin += "\n Điện thoại:";
            thongtin += this.txtSDT.Text;
            thongtin += "\n Email:";
            thongtin += this.txtEmail.Text;
            if (this.chkDangDiHoc.Checked == true)
            {
                thongtin += this.chkDangDiHoc.Text;
            }
            if (this.chkDangDiLam.Checked == true)
            {
                thongtin += this.chkDangDiLam.Text;
            }

            MessageBox.Show(thongtin, "thongtin");
        }

    

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)

        { 

        }

        private void txtDC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkDangDiHoc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkDangDiLam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void picHinhAnh_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
