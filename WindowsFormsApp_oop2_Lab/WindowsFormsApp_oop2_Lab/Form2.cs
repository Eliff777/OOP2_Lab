﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profile pr = new profile();
            pr.Show();
        }

        
    }
}
