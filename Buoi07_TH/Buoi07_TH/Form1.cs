namespace Buoi07_TH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {          
            string kytu = txtName.Text.Substring(0, 1).ToUpper();         
            foreach (TreeNode root in treeView1.Nodes)
            {
                if (root.Text == kytu)
                {              
                        TreeNode nodecon = new TreeNode();
                        nodecon.Text = txtName.Text + ", " + txtsurname.Text;
                        root.Nodes.Add(nodecon);
                        this.txtName.ResetText();
                        this.txtsurname.ResetText();
                        treeView1.ExpandAll();
                    
                }               
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* for(char i = 'A'; i <= 'Z'; i++)
            {
                TreeNode root = new TreeNode();
                root.Text = i.ToString();
                treeView1.Nodes.Add(root);
            }*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}