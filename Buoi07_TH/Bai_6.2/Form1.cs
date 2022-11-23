using System.Linq.Expressions;
using System.IO;
using System.Net.NetworkInformation;
using static System.Net.WebRequestMethods;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai_6._2
{
    public partial class Bài02 : Form
    {
        public Bài02()
        {
            InitializeComponent();
        }        
        private void tvThuMuc_AfterSelect(object sender, TreeViewEventArgs e)
        {                                
             DirectoryInfo di = new DirectoryInfo(e.Node.FullPath);
             foreach (FileInfo file in di.GetFiles())
             {
                PictureBox[] pic = new PictureBox[20];
                int i = 0;
                string extension = file.Extension;
                if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif")
                {
                    if (i >= 20) break; 
                    pic[i] = new PictureBox();
                    pic[i].BorderStyle = BorderStyle.FixedSingle;
                    pic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    pic[i].Image = Image.FromFile(file.FullName);
                    pic[i].Click += new EventHandler(picHinhAnh_Click);
                    flowLayoutPanel1.Controls.Add(pic[i]);
                    i++;
                    flowLayoutPanel1.Update();
                }
             }
            
            
        }

        private void Bài02_Load(object sender, EventArgs e)
        {
            /* string[] drives = Directory.GetLogicalDrives();

             TreeNode node = null;

             foreach (string drv in drives)
             {
                 node = new TreeNode(drv);

                 tvThuMuc.Nodes.Add(node);

                 node.Nodes.Add("");
             }        */
            tvThuMuc.ShowRootLines = true;
            tvThuMuc.ShowLines = true;
            TreeNode root;
            string[] driver = Directory.GetLogicalDrives();
            foreach (string dvr in driver)
            {
                root = new TreeNode(dvr);
                root.Nodes.Add(new TreeNode(""));
                tvThuMuc.Nodes.Add(root);
            }
        }
        private void ExploreDirectory(DirectoryInfo dir, TreeNode node)
        {
            DirectoryInfo[] directories = dir.GetDirectories();
            foreach (DirectoryInfo newDir in directories)
            {
                TreeNode x = new TreeNode(newDir.Name);
                node.Nodes.Add(x);
                try
                {
                    ExploreDirectory(newDir, x);
                }
                catch (Exception) { }
            }
        }  
        private void picHinhAnh_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            picHinhAnh.Image = pic.Image;
        }

        private void tvThuMuc_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                if (e.Node.Nodes[0].Text == "")
                {
                    e.Node.Nodes.Clear();
                    FillNode(e.Node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillNode(TreeNode rootNode)
        {
            DirectoryInfo dir = new DirectoryInfo(rootNode.FullPath);
            foreach (DirectoryInfo chirldName in dir.GetDirectories())
            {
                TreeNode chirldNode = new TreeNode(chirldName.Name);
                chirldNode.Nodes.Add(new TreeNode(""));
                rootNode.Nodes.Add(chirldNode);
            }
        }
        private void Bài02_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            picHinhAnh.Image = pic.Image;
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
         

        }
    }
    
}