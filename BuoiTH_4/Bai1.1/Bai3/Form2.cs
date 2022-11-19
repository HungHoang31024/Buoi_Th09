using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form2 : Form
    {
        private String bForm2;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string p)
        {
            InitializeComponent();
            this.bForm2 = p;
            
        }              
        private void Form2_Load(object sender, EventArgs e)
        {
            lblKq.Text = bForm2;
            
        }
    }
}
