using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Windows.Forms;

namespace WindowsFormsApp_oop2_Lab
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            String myfile1 = @"log.txt";
            File.Delete(myfile1);
            Form2 form2 = new Form2();
            this.Hide();
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                if (Square.Checked == true)
                {
                    w.WriteLine("Square");
                }
                if (Triangle.Checked == true)
                {
                    w.WriteLine("Triangle");
                }
                if (Round.Checked == true)
                {
                    w.WriteLine("Round");
                }
                if (Easy.Checked == true)
                {
                    w.WriteLine("Easy");
                }
                if (Normal.Checked == true)
                {
                    w.WriteLine("Normal");
                }
                if (Hard.Checked == true)
                {
                    w.WriteLine("Hard");
                }
                if (Custom.Checked == true)
                {
                    w.WriteLine("Custom");
                    w.WriteLine(input1.Text);
                    w.WriteLine(input2.Text);
                }
                if (red.Checked == true)
                {
                    w.WriteLine("red");
                }
                if (blue.Checked == true)
                {
                    w.WriteLine("blue");
                }
                if (yellow.Checked == true)
                {
                    w.WriteLine("yellow");
                }
                w.Close();
            }
        }

        private void Easy_CheckedChanged(object sender, EventArgs e)
        {
            input1.Visible = false;
            input2.Visible = false;
        }

        private void Normal_CheckedChanged(object sender, EventArgs e)
        {
            input1.Visible = false;
            input2.Visible = false;
        }

        private void Hard_CheckedChanged(object sender, EventArgs e)
        {
            input1.Visible = false;
            input2.Visible = false;
        }

        private void Custom_CheckedChanged(object sender, EventArgs e)
        {
            input1.Visible = true;
            input2.Visible = true;
        }

        private void Square_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<string> satirlarList = new List<string>(); //Satırların list'e aktarıp daha sonra kullanmamız için yeni bir değişken tanımlıyoruz. 
            try {
                using (StreamReader sr = new StreamReader("log.txt")) //StreamReader fonksiyonu ile okunacak dosyamızı açtırıyoruz.
                {
                    string satir; //burada okuduğunuz her satırı atamamız için gerekli değişkeni tanımlıyoruz.
                    while ((satir = sr.ReadLine()) != null) //Döngü kurup eğer satır boş değilse, satirlarList List'ine ekleme yapıyoruz.
                    {
                        if (satir == "Square")
                        {
                            Square.Checked = true;
                        }
                        if (satir == "Triangle")
                        {
                            Triangle.Checked = true;
                        }
                        if (satir == "Round")
                        {
                            Round.Checked = true;
                        }
                        if (satir == "Easy")
                        {
                            Easy.Checked = true;
                        }
                        if (satir == "Normal")
                        {
                            Normal.Checked = true;
                        }
                        if (satir == "Hard")
                        {
                            Hard.Checked = true;
                        }
                        if (satir == "Custom")
                        {
                            Custom.Checked = true;
                            input1.Text = sr.ReadLine();
                            input2.Text = sr.ReadLine();
                        }
                        if (satir == "red")
                        {
                            red.Checked = true;
                        }
                        if (satir == "blue")
                        {
                            blue.Checked = true;
                        }
                        if (satir == "yellow")
                        {
                            yellow.Checked = true;
                        }
                    }
                }
            }
            catch { }
            
        }
    }
}
