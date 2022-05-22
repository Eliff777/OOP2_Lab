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
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApp_oop2_Lab
{
    public partial class updateUsersİnformation : Form
    {
        public updateUsersİnformation()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string username;
        private void updateUsersİnformation_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + "//document.xml");
           // int check = 0;//eğer kullanıcu var ise 1 olur 
            foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            {
                if (node.SelectSingleNode("username").InnerText == username)
                {
                    //userinformations.Visible = true;
                    userName_.Text = node.SelectSingleNode("username").InnerText;
                    //password_.Text = node.SelectSingleNode("password").InnerText;
                    nameSurname_.Text = node.SelectSingleNode("Name-Surname").InnerText;
                    phoneNumber_.Text = node.SelectSingleNode("PhoneNumber").InnerText;
                    address_.Text = node.SelectSingleNode("Address").InnerText;
                    city_.Text = node.SelectSingleNode("City").InnerText;
                    country_.Text = node.SelectSingleNode("Country").InnerText;
                    email_.Text = node.SelectSingleNode("E-mail").InnerText;
                    //check = 1;
                }
            }
        }

       
        private void cancel_Click_1(object sender, EventArgs e)
        {
            ListAllUsers l = new ListAllUsers();
            l.Show();
            this.Close();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

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
        public string conString = "Data Source=LAPTOP-R4PTUFT9;Initial Catalog=person;Integrated Security=True";
        private void Update_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string sql = "Update Table_1 set  password=@password, namesurname=@namesurname, phonenumber=@phonenumber,address=@address,city=@city,country=@country,email=@email where username=@smth";
            string pass = getHashSha256(password_.Text);
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@smth", username);
            com.Parameters.AddWithValue("@password", pass);
            com.Parameters.AddWithValue("@namesurname", nameSurname_.Text);
            com.Parameters.AddWithValue("@phonenumber", phoneNumber_.Text);
            com.Parameters.AddWithValue("@address", address_.Text);
            com.Parameters.AddWithValue("@city", city_.Text);
            com.Parameters.AddWithValue("@country", country_.Text);
            com.Parameters.AddWithValue("@email", email_.Text);
            com.ExecuteNonQuery();
            con.Close();
            //XmlDocument d = new XmlDocument();
            //d.Load(Directory.GetCurrentDirectory() + "//document.xml");

            //foreach (XmlNode node in d.SelectNodes("Kullanıcılar/person"))
            //{
            //    if (node.SelectSingleNode("username").InnerText == username)
            //    {

            //        node.SelectSingleNode("password").InnerText = getHashSha256(password_.Text);
            //        node.SelectSingleNode("Name-Surname").InnerText = nameSurname_.Text;
            //        node.SelectSingleNode("PhoneNumber").InnerText = phoneNumber_.Text;
            //        node.SelectSingleNode("Address").InnerText = address_.Text;
            //        node.SelectSingleNode("City").InnerText = city_.Text;
            //        node.SelectSingleNode("Country").InnerText = country_.Text;
            //        node.SelectSingleNode("E-mail").InnerText = email_.Text;
            //        d.Save(@Directory.GetCurrentDirectory() + "//document.xml");
            //    }
            //}
            ListAllUsers l = new ListAllUsers();
            l.Show();
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string sql = "delete Table_1 where username=@smth";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@smth", username);
            com.ExecuteNonQuery();
            con.Close();
            ListAllUsers l = new ListAllUsers();
            l.Show();
            this.Close();
            //XmlDocument doc = new XmlDocument();
            //doc.Load(Directory.GetCurrentDirectory() + "//document.xml");
            //foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            //{
            //    if (node.SelectSingleNode("username").InnerText == username)
            //    {
            //        node.ParentNode.RemoveChild(node);
            //        doc.Save(Directory.GetCurrentDirectory() + "//document.xml");
            //        ListAllUsers l = new ListAllUsers();
            //        l.Show();
            //        this.Close();
            //    }
            //}
        }

        private void password__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
