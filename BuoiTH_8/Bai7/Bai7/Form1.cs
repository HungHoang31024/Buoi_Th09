namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbHinhVuong_Click(object sender, EventArgs e)
        {
            //xoá hết hết dữ liệu tất cả các ô
            this.txtDai.Clear();
            this.txtCanh.Clear();
            this.txtBK.Clear();
            this.txtRong.Clear();

            //chỉ có txtCanh là có tác dụng
            this.txtCanh.Enabled = true;
            this.txtBK.Enabled = false;
            this.txtRong.Enabled = false;
            this.txtDai.Enabled = false;

            //dặt con trỏ ở txtCanh
            this.txtCanh.Focus();
        }

        private void rdbHCN_Click(object sender, EventArgs e)
        {
            //xoá hết hết dữ liệu tất cả các ô
            this.txtDai.Clear();
            this.txtCanh.Clear();
            this.txtBK.Clear();
            this.txtRong.Clear();

            //chỉ có txtBK là có tác dụng
            this.txtCanh.Enabled = false;
            this.txtBK.Enabled = false;
            this.txtRong.Enabled = true;
            this.txtDai.Enabled = true;

            //dặt con trỏ ở txtCanh
            this.txtDai.Focus();
        }

        private void rdbHTron_Click(object sender, EventArgs e)
        {
            //xoá hết hết dữ liệu tất cả các ô
            this.txtDai.Clear();
            this.txtCanh.Clear();
            this.txtBK.Clear();
            this.txtRong.Clear();

            //chỉ có txtCanh là có tác dụng
            this.txtCanh.Enabled = false;
            this.txtBK.Enabled = true;
            this.txtRong.Enabled = false;
            this.txtDai.Enabled = false;

            //dặt con trỏ ở txtCanh
            this.txtBK.Focus();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rdbHinhVuong.Checked == true)
            {
                if (this.txtCanh.Text == "")
                {
                    MessageBox.Show("Hãy nhập vài chiều dài cạnh", "Thông Báo");
                    this.txtCanh.Focus();
                }
                else
                {
                    Form2 f2 = new Form2();
                    f2.canha = double.Parse(txtCanh.Text);
                    f2.ShowDialog();
                }
            }

            else if (rdbHCN.Checked == true)
            {
                if ((this.txtDai.Text == "") || (this.txtRong.Text == ""))
                {
                    MessageBox.Show("Hãy nhập chiều dài và chièu rộng", "Thông Báo");
                    this.txtDai.Focus();
                }
                else
                {
                    Form3 f3 = new Form3();
                    f3.daia = double.Parse(txtDai.Text);
                    f3.ronga = double.Parse(txtRong.Text);
                    f3.ShowDialog();
                }
            }
            else if(rdbHTron.Checked == true)
            {
                if(this.txtBK.Text == "")
                {
                    MessageBox.Show("Hãy nhật bán kính hình tròn", "Thông Báo");
                    this.txtBK.Focus();
                }
                else
                {
                    Form4 f4 = new Form4();
                    f4.bankinh = double.Parse(txtBK.Text);
                    f4.ShowDialog();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult thoat;
            thoat = MessageBox.Show("Bạn Muốn Đóng Chương Trình ?", "Thông báo", MessageBoxButtons.YesNo);
            if (thoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}