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
            DataSet ds = new DataSet();
            ds.ReadXml(Directory.GetCurrentDirectory() + "//document.xml");
            Tablo.DataSource = ds.Tables[0];
            ds.Tables[0].Columns.RemoveAt(1);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.username = "admin";
            f2.Show();
        }

        private void userss_Click(object sender, EventArgs e)
        {

        }

        private void Tablo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateUsersİnformation upd = new updateUsersİnformation();
            this.Hide();
            
            upd.username = this.Tablo.CurrentRow.Cells[0].Value.ToString();
            upd.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddNewUser add = new AddNewUser();
            add.Show();
            this.Close();
        }
    }
}
