namespace Bai_4
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
       
           

       

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
           foreach(ListViewItem item in this.listDanhSachSV.SelectedItems)
            {
                listDanhSachSV.Items.RemoveAt(item.Index);
            }
        }

        private void btnThêm_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text.Trim() == "")
                MessageBox.Show("Mã Sinh viên không có", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txthoten.Text.Trim() == "")
                MessageBox.Show("Họ tên không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = txtmasv.Text;

                ListViewItem.ListViewSubItem hoten = new ListViewItem.ListViewSubItem();
                hoten.Text = txthoten.Text;
                ListViewItem.ListViewSubItem ngaysinh = new ListViewItem.ListViewSubItem();
                ngaysinh.Text = dtpngaysinh.Text;
                ListViewItem.ListViewSubItem lop = new ListViewItem.ListViewSubItem();
                lop.Text = cboLop.Text;
                ListViewItem.ListViewSubItem diachi = new ListViewItem.ListViewSubItem();
                diachi.Text = txtdiachi.Text;

                item.SubItems.Add(hoten);
                item.SubItems.Add(ngaysinh);
                item.SubItems.Add(lop);
                item.SubItems.Add(diachi);

                listDanhSachSV.Items.Add(item);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Lưu Tệp";
            saveFileDialog1.Filter = "Tập tin TXT|*.txt";
            saveFileDialog1.InitialDirectory = "E:\\";
            saveFileDialog1.FileName = "Demo";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = saveFileDialog1.OpenFile();
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(listDanhSachSV.SelectedItems);
                writer.Close();
                stream.Close();

            }

        }

        private void listDanhSachSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmasv.Text = listDanhSachSV.SelectedItems[0].SubItems[0].Text;
            txthoten.Text = listDanhSachSV.SelectedItems[0].SubItems[1].Text;
            txtdiachi.Text = listDanhSachSV.SelectedItems[0].SubItems[2].Text;
            dtpngaysinh.Text = listDanhSachSV.SelectedItems[0].SubItems[3].Text;
            cboLop.Text = listDanhSachSV.SelectedItems[0].SubItems[4].Text;
        }
    }
}