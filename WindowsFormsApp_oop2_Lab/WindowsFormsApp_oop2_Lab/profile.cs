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
using System.Security.Cryptography;
using System.Windows.Forms;

namespace WindowsFormsApp_oop2_Lab
{
    public partial class profile : Form
    {
        public profile()
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
        private void profile_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + "//user.xml");

            foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            {
                userName_.Text = node.SelectSingleNode("username").InnerText;
                nameSurname_.Text = node.SelectSingleNode("Name-Surname").InnerText;
                phoneNumber_.Text = node.SelectSingleNode("PhoneNumber").InnerText;
                address_.Text = node.SelectSingleNode("Address").InnerText;
                city_.Text = node.SelectSingleNode("City").InnerText;
                country_.Text = node.SelectSingleNode("Country").InnerText;
                email_.Text = node.SelectSingleNode("E-mail").InnerText;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string oldpass = getHashSha256(oldPassword_.Text);
            bool check = false; //eğer eski şifreyi doğru girdiyse true olur.
            string kullanıcıAdı = null;
            XmlDocument d = new XmlDocument();
            d.Load(Directory.GetCurrentDirectory() + "//user.xml");
            foreach (XmlNode node in d.SelectNodes("Kullanıcılar/person"))
            {
                kullanıcıAdı = node.SelectSingleNode("username").InnerText;
                if (oldpass == node.SelectSingleNode("password").InnerText)
                {
                    check = true;
                    node.SelectSingleNode("password").InnerText = oldPassword_.Text;
                    node.SelectSingleNode("Name-Surname").InnerText = nameSurname_.Text;
                    node.SelectSingleNode("PhoneNumber").InnerText = phoneNumber_.Text;
                    node.SelectSingleNode("Address").InnerText = address_.Text;
                    node.SelectSingleNode("City").InnerText = city_.Text;
                    node.SelectSingleNode("Country").InnerText = country_.Text;
                    node.SelectSingleNode("E-mail").InnerText = email_.Text;
                    d.Save(Directory.GetCurrentDirectory() + "//user.xml");
                }
                else
                {
                    string message = "The password is incorrect!";
                    string title = "Warning!";
                    MessageBox.Show(message, title);
                }

            }

            if (check == true)
            {
                string newpass = getHashSha256(password_.Text);
                this.Hide();
                XmlDocument doc = new XmlDocument();
                doc.Load(Directory.GetCurrentDirectory() + "//document.xml");
                foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
                {
                    if (kullanıcıAdı == node.SelectSingleNode("username").InnerText)
                    {
                        node.ParentNode.RemoveChild(node);
                        doc.Save(Directory.GetCurrentDirectory() + "//document.xml");
                        
                        XmlNode person = doc.CreateElement("person");

                        XmlNode username = doc.CreateElement("username");
                        username.InnerText = userName_.Text;
                        person.AppendChild(username);

                        XmlNode password = doc.CreateElement("password");
                        password.InnerText = newpass;
                        person.AppendChild(password);

                        XmlNode NameSurname = doc.CreateElement("Name-Surname");
                        NameSurname.InnerText = nameSurname_.Text;
                        person.AppendChild(NameSurname);

                        XmlNode PhoneNumber = doc.CreateElement("PhoneNumber");
                        PhoneNumber.InnerText = phoneNumber_.Text;
                        person.AppendChild(PhoneNumber);

                        XmlNode Address = doc.CreateElement("Address");
                        Address.InnerText = address_.Text;
                        person.AppendChild(Address);

                        XmlNode City = doc.CreateElement("City");
                        City.InnerText = city_.Text;
                        person.AppendChild(City);

                        XmlNode Country = doc.CreateElement("Country");
                        Country.InnerText = country_.Text;
                        person.AppendChild(Country);

                        XmlNode Email = doc.CreateElement("E-mail");
                        Email.InnerText = email_.Text;
                        person.AppendChild(Email);

                        doc.DocumentElement.AppendChild(person);
                        doc.Save(Directory.GetCurrentDirectory() + "//document.xml");
                    }
                }
            }
        }

        private void userName__TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldpass = getHashSha256(oldPassword_.Text);
            string ka = null;
            bool chk = false;//eğer şifre doğruysa true olur sil demek.
            XmlDocument d = new XmlDocument();
            d.Load(Directory.GetCurrentDirectory() + "//user.xml");
            foreach (XmlNode node in d.SelectNodes("Kullanıcılar/person"))
            {
                if (oldpass == node.SelectSingleNode("password").InnerText)
                {
                    ka = node.SelectSingleNode("username").InnerText;
                    chk = true;
                    node.ParentNode.RemoveChild(node);
                    d.Save(Directory.GetCurrentDirectory() + "//user.xml");
                }
                else
                {
                    string message = "The password is incorrect!";
                    string title = "Warning!";
                    MessageBox.Show(message, title);
                }
            }
            
            if (chk == true)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(Directory.GetCurrentDirectory() + "//document.xml");

                foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
                {
                    if (ka == node.SelectSingleNode("username").InnerText)
                    {
                        node.ParentNode.RemoveChild(node);
                        doc.Save(Directory.GetCurrentDirectory() + "//document.xml");
                        List<Form> openForms = new List<Form>();

                        foreach (Form f in Application.OpenForms)
                            openForms.Add(f);

                        foreach (Form f in openForms)
                        {
                            if (f.Name == "Form1")
                                f.Show();
                            else
                                f.Close();
                        }
                    }
                }
            }
        }
    }
}

