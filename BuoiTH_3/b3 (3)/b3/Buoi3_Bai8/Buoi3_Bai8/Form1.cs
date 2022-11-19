namespace Buoi3_Bai8
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

        private void btnHTLoichao_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Chào" + cmbten.Text+".Chúc một ngày vui vẻ");
        }
    }
}