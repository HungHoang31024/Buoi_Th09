using System;

namespace Buoi3_Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string n;
            n = string.Format(txtNhap.Text);
            this.lstChuoi.Items.Add(n);
            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string n;
            n = string.Format(lstChuoi.Text);
            this.lstChuoi.Items.Clear();
            
        }
       
        private void txtKq_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void lstChuoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKq.Text = lstChuoi.SelectedItem.ToString();
        }

        private void btnCmauchu_Click(object sender, EventArgs e)
        {
            DialogResult KQ;
            KQ = colorDialog.ShowDialog();
            if (KQ == DialogResult.OK)
                txtKq.ForeColor = colorDialog.Color;

        }

        private void btnCmaunen_Click(object sender, EventArgs e)
        {
            DialogResult KQ;
            KQ = colorDialog.ShowDialog();
            if (KQ == DialogResult.OK)
                txtKq.BackColor = colorDialog.Color;

        }

        private void btnChon_Click(object sender, EventArgs e)
        {

            DialogResult KQ;
            KQ = fontDialog.ShowDialog();
            if (KQ == DialogResult.OK)
                txtKq.Font = fontDialog.Font;

        }

        private void btnĐong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}