using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VectorCreater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Storage storage = new Storage(100); //создание хранилища
        Bitmap bmp = new Bitmap(1800,800); //создание места для рисования
        Point temp = new Point(0, 0);
        public Bitmap Image { get; internal set; }
        //SortedDictionary<char, Command> commands = new SortedDictionary<char, Command>();

        /*private void ColorObserver(object sender, EventArgs e) 
        {
            
        }*/
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Дерево");
            myTreeView treeView1 = new myTreeView();
            treeView1 = new myTreeView();
            treeView1.Location = new System.Drawing.Point(567, 12);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Узел1";
            treeNode1.Text = "Дерево";
            treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode1 });
            treeView1.SelectedNode = treeNode1;
            treeView1.Size = new System.Drawing.Size(191, 277);
            treeView1.TabIndex = 10;
            this.Controls.Add(treeView1);
            treeView1.AfterSelect += new TreeViewEventHandler(treeView1_AfterSelect);
            treeView1.Name = "tview";
            (Controls["tview"] as myTreeView).addStorage(storage);
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            RadioButton rb = rbColorBlack; //выбор цвета создаваемой компоненты
            if(rbColorBlack.Checked == true) 
            {
                rb = rbColorBlack;
            } 
            else if (rbColorRed.Checked == true)
            {
                rb = rbColorRed;
            }
            else if(rbColorYellow.Checked == true)
            {
                rb = rbColorYellow;
            }
            else if(rbColorGreen.Checked == true)
            {
                rb = rbColorGreen;
            }
            else if(rbColorBlue.Checked == true)
            {
                rb = rbColorBlue;
            }
            else if(rbColorViolet.Checked == true)
            {
                rb = rbColorViolet;
            }
            if (Control.ModifierKeys == Keys.Control) //если зажат Ctrl
            {
                if (storage.checkInfo2(e) == false) 
                {
                    if (radioButton1.Checked == true)
                    {
                        storage.addObj(new CCircle(e.X, e.Y, 20, rb.ForeColor));
                        g.Clear(Color.WhiteSmoke);
                        Refresh();
                    }
                    else if (radioButton2.Checked == true)
                    {
                        storage.addObj(new CSquare(e.X, e.Y, 40, rb.ForeColor));
                        g.Clear(Color.WhiteSmoke);
                        Refresh();
                    }
                    else if (radioButton3.Checked == true)
                    {
                        storage.addObj(new CTriangle(e.X, e.Y - 30, e.X + 20, e.Y + 10, e.X - 20, e.Y + 10, rb.ForeColor));
                        g.Clear(Color.WhiteSmoke);
                        Refresh();
                    }
                    else if (radioButton4.Checked == true)
                    {
                        if (temp.X == 0)
                        {
                            temp = new Point(e.X, e.Y);
                        }
                        else
                        {
                            storage.addObj(new Secture(temp.X, temp.Y, e.X, e.Y, rb.ForeColor));
                            g.Clear(Color.WhiteSmoke);
                            temp.X = 0;
                            temp.Y = 0;
                            Refresh();
                        }

                    }
                    lb1.Text = storage.getCount().ToString();
                }
                else 
                {
                    lb1.Text = storage.getCount().ToString();
                    g.Clear(Color.WhiteSmoke);
                    Refresh();
                }

            }
            else
            {
                if (storage.checkInfo1(e) == false) //если нажали по форме
                {
                    if (radioButton1.Checked == true)
                    {
                        storage.addObj(new CCircle(e.X, e.Y, 20, rb.ForeColor));
                        g.Clear(Color.WhiteSmoke);
                        Refresh();
                    }
                    else if (radioButton2.Checked == true)
                    {
                        storage.addObj(new CSquare(e.X, e.Y, 40, rb.ForeColor));
                        g.Clear(Color.WhiteSmoke);
                        Refresh();
                    }
                    else if (radioButton3.Checked == true)
                    {
                        storage.addObj(new CTriangle(e.X, e.Y - 30, e.X + 20, e.Y + 10, e.X - 20, e.Y + 10, rb.ForeColor));
                        g.Clear(Color.WhiteSmoke);
                        Refresh();
                    }
                    else if (radioButton4.Checked == true)
                    {
                        if (temp.X == 0)
                        {
                            temp = new Point(e.X, e.Y);
                        }
                        else
                        {
                            storage.addObj(new Secture(temp.X, temp.Y, e.X, e.Y, rb.ForeColor));
                            g.Clear(Color.WhiteSmoke);
                            temp.X = 0;
                            temp.Y = 0;
                            Refresh();
                        }

                    }
                    lb1.Text = storage.getCount().ToString();
                    (Controls["tview"] as myTreeView).Nodes.Clear();
                    (Controls["tview"] as myTreeView).Nodes.Add(new TreeNode("Дерево"));
                    storage.processNode((Controls["tview"] as myTreeView).Nodes[0], storage._storage);
                    (Controls["tview"] as myTreeView).ExpandAll();
                }
                else //если мышью нажали на объект на форме
                {
                    lb1.Text = storage.getCount().ToString();
                    g.Clear(Color.WhiteSmoke);
                    Refresh();
                }
            }
            (Controls["tview"] as myTreeView).callRecursive(Controls["tview"] as myTreeView, storage);
            Refresh();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = pictureBox1.CreateGraphics();
            
            Graphics g = Graphics.FromImage(bmp);
            for (int i = 0; i < (storage.getCount()); i++)
            {
                storage.methodObj(pictureBox1, i,bmp, g);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            if (e.KeyData == Keys.A)
            {
                storage.moveObj(pictureBox1,-10, 0);
                g.Clear(Color.WhiteSmoke);
                Refresh();
            }
            if (e.KeyData == Keys.D)
            {
                storage.moveObj(pictureBox1, 10, 0);
                g.Clear(Color.WhiteSmoke);
                Refresh();
            }
            if (e.KeyData == Keys.W)
            {
                storage.moveObj(pictureBox1, 0, -10);
                g.Clear(Color.WhiteSmoke);
                Refresh();
            }
            if (e.KeyData == Keys.S)
            {
                storage.moveObj(pictureBox1, 0, 10);
                g.Clear(Color.WhiteSmoke);
                Refresh();
            }
            if(e.KeyData == Keys.Delete) 
            {
                storage.deleteWhenDel();
                g.Clear(Color.WhiteSmoke);
                (Controls["tview"] as myTreeView).Nodes.Clear();
                (Controls["tview"] as myTreeView).Nodes.Add(new TreeNode("Дерево"));
                storage.processNode((Controls["tview"] as myTreeView).Nodes[0], storage._storage);
                (Controls["tview"] as myTreeView).ExpandAll();
                Refresh();
            }
            if(e.KeyData == Keys.Up) 
            {
                storage.resizeObj(pictureBox1,5);
                g.Clear(Color.WhiteSmoke);
                Refresh();
            }
            if (e.KeyData == Keys.Down)
            {
                storage.resizeObj(pictureBox1,-5);
                g.Clear(Color.WhiteSmoke);
                Refresh();
            }
            /*if(e.KeyData == Keys.Left) 
            {
                storage.changeAngle(pictureBox1,-5);
                g.Clear(Color.WhiteSmoke);
                Refresh();
            }
            if (e.KeyData == Keys.Right)
            {
                storage.changeAngle(pictureBox1, 5);
                g.Clear(Color.WhiteSmoke);
                Refresh();
            }*/
            lb1.Text = storage.getCount().ToString();
            Refresh();
        }

        private void rbColorBlack_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            storage.changeObjColor(rb.ForeColor);
        }

        private void rbColorRed_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            storage.changeObjColor(rb.ForeColor);
        }

        private void rbColorYellow_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            storage.changeObjColor(rb.ForeColor);
        }

        private void rbColorGreen_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            storage.changeObjColor(rb.ForeColor);
        }

        private void rbColorBlue_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            storage.changeObjColor(rb.ForeColor);
        }

        private void rbColorViolet_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            storage.changeObjColor(rb.ForeColor);
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            storage.createGroup();
            g.Clear(Color.WhiteSmoke);
            (Controls["tview"] as myTreeView).Nodes.Clear();
            (Controls["tview"] as myTreeView).Nodes.Add(new TreeNode("Дерево"));
            storage.processNode((Controls["tview"] as myTreeView).Nodes[0], storage._storage);
            (Controls["tview"] as myTreeView).ExpandAll();
            Refresh();
        }

        private void btnReGroup_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            storage.deleteGroup();
            g.Clear(Color.WhiteSmoke);
            (Controls["tview"] as myTreeView).Nodes.Clear();
            (Controls["tview"] as myTreeView).Nodes.Add(new TreeNode("Дерево"));
            storage.processNode((Controls["tview"] as myTreeView).Nodes[0], storage._storage);
            (Controls["tview"] as myTreeView).ExpandAll();
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            storage.saveObjs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            storage.loadObjs();
            g.Clear(Color.WhiteSmoke);
            Refresh();
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            //storage.getObjectSticky();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) 
        {
            Graphics g = Graphics.FromImage(bmp);
            (Controls["tview"] as myTreeView).notifyStorage(e.Node);
            g.Clear(Color.WhiteSmoke);
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            storage.makeObjSticky();
        }
    }
    class myTreeView : TreeView
    {
        private Storage storage;

        public void addStorage(Storage _storage)
        {
            storage = _storage;
        }
        public void notifyStorage(TreeNode treeNode)
        {
            storage.treeNodeSelect(treeNode);
            //storage.Change
            //короче если чето в дереве выберем, то тут делаем так
            //чтобы и в хранилище чето менялось

        }
        public void objSelectRecursive(TreeNode treeNode,Shape shape)
        {
            if (treeNode.Tag == shape)
            {
                treeNode.TreeView.SelectedNode = treeNode;
            }
            foreach (TreeNode tn in treeNode.Nodes)
            {          
                objSelectRecursive(tn,shape);
            }
        }
        public void callRecursive(myTreeView treeView,Storage s)
        {
            Shape shape = s.getSelectedShape();
            foreach (TreeNode n in treeView.Nodes)
            {
                objSelectRecursive(n, shape);               
            }
        }
    }
}
