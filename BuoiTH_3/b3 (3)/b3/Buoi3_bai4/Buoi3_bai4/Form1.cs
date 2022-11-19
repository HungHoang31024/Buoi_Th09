namespace Buoi3_bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.txtHoTen.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo"); this.txtHoTen.Focus();
            }
            else
            {
                string hoten = this.txtHoTen.Text;
                if (this.rad1.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToLower();
                }
                if (this.rad2.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToUpper();
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoTen.ResetText();
            this.txtKQ.ResetText();
            this.rad1.ResetText();
            this.txtHoTen.Focus();

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}