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
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp_oop2_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string getHashSha256(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = getHashSha256(şifre.Text);
            String myfile1 = @"log1.txt";
            File.Delete(myfile1);
            using (StreamWriter w = File.AppendText("log1.txt"))
            {
                w.WriteLine(kullanıcıadı.Text);
               
            }
            

                XmlDocument doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + "//document.xml");
            foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            {
                if (node.SelectSingleNode("username").InnerText == kullanıcıadı.Text)
                {
                    if (node.SelectSingleNode("password").InnerText == pass)
                    {
                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.Show();
                        XDocument d = new XDocument(new XElement("Kullanıcılar",
                                           new XElement("person",
                                               new XElement("username", node.SelectSingleNode("username").InnerText),
                                               new XElement("password", node.SelectSingleNode("password").InnerText),
                                               new XElement("Name-Surname", node.SelectSingleNode("Name-Surname").InnerText),
                                               new XElement("PhoneNumber", node.SelectSingleNode("PhoneNumber").InnerText),
                                               new XElement("Address", node.SelectSingleNode("Address").InnerText),
                                               new XElement("City", node.SelectSingleNode("City").InnerText),
                                               new XElement("Country", node.SelectSingleNode("Country").InnerText),
                                               new XElement("E-mail", node.SelectSingleNode("E-mail").InnerText))));
                        d.Save(Directory.GetCurrentDirectory() + "//user.xml");
                    }
                }
                else
                {
                    label3.Show();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> satirlarList = new List<string>();
            using (StreamReader sr = new StreamReader("log1.txt")) 
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    int check = 0;
                    if(check==0)
                    {
                        kullanıcıadı.Text = satir;
                    }
                    
                }
            }
                string curFile = @"document.xml";
            if (File.Exists(curFile) == false)
            {
                XDocument d = new XDocument(new XElement("Kullanıcılar",
                                           new XElement("person",
                                               new XElement("username", "Admin"),
                                               new XElement("password", "admin"),
                                               new XElement("Name-Surname", "Name-Surname"),
                                               new XElement("PhoneNumber", "Phone Number"),
                                               new XElement("Address", "Address"),
                                               new XElement("City", "City"),
                                               new XElement("Country", "Country"),
                                               new XElement("E-mail", "E-mail"))));
                d.Save(Directory.GetCurrentDirectory() + "//document.xml");
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            signUp s = new signUp();
            this.Hide();
            s.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                şifre.PasswordChar = '\0';
            }
            else
            {
                şifre.PasswordChar = '*';
            }
        }

        private void kullanıcıadı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
