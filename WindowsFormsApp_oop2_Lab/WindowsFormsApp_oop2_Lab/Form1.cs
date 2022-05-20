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
    public partial class Form1 : Form
    {
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
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public string conString = "Data Source=DESKTOP-M5UOMRR\\SQLEXPRESS;Initial Catalog=users;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand com = new SqlCommand();
            try
            {
                con.Open();
                string sql = "select * from Table_1 where username= @username AND password=@password ";
                SqlParameter prm1 = new SqlParameter("username", kullanıcıadı.Text.Trim());
                SqlParameter prm2 = new SqlParameter("password", şifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, con);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Form2 form2 = new Form2();
                    form2.username = kullanıcıadı.Text;
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    if (kullanıcıadı.Text == "admin")
                    {
                        //********************//
                        string curFile = @"document.xml";
                        if (File.Exists(curFile) == false)
                        {
                            XDocument d = new XDocument(new XElement("Kullanıcılar",
                                                       new XElement("person",
                                                           new XElement("username", "admin"),
                                                           new XElement("Shape",
                                                                new XElement("Square", "true"),
                                                                new XElement("Triangle", "true"),
                                                                new XElement("Round", "true")),
                                                           new XElement("Difficulty",
                                                                new XElement("degree", "Easy"),
                                                                new XElement("first", "15"),
                                                                new XElement("second", "15")),
                                                           new XElement("Colour",
                                                                new XElement("Red", "true"),
                                                                new XElement("Blue", "true"),
                                                                new XElement("Yellow", "true")))));
                            d.Save(Directory.GetCurrentDirectory() + @"//document.xml");
                        }
                        ///*********//
                        ///
                        con.Close();
                        con.Open();
                        string q = "insert into Table_1 (username,password,namesurname,phonenumber,address,city,country,email,bestscore) values(@pusername,@ppassword,@pnamesurname,@pphonenumber,@paddress,@pcity,@pcountry,@pemail,@bestscore)";
                        SqlCommand cmd = new SqlCommand(q, con);
                        cmd.Parameters.AddWithValue("@pusername", "admin");
                        cmd.Parameters.AddWithValue("@ppassword", "admin");
                        cmd.Parameters.AddWithValue("@pnamesurname", "");
                        cmd.Parameters.AddWithValue("@pphonenumber", "");
                        cmd.Parameters.AddWithValue("@paddress", "");
                        cmd.Parameters.AddWithValue("@pcity", "");
                        cmd.Parameters.AddWithValue("@pcountry", "");
                        cmd.Parameters.AddWithValue("@pemail", "");
                        cmd.Parameters.AddWithValue("@bestscore", 0);
                        cmd.ExecuteNonQuery();
                        Form2 form2 = new Form2();
                        form2.username = kullanıcıadı.Text;
                        form2.Show();
                        this.Hide();
                    }
                    else
                        label3.Show();
                }
                    
            }
            catch (Exception)
            { }
            con.Close();
            //XmlDocument doc = new XmlDocument();
            //       doc.Load(Directory.GetCurrentDirectory() + "//document.xml");
            //       foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            //       {
            //           if (node.SelectSingleNode("username").InnerText == kullanıcıadı.Text)
            //           {
            //               if (node.SelectSingleNode("password").InnerText == getHashSha256(şifre.Text))
            //               {
            //                   this.Hide();


            //                   XDocument d = new XDocument(new XElement("Kullanıcılar",
            //                                      new XElement("person",
            //                                          new XElement("username", node.SelectSingleNode("username").InnerText),
            //                                          new XElement("password", node.SelectSingleNode("password").InnerText),
            //                                          new XElement("Name-Surname", node.SelectSingleNode("Name-Surname").InnerText),
            //                                          new XElement("PhoneNumber", node.SelectSingleNode("PhoneNumber").InnerText),
            //                                          new XElement("Address", node.SelectSingleNode("Address").InnerText),
            //                                          new XElement("City", node.SelectSingleNode("City").InnerText),
            //                                          new XElement("Country", node.SelectSingleNode("Country").InnerText),
            //                                          new XElement("E-mail", node.SelectSingleNode("E-mail").InnerText),
            //                                          new XElement("Shape",
            //                                               new XElement("Square", node.SelectSingleNode("Shape").FirstChild.InnerText),
            //                                               new XElement("Triangle", node.SelectSingleNode("Shape").FirstChild.NextSibling.InnerText),
            //                                               new XElement("Round", node.SelectSingleNode("Shape").LastChild.InnerText)),
            //                                          new XElement("Difficulty",
            //                                                 new XElement("degree", node.SelectSingleNode("Difficulty").FirstChild.InnerText),
            //                                                 new XElement("first", node.SelectSingleNode("Difficulty").FirstChild.NextSibling.InnerText),
            //                                                 new XElement("second", node.SelectSingleNode("Difficulty").LastChild.InnerText)),
            //                                          new XElement("Colour",
            //                                               new XElement("Red", node.SelectSingleNode("Colour").FirstChild.InnerText),
            //                                               new XElement("Blue", node.SelectSingleNode("Colour").FirstChild.NextSibling.InnerText),
            //                                               new XElement("Yellow", node.SelectSingleNode("Colour").LastChild.InnerText))
            //                                         )));

            //                   d.Save(Directory.GetCurrentDirectory() + "//user.xml");
            //               Form2 form2 = new Form2();
            //               form2.username = kullanıcıadı.Text;
            //               form2.Show();
            //           }

            //           }
            //           else
            //           {
            //               label3.Show();
            //           }
            //       }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //string curFile = @"document.xml";
            //if (File.Exists(curFile) == false)
            //{
            //    XDocument d = new XDocument(new XElement("Kullanıcılar",
            //                               new XElement("person",
            //                                   new XElement("username", "admin"),
            //                                   new XElement("password", getHashSha256("admin")),
            //                                   new XElement("Name-Surname", "Name-Surname"),
            //                                   new XElement("PhoneNumber", "Phone Number"),
            //                                   new XElement("Address", "Address"),
            //                                   new XElement("City", "City"),
            //                                   new XElement("Country", "Country"),
            //                                   new XElement("E-mail", "E-mail"),
            //                                   new XElement("Shape",
            //                                        new XElement("Square","false"),
            //                                        new XElement("Triangle", "false"),
            //                                        new XElement("Round", "false")),
            //                                   new XElement("Difficulty",
            //                                        new XElement("degree", "Custom"),
            //                                        new XElement("first","0"),
            //                                        new XElement("second", "0")),
            //                                   new XElement("Colour",
            //                                        new XElement("Red", "false"),
            //                                        new XElement("Blue", "false"),
            //                                        new XElement("Yellow", "false")))));
                
            //    d.Save(Directory.GetCurrentDirectory() + @"//document.xml");
            //}try
            //{
            //    XmlDocument doc = new XmlDocument();
            //    doc.Load(Directory.GetCurrentDirectory() + "//user.xml");
            //    foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            //    {
            //        kullanıcıadı.Text = node.SelectSingleNode("username").InnerText;
            //    }
            //}
            //catch { }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            signUp s = new signUp();
            this.Hide();
            s.Show();
        }

        private void kullanıcıadı_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullanıcıadı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                şifre.PasswordChar = '\0';
            }
            else
            {
                şifre.PasswordChar = '*';
            }
        }
    }
}
