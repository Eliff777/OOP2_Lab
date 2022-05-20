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
using System.Threading; //Thread.sleep
using System.Windows.Forms;
using System.Timers;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApp_oop2_Lab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string whatis = null;

        public string username;
        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            var select = "SELECT * FROM Table_1 where username=@us";

            SqlParameter prm1 = new SqlParameter("@us", username.Trim());
            SqlCommand komut = new SqlCommand(select, con);
            komut.Parameters.Add(prm1);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            string bestScore = dt.Rows[0][8].ToString();
            best_score_label.Text = " The best score is : " + bestScore;
            con.Close();

            if (username == "admin")
            {
                managersc.Visible = true;
            }
            Form3 form3 = new Form3();
            
            //******************
            XmlDocument doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + "//document.xml");

            foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            {
                 if (node.SelectSingleNode("username").InnerText == username)
                  {
                
                    imagelist = createimagelist();
                    if (node.SelectSingleNode("Difficulty").FirstChild.InnerText == "Easy")
                    {
                        whatis = "easy";
                        butonlar = create_board(15, 15);
                        random_atama(imagelist, butonlar);
                    }
                    if (node.SelectSingleNode("Difficulty").FirstChild.InnerText == "Normal")
                    {
                        whatis = "normal";
                        butonlar = create_board(9, 9);
                        random_atama(imagelist, butonlar);
                    }
                    if (node.SelectSingleNode("Difficulty").FirstChild.InnerText == "Hard")
                    {
                        whatis = "hard";
                        butonlar = create_board(6, 6);
                        random_atama(imagelist, butonlar);
                    }
                    if (node.SelectSingleNode("Difficulty").FirstChild.InnerText == "Custom")
                    {
                        whatis = "custom";
                        string a = node.SelectSingleNode("Difficulty").FirstChild.NextSibling.InnerText;
                        string b = node.SelectSingleNode("Difficulty").FirstChild.NextSibling.NextSibling.InnerText;
                        butonlar = create_board(int.Parse(a), int.Parse(b));
                        random_atama(imagelist, butonlar);
                    }
                }
            }//end of creating board as it wanted to be...
            
            
        }
        private void increase_total_point()
        {
            if (whatis == "easy")
                total_point++;
            else if (whatis == "normal")
                total_point += 3;
            else if (whatis == "custom")
                total_point += 2;
            else if (whatis == "hard")
                total_point += 5;
        }
        private bool showThePath(int sr, int sc, int tr, int tc)
        {
            //grid=matrix

            int m = butonlar.GetUpperBound(0) + 1;
            int n = butonlar.GetUpperBound(0) + 1;
            bool[,] visited = new bool[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    visited[i, j] = false;
                }
            }

            string[,] pred = new string[m, n];
            string s = sr.ToString() + " " + sc.ToString();

            Queue<String> Q = new Queue<string>();
            Q.Enqueue(s);
            pred[sr, sc] = "-1 -1";
            visited[sr, sc] = true;
            int a = 0;
            while (Q.Count > 0)
            {
                a++;
                string p = Q.Peek(); Q.Dequeue();
                string[] subs = p.Split(' ');
                int r = int.Parse(subs[0]);
                int c = int.Parse(subs[1]);
                if (r == tr && c == tc) break;

                // Neighbors
                int[,] neighs = new int[,] { { r - 1, c }, { r + 1, c }, { r, c - 1 }, { r, c + 1 } };
                for (int x = 0; x < 4; x++)
                {
                    int nr = neighs[x, 0];
                    int nc = neighs[x, 1];
                    if (nr < 0 || nr >= m || nc < 0 || nc >= n) continue;

                    if (butonlar[nr, nc].BackgroundImage == null && visited[nr, nc] == false) 
                    {
                        visited[nr, nc] = true;
                        pred[nr, nc] = r.ToString() + " " + c.ToString();
                        s = nr.ToString() + " " + nc.ToString();
                        Q.Enqueue(s);
                    }
                }

            } // end-while
            List<string> path = new List<string>();
            int X = tr;//R
            int Y = tc;//C
            while (true)
            {
                path.Add(X.ToString() + " " + Y.ToString());
                try
                {
                    string[] subs = pred[X, Y].Split(' ');
                
                if (int.Parse(subs[0]) < 0)
                    break;
                int nr = int.Parse(subs[0]);
                int nc = int.Parse(subs[1]);
                X = nr;
                Y = nc;
                }
                catch
                {
                    return false;
                }
            } // end-while
            string buney = null;
            for (int ş = path.Count() - 1; ş > -1; ş--)
                buney += path[ş] + " ";
            int önceki_i = sr;
            int önceki_j = sc;
            //MessageBox.Show(buney);
            for (int i = path.Count-2; i > -1; i--) 
            {
                string[] subs = path[i].Split(' ');
                butonlar[int.Parse(subs[0]), int.Parse(subs[1])].BackgroundImage = butonlar[önceki_i, önceki_j].BackgroundImage;
                string k = null;
                k = butonlar[int.Parse(subs[0]), int.Parse(subs[1])].Name;
                //k = butonlar[int.Parse(subs[0]), int.Parse(subs[1])].Name.Substring(butonlar[int.Parse(subs[0]), int.Parse(subs[1])].Name.Length - 2);

                //son 2 karakteri aldı yani indexi
                butonlar[int.Parse(subs[0]), int.Parse(subs[1])].Name = butonlar[önceki_i, önceki_j].Name.Substring(0, 2) + k;
                
                //şimdiki buton.Name = önceki buton.Name;
                //önceki butonun isminin ilk 2 karakterini aldı çünkü ilk 2 karakter şekli belirtir
                //sonra da k aldı çünkü kendi indexi index

                butonlar[önceki_i, önceki_j].BackgroundImage = null;
                butonlar[önceki_i, önceki_j].Name = butonlar[önceki_i, önceki_j].Name.Substring(butonlar[önceki_i, önceki_j].Name.Length - 2);
               /// butonlar[önceki_i, önceki_j].Name = butonlar[önceki_i, önceki_j].Name.Remove(0, 2); //=null idi önceden
                //butonlar[önceki_i, önceki_j].Text = butonlar[önceki_i, önceki_j].Name;
                //butonlar[int.Parse(subs[0]), int.Parse(subs[1])].Text = butonlar[int.Parse(subs[0]), int.Parse(subs[1])].Name;
                //butonlar[önceki_i, önceki_j].Text = "";
                butonlar[int.Parse(subs[0]), int.Parse(subs[1])].Refresh();
                butonlar[önceki_i, önceki_j].Refresh();
                System.Threading.Thread.Sleep(500);
                önceki_i = int.Parse(subs[0]);
                önceki_j = int.Parse(subs[1]);
                //butonlar[int.Parse(subs[0]), int.Parse(subs[1])].Text = butonlar[int.Parse(subs[0]), int.Parse(subs[1])].Name;
            }
            return true;
        }
        private int total_point = 0;
        private void yoketme()
        {
            //soldan sağa yok etme...
            for (int i = 0; i < butonlar.GetLength(0); i++)
            {
                for (int j = 0; j < butonlar.GetLength(1); j++)
                {
                    if (j + 2 < butonlar.GetLength(1))
                    {
                        bool check = false;
                        if (butonlar[i, j].Name.Length != 2 &&
                            butonlar[i, j + 1].Name.Length != 2 &&
                            butonlar[i, j + 2].Name.Length != 2)
                        {
                            check = true;
                        }
                                
                        if (check == true && (butonlar[i, j].Name.Substring(0, 2) == butonlar[i, j + 1].Name.Substring(0, 2)
                            && butonlar[i, j].Name.Substring(0, 2) == butonlar[i, j + 2].Name.Substring(0, 2)))  //&& butonlar[i, j].Name != ""
                        {
                            while ((butonlar[i, j].Name.Substring(0, 2) == butonlar[i, j + 1].Name.Substring(0, 2)) && j + 2 != butonlar.GetLength(1))
                            {
                                MessageBox.Show(butonlar[i, j + 2].Name);
                                if (butonlar[i, j + 2].BackgroundImage == null)
                                    MessageBox.Show("NULL");
                                butonlar[i, j].Name = butonlar[i, j].Name.Substring(butonlar[i, j].Name.Length - 2);
                                // butonlar[i, j].Name.Remove(0, 2);//  butonlar[i, j].Name = "";
                                //butonlar[i, j].Text = " ";
                                butonlar[i, j].BackgroundImage = null;
                                j++;
                                increase_total_point();
                                puanaldı = true;
                            }
                            string n = butonlar[i, j].Name.Substring(0, 2);
                            butonlar[i, j].Name = butonlar[i, j].Name.Substring(butonlar[i, j].Name.Length - 2);
                            butonlar[i, j].BackgroundImage = null;
                            increase_total_point();
                            if (j + 2 == butonlar.GetLength(1) && n == butonlar[i, j + 1].Name.Substring(0, 2))
                            {
                                butonlar[i, j + 1].Name = butonlar[i, j + 1].Name.Substring(butonlar[i, j + 1].Name.Length - 2);
                                butonlar[i, j + 1].BackgroundImage = null;
                                increase_total_point();
                            }
                        }
                    }
                }
            }

            //yukarıdan aşağıya yok etme...
            for (int j = 0; j < butonlar.GetLength(0); j++)
            {
                for (int i = 0; i < butonlar.GetLength(1); i++)
                {
                    if (i + 2 < butonlar.GetLength(1))
                    {
                        bool check = false;
                        if (butonlar[i, j].Name.Length != 2 &&
                            butonlar[i+1, j ].Name.Length != 2 &&
                            butonlar[i+2, j].Name.Length != 2)
                            check = true;
                        if (check == true && (butonlar[i, j].Name.Substring(0, 2) == butonlar[i + 1, j].Name.Substring(0, 2)
                            && butonlar[i, j].Name.Substring(0, 2) == butonlar[i + 2, j].Name.Substring(0, 2)))
                        {
                            while ((butonlar[i, j].Name.Substring(0, 2) == butonlar[i + 1, j].Name.Substring(0, 2)) && i + 2 != butonlar.GetLength(1))
                            {
                                butonlar[i, j].Name = butonlar[i, j].Name.Substring(butonlar[i, j].Name.Length - 2);

                                increase_total_point();
                                butonlar[i, j].BackgroundImage = null;
                                i++;
                                puanaldı = true;
                            }
                            string n = butonlar[i, j].Name.Substring(0, 2);
                            butonlar[i, j].Name = butonlar[i, j].Name.Substring(butonlar[i, j].Name.Length - 2);                           //butonlar[i, j].Name.Remove(0, 2);
                                                                                                                                           //butonlar[i, j].Text = null;
                            increase_total_point();
                            butonlar[i, j].BackgroundImage = null;
                            if (i + 2 == butonlar.GetLength(1) && n == butonlar[i + 1, j].Name.Substring(0, 2)) 
                            {
                                butonlar[i + 1, j].Name = butonlar[i + 1, j].Name.Substring(butonlar[i + 1, j].Name.Length - 2);
                                increase_total_point();
                                butonlar[i + 1, j].BackgroundImage = null;
                            }
                        }
                    }
                }
            }
        }
        private bool puanaldı = false;
        private bool secondtime = false;
        private Button b = null;//ilk tıklanan buton
        private ImageList imagelist = null;
        private Button[,] butonlar = null;
        private void button_click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;//2. tıklanan buton
            if (secondtime == true)
            {
                string name = btn.Name.Substring(btn.Name.Length - 2);
                string si = name.Substring(0, 1);
                string sj = name.Substring(name.Length - 1);//btn.Name.Length

                name = b.Name.Substring(b.Name.Length - 2);
                string ti = name.Substring(0, 1);
                string tj = name.Substring(name.Length - 1);
                bool x= showThePath(int.Parse(ti), int.Parse(tj), int.Parse(si), int.Parse(sj));
                if (x == false)
                {
                    MessageBox.Show("You can't move there!!!");
                    secondtime = false;
                }
                    
                else
                {
                    secondtime = false;
                    yoketme();
                    if(puanaldı==false)
                        random_atama(imagelist, butonlar);
                    puanaldı = false;
                }
            }
            else
            {
                b = btn;
                secondtime = true;
            }
        }
        public string conString = "Data Source=DESKTOP-M5UOMRR\\SQLEXPRESS;Initial Catalog=users;Integrated Security=True";
        private void random_atama(ImageList img, Button[,] buttons)
        {
            List<string> liste = new List<string>();
            int i, count = 0;
            var row = butonlar.GetLength(0);
            var col = butonlar.GetLength(1);
            for (i = 0; i < row; i++) 
            {
                for (int j = 0; j < col; j++)
                {
                    if (butonlar[i, j].Name.Length == 2)
                    {
                        liste.Add(butonlar[i, j].Name.ToString());
                        count++;
                    }
                        
                }
            }
            if (count == 0)
                is_the_game_over = true;
            i = 0;
            if (count >= 3)
                count = 3;
            while (i < count)
            {
                string name = null;
                //0 kırmızı, 1 mavi, 2 sarı
                // 0 daire, 1 kare, 2 üçgen
                Random rnd = new Random();
                Random rnd1 = new Random();
                //burayı düzeltmem lazım çok çalışıyor..
                int random_number = new Random().Next(0, img.Images.Count);


                int index = rnd.Next(liste.Count);
                string a = liste[index];
                liste.RemoveAt(index);
                int rowa = int.Parse(a.Substring(0, 1));
                int column = int.Parse(a.Substring(a.Length - 1, 1));
                //int rowa = rnd.Next(butonlar.GetLength(0));//int rowa = rnd.Next(buttons.GetUpperBound(0));
                //int column = rnd1.Next(butonlar.GetLength(1));//int column = rnd1.Next(buttons.GetUpperBound(0));
                var value = buttons[rowa, column];
                MessageBox.Show(rowa.ToString() + column.ToString() + random_number.ToString());

                if (value.BackgroundImage == null)
                {
                    Bitmap resized = new Bitmap(img.Images[random_number], new Size(50, 50));
                    value.BackgroundImage = resized;
                    if (random_number == 0)
                        name = "00";//kırmızı daire
                    if (random_number == 1)
                        name = "01";//kırmızı kare
                    if (random_number == 2)
                        name = "02";//kırmızı üçgen
                    if (random_number == 3)
                        name = "10";//mavi daire
                    if (random_number == 4)
                        name = "11";//mavi kare
                    if (random_number == 5)
                        name = "12";//mavi üçgen
                    if (random_number == 6)
                        name = "20";//sarı daire
                    if (random_number == 7)
                        name = "21";//sarı kare
                    if (random_number == 8)
                        name = "22";//sarı üçgen
                    value.Name = name + value.Name.Substring(value.Name.Length - 2);//ilk 2si renk belirtir son 2si index belirtir
                    //value.Text = value.Name;
                    i++;
                }
            }
            if (count < 3)
            {
                MessageBox.Show("Game Over" + total_point.ToString());
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                var select = "SELECT * FROM Table_1 where username=@us";

                SqlParameter prm1 = new SqlParameter("@us", username.Trim());
                SqlCommand komut = new SqlCommand(select, con);
                komut.Parameters.Add(prm1);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                string a = dt.Rows[0][8].ToString();
                if (int.Parse(a) < total_point)
                {
                    string sql = "Update Table_1 set bestscore=@bestscore where username=@smth";
                    SqlCommand com = new SqlCommand(sql, con);

                    com.Parameters.AddWithValue("@bestscore", total_point);
                    com.Parameters.AddWithValue("@smth", username);
                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
             yoketme();
        }
        private bool is_the_game_over = false;
        private ImageList createimagelist()
        {
            ImageList img = new ImageList();
            List<string> renkler = new List<string>();
            List<string> şekiller = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + "//document.xml");
            foreach (XmlNode node in doc.SelectNodes("Kullanıcılar/person"))
            {
                if (node.SelectSingleNode("username").InnerText == username)
                {
                    if (node.SelectSingleNode("Colour").FirstChild.InnerText == "true")
                        renkler.Add("red");
                    if (node.SelectSingleNode("Colour").FirstChild.NextSibling.InnerText == "true")
                        renkler.Add("blue");
                    if (node.SelectSingleNode("Colour").LastChild.InnerText == "true")
                        renkler.Add("yellow");

                    if (node.SelectSingleNode("Shape").FirstChild.InnerText == "true")
                        şekiller.Add("square");
                    if (node.SelectSingleNode("Shape").FirstChild.NextSibling.InnerText == "true")
                        şekiller.Add("triangle");
                    if (node.SelectSingleNode("Shape").LastChild.InnerText == "true")
                        şekiller.Add("round");
                    if (renkler.Contains("red"))
                    {
                        if (şekiller.Contains("round"))
                            img.Images.Add(ımageList1.Images[0]);
                        if (şekiller.Contains("square"))
                            img.Images.Add(ımageList1.Images[1]);
                        if (şekiller.Contains("triangle"))
                            img.Images.Add(ımageList1.Images[2]);
                    }
                    if (renkler.Contains("blue"))
                    {
                        if (şekiller.Contains("round"))
                            img.Images.Add(ımageList1.Images[3]);
                        if (şekiller.Contains("square"))
                            img.Images.Add(ımageList1.Images[4]);
                        if (şekiller.Contains("triangle"))
                            img.Images.Add(ımageList1.Images[5]);
                    }
                    if (renkler.Contains("yellow"))
                    {
                        if (şekiller.Contains("round"))
                            img.Images.Add(ımageList1.Images[6]);
                        if (şekiller.Contains("square"))
                            img.Images.Add(ımageList1.Images[7]);
                        if (şekiller.Contains("triangle"))
                            img.Images.Add(ımageList1.Images[8]);
                    }
                }

                
            }
            return img;

        }
       
        private Button[,] create_board(int row, int col)
        {
            Button[,] buttons = new Button[row, col];
            int top = 40;
            int left = 10;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(0); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    buttons[i, j].Name = i.ToString() + j.ToString();
                    buttons[i, j].Click += new EventHandler(this.button_click);
                    buttons[i, j].MouseMove += new MouseEventHandler(this.mouse_up);
                    left += 50;
                    buttons[i, j].BackColor = Color.White;
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 10;
            }
            return buttons;
        }
        private void mouse_up(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Text = btn.Name;
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.kullanıcı_adı = username;
            form3.Show();
        }
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile pr = new profile();
            pr.kullanıcıadı = username;
            pr.Show();
        }
        private void managersc_Click(object sender, EventArgs e)
        {
            ListAllUsers l = new ListAllUsers();
            l.Show();
            this.Close();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about ab = new about();
            ab.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
