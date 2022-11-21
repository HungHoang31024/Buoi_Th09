using System.Linq.Expressions;

namespace Bai_6._2
{
    public partial class Bài02 : Form
    {
        public Bài02()
        {
            InitializeComponent();
        }
        private void InitExploreTreeView()
        {
            tvThuMuc.ShowRootLines = true;
            tvThuMuc.ShowLines = true;
            TreeNode root;
            string[] driver = Directory.GetLogicalDrives();
            foreach(string drive in driver)
            {
                root = new TreeNode(drive);
                root.Nodes.Add("...");
                tvThuMuc.Nodes.Add(root);
            }
        }
        private void tvThuMuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
           

           
                
            DirectoryInfo dr = new DirectoryInfo(e.Node.FullPath);
            flowLayoutPanel1.Controls.Clear();
            PictureBox[] pic;
            picHinhAnh.Image = null;
            if(dr.Exists)
            {
                pic = new PictureBox[dr.GetFiles().GetLength(0)];
                int i = 0;
                foreach(FileInfo file in dr.GetFiles())
                {
                    if (file.Name.EndsWith("jpg") || file.Name.EndsWith("png") || file.Name.EndsWith("bmp"))
                    {

                        pic[i] = new PictureBox();
                        pic[i].Name = "pic" + file.Name;
                        pic[i].SizeMode = PictureBoxSizeMode.Zoom;
                        pic[i].Size = new Size(100, 100);
                        pic[i].BorderStyle = BorderStyle.FixedSingle;
                        pic[i].Image = Image.FromFile(e.Node.FullPath + "//" + file.Name);
                        pic[i].Click += new EventHandler(picHinhAnh_Click);
                      

                    }
                }
            }            
        }       
        private void Bài02_Load(object sender, EventArgs e)
        {
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;           
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillNode(TreeNode rootNode)
        {
            DirectoryInfo dri = new DirectoryInfo(rootNode.FullPath);
            foreach (DirectoryInfo chirldName in dri.GetDirectories())
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
            PictureBox pic = (PictureBox)sender;
            picHinhAnh.Image = pic.Image;
        }
    }
    
}