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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + "//user.xml");
            string kullanıcıadı = null;
            foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            {
                kullanıcıadı = node.SelectSingleNode("username").InnerText;
            }
            XmlDocument d = new XmlDocument();
            d.Load(Directory.GetCurrentDirectory() + "//document.xml");
            foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            {
                this.Hide();
                if (node.SelectSingleNode("username").InnerText == kullanıcıadı)
                {
                    //node.ParentNode.RemoveChild(node);
                    //doc.Save(Directory.GetCurrentDirectory() + "//document.xml");

                    XmlNode shape = doc.CreateElement("Shape");
                    if (Square.Checked == true)
                    {
                        XmlNode square = doc.CreateElement("Square");
                        square.InnerText = "Square";
                        shape.AppendChild(square);

                        doc.DocumentElement.AppendChild(shape);
                    }
                    if (Triangle.Checked == true)
                    {
                        XmlNode triangle = doc.CreateElement("Triangle");
                        triangle.InnerText = "Triangle";
                        shape.AppendChild(triangle);
                        doc.DocumentElement.AppendChild(shape);
                    }
                    if (Round.Checked == true)
                    {
                        XmlNode round = doc.CreateElement("Round");
                        round.InnerText = "Round";
                        shape.AppendChild(round);
                        doc.DocumentElement.AppendChild(shape);
                    }


                    XmlNode difficulty = doc.CreateElement("Difficulty");
                    if (Easy.Checked == true)
                    {
                        XmlNode easy = doc.CreateElement("Easy");
                        easy.InnerText = "Easy";
                        difficulty.AppendChild(easy);
                        doc.DocumentElement.AppendChild(difficulty);
                    }
                    if (Normal.Checked == true)
                    {
                        XmlNode normal = doc.CreateElement("Normal");
                        normal.InnerText = "Normal";
                        difficulty.AppendChild(normal);
                        doc.DocumentElement.AppendChild(difficulty);
                    }
                    if (Hard.Checked == true)
                    {
                        XmlNode hard = doc.CreateElement("Hard");
                        hard.InnerText = "Hard";
                        difficulty.AppendChild(hard);
                        doc.DocumentElement.AppendChild(difficulty);
                    }
                    if (Custom.Checked == true)
                    {
                        XmlNode custom = doc.CreateElement("Custom");
                        custom.InnerText = "Custom";
                        difficulty.AppendChild(custom);
                        doc.DocumentElement.AppendChild(difficulty);
                    }

                    XmlNode colours = doc.CreateElement("Colour");

                    if (red.Checked == true)
                    {
                        XmlNode red_ = doc.CreateElement("Red");
                        red_.InnerText = "Red";
                        colours.AppendChild(red_);
                        doc.DocumentElement.AppendChild(colours);
                    }

                    if (blue.Checked == true)
                    {
                        XmlNode blue_ = doc.CreateElement("Blue");
                        blue_.InnerText = "Blue";
                        colours.AppendChild(blue_);
                        doc.DocumentElement.AppendChild(colours);
                    }
                    if (yellow.Checked == true)
                    {
                        XmlNode yelow_ = doc.CreateElement("Yellow");
                        yelow_.InnerText = "Yellow";
                        colours.AppendChild(yelow_);
                        doc.DocumentElement.AppendChild(colours);
                    }

                    doc.Save(Directory.GetCurrentDirectory() + "//document.xml");


                    if (node.SelectSingleNode("Square").InnerText == "Square")
                    {
                        Square.Checked = true;
                        d.Save(Directory.GetCurrentDirectory() + "//user.xml");
                    }
                    if (node.SelectSingleNode("Triangle").InnerText == "Triangle")
                    {
                        Triangle.Checked = true;
                        d.Save(Directory.GetCurrentDirectory() + "//user.xml");
                    }
                    if (node.SelectSingleNode("Round").InnerText == "Round")
                    {
                        Round.Checked = true;
                        d.Save(Directory.GetCurrentDirectory() + "//user.xml");
                    }
                    if (node.SelectSingleNode("Easy").InnerText == "Easy")
                    {
                        Easy.Checked = true;
                        d.Save(Directory.GetCurrentDirectory() + "//user.xml");
                    }
                    if (node.SelectSingleNode("Normal").InnerText == "Normal")
                    {
                        Normal.Checked = true;
                        d.Save(Directory.GetCurrentDirectory() + "//user.xml");
                    }
                    if (node.SelectSingleNode("Hard").InnerText == "Hard")
                    {
                        Hard.Checked = true;
                        d.Save(Directory.GetCurrentDirectory() + "//user.xml");
                    }
                    if (node.SelectSingleNode("Custom").InnerText == "Custom")
                    {
                        Custom.Checked = true;
                        d.Save(Directory.GetCurrentDirectory() + "//user.xml");
                    }
                    if (node.SelectSingleNode("Yellow").InnerText == "Yellow")
                    {
                        yellow.Checked = true;
                        d.Save(Directory.GetCurrentDirectory() + "//user.xml");
                    }
                    if (node.SelectSingleNode("Blue").InnerText == "Blue")
                    {
                        blue.Checked = true;
                        d.Save(Directory.GetCurrentDirectory() + "//user.xml");
                    }
                    if (node.SelectSingleNode("Red").InnerText == "Red")
                    {
                        red.Checked = true;
                        d.Save(Directory.GetCurrentDirectory() + "//user.xml");
                    }
                }
            }



        }

        private void Easy_CheckedChanged(object sender, EventArgs e)
        {
            input1.Visible = false;
            input2.Visible = false;
        }

        private void Normal_CheckedChanged(object sender, EventArgs e)
        {
            input1.Visible = false;
            input2.Visible = false;
        }

        private void Hard_CheckedChanged(object sender, EventArgs e)
        {
            input1.Visible = false;
            input2.Visible = false;
        }

        private void Custom_CheckedChanged(object sender, EventArgs e)
        {
            input1.Visible = true;
            input2.Visible = true;
        }

        private void Square_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //    List<string> satirlarList = new List<string>(); //Satırların list'e aktarıp daha sonra kullanmamız için yeni bir değişken tanımlıyoruz. 
            //    try {
            //        using (StreamReader sr = new StreamReader("log.txt")) //StreamReader fonksiyonu ile okunacak dosyamızı açtırıyoruz.
            //        {
            //            string satir; //burada okuduğunuz her satırı atamamız için gerekli değişkeni tanımlıyoruz.
            //            while ((satir = sr.ReadLine()) != null) //Döngü kurup eğer satır boş değilse, satirlarList List'ine ekleme yapıyoruz.
            //            {
            //                if (satir == "Square")
            //                {
            //                    Square.Checked = true;
            //                }
            //                if (satir == "Triangle")
            //                {
            //                    Triangle.Checked = true;
            //                }
            //                if (satir == "Round")
            //                {
            //                    Round.Checked = true;
            //                }
            //                if (satir == "Easy")
            //                {
            //                    Easy.Checked = true;
            //                }
            //                if (satir == "Normal")
            //                {
            //                    Normal.Checked = true;
            //                }
            //                if (satir == "Hard")
            //                {
            //                    Hard.Checked = true;
            //                }
            //                if (satir == "Custom")
            //                {
            //                    Custom.Checked = true;
            //                    input1.Text = sr.ReadLine();
            //                    input2.Text = sr.ReadLine();
            //                }
            //                if (satir == "red")
            //                {
            //                    red.Checked = true;
            //                }
            //                if (satir == "blue")
            //                {
            //                    blue.Checked = true;
            //                }
            //                if (satir == "yellow")
            //                {
            //                    yellow.Checked = true;
            //                }
            //            }
            //        }
            //    }
            //    catch { }

            //}
        }
    }
}
