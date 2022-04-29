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
       public void changecolor(Button bt,Color color)
        {
            bt.BackColor = color;
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (Custom.Checked == true && (input1.Text == "" || input2.Text == ""))
            {
                MessageBox.Show("Enter the custom values.");
            }
            else
            {
                XmlDocument d = new XmlDocument();
                d.Load(Directory.GetCurrentDirectory() + "//user.xml");
                XmlNode n = d.SelectSingleNode("Kullanıcılar/person/username").FirstChild;
                //n.ToString();//username aldık burda 

                string s = null;
                s = n.InnerText;
                string a = null;
                XmlDocument doc = new XmlDocument();
                doc.Load(Directory.GetCurrentDirectory() + "//document.xml");
                foreach (XmlNode nd in doc.SelectNodes("Kullanıcılar/person"))
                {
                    a = nd.SelectSingleNode("username").InnerText;
                    if (s == a)
                    {
                        if (Square.Checked == true) {
                            nd.SelectSingleNode("Shape").FirstChild.InnerText = "true";
                            d.DocumentElement.FirstChild.SelectSingleNode("Shape").FirstChild.InnerText = "true";
                        }
                        else {
                            nd.SelectSingleNode("Shape").FirstChild.InnerText = "false";
                            d.DocumentElement.FirstChild.SelectSingleNode("Shape").FirstChild.InnerText = "false";
                        }

                        if (Triangle.Checked == true) {
                            nd.SelectSingleNode("Shape").FirstChild.NextSibling.InnerText = "true";
                            d.DocumentElement.FirstChild.SelectSingleNode("Shape").FirstChild.NextSibling.InnerText = "true";
                        }

                        else {
                            nd.SelectSingleNode("Shape").FirstChild.NextSibling.InnerText = "false";
                            d.DocumentElement.FirstChild.SelectSingleNode("Shape").FirstChild.NextSibling.InnerText = "false";
                        }

                        if (Round.Checked == true) {
                            nd.SelectSingleNode("Shape").LastChild.InnerText = "true";
                            d.DocumentElement.FirstChild.SelectSingleNode("Shape").LastChild.InnerText = "true";
                        }

                        else {
                            nd.SelectSingleNode("Shape").LastChild.InnerText = "false";
                            d.DocumentElement.FirstChild.SelectSingleNode("Shape").LastChild.InnerText = "false";
                        }
                        //end of shape checks....

                        if (Easy.Checked == true) {
                            nd.SelectSingleNode("Difficulty").FirstChild.InnerText = "Easy";
                            d.DocumentElement.FirstChild.SelectSingleNode("Difficulty").FirstChild.InnerText = "Easy";
                        }
                        if (Normal.Checked == true) {
                            nd.SelectSingleNode("Difficulty").FirstChild.InnerText = "Normal";
                            d.DocumentElement.FirstChild.SelectSingleNode("Difficulty").FirstChild.InnerText = "Normal";
                        }

                        if (Hard.Checked == true) {
                            nd.SelectSingleNode("Difficulty").FirstChild.InnerText = "Hard";
                            d.DocumentElement.FirstChild.SelectSingleNode("Difficulty").FirstChild.InnerText = "Hard";
                        }

                        if (Custom.Checked == true) {
                            nd.SelectSingleNode("Difficulty").FirstChild.InnerText = "Custom";
                            nd.SelectSingleNode("Difficulty").FirstChild.NextSibling.InnerText = input1.Text;
                            nd.SelectSingleNode("Difficulty").LastChild.InnerText = input2.Text;

                            d.DocumentElement.FirstChild.SelectSingleNode("Difficulty").FirstChild.InnerText = "Custom";
                            d.DocumentElement.FirstChild.SelectSingleNode("Difficulty").FirstChild.NextSibling.InnerText = input1.Text;
                            d.DocumentElement.FirstChild.SelectSingleNode("Difficulty").LastChild.InnerText = input2.Text;
                        }
                        if (red.Checked == true) {
                            nd.SelectSingleNode("Colour").FirstChild.InnerText = "true";
                            d.DocumentElement.FirstChild.SelectSingleNode("Colour").FirstChild.InnerText = "true";
                        }
                        else {
                            nd.SelectSingleNode("Colour").FirstChild.InnerText = "false";
                            d.DocumentElement.FirstChild.SelectSingleNode("Colour").FirstChild.InnerText = "false";
                        }
                        if (blue.Checked == true) {
                            nd.SelectSingleNode("Colour").FirstChild.NextSibling.InnerText = "true";
                            d.DocumentElement.FirstChild.SelectSingleNode("Colour").FirstChild.NextSibling.InnerText = "true";
                        }
                        else {
                            nd.SelectSingleNode("Colour").FirstChild.NextSibling.InnerText = "false";
                            d.DocumentElement.FirstChild.SelectSingleNode("Colour").FirstChild.NextSibling.InnerText = "false";
                        }
                        if (yellow.Checked == true) {
                            nd.SelectSingleNode("Colour").LastChild.InnerText = "true";
                            d.DocumentElement.FirstChild.SelectSingleNode("Colour").LastChild.InnerText = "true";
                        }
                        else {
                            nd.SelectSingleNode("Colour").LastChild.InnerText = "false";
                            d.DocumentElement.FirstChild.SelectSingleNode("Colour").LastChild.InnerText = "false";
                        }
                        //end of colour checks.....
                    }
                }
                doc.Save(Directory.GetCurrentDirectory() + "//document.xml");
                d.Save(Directory.GetCurrentDirectory() + "//user.xml");

                this.Close();
            }
            if(Easy.Checked)
            {
             
                easy s = new easy();
                this.Hide();
                s.Show();
            }
            if (Normal.Checked)
            {
                normal s = new normal();
                this.Hide();
                s.Show();
            }
            if(Hard.Checked)
            {
                hard s = new hard();
                this.Hide();
                s.Show();
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
            XmlDocument doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + "//user.xml");
            foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            {
                if (node.SelectSingleNode("Shape").FirstChild.InnerText == "true")
                    Square.Checked = true;
                if (node.SelectSingleNode("Shape").FirstChild.NextSibling.InnerText == "true")
                    Triangle.Checked = true;
                if (node.SelectSingleNode("Shape").LastChild.InnerText == "true")
                    Round.Checked = true;
                //end of shape
                if (node.SelectSingleNode("Difficulty").FirstChild.InnerText == "Easy")
                    Easy.Checked = true;
                if (node.SelectSingleNode("Difficulty").FirstChild.InnerText == "Normal")
                    Normal.Checked = true;
                if (node.SelectSingleNode("Difficulty").FirstChild.InnerText == "Hard")
                    Hard.Checked = true;
                if (node.SelectSingleNode("Difficulty").FirstChild.InnerText == "Custom")
                {
                    Custom.Checked = true;
                    input1.Text = node.SelectSingleNode("Difficulty").FirstChild.NextSibling.InnerText;
                    input2.Text = node.SelectSingleNode("Difficulty").LastChild.InnerText;
                }

                //end of difficulty
                if (node.SelectSingleNode("Colour").FirstChild.InnerText == "true")
                    red.Checked = true;
                if (node.SelectSingleNode("Colour").FirstChild.NextSibling.InnerText == "true")
                    blue.Checked = true;
                if (node.SelectSingleNode("Colour").LastChild.InnerText == "true")
                    yellow.Checked = true;
            }
         

        }


    }
}
    

