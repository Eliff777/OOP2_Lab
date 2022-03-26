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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanıcıAdı = kullanıcıadı.Text;
            string şfr = şifre.Text;
            if (kullanıcıAdı == "admin" && şfr == "admin")
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            else if (kullanıcıAdı == "user" && şfr == "user")
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            else
            {
                label3.Text = "Username /Password is wrong";
                label3.Visible = true;
            }
        }
    }
}
