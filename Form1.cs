﻿using System;
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
            //storage.observers += new System.EventHandler(this.ColorObserver);
        }

        Storage storage = new Storage(100); //создание хранилища
        Bitmap bmp = new Bitmap(1800,800); //создание места для рисования
        public Bitmap Image { get; internal set; }
        //SortedDictionary<char, Command> commands = new SortedDictionary<char, Command>();

        /*private void ColorObserver(object sender, EventArgs e) 
        {
            
        }*/
        private void Form1_Load(object sender, EventArgs e)
        {
            /*commands.Add('A', new MoveCommand(-10, 0));
            commands.Add('D', new MoveCommand(10, 0));
            commands.Add('W', new MoveCommand(0, -10));
            commands.Add('S', new MoveCommand(0, 10));*/
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);

            if (storage.checkInfo1(e) == false) //если нажали по форме
            {
                if (radioButton1.Checked == true)
                {
                    storage.addObj(new CCircle(e.X, e.Y, 20));
                    g.Clear(Color.WhiteSmoke);
                    Refresh();
                }
                else if (radioButton2.Checked == true)
                {
                    storage.addObj(new CSquare(e.X, e.Y, 40));
                    g.Clear(Color.WhiteSmoke);
                    Refresh();
                }
                else if (radioButton3.Checked == true)
                {
                    storage.addObj(new CTriangle(e.X, e.Y - 30, e.X + 20, e.Y + 10, e.X - 20, e.Y + 10));
                    g.Clear(Color.WhiteSmoke);
                    Refresh();
                }
                lb1.Text = storage.getCount().ToString();
            }
            else //если мышью нажали на объект на форме
            {
                lb1.Text = storage.getCount().ToString();
                g.Clear(Color.WhiteSmoke);
                Refresh();
            }
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
    }
}
