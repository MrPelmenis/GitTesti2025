﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Čau, kā tev iet?????!";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = "Norlands";

            textBox1.Text = "Angelina";

        }
    }
}
