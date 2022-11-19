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
    public partial class Form3 : Form
    {
        private String bForm3;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string c)
        {
            InitializeComponent();
            this.bForm3 = c;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            lblkq.Text = bForm3;
        }
    }
}
