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
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void save_signup_Click(object sender, EventArgs e)
        {
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
                password.InnerText = password_.Text;
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
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                string message = "This username has been taken.";
                string title = "Warning!";
                MessageBox.Show(message, title);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
