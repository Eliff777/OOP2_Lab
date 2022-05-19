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
namespace WindowsFormsApp_oop2_Lab
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=LAPTOP-R4PTUFT9;Initial Catalog=person;Integrated Security=True";
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
        private void save_signup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if(con.State==System.Data.ConnectionState.Open)
            {
                string q= "insert into Table_1 (username,password,namesurname,phonenumber,address,city,country,email) values(@pusername,@ppassword,@pnamesurname,@pphonenumber,@paddress,@pcity,@pcountry,@pemail)";
                SqlCommand cmd = new SqlCommand(q, con);
                string pass = getHashSha256(password_.Text);
                cmd.Parameters.AddWithValue("@pusername", userName_.Text);
                cmd.Parameters.AddWithValue("@ppassword", pass);
                cmd.Parameters.AddWithValue("@pnamesurname", nameSurname_.Text);
                cmd.Parameters.AddWithValue("@pphonenumber", phoneNumber_.Text);
                cmd.Parameters.AddWithValue("@paddress", address_.Text);
                cmd.Parameters.AddWithValue("@pcity", city_.Text);
                cmd.Parameters.AddWithValue("@pcountry", country_.Text);
                cmd.Parameters.AddWithValue("@pemail", email_.Text);

                cmd.ExecuteNonQuery();
            }
            //SqlCommand commandRegister = new SqlCommand("Insert into Table_1(username,password,namesurname,phonenumber,address,city,country,email) values (@pusername,@ppassword,@pnamesurname,@pphonenumber,@paddress,@pcity,@pcountry,@pemail)");
            //SqlOperations.CheckConnection(SqlOperations.connection);
            
            //commandRegister.Parameters.AddWithValue("@pusername", userName_.Text);
            //commandRegister.Parameters.AddWithValue("@ppassword", password_.Text);
            //commandRegister.Parameters.AddWithValue("@pnamesurname", nameSurname_.Text);
            //commandRegister.Parameters.AddWithValue("@pphonenumber", phoneNumber_.Text);
            //commandRegister.Parameters.AddWithValue("@paddress", address_.Text);
            //commandRegister.Parameters.AddWithValue("@pcity", city_.Text);
            //commandRegister.Parameters.AddWithValue("@pcountry", country_.Text);
            //commandRegister.Parameters.AddWithValue("@pemail", email_.Text);

            //commandRegister.ExecuteNonQuery();
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
                password.InnerText = getHashSha256(password_.Text);
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

                XmlNode Shape = doc.CreateElement("Shape");
                XmlNode Square = doc.CreateElement("Square");
                XmlNode Triangle = doc.CreateElement("Triangle");
                XmlNode Round = doc.CreateElement("Round");
                Square.InnerText = "true";
                Triangle.InnerText = "true";
                Round.InnerText = "true";

                Shape.AppendChild(Square);
                Shape.AppendChild(Triangle);
                Shape.AppendChild(Round);
                person.AppendChild(Shape);

                XmlNode Difficulty = doc.CreateElement("Difficulty");
                XmlNode degree = doc.CreateElement("Degree");
                degree.InnerText = "Easy";
                XmlNode first = doc.CreateElement("first");
                first.InnerText = "0";
                XmlNode second = doc.CreateElement("second");
                second.InnerText = "0";
                Difficulty.AppendChild(degree);
                Difficulty.AppendChild(first);
                Difficulty.AppendChild(second);
                person.AppendChild(Difficulty);

                XmlNode Colour = doc.CreateElement("Colour");
                XmlNode Red = doc.CreateElement("Red");
                XmlNode Blue = doc.CreateElement("Blue");
                XmlNode Yellow = doc.CreateElement("Yellow");

                Red.InnerText = "true";
                Blue.InnerText = "true";
                Yellow.InnerText = "true";
                Colour.AppendChild(Red);
                Colour.AppendChild(Blue);
                Colour.AppendChild(Yellow);
                person.AppendChild(Colour);



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

        private void signUp_Load(object sender, EventArgs e)
        {

        }
    }
}
