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
    public partial class Chức_năng : Form
    {
        public Chức_năng()
        {
            InitializeComponent();
        }

        private void frmQLBS_Click(object sender, EventArgs e)
        {
            frmQLBS QLS = new frmQLBS();
            QLS.ShowDialog();
        }

        private void tsmTke_Click(object sender, EventArgs e)
        {
            ThongKe TK = new ThongKe();
            TK.ShowDialog();
        }

        private void tsmHDan_Click(object sender, EventArgs e)
        {
            Hướng_dẫn hdan = new Hướng_dẫn();
            hdan.ShowDialog();
        }
    }
}
