using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                     
            int thang = int.Parse(txtThang.Text);
            int ngay = int.Parse(txtNgay.Text);
            int nam = int.Parse(txtNam.Text);               
            if (thang >= 1 && thang <= 12)
            {
                
                switch (thang)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (ngay > 31)
                            MessageBox.Show("Ngay khong hop le!!");
                        else
                            MessageBox.Show("Ngay hop le");
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (ngay > 30)
                            MessageBox.Show("Ngay khong hop le");
                        else
                            MessageBox.Show("Ngay hop le");
                        break;
                    case 2:
                        if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
                        {
                            if (ngay > 29)
                                MessageBox.Show("Ngay khong hop le");
                            else
                                MessageBox.Show("Ngay hop le");
                        }
                         else 
                        {
                            if (ngay > 28)
                                MessageBox.Show("Ngay khong hop le");
                            else
                                MessageBox.Show("Ngay hop le");
                        }
                        break;
                }


             
            }
         

        }

        private void txtNgay_TextChanged(object sender, EventArgs e)
        {
                          
        }

        private void txtThang_TextChanged(object sender, EventArgs e)
        {            
            
        }

        private void txtNam_TextChanged(object sender, EventArgs e)
        {          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
