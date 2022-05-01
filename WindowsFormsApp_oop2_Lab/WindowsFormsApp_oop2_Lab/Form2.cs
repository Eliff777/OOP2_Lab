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
            }//end of creating board as it wanted to be...
                

            //Random rnd = new Random();
            //Random rnd1 = new Random();
            //for (int i = 0; i < 3; i++)
            //{
            //    int row = rnd.Next(buttons.GetUpperBound(0));
            //    int column = rnd1.Next(buttons.GetUpperBound(1));
            //    var value = buttons[column, row];
            //   // value.BackgroundImage = ımageList1.Images[0];
            //    value = null;
            //}
            
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
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 10;
            }
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
    }
}
