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
    public partial class deleteUser : Form
    {
        public deleteUser()
        {
            InitializeComponent();
        }
        private void search_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + "//document.xml");
            bool check = false;
            foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            {
                if (node.SelectSingleNode("username").InnerText == usName.Text)
                {
                    check = true;
                    node.ParentNode.RemoveChild(node);
                    doc.Save(Directory.GetCurrentDirectory() + "//document.xml");
                    this.Close();
                    break;
                }
            }
            if (check == false)
            {
                MessageBox.Show("there is no user with this username");
            }
            else
            {
                MessageBox.Show("user deleted");
            }
        }
    }
}
