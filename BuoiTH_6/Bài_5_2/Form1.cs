using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text.Trim() == "")
            {
                MessageBox.Show("Bé chưa nhập gì chơn á!!!", "Hưng Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (radbLopA.Checked == true)
                {
                    this.listLopA.Items.Add(txtNhap.Text);
                    this.txtNhap.ResetText();
                }
                if (radbLopB.Checked == true)
                {
                    this.listLopB.Items.Add(txtNhap.Text);
                    this.txtNhap.ResetText();
                }
            }
            tatMo();
        }
        public void tatMo()
        {
            if(listLopA.Items.Count == 0)
            {
                btnQuaPhai.Enabled = false;
                btnQuaphaiALL.Enabled = false;
            }
            else
            {
                btnQuaPhai.Enabled = true;
                btnQuaphaiALL.Enabled = true;
            }
            if(listLopB.Items.Count == 0)
            {
                btnQuatrai1.Enabled = false;
                btnQuatraiAll.Enabled = false;
            }
            else
            {
                btnQuatrai1.Enabled = true;
                btnQuatraiAll.Enabled = true;
            }
            
        }
        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            foreach (string item in listLopA.SelectedItems)
                listLopB.Items.Add(item);
            foreach (string item in listLopA.SelectedItems.OfType<string>().ToList())
                listLopA.Items.Remove(item);
            tatMo();
               
        }

        private void btnQuatrai1_Click(object sender, EventArgs e)
        {
            foreach (string item in listLopB.SelectedItems)
                listLopA.Items.Add(item);
            foreach (string item in listLopB.SelectedItems.OfType<string>().ToList())
                listLopB.Items.Remove(item);
            tatMo();
        }

        private void btnQuaphaiALL_Click(object sender, EventArgs e)
        {
            foreach (string item in listLopA.Items)
                listLopB.Items.Add(item);
            listLopA.Items.Clear();
            tatMo();

        }

        private void btnQuatraiAll_Click(object sender, EventArgs e)
        {
            foreach (string item in listLopB.Items)
                listLopA.Items.Add(item);
            listLopB.Items.Clear();
            tatMo();
        }

        private void btnTongSv_Click(object sender, EventArgs e)
        {
            int n = listLopA.Items.Count;
            int m = listLopB.Items.Count;
            int sum = 0;
            sum = n + m;
            MessageBox.Show("Tổng Số Sv: " + sum.ToString(),"Thông Báo", MessageBoxButtons.OK);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
