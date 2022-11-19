using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_bai3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.cbWeb.Items.Add("Tuổi trẻ");
            this.cbWeb.Items.Add("Thanh niên");
            this.cbWeb.Items.Add("VNExpress");
            this.cbWeb.Items.Add("Dân trí");
            this.cbWeb.Items.Add("Công an");
            this.cbWeb.Items.Add("24h");
            this.cbWeb.Items.Add("Zingme");
            this.cbWeb.Items.Add("Kênh 14");
            this.cbWeb.Items.Add("Sài Gòn Tiếp Thị");
            this.cbWeb.SelectedItem = "VNExpress";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.txtKq.Text = "Bạn chọn web ";
            this.txtKq.Text += this.cbWeb.SelectedItem.ToString();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            this.cbWeb.SelectedItem = "VNExpress"; this.txtKq.Clear();
        }
    }
}
