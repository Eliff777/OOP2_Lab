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
    public partial class AddNewUser : Form
    {
        public AddNewUser()
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
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            ListAllUsers l = new ListAllUsers();
            l.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string pass = getHashSha256(password_.Text);
            bool check = false; //kullanıcı adı alınmışsa true olur
            XmlDocument doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + "//document.xml");

            foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            {
                if (node.SelectSingleNode("username").InnerText == userName_.Text)
                {
                    check = true;
                }
            }
            if (check == false)
            {
                XmlNode person = doc.CreateElement("person");
                XmlNode username = doc.CreateElement("username");
                username.InnerText = userName_.Text;
                person.AppendChild(username);

                XmlNode password = doc.CreateElement("password");
                password.InnerText = pass;
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
                this.Close();
                ListAllUsers l = new ListAllUsers();
                l.Show();
            }
            else
            {
                string message = "This username has been taken.";
                string title = "Warning!";
                MessageBox.Show(message, title);
            }
            
        }

        private void Password_lb_Click(object sender, EventArgs e)
        {

        }

        private void city__TextChanged(object sender, EventArgs e)
        {

        }

        private void country__TextChanged(object sender, EventArgs e)
        {

        }

        private void email__TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumber__TextChanged(object sender, EventArgs e)
        {

        }

        private void address__TextChanged(object sender, EventArgs e)
        {

        }

        private void nameSurname__TextChanged(object sender, EventArgs e)
        {

        }

        private void password__TextChanged(object sender, EventArgs e)
        {

        }

        private void userName__TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_lb_Click(object sender, EventArgs e)
        {

        }

        private void Country_lb_Click(object sender, EventArgs e)
        {

        }

        private void City_lb_Click(object sender, EventArgs e)
        {

        }

        private void Address_lb_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNumber_lb_Click(object sender, EventArgs e)
        {

        }

        private void NameSurname_lb_Click(object sender, EventArgs e)
        {

        }

        private void Username_lb_Click(object sender, EventArgs e)
        {

        }
    }
}
