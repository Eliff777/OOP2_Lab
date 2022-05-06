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
                imagelist = createimagelist();
                if (node.SelectSingleNode("degree").FirstChild.InnerText == "Easy")
                {
                    butonlar = create_board(15, 15);
                    random_atama(imagelist, butonlar);
                }
                if (node.SelectSingleNode("degree").FirstChild.InnerText == "Normal")
                {
                    butonlar = create_board(9, 9);
                    random_atama(imagelist, butonlar);
                }
                if (node.SelectSingleNode("degree").FirstChild.InnerText == "Hard")
                {
                    butonlar = create_board(6, 6);
                    random_atama(imagelist, butonlar);
                }
                if (node.SelectSingleNode("degree").FirstChild.InnerText == "Custom")
                {
                    string a = node.SelectSingleNode("degree").NextSibling.InnerText;
                    string b = node.SelectSingleNode("degree").NextSibling.NextSibling.InnerText;
                    butonlar = create_board(int.Parse(a), int.Parse(b));
                    random_atama(imagelist, butonlar);
                }
                
            }//end of creating board as it wanted to be...
            
            
        }
        private bool secondtime = false;
        private Button b = null;
        private ImageList imagelist = null;
        private Button[,] butonlar = null;
        private void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (secondtime == true)
            {
                //Button img = (Button) Application.OpenForms["Form2"].Tag;
                btn.BackgroundImage = b.BackgroundImage;
                secondtime = false;
                b.BackgroundImage = null;
                b = null;
                random_atama(imagelist, butonlar);
            }
            else
            {
                b = btn;
                secondtime = true;
            }
        }
        private void showthepath()
        {

        }
        private void random_atama(ImageList img, Button[,] buttons)
        {
            int i = 0;

            while (i < 3)
            {
                Random rnd = new Random();
                Random rnd1 = new Random();
                int random_number = new Random().Next(0, img.Images.Count);
                int rowa = rnd.Next(buttons.GetUpperBound(0));
                int column = rnd1.Next(buttons.GetUpperBound(0));
                var value = buttons[column, rowa];
                if (value.BackgroundImage == null)
                {
                    Bitmap resized = new Bitmap(img.Images[random_number], new Size(50, 50));
                    value.BackgroundImage = resized;
                    i++;
                }
            }
        }

        private ImageList createimagelist()
        {
            ImageList img = new ImageList();
            List<string> renkler = new List<string>();
            List<string> şekiller = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + "//user.xml");
            foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            {
                if (node.SelectSingleNode("Colour").FirstChild.InnerText == "true") 
                renkler.Add("red");
                if (node.SelectSingleNode("Colour").FirstChild.NextSibling.InnerText == "true") 
                renkler.Add("blue");
                if (node.SelectSingleNode("Colour").LastChild.InnerText == "true") 
                renkler.Add("yellow");

                if (node.SelectSingleNode("Shape").FirstChild.InnerText == "true")
                    şekiller.Add("square");
                if (node.SelectSingleNode("Shape").FirstChild.NextSibling.InnerText == "true")
                    şekiller.Add("triangle");
                if (node.SelectSingleNode("Shape").LastChild.InnerText == "true")
                    şekiller.Add("round");
            }

           if(renkler.Contains("red"))
           {
                if (şekiller.Contains("round"))
                    img.Images.Add(ımageList1.Images[0]);
                if (şekiller.Contains("square"))
                    img.Images.Add(ımageList1.Images[1]);
                if (şekiller.Contains("triangle"))
                    img.Images.Add(ımageList1.Images[2]);
           }
            if (renkler.Contains("blue"))
            {
                if (şekiller.Contains("round"))
                    img.Images.Add(ımageList1.Images[3]);
                if (şekiller.Contains("square"))
                    img.Images.Add(ımageList1.Images[4]);
                if (şekiller.Contains("triangle"))
                    img.Images.Add(ımageList1.Images[5]);
            }
            if (renkler.Contains("yellow"))
            {
                if (şekiller.Contains("round"))
                    img.Images.Add(ımageList1.Images[6]);
                if (şekiller.Contains("square"))
                    img.Images.Add(ımageList1.Images[7]);
                if (şekiller.Contains("triangle"))
                    img.Images.Add(ımageList1.Images[8]);
            }

            return img;

        }
       
        private Button[,] create_board(int row, int col)
        {
            Button[,] buttons = new Button[row, col];
            int top = 40;
            int left = 10;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(0); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    buttons[i, j].Click += new EventHandler(this.button_click);
                    left += 50;
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 10;
            }
            return buttons;
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
