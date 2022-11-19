using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a, b, d, r;
        float x, y, z;
        double P, S;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            this.grbTron.Enabled = true;
            this.grbTamGiac.Enabled = true;
            this.grbHinhCN.Enabled = true;
            this.grbHinhVuong.Enabled = true;
            if (rdbNhat.Checked == true)
            {
                a = Convert.ToInt32(txtNhapACHunhat.Text);
                b = Convert.ToInt32(txtNhapBChuNhat.Text);
                txtChuviCN.Text = Convert.ToString((a + b) * 2);
                txtDienTichCN.Text = Convert.ToString(a * b);
            }
            if (rdbTamGiac.Checked == true)
            {
                float a = float.Parse(txtTgA.Text);
                float b = float.Parse(txtTgB.Text);
                float c = float.Parse(txtTgC.Text);

                x = a * a;
                y = b * b;
                z = c * c;

                if (a + b > c && a + c > b && b + c > a)
                {
                    if (x == y || y == z || z == x)
                    {
                        if (x == y && y == z)
                            txtKqTamGiac.Text = ("Tam Giác đều");
                        else
                        {
                            if (x == y + z || y == z + x || z == x + y)
                                txtKqTamGiac.Text = ("Tam Giác vuông cân");
                            else
                                txtKqTamGiac.Text = ("Tam Giác Cân");
                        }
                    }

                    else
                    {
                        if (x == y + z || y == x + z || z == x + y)
                            txtKqTamGiac.Text = ("Tam Giác vuông");
                        else
                            txtKqTamGiac.Text = ("Tam Giác Thường");
                    }
                    P = (a + b + c) / 2;
                    S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
                    txtTgCVi.Text = Convert.ToString(S);
                    txtDtTamGiac.Text = Convert.ToString(P);

                }
                else
                    txtKqTamGiac.Text = ("Ba cạnh không tạo thành tam giác");
            }
            if(rdbTron.Checked == true)
            {
                r = Convert.ToInt32(txtBanKinh.Text);
                txtCVhTRon.Text = Convert.ToString((r * 2) * 3.14);
                txtDTHTron.Text = Convert.ToString(3.14 * 3.14 * r);
                
            }
            if(rdbVuong.Checked == true)
            {
                d = Convert.ToInt32(txtNhapCanhA.Text);
                txtChuvihv.Text = Convert.ToString(d * 4);
                txtDientichHV.Text= Convert.ToString(d * d);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtChuviCN.ResetText();
            txtDienTichCN.ResetText();
            txtNhapACHunhat.ResetText();
            txtNhapBChuNhat.ResetText();
            txtNhapCanhA.ResetText();
            txtChuvihv.ResetText();
            txtDientichHV.ResetText();
            txtBanKinh.ResetText();
            txtCVhTRon.ResetText();
            txtDTHTron.ResetText();
            txtTgA.ResetText();
            txtTgB.ResetText();
            txtTgC.ResetText();
            txtTgCVi.ResetText();
            txtDtTamGiac.ResetText();
            txtKqTamGiac.ResetText();
        }

        private void grbHinhVuong_Enter(object sender, EventArgs e)
        {
            

        }

        private void grbHinhCN_Enter(object sender, EventArgs e)
        {
            
        }

        private void grbTron_Enter(object sender, EventArgs e)
        {
            
        }

        private void grbTamGiac_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            grbHinhCN.Visible = false;
            grbTamGiac.Visible = false;
            grbTron.Visible = false;
            grbHinhVuong.Visible = false;
        }

        private void rdbTron_CheckedChanged(object sender, EventArgs e)
        {
            grbHinhVuong.Visible = false;
            grbHinhCN.Visible = false;
            grbTamGiac.Visible = false;
            grbTron.Visible = true;
            this.grbTron.Enabled = true;
        }

        private void rdbTamGiac_CheckedChanged(object sender, EventArgs e)
        {
            grbHinhVuong.Visible = false;
            grbHinhCN.Visible = false;
            grbTamGiac.Visible = true;
            grbTron.Visible = false;
            this.grbTamGiac.Enabled = true;
        }

        private void rdbNhat_CheckedChanged(object sender, EventArgs e)
        {
            grbHinhVuong.Visible = false;
            grbHinhCN.Visible = true;
            grbTamGiac.Visible = false;
            grbTron.Visible = false;
            this.grbHinhCN.Enabled = true;
        }

        private void rdbVuong_CheckedChanged(object sender, EventArgs e)
        {
            grbHinhVuong.Visible = true;
            grbHinhCN.Visible = false;
            grbTamGiac.Visible = false;
            grbTron.Visible = false;
            this.grbHinhVuong.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
