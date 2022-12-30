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
using System.Windows.Forms.VisualStyles;
namespace BuoiTH11
{
    public partial class QLHSinh : Form
    {
        public QLHSinh()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet("dsQLHS");
        SqlDataAdapter dahocsinh;
        SqlDataAdapter daquequan;

        SqlConnection conn = new SqlConnection(@"Data Source=HUNG-T0352;Initial Catalog=QLHS;Integrated Security=True");

        private void QLHSinh_Load(object sender, EventArgs e)
        {
            
          
            string SQlHocSinh = @"select h.*, q.tenqq from hocsinh h, quequan q where h.maqq=q.maqq";
            dahocsinh = new SqlDataAdapter(SQlHocSinh, conn);
            dahocsinh.Fill(ds, "tblhocsinh");
            dgvQLhs.DataSource = ds.Tables["tblhocsinh"];

            dgvQLhs.Columns["mahs"].HeaderText = "Mã Học Sinh";
            dgvQLhs.Columns["mahs"].Width = 150;
            this.dgvQLhs.Columns["mahs"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvQLhs.Columns["mahs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvQLhs.Columns["holot"].HeaderText = "Họ lót";
            dgvQLhs.Columns["holot"].Width = 170;
            this.dgvQLhs.Columns["holot"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvQLhs.Columns["holot"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvQLhs.Columns["tenhs"].HeaderText = "Tên";
            dgvQLhs.Columns["tenhs"].Width = 100;
            this.dgvQLhs.Columns["tenhs"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvQLhs.Columns["tenhs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvQLhs.Columns["phai"].HeaderText = "Phái";
            dgvQLhs.Columns["phai"].Width = 100;
            this.dgvQLhs.Columns["phai"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvQLhs.Columns["phai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvQLhs.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dgvQLhs.Columns["ngaysinh"].Width = 190;
            this.dgvQLhs.Columns["ngaysinh"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvQLhs.Columns["ngaysinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvQLhs.Columns["tenqq"].HeaderText = "Quê Quán";
            dgvQLhs.Columns["tenqq"].Width = 190;
            this.dgvQLhs.Columns["tenqq"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvQLhs.Columns["tenqq"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvQLhs.Columns["maqq"].Visible = false;
            string sqlQuequan = @"select * from quequan";
            daquequan = new SqlDataAdapter(sqlQuequan, conn);
            daquequan.Fill(ds, "tblquequan");
            cboQueQuan.DataSource = ds.Tables["tblquequan"];

            dgvQLhs.RowsDefaultCellStyle.BackColor = Color.Lavender;
            dgvQLhs.AlternatingRowsDefaultCellStyle.BackColor = Color.LawnGreen;

            string SThemHs = @"insert into hocsinh values(@mahs, @holot, @tenhs, @phai, @ngaysinh, @maqq, @tenqq)";
            SqlCommand cmThemhs = new SqlCommand(SThemHs, conn);
            cmThemhs.Parameters.Add("@mahs", SqlDbType.Char, 5, "mahs");
            cmThemhs.Parameters.Add("@holot", SqlDbType.NVarChar, 40, "holot");
            cmThemhs.Parameters.Add("@tenhs", SqlDbType.NVarChar, 30, "tenhs");
            cmThemhs.Parameters.Add("@phai", SqlDbType.NVarChar, 15, "phai");
            cmThemhs.Parameters.Add("@ngaysinh", SqlDbType.Date, 5, "ngaysinh");
            cmThemhs.Parameters.Add("@maqq", SqlDbType.Char, 5, "maqq");
            cmThemhs.Parameters.Add("@tenqq", SqlDbType.NVarChar, 20, "tenqq");
            dahocsinh.InsertCommand = cmThemhs;

            string sql = @"select s.* from quequan s";
            SqlDataAdapter data = new SqlDataAdapter(sql, conn);
            DataTable tbl = new DataTable();
            data.Fill(tbl);
            cboQueQuan.DataSource = tbl;
            cboQueQuan.DisplayMember = tbl.Columns["tenqq"].ToString();

           

            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["tblhocsinh"].NewRow();
            row["mahs"] = txtMS.Text;
            row["holot"] = txtHoLot.Text;
            row["tenhs"] = txtTen.Text;
            if ( rdbNam.Checked == true)
            {
               row["phai"] = "Nam";
            }
            else
            {
                row["phai"] = "Nữ";
            }
            row["ngaysinh"] = dtpNgaySinh.Text;
            row["tenqq"] = cboQueQuan.Text;
            ds.Tables["tblhocsinh"].Rows.Add(row);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvQLhs.SelectedRows[0];

            txtMS.Text = dr.Cells["mahs"].Value.ToString();
            txtHoLot.Text = dr.Cells["holot"].Value.ToString();
            txtTen.Text = dr.Cells["tenhs"].Value.ToString();
            if (dr.Cells["phai"].Value.ToString() == "Nam")
            {
                rdbNam.Checked = true;
            }
            else
            {
                rdbNu.Checked = true;
            }

            dtpNgaySinh.Text = dr.Cells["ngaysinh"].Value.ToString();
            cboQueQuan.Text = dr.Cells["maqq"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgvQLhs.SelectedRows[0];

            r.Cells["mahs"].Value = txtMS.Text;
            r.Cells["holot"].Value = txtHoLot.Text;
            r.Cells["tenhs"].Value = txtTen.Text;
            if (rdbNam.Checked == true)
            {
                r.Cells["phai"].Value = "Nam";
            }
            else
            {
                r.Cells["phai"].Value = "Nữ";
            }
            r.Cells["ngaysinh"].Value = dtpNgaySinh.Text;
            r.Cells["maqq"].Value = cboQueQuan.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvQLhs.SelectedRows)
            {
                dgvQLhs.Rows.RemoveAt(item.Index);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMS.ResetText();
            txtHoLot.ResetText();
            txtTen.ResetText();
            cboQueQuan.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }


    }
}
