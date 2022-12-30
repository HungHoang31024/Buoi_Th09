using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quản_Lý_Bán_Sach
{
    public partial class Don_Ban_Hang : Form
    {
        public Don_Ban_Hang()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet("dsQLBSach");


        SqlDataAdapter daSach;
        SqlDataAdapter daHD;
        SqlConnection conn = new SqlConnection();
        public void loadData()
        {
            conn.ConnectionString = @"Data Source=HUNG-T0352;Initial Catalog=QLBSach;Integrated Security=True";

            string sQuerySACH = @"select * from SACH ";
            daSach = new SqlDataAdapter(sQuerySACH, conn);
            daSach.Fill(ds, "tblDSSACH");
            dgvHD.DataSource = ds.Tables["tblDSSACH"];

            // Dữ liệu datagrid Sách 
            string sQueryHoaDon = @"select hd.*,s.TenSach,s.DonGia, s.SLTon from HOADON hd,SACH s where hd.MaSach=s.MaSach ";
            daHD = new SqlDataAdapter(sQueryHoaDon, conn);
            daHD.Fill(ds, "tblDSHOADON");
            dgvHD.DataSource = ds.Tables["tblDSHOADON"];

            dgvHD.Columns["MaHD"].HeaderText = "Mã Hóa Đơn";
            dgvHD.Columns["MaHD"].Width = 100;
            this.dgvHD.Columns["MaHD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvHD.Columns["MaHD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvHD.Columns["NgayBan"].HeaderText = "Ngày Bán";
            dgvHD.Columns["NgayBan"].Width = 150;
            this.dgvHD.Columns["NgayBan"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvHD.Columns["NgayBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            dgvHD.Columns["SLMua"].HeaderText = "Số Lương Mua";
            dgvHD.Columns["SLMua"].Width = 150;
            this.dgvHD.Columns["SLMua"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvHD.Columns["SLMua"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvHD.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dgvHD.Columns["ThanhTien"].Width = 150;
            this.dgvHD.Columns["ThanhTien"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvHD.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvHD.Columns["MaSach"].HeaderText = "Mã Sách";
            dgvHD.Columns["MaSach"].Width = 100;
            this.dgvHD.Columns["MaSach"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvHD.Columns["MaSach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvHD.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvHD.Columns["TenSach"].Width = 200;
            this.dgvHD.Columns["TenSach"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvHD.Columns["TenSach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvHD.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgvHD.Columns["DonGia"].Width = 110;
            this.dgvHD.Columns["DonGia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvHD.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvHD.Columns["SLTon"].HeaderText = "Số Lượng Sách";
            dgvHD.Columns["SLTon"].Width = 110;
            this.dgvHD.Columns["SLTon"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvHD.Columns["SLTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvHD.RowsDefaultCellStyle.BackColor = Color.YellowGreen;
            dgvHD.AlternatingRowsDefaultCellStyle.BackColor = Color.White;



            lsvDSMHang.Items[0].BackColor = Color.Blue;

            lsvDSMHang.BackColor = Color.Lavender;


            string sThemHD = @"insert into HOADON values(@MaHD, @NgayBan, @SLMua, @ThanhTien, @MaSach)";
            SqlCommand cmThemHD = new SqlCommand(sThemHD, conn);
            cmThemHD.Parameters.Add("@MaHD", SqlDbType.Char, 5, "MaHD");
            cmThemHD.Parameters.Add("@NgayBan", SqlDbType.Date, 0, "NgayBan");
            cmThemHD.Parameters.Add("@SLMua", SqlDbType.SmallInt, 0, "SLMua");
            cmThemHD.Parameters.Add("@ThanhTien", SqlDbType.Int, 20, "ThanhTien");
            cmThemHD.Parameters.Add("@MaSach", SqlDbType.Char, 5, "MaSAch");
            daHD.InsertCommand = cmThemHD;

            string sThemS = @"insert into SACH values(@TenSach, @DonGia, @SLTon)";
            SqlCommand cmThemS = new SqlCommand(sThemS, conn);
            cmThemS.Parameters.Add("@MaSach", SqlDbType.Char, 5, "MaSach");
            cmThemS.Parameters.Add("@TenSach", SqlDbType.NVarChar, 40, "TenSach");
            cmThemS.Parameters.Add("@DonGia", SqlDbType.Int, 0, "DonGia");
            cmThemS.Parameters.Add("@SLTon", SqlDbType.SmallInt, 0, "SLTon");
            daSach.InsertCommand = cmThemS;
        }

        private void Don_Ban_Hang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvHD.SelectedRows[0];

            txtMaHD.Text = dr.Cells["MaHD"].Value.ToString();
            dtpNBan.Text = dr.Cells["NgayBan"].Value.ToString();
            txtSLMua.Text = dr.Cells["SLMua"].Value.ToString();
            txtTTien.Text = dr.Cells["ThanhTien"].Value.ToString();
            txtTenS.Text = dr.Cells["TenSach"].Value.ToString();
            txtDGia.Text = dr.Cells["DonGia"].Value.ToString();
            txtMaS.Text = dr.Cells["MaSach"].Value.ToString();
            txtSLSTon.Text = dr.Cells["SLTon"].Value.ToString();
        }
        public void ThanhTien()
        {
            string tt;
            int t1,t2, t3;
            t1 = int.Parse(txtSLMua.Text);
            t2 = int.Parse(txtDGia.Text);
            t3 = t1 * t2;
            tt = Convert.ToString(t3);
            this.txtTTien.Text = tt;
        }
        private void btnThemDSM_Click(object sender, EventArgs e)
        {
            ThanhTien();
            this.txtMaHD.Focus();
            int slt = int.Parse(txtSLSTon.Text);
            int slm = int.Parse(txtSLMua.Text);
            
            int truSL = slt - slm;
            string sl = Convert.ToString(truSL);
            txtSLSTon.Text = sl;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update SACH set SLTon= @SLTon where MaSach = @MaSAch", conn);
            cmd.Parameters.AddWithValue("MaSach", Convert.ToString(txtMaS.Text));
            cmd.Parameters.AddWithValue("SLTon", Convert.ToString(txtSLSTon.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Đã cập nhật");
            if(dgvHD.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgvHD.SelectedRows[00];
                dr.Cells["SLTon"].Value = txtSLSTon.Text;
            }

            //thêm vao listview
            ListViewItem item = lsvDSMHang.Items.Add(txtMaHD.Text);
            item.SubItems.Add(dtpNBan.Text.ToString());
            item.SubItems.Add(txtSLMua.Text.ToString());
            item.SubItems.Add(txtTTien.Text.ToString());
            item.SubItems.Add(txtTenS.Text.ToString());
            item.SubItems.Add(txtDGia.Text.ToString());

            //Thêm hóa dơn
            DataRow row1 = ds.Tables["tblDSHOADON"].NewRow();
            row1["MaHD"] = txtMaHD.Text;
            row1["NgayBan"] = dtpNBan.Text;
            row1["SLMua"] = txtSLMua.Text;
            row1["ThanhTien"] = txtTTien.Text;
            row1["MaSach"] = txtMaS.Text;
            row1["TenSach"] = txtTenS.Text;
            row1["DonGia"] = txtDGia.Text;
            ds.Tables["tblDSHOADON"].Rows.Add(row1);
          /*  //lưu
            this.BindingContext[ds, "tblDSHOADON"].EndCurrentEdit();
            this.BindingContext[ds, "tblDSSACH"].EndCurrentEdit();
            if (ds.HasChanges() == true)
            {
                if (MessageBox.Show("Bạn có thực sự muốn lưu các thay đổi trên bảng dữ liệu Danh sách nhân viên ?", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                          daHD.Update(ds.Tables["tblDSHOADON"]);
                          daSach.Update(ds.Tables["tblDSSACH"]);                                       
                        MessageBox.Show("Đã cập nhật");
                    }
                    catch (Exception x) { MessageBox.Show(x.Message); }              
                }
            }
            else
            {
                MessageBox.Show("Cơ sở dữ liệu chưa có sự thay đổi.", "Thông báo người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          */
        }
        public void Sum()
        {
            double sumTT = 0;
            for (int i = 0; i < lsvDSMHang.Items.Count; i++)
            {
                sumTT += double.Parse(lsvDSMHang.Items[i].SubItems[3].Text);
            }
            this.lblTongT.Text = sumTT.ToString();


        }
        private void btnTongT_Click(object sender, EventArgs e)
        {
            Sum();
        }

        private void btnXoaDSM_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete HOADON  where MaHD=@MaHD", conn);
            cmd.Parameters.AddWithValue("@MaHD", Convert.ToString(txtMaHD.Text));
            cmd.ExecuteNonQuery();
            /*SqlCommand cmd1 = new SqlCommand("Delete HOADON  where MaHD=@MaHD", conn);
            cmd.Parameters.AddWithValue("@MaHD", Convert.ToString(txtMaHD.Text));
            cmd.ExecuteNonQuery();*/
            conn.Close();
            MessageBox.Show("Xóa thành công");
            //Xóa texbox
            this.txtMaHD.ResetText();
            this.txtDGia.ResetText();
            this.txtMaS.ResetText();
            this.txtSLMua.ResetText();
            this.txtTenS.ResetText();
            this.txtTTien.ResetText();
            this.dtpNBan.ResetText();
            //Xóa Bảng datagridview
            foreach (DataGridViewRow dr in this.dgvHD.SelectedRows)
            {
                this.dgvHD.Rows.RemoveAt(dr.Index);
            }
            //Xóa bảng listview 
            if (lsvDSMHang.SelectedItems.Count > 0)
            {
                lsvDSMHang.Items.Remove(lsvDSMHang.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("cần phải chọn ít nhất 1 dòng");
            }
        }
    }
}
