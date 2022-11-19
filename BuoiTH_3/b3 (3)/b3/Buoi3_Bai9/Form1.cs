using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai9
{
    public partial class frmBai9 : Form
    {
        public frmBai9()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datetpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnHienThongTin_Click(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList();
            string hoten = txtHoTen.Text;
            string gioitinh = "Chua Chon Gioi Tinh";
            arr.Add(hoten);

            if (this.radNam.Checked==true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nu";
            }
            string ngaysinh  = datetpNgaySinh.Value.ToString();
            string diachi = txtDiaChi.Text;
            string dienthoai = txtEmail.Text;
            string email = txtEmail.Text;
            string tinhtrang = "Chua Chon Tinh trang";
            if(this.ckBDangDiHoc.Checked==true)
            {
                tinhtrang = "Dang di hoc";
            }
            else
            {
                tinhtrang = "Dang di lam";
            }
            string ch = "Ho ten: " + hoten + "\n" + 
                        "Gioi tinh: " + gioitinh + "\n" +
                        "Ngay sinh: " + ngaysinh + "\n" +
                        "Dia chi: " + diachi + "\n" +
                        "So dien thoai: " + dienthoai + "\n" +
                        "Email: " + email + "\n" +
                        "Tinh trang: " + tinhtrang + "\n";
            MessageBox.Show(ch.ToString());
        }

        private void frmBai9_Load(object sender, EventArgs e)
        {

        }
    }
}
