using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Bán_Sach
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet("dsQLBSach");
        SqlDataAdapter daSach;
        SqlConnection conn = new SqlConnection();
        public void loadData()
        {
            conn.ConnectionString = @"Data Source=HUNG-T0352;Initial Catalog=QLBSach;Integrated Security=True";

            // Dữ liệu datagrid Sách 
            string sQuerySach = @"select MaSach, TenSach, TacGia, TenNSX, MaLoai, DonGia, SLTon, NgayNhap  from SACH";
            daSach = new SqlDataAdapter(sQuerySach, conn);
            daSach.Fill(ds, "tblDSSACH");
            dtgThongKeSach.DataSource = ds.Tables["tblDSSACH"];

            dtgThongKeSach.Columns["MaSach"].HeaderText = "Mã Sách";
            dtgThongKeSach.Columns["MaSach"].Width = 100;
            this.dtgThongKeSach.Columns["MaSach"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgThongKeSach.Columns["MaSach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgThongKeSach.Columns["TenSach"].HeaderText = "Tên Sách";
            dtgThongKeSach.Columns["TenSach"].Width = 220;
            this.dtgThongKeSach.Columns["TenSach"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgThongKeSach.Columns["TenSach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgThongKeSach.Columns["TacGia"].HeaderText = "Tác Giả";
            dtgThongKeSach.Columns["TacGia"].Width = 170;
            this.dtgThongKeSach.Columns["TacGia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgThongKeSach.Columns["TacGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgThongKeSach.Columns["TenNSX"].HeaderText = "Tên NSX";
            dtgThongKeSach.Columns["TenNSX"].Width = 220;
            this.dtgThongKeSach.Columns["TenNSX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgThongKeSach.Columns["TenNSX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgThongKeSach.Columns["MaLoai"].HeaderText = "Mã Loại";
            dtgThongKeSach.Columns["MaLoai"].Width = 90;
            this.dtgThongKeSach.Columns["MaLoai"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgThongKeSach.Columns["MaLoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgThongKeSach.Columns["DonGia"].HeaderText = "Đơn Giá";
            dtgThongKeSach.Columns["DonGia"].Width = 170;
            this.dtgThongKeSach.Columns["DonGia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgThongKeSach.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgThongKeSach.Columns["SLTon"].HeaderText = "SL Tồn";
            dtgThongKeSach.Columns["SLTon"].Width = 60;
            this.dtgThongKeSach.Columns["SLTon"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgThongKeSach.Columns["SLTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgThongKeSach.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
            dtgThongKeSach.Columns["NgayNhap"].Width = 200;
       
            this.dtgThongKeSach.Columns["NgayNhap"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgThongKeSach.Columns["NgayNhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgThongKeSach.RowsDefaultCellStyle.BackColor = Color.YellowGreen;
            dtgThongKeSach.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            string sThemS = @"insert into Sach values(@MaSach, @TenSach, @TacGia,@TenNSX, @MaLoai, @DonGia, @SLTon, @NgayNhap)";
            SqlCommand cmThemS = new SqlCommand(sThemS, conn);
            cmThemS.Parameters.Add("@MaSach", SqlDbType.Char, 20, "MaSach");
            cmThemS.Parameters.Add("@TenSach", SqlDbType.NVarChar, 40, "TenSach");
            cmThemS.Parameters.Add("@TacGia", SqlDbType.NVarChar, 50, "TacGia");
            cmThemS.Parameters.Add("@TenNSX", SqlDbType.NVarChar, 20, "TenNSX");
            cmThemS.Parameters.Add("@MaLoai", SqlDbType.Char, 5, "MaLoai");
            cmThemS.Parameters.Add("@DonGia", SqlDbType.Int, 10, "DonGia");
            cmThemS.Parameters.Add("@SLTon", SqlDbType.SmallInt, 5, "SLTon");
            cmThemS.Parameters.Add("@NgayNhap", SqlDbType.Date, 20, "NgayNhap");



            daSach.InsertCommand = cmThemS;
        }
        private void ThongKe_Load(object sender, EventArgs e)
        {
            loadData();
            string sql = @"select s.* from SACH s";
            SqlDataAdapter dat = new SqlDataAdapter(sql, conn);
            DataTable dataTable = new DataTable();
            dat.Fill(dataTable);

            cmbNgayNhapS.DataSource = dataTable;         
            cmbNgayNhapS.ValueMember = dataTable.Columns["NgayNhap"].ToString();

            SqlDataAdapter Dat = new SqlDataAdapter(sql, conn);
            DataTable dataTb = new DataTable();
            Dat.Fill(dataTb);
            cmbSLCu.DataSource = dataTb;
            cmbSLCu.ValueMember = dataTb.Columns["SLTon"].ToString();
            
        }
        
        private void btnTK_Click(object sender, EventArgs e)
        {
            
            dgvTKSNLau.Rows.Clear();
            for (int i = 0; i < dtgThongKeSach.Rows.Count - 1; i++)
            {
                if (dtgThongKeSach[7, i].Value.ToString() == cmbNgayNhapS.Text)
                {
                    dgvTKSNLau.Rows.Add(dtgThongKeSach[0, i].Value, dtgThongKeSach[1, i].Value, dtgThongKeSach[2, i].Value, dtgThongKeSach[3, i].Value,
                        dtgThongKeSach[4, i].Value, dtgThongKeSach[5, i].Value, dtgThongKeSach[6, i].Value, dtgThongKeSach[7, i].Value);

                }
            }

            dgvTKSNLau.RowsDefaultCellStyle.BackColor = Color.Red;
            dgvTKSNLau.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void btnTKe_Click(object sender, EventArgs e)
        {
            dgvTKSLCIt.Rows.Clear();
           
            for (int i = 0; i < dtgThongKeSach.Rows.Count - 1; i++)
            {
                if (dtgThongKeSach[6, i].Value.ToString() == cmbSLCu.Text)
                {
                    dgvTKSLCIt.Rows.Add(dtgThongKeSach[0, i].Value, dtgThongKeSach[1, i].Value, dtgThongKeSach[2, i].Value, dtgThongKeSach[3, i].Value,
                        dtgThongKeSach[4, i].Value, dtgThongKeSach[5, i].Value, dtgThongKeSach[6, i].Value, dtgThongKeSach[7, i].Value);

                }
            }                      
            dgvTKSLCIt.RowsDefaultCellStyle.BackColor = Color.Red;
            dgvTKSLCIt.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
