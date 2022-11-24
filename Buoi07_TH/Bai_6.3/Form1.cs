using System.Security.Cryptography;

namespace Bai_6._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] hinhanh = new string[20];
        int index = 0;
        private void btnModsh_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Chọn thư mục chứa ảnh";
            folderBrowserDialog1.ShowNewFolderButton = false;
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //Đọc thư mục
                DirectoryInfo dr = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                int i = 0;
                foreach(var file in dr.GetFiles())
                {
                    string extension = file.Extension;
                    if(extension == ".jpg" || extension == ".git" || extension == ".png" || extension == ".jpeg")
                    {
                        if(i >= 20)
                        {
                            break;
                        }                   
                        hinhanh[i] = file.FullName;
                        i++;                                         
                    }

                }
            }
            //Nếu có ảnh thì ảnh đầu hiện lên pic 
            if(hinhanh.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(hinhanh[0]);
            }
        }

        private void btntruoc_Click(object sender, EventArgs e)
        {
            index--;
            if(index <= 0)
            {
                index = 19;
            }
            else
            {
                btnSau.Enabled = true;
                pictureBox1.Image = Image.FromFile(hinhanh[index]);
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            index++;
            if(index >= 19)
            {
                index = 0;
            }
            else
            {
                btntruoc.Enabled = true;
                pictureBox1.Image = Image.FromFile(hinhanh[index]);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if(index > 9)
            {
                index = -1;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}