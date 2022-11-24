namespace _6_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            canPaint = false;
        }
        bool canPaint;
        Graphics g;
        int x, y;
        
        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            canPaint = true;
            x = e.X;
            y = e.Y;
        }
        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            //cboColor1.Text = colorDialog1.ToString();
            if (canPaint)
            {
                g.DrawLine(Pens.Blue, x, y, e.X, e.Y);               
                x = e.X;
                y = e.Y;
              
            }
        }
        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            canPaint = false;
        }
      
    }
}