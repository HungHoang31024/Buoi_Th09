namespace Bai_6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int TongTien = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Label[] labels = new Label[30];
            for(int i = 0; i< 30; i++)
            {
                labels[i] = new Label();
                labels[i].Width = 90;
                labels[i].Height = 95;
                labels[i].BackColor = Color.White;
                labels[i].BorderStyle = BorderStyle.Fixed3D;
                labels[i].Margin = new Padding(3, 3, 3, 10);
                labels[i].Text = (i + 1).ToString();
                labels[i].Click += new EventHandler(label1_Click);
                flowLayoutPanel1.Controls.Add(labels[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label lbchon = (Label)sender;
            if (lbchon.BackColor == Color.White)
            {
                lbchon.BackColor = Color.Blue;
                TongTien += 100000;
                lbThanhtien.Text = TongTien + "VND";
            }
            else if (lbchon.BackColor == Color.Blue)
            {
                lbchon.BackColor = Color.White;
                lbThanhtien.Text = TongTien + "VND";
            }
            else if (lbchon.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế này đã được bán", "Đã Bán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            foreach(Label label in flowLayoutPanel1.Controls)
            {
                if(label.BackColor == Color.Blue)
                {
                    label.BackColor = Color.Yellow;
                    TongTien = 0;
                    lbThanhtien.Text = TongTien + "VND";
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach(Label label in flowLayoutPanel1.Controls)
            {
                if(label.BackColor == Color.Blue)
                {
                    label.BackColor = Color.White;
                    TongTien = 0;
                    lbThanhtien.Text = TongTien + "VND";
                }
            }
        }

      

        private void lbThanhtien_Click(object sender, EventArgs e)
        {
            
        }
    }
}