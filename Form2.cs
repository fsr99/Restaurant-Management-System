using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login item = new Login();
            item.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogin item = new ManagerLogin();
            item.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
