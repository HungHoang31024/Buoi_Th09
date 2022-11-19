using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaSv.Text.Trim() == "")
            {
                MessageBox.Show("Mã số không được bỏ trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtHovsTen.Text.Trim() == "")
            {
                MessageBox.Show("Họ Vs Tên không được bỏ trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = txtMaSv.Text;
                this.txtMaSv.ResetText();
                ListViewItem.ListViewSubItem Hoten = new ListViewItem.ListViewSubItem();
                Hoten.Text = txtHovsTen.Text;
                this.txtHovsTen.ResetText();
                ListViewItem.ListViewSubItem birthday = new ListViewItem.ListViewSubItem();
                birthday.Text = dtpNgaySinh.Text;
                this.dtpNgaySinh.ResetText();
                ListViewItem.ListViewSubItem phai = new ListViewItem.ListViewSubItem();
                phai.Text = radbNam.Checked ? "Nam" : "Nữ";
                ListViewItem.ListViewSubItem quequan = new ListViewItem.ListViewSubItem();
                quequan.Text = cboQueQuan.Text;
                this.cboQueQuan.ResetText();
                ListViewItem.ListViewSubItem numberphone = new ListViewItem.ListViewSubItem();
                numberphone.Text = txtDienThoai.Text;
                this.txtDienThoai.ResetText();

                item.SubItems.Add(Hoten);
                item.SubItems.Add(birthday);
                item.SubItems.Add(phai);
                item.SubItems.Add(quequan);
                item.SubItems.Add(numberphone);
                
                listThongtinchung.Items.Add(item);
            }
        }

        private void listThongtinchung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listThongtinchung.SelectedItems.Count > 0)
            {
             
                txtMaSv.Text = listThongtinchung.SelectedItems[0].SubItems[0].Text;
                txtHovsTen.Text = listThongtinchung.SelectedItems[0].SubItems[1].Text;
                dtpNgaySinh.Text = listThongtinchung.SelectedItems[0].SubItems[2].Text;
                if (listThongtinchung.SelectedItems[0].SubItems[3].Text == "Nam")
                {
                   radbNam.Checked = true;
                }
                else
                {
                    radbNu.Checked = true;
                }
                
                cboQueQuan.Text = listThongtinchung.SelectedItems[0].SubItems[4].Text;

                txtDienThoai.Text = listThongtinchung.SelectedItems[0].SubItems[5].Text;

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in this.listThongtinchung.SelectedItems)
            {
             
                listThongtinchung.Items.RemoveAt(item.Index);
            }
           
                 
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (listThongtinchung.SelectedItems.Count > 0)
            {
                ListViewItem item = listThongtinchung.SelectedItems[0];
                item.Text = txtMaSv.Text;
                item.SubItems[1].Text = txtHovsTen.Text;
                item.SubItems[2].Text = dtpNgaySinh.Text;
                item.SubItems[3].Text = radbNam.Checked ? "Nam":"Nu";
                item.SubItems[4].Text = cboQueQuan.Text;
                item.SubItems[5].Text = txtDienThoai.Text;

            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
