﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2023
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order item = new Order();
            item.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 item = new Form1();
            item.Show();
        }
    }
}
