using System.Data;
using System.Security.Cryptography;
namespace QLTV
{
    public partial class Frmtaomoitk : Form
    {
        SqlConnection cn;
        SqlCommand cmdSelect;
        SqlCommand cmdInsert;
        SqlCommand cmdXoa;
        int i = 0;
        public Frmtaomoitk()
        {
            InitializeComponent();
        }
        private void MoKetnoi()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
        }
        private void LoadListView()
        {
            MoKetnoi();
            cmdSelect = new SqlCommand("Select* form nhanvien", cn);
            SqlDataReader r = cmdSelect.ExecuteReader();
            listView1.Items.Clear(); // Xoá tất cả dữ liệu trong listview 1
            while (r.Read())
            {
                String[] st = new String[5];
                st[0] = r[0].ToString();
                st[1] = r[1].ToString();
                st[2] = r[2].ToString();
                st[3] = r[4].ToString();
                st[4] = r[5].ToString();

                ListViewItem lv = new ListViewItem(st);
                listView1.Items.Add(lv);
           
            }
            cmdSelect.Dispose();
        }
        private LoadIteam(int i)
        {
            txtMaNV.Text = listView1.Items[i].Text;
            txtHoTen.Text = listView1.Items[i].SubItems[1].Text;
            txtDiaChi.Text = listView1.Items[i].SubItems[2].Text;
            txtTenDangNhap.Text = listView1.Items[i].SubItems[3].Text;
            cboQH.Text = listView1.Items[i].SubItems[4].Text;
        }
        private void LoadCombox()
        {
            cboQH.Items.Add("admin");
            cboQH.Items.Add("SinhVien");
            cboQH.Items.Add("thuthu");
            cboQH.Text = "admin";
        }
        private void xoatextbox()
        {
            txtMaNV.Clear();
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtMaNV.Focus();
        }
        private int KiemTraMa(string ma)
        {
            MoKetnoi();

        }
    }
}