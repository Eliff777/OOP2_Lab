﻿using System;
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
using System.Security.Cryptography;

namespace WindowsFormsApp_oop2_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SHA256 sha256Encrypting = new SHA256CryptoServiceProvider();
            string sifrelenecek = şifre.Text;
            SHA256Managed sha256 = new SHA256Managed();
            byte[] bitDizisi = System.Text.Encoding.UTF8.GetBytes(sifrelenecek);
            string sifreliVeri = Convert.ToBase64String(sha256.ComputeHash(bitDizisi));

            XmlDocument doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + "//document.xml");
            foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            {
                if (node.SelectSingleNode("username").InnerText == kullanıcıadı.Text)
                {
                    if (node.SelectSingleNode("password").InnerText == sifreliVeri)
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
    }
}
