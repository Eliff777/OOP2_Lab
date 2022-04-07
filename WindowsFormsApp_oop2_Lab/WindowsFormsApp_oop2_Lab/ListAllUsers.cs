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
    public partial class ListAllUsers : Form
    {
        public ListAllUsers()
        {
            InitializeComponent();
        }

        private void ListAllUsers_Load(object sender, EventArgs e)
        {
            string s = null;
            XmlDocument doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + "//document.xml");

            foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            {
                s += node.SelectSingleNode("username").InnerText + System.Environment.NewLine;

            }
            userss.Text = s;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
