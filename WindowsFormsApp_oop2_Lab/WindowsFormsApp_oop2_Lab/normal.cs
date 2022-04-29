using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp_oop2_Lab
{
    public partial class normal : Form
    {
        public normal()
        {
            InitializeComponent();
        }
       
        private void normal_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[9, 9];
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 0;
            }
            Random rnd = new Random();
            Random rnd1 = new Random();
            for (int i = 0; i < 3; i++)
            {
                int row = rnd.Next( buttons.GetUpperBound(0) );
                int column = rnd1.Next( buttons.GetUpperBound(1) );
                var value = buttons[column, row];
                value.BackgroundImage = ımageList1.Images[0];
                value = null;
            }
        }

    }
}
