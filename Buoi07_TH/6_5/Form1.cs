namespace _6_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
        }
      
        Graphics g;
        int x1, y1, x2, y2;
        
        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {           
            x1 = e.X;
            y1 = e.Y;
        }

        private void txtmauvien_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtmauvien.BackColor = colorDialog1.Color;
        }

        private void txtmau_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtmau.BackColor = colorDialog1.Color;
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {                     
                x2 = e.X;
                y2 = e.Y;                       
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(SystemColors.Control);
            SolidBrush mauto = new SolidBrush(txtmau.BackColor);
            int s = Convert.ToInt32(num.Value);
            Pen p = new Pen(txtmauvien.BackColor,s);
            if(cboChonHinhVe.Text == "Hình Tròn")
            {
                g.DrawEllipse(p, x1 - 1, y1 - 1, x2 - x1, y2 - y1);
                g.FillEllipse(mauto, x1, y1, x2 - x1 - 2, y2 - y1 - 2);
            }
        }

        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
        
        }
      
    }
}