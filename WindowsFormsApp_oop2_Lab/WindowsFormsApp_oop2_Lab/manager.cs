using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_oop2_Lab
{
    public partial class manager : Form
    {
        public manager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddNewUser add = new AddNewUser();
            add.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            updateUsersİnformation upd = new updateUsersİnformation();
            upd.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            deleteUser d = new deleteUser();
            d.Show();
        }

        private void list_Click(object sender, EventArgs e)
        {
            ListAllUsers list = new ListAllUsers();
            list.Show();
        }
    }
}
