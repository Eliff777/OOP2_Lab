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
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApp_oop2_Lab
{
    public partial class ListAllUsers : Form
    {
        public ListAllUsers()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-M5UOMRR\\SQLEXPRESS;Initial Catalog=users;Integrated Security=True";
         private void ListAllUsers_Load(object sender, EventArgs e)
        {
            
            var select = "SELECT * FROM Table_1";
            var c = new SqlConnection(conString); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            Tablo.ReadOnly = true;
            ds.Tables[0].Columns.Remove(ds.Tables[0].Columns[1]);
            Tablo.DataSource = ds.Tables[0];
            
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

        private void Tablo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Tablo.Sort(this.Tablo.Columns["bestscore"], ListSortDirection.Descending);
        }
    }
}
