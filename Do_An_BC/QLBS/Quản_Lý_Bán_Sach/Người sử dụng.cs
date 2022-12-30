using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Bán_Sach
{
    public partial class Người_sử_dụng : Form
    {
        public Người_sử_dụng()
        {
            InitializeComponent();
        }

        private void radQL_CheckedChanged(object sender, EventArgs e)
        {

            this.Hide();
            Đăng_nhập Dn = new Đăng_nhập();
            Dn.ShowDialog();
            

        }

        private void radNV_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Đăng_nhập Dn = new Đăng_nhập();
            Dn.ShowDialog();
            

        }

        private void Người_sử_dụng_Load(object sender, EventArgs e)
        {
            this.radQL.Checked = false;
            this.radNV.Checked = false;

        }
    }
}
