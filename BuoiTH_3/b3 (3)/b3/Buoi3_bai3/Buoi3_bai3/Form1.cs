namespace Buoi3_bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstWeb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.txtKq.Text = "Bạn đã chọn website ";
            this.txtKq.Text += this.lstWeb.SelectedItem.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtKq.Clear();
        }
    }
}