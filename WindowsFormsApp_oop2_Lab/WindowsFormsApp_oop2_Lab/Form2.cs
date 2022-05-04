using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;

using System.Windows.Forms;

namespace WindowsFormsApp_oop2_Lab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int[] ilkX;
        int[] ilkY;
        bool suruklenmedurumu = false;
        Point ilkkonum;
        public string username;
       
        private void Form2_Load(object sender, EventArgs e)
        {
            if (username == "admin")
            {
                managersc.Visible = true;
            }
            Form3 form3 = new Form3();
            //******************
            XmlDocument doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + "//user.xml");
            foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person/Difficulty"))
            {
                if (node.SelectSingleNode("degree").FirstChild.InnerText == "Easy")
                    create_board(15, 15);
                if (node.SelectSingleNode("degree").FirstChild.InnerText == "Normal")
                    create_board(9, 9);
                if (node.SelectSingleNode("degree").FirstChild.InnerText == "Hard")
                    create_board(6, 6);
                if (node.SelectSingleNode("degree").FirstChild.InnerText == "Custom")
                {
                    string a = node.SelectSingleNode("degree").NextSibling.InnerText;
                    string b = node.SelectSingleNode("degree").NextSibling.NextSibling.InnerText;
                    create_board(int.Parse(a), int.Parse(b));
                }
            }
            
        }

        private void create_board(int row, int col)
        {
            Button[,] buttons = new Button[row, col];
            int top = 40;
            int left = 10;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                   
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    buttons[i,j].Click += new EventHandler(btn_Click);
                    buttons[i, j].MouseMove += new MouseEventHandler(btn_move);
                    buttons[i, j].MouseDown += new MouseEventHandler(btn_down);
                    buttons[i, j].MouseUp += new MouseEventHandler(btn_up);
                    
                    
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 10;
            }
            Random rnd = new Random();
            Random rnd1 = new Random();
            Random rastgele = new Random();
            for (int i = 0; i < 3; i++)
            {
                int rowa = rnd.Next(buttons.GetUpperBound(0)+1);
                int column = rnd1.Next(buttons.GetUpperBound(1)+1);
                var value = buttons[column, rowa];
                int sayi = rastgele.Next(3);
                if(sayi==0)
                { value.BackgroundImage = ımageList1.Images[0]; }
                if (sayi == 1)
                { value.BackgroundImage = ımageList1.Images[1]; }
                if (sayi == 2)
                { value.BackgroundImage = ımageList1.Images[2]; }
                value = null;
                
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            int x = btn.Location.X;
            int y = btn.Location.Y;

            
        }
        private void btn_move(object sender, MouseEventArgs e)
        {
            Button btn = (sender as Button);
            int a, b;
            if (suruklenmedurumu)
            {
                //a = btn.Left;
                //b = btn.Top;
                //a = e.X + a - (ilkkonum.X);
                //b = e.Y + b - (ilkkonum.Y);
                //btn.Location = new Point(a, b);
                //int i = 0, j = 0;
                //i = e.X+i;
                //j = e.Y+j;
               
            }
           

        }
        private void btn_down(object sender, MouseEventArgs e)
        {
            Button btn = (sender as Button);
            suruklenmedurumu = true;
            btn.Cursor = Cursors.Default;
            ilkkonum = e.Location;

        }
        private void btn_up(object sender, MouseEventArgs e)
        {
            Button btn = (sender as Button);
            suruklenmedurumu = false;
            int i = 0, j = 0;
            i = e.X + i;
            j = e.Y + j;
            btn.Location = new Point(btn.Location.X+i,btn.Location.Y+j);
            
            btn.Cursor = Cursors.Default;
            
        }
        
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            profile pr = new profile();
            pr.Show();
        }

        private void managersc_Click(object sender, EventArgs e)
        {
            ListAllUsers l = new ListAllUsers();
            l.Show();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about ab = new about();
            ab.ShowDialog();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
