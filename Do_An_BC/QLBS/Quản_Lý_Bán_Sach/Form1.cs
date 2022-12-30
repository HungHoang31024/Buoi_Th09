using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quản_Lý_Bán_Sach
{
    public partial class frmQLBS : Form
    {
        public frmQLBS()
        {
            InitializeComponent();
            
        }
        DataSet ds = new DataSet("dsQLBSach");

        SqlDataAdapter daSach;
        SqlDataAdapter daHD;
        SqlConnection conn = new SqlConnection();
        public void loadData()
        {
            //SqlConnection conn = new SqlConnection();

            conn.ConnectionString = @"Data Source=HUNG-T0352;Initial Catalog=QLBSach;Integrated Security=True";


            // Dữ liệu datagrid Sách 
            string sQuerySach = @"select s.* from SACH s";
            daSach = new SqlDataAdapter(sQuerySach, conn);
            daSach.Fill(ds, "tblDSSACH");
            dgvSach.DataSource = ds.Tables["tblDSSACH"];

            dgvSach.Columns["MaSach"].HeaderText = "Mã Sách";
            dgvSach.Columns["MaSach"].Width = 100;
            this.dgvSach.Columns["MaSach"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvSach.Columns["MaSach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvSach.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvSach.Columns["TenSach"].Width = 200;
            this.dgvSach.Columns["TenSach"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvSach.Columns["TenSach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            dgvSach.Columns["TacGia"].HeaderText = "Tác Giả";
            dgvSach.Columns["TacGia"].Width = 180;
            this.dgvSach.Columns["TacGia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvSach.Columns["TacGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvSach.Columns["TenNSX"].HeaderText = "Tên Nhà Sản Xuất";
            dgvSach.Columns["TenNSX"].Width = 200;
            this.dgvSach.Columns["TenNSX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvSach.Columns["TenNSX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvSach.Columns["MaLoai"].HeaderText = "Mã Loại";
            dgvSach.Columns["MaLoai"].Width = 110;
            this.dgvSach.Columns["MaLoai"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvSach.Columns["MaLoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvSach.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgvSach.Columns["DonGia"].Width = 170;
            this.dgvSach.Columns["DonGia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvSach.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvSach.Columns["SLTon"].HeaderText = "Số Lượng Tồn";
            dgvSach.Columns["SLTon"].Width = 150;
            this.dgvSach.Columns["SLTon"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvSach.Columns["SLTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvSach.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
            dgvSach.Columns["NgayNhap"].Width = 130;
            this.dgvSach.Columns["NgayNhap"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvSach.Columns["NgayNhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




            string sThemS = @"insert into SACH values(@MaSach, @TenSach, @TacGia,@TenNSX, @MaLoai, @DonGia, @SLTon,@NgayNhap)";
            SqlCommand cmThemS = new SqlCommand(sThemS, conn);
            cmThemS.Parameters.Add("@MaSach", SqlDbType.Char, 20, "MaSach");
            cmThemS.Parameters.Add("@TenSach", SqlDbType.NVarChar, 40, "TenSach");
            cmThemS.Parameters.Add("@TacGia", SqlDbType.NVarChar, 50, "TacGia");
            cmThemS.Parameters.Add("@TenNSX", SqlDbType.NVarChar, 20, "TenNSX");
            cmThemS.Parameters.Add("@MaLoai", SqlDbType.Char, 5, "MaLoai");
            cmThemS.Parameters.Add("@DonGia", SqlDbType.Int, 10, "DonGia");
            cmThemS.Parameters.Add("@SLTon", SqlDbType.SmallInt, 5, "SLTon");
            cmThemS.Parameters.Add("@NgayNhap", SqlDbType.Date, 0, "NgayNhap");
            daSach.InsertCommand = cmThemS;
        }
            private void btnThemS_Click(object sender, EventArgs e)
        {
            //Thêm TT Sách
            DataRow row = ds.Tables["tblDSSACH"].NewRow();
            row["MaSach"] = txtMSach.Text;
            row["TenSach"] = txtTSach.Text;
            row["TacGia"] = txtTGia.Text;
            row["TenNSX"] = txtNSXuat.Text;
            row["MaLoai"] = txtMLoai.Text;
            row["DonGia"] = txtĐGia.Text;
            row["SLTon"] = txtSLCon.Text;
            row["NgayNhap"] = dtpNNhap.Text;
            ds.Tables["tblDSSACH"].Rows.Add(row);
            //lưu
            this.BindingContext[ds, "tblDSSACH"].EndCurrentEdit();
            if (ds.HasChanges() == true)
            {
                if (MessageBox.Show("Bạn có thực sự muốn lưu các thay đổi trên bảng dữ liệu Danh sách nhân viên ?", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        
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
        }

        private void frmQLBS_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvSach.SelectedRows[0];

            txtMSach.Text = dr.Cells["MaSach"].Value.ToString();
            txtTSach.Text = dr.Cells["TenSach"].Value.ToString();
            txtTGia.Text = dr.Cells["TacGia"].Value.ToString();
            txtNSXuat.Text = dr.Cells["TenNSX"].Value.ToString();
            txtMLoai.Text = dr.Cells["MaLoai"].Value.ToString();
            txtĐGia.Text = dr.Cells["DonGia"].Value.ToString();
            txtSLCon.Text = dr.Cells["SLTon"].Value.ToString();
            dtpNNhap.Text = dr.Cells["NgayNhap"].Value.ToString();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            //sửa in SQL
            string tens = txtTSach.Text, tg = txtTGia.Text, nsx = txtNSXuat.Text, ml = txtMLoai.Text;
            string sl = Convert.ToString(txtSLCon.Text);
            string ms = Convert.ToString(txtMSach.Text);
            int dg = int.Parse(txtĐGia.Text);
            DateTime nn = DateTime.Parse(dtpNNhap.Text);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update SACH set TenSach=@TenSach, TacGia=@TacGia, TenNSX=@TenNSX, MaLoai=@MaLoai, DonGia=@DonGia, SLTon=@SLTon, NgayNhap=@NgayNhap where MaSach=@MaSach", conn);
            cmd.Parameters.AddWithValue("@MaSach", Convert.ToString(txtMSach.Text));
            cmd.Parameters.AddWithValue("@TenSach", txtTSach.Text);
            cmd.Parameters.AddWithValue("@TacGia", txtTGia.Text);
            cmd.Parameters.AddWithValue("@TenNSX", txtNSXuat.Text);
            cmd.Parameters.AddWithValue("@MaLoai", txtMLoai.Text);
            cmd.Parameters.AddWithValue("@DonGia", int.Parse(txtĐGia.Text));
            cmd.Parameters.AddWithValue("@SLTon", Convert.ToString(txtSLCon.Text));
            cmd.Parameters.AddWithValue("@NgayNhap", DateTime.Parse(dtpNNhap.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa thành công");
            //Sửa trên datgridview
            if (dgvSach.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgvSach.SelectedRows[0];
                dr.Cells["MaSach"].Value = txtMSach.Text;
                dr.Cells["TenSach"].Value = txtTSach.Text;
                dr.Cells["TacGia"].Value = txtTGia.Text;
                dr.Cells["TenNSX"].Value = txtNSXuat.Text;
                dr.Cells["MaLoai"].Value = txtMLoai.Text;
                dr.Cells["DonGia"].Value = txtĐGia.Text;
                dr.Cells["SLTon"].Value = txtSLCon.Text;
                dr.Cells["NgayNhap"].Value = dtpNNhap.Text;
                //ds.Tables["tblDSSACH"].Rows.Add(dr);
            }
        }

        private void btnXoaS_Click(object sender, EventArgs e)
        {
            //Xóa dữ liệu SQl
            string tens = txtTSach.Text, tg = txtTGia.Text, nsx = txtNSXuat.Text, ml = txtMLoai.Text;
            string sl = Convert.ToString(txtSLCon.Text);
            string ms = Convert.ToString(txtMSach.Text);
            string dg = Convert.ToString(txtĐGia.Text);
            DateTime nn = DateTime.Parse(dtpNNhap.Text);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete SACH  where MaSach=@MaSach", conn);
            cmd.Parameters.AddWithValue("@MaSach", Convert.ToString(txtMSach.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Xóa thành công");
            //Xóa texbox
            this.txtMSach.ResetText();
            this.txtTSach.ResetText();
            this.txtTGia.ResetText();
            this.txtNSXuat.ResetText();
            this.txtĐGia.ResetText();

            this.txtSLCon.ResetText();

            this.txtMLoai.ResetText();
            this.dtpNNhap.ResetText();
            //Xóa Bảng datagridview
            foreach (DataGridViewRow dr in this.dgvSach.SelectedRows)
            {
                this.dgvSach.Rows.RemoveAt(dr.Index);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            gbTimKiem.Visible = true;
            dgvTimSach.Visible = true;

            dgvTimSach.Rows.Clear();
            for (int i = 0; i < dgvSach.Rows.Count - 1; i++)
            {
                if (dgvSach[0, i].Value.ToString() == cmbTKSach.Text)
                {

                    dgvTimSach.Rows.Add(dgvSach[0, i].Value, dgvSach[1, i].Value, dgvSach[2, i].Value, dgvSach[3, i].Value,
                        dgvSach[4, i].Value, dgvSach[5, i].Value, dgvSach[6, i].Value, dgvSach[7, i].Value);

                }
            }

            string sql = @"select s.* from SACH s";
            SqlDataAdapter data = new SqlDataAdapter(sql, conn);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            cmbTKSach.DataSource = dataTable;
            cmbTKSach.DisplayMember = dataTable.Columns["MaSach"].ToString();
            cmbTKSach.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}