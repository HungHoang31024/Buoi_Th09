using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnFont_Click(object sender, EventArgs e)
        {
            //hiển thị chức năng chọn màu
            fontDialog1.ShowColor = true;
            //chọn màu mặc định
            fontDialog1.Color = txtNhap.ForeColor;
            //thiết lập font mặc định là font của txtnhap
            fontDialog1.Font = txtNhap.Font;
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                //thiết lập font mới cho lable
                txtNhap.Font = fontDialog1.Font;
                this.txtNhap.ForeColor = fontDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMau_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtNhap.ForeColor = colorDialog1.Color;

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
                       
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNhap.Text = openFileDialog1.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Lưu tệp tin";
            saveFileDialog1.Filter = "Tập tin TXT |*.txt";
            saveFileDialog1.InitialDirectory = "D:\\";
            saveFileDialog1.FileName = "Demo";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = saveFileDialog1.OpenFile();
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(txtNhap.Text);
                writer.Close();
                stream.Close();

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
