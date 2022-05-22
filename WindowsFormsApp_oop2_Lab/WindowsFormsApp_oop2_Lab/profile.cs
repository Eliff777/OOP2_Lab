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
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp_oop2_Lab
{
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }
        public string kullanıcıadı;
        public string conString = "Data Source=DESKTOP-M5UOMRR\\SQLEXPRESS;Initial Catalog=users;Integrated Security=True";
        private void profile_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string sql = "select * from Table_1 where username= @username";
            SqlParameter prm1 = new SqlParameter("username", kullanıcıadı);
            SqlCommand komut = new SqlCommand(sql, con);
            komut.Parameters.Add(prm1);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            int i = dt.Rows.Count;
            userName_.Text = dt.Rows[0][0].ToString();
            nameSurname_.Text = dt.Rows[0][2].ToString();
            phoneNumber_.Text = dt.Rows[0][3].ToString();
            address_.Text = dt.Rows[0][4].ToString();
            city_.Text = dt.Rows[0][5].ToString();
            country_.Text = dt.Rows[0][6].ToString();
            email_.Text = dt.Rows[0][7].ToString();
            con.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.username = kullanıcıadı;
            f2.Show();
            this.Close();
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
        //public string conString = "Data Source=DESKTOP-M5UOMRR\\SQLEXPRESS;Initial Catalog=users;Integrated Security=True";
        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string sql = "Update Table_1 set  password=@password, namesurname=@namesurname, phonenumber=@phonenumber,address=@address,city=@city,country=@country,email=@email where username=@smth";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@smth", userName_.Text);
            com.Parameters.AddWithValue("@password", password_.Text);
            com.Parameters.AddWithValue("@namesurname", nameSurname_.Text);
            com.Parameters.AddWithValue("@phonenumber", phoneNumber_.Text);
            com.Parameters.AddWithValue("@address", address_.Text);
            com.Parameters.AddWithValue("@city", city_.Text);
            com.Parameters.AddWithValue("@country", country_.Text);
            com.Parameters.AddWithValue("@email", email_.Text);
            com.ExecuteNonQuery();
            con.Close();
            this.Close();
            Form2 f2 = new Form2();
            f2.username = kullanıcıadı;
            f2.Show();
            //string s = getHashSha256(oldPassword_.Text);
            //bool check = false; //eğer eski şifreyi doğru girdiyse true olur.
            //string kullanıcıAdı = null;
            //XmlDocument d = new XmlDocument();
            //d.Load(Directory.GetCurrentDirectory() + "//user.xml");
            //foreach (XmlNode node in d.SelectNodes("Kullanıcılar/person"))
            //{
            //    kullanıcıAdı = node.SelectSingleNode("username").InnerText;
            //    if (s == node.SelectSingleNode("password").InnerText)
            //    {
            //        check = true;
            //        node.SelectSingleNode("password").InnerText = getHashSha256(password_.Text);
            //        node.SelectSingleNode("Name-Surname").InnerText = nameSurname_.Text;
            //        node.SelectSingleNode("PhoneNumber").InnerText = phoneNumber_.Text;
            //        node.SelectSingleNode("Address").InnerText = address_.Text;
            //        node.SelectSingleNode("City").InnerText = city_.Text;
            //        node.SelectSingleNode("Country").InnerText = country_.Text;
            //        node.SelectSingleNode("E-mail").InnerText = email_.Text;
            //        d.Save(Directory.GetCurrentDirectory() + "//user.xml");
            //    }
            //    else
            //    {
            //        string message = "Please enter the old password correctly";
            //        string title = "Warning!";
            //        MessageBox.Show(message, title);
            //    }

            //}

            //if (check == true)
            //{
            //    string newpass = getHashSha256(password_.Text);
            //    this.Close();
            //    Form2 f2 = new Form2();
            //    f2.Show();
            //    XmlDocument doc = new XmlDocument();
            //    doc.Load(Directory.GetCurrentDirectory() + "//document.xml");
            //    foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            //    {
            //        if (kullanıcıAdı == node.SelectSingleNode("username").InnerText)
            //        {
            //            node.SelectSingleNode("password").InnerText = newpass;
            //            node.SelectSingleNode("Name-Surname").InnerText = nameSurname_.Text;
            //            node.SelectSingleNode("PhoneNumber").InnerText = phoneNumber_.Text;
            //            node.SelectSingleNode("Address").InnerText = address_.Text;
            //            node.SelectSingleNode("City").InnerText = city_.Text;
            //            node.SelectSingleNode("Country").InnerText = country_.Text;
            //            node.SelectSingleNode("E-mail").InnerText = email_.Text;

            //            doc.Save(Directory.GetCurrentDirectory() + "//document.xml");
            //        }
            //    }
            //}
        }

        private void userName__TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            var select = "SELECT * FROM Table_1 where username=@us";

            SqlParameter prm1 = new SqlParameter("@us", kullanıcıadı.Trim());
            SqlCommand komut = new SqlCommand(select, con);
            komut.Parameters.Add(prm1);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            string a = dt.Rows[0][1].ToString();
            if (a == oldPassword_.Text.Trim())
            {
                string sql = "delete Table_1 where username=@smth";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@smth", kullanıcıadı);
                com.ExecuteNonQuery();
                con.Close();
                Form1 f1 = new Form1();
                f1.Show();
                this.Close();
            }
            else
                MessageBox.Show("Wrong password");
            //    string ka = null;
            //    bool chk = false;//eğer şifre doğruysa true olur sil demek.
            //    XmlDocument d = new XmlDocument();
            //    d.Load(Directory.GetCurrentDirectory() + "//user.xml");
            //    foreach (XmlNode node in d.SelectNodes("Kullanıcılar/person"))
            //    {
            //        if (getHashSha256(oldPassword_.Text) == node.SelectSingleNode("password").InnerText)
            //        {
            //            ka = node.SelectSingleNode("username").InnerText;
            //            chk = true;
            //            node.ParentNode.RemoveChild(node);
            //            d.Save(Directory.GetCurrentDirectory() + "//user.xml");
            //        }
            //        else
            //        {
            //            string message = "Please enter the old password correctly";
            //            string title = "Warning!";
            //            MessageBox.Show(message, title);
            //        }
            //    }

            //    if (chk == true)
            //    {
            //        XmlDocument doc = new XmlDocument();
            //        doc.Load(Directory.GetCurrentDirectory() + "//document.xml");

            //        foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            //        {
            //            if (ka == node.SelectSingleNode("username").InnerText)
            //            {
            //                node.ParentNode.RemoveChild(node);
            //                doc.Save(Directory.GetCurrentDirectory() + "//document.xml");
            //                List<Form> openForms = new List<Form>();

            //                foreach (Form f in Application.OpenForms)
            //                    openForms.Add(f);

            //                foreach (Form f in openForms)
            //                {
            //                    if (f.Name == "Form1")
            //                        f.Show();
            //                    else
            //                        f.Close();
            //                }
            //            }
            //        }
            //    }
        }
    }
}

