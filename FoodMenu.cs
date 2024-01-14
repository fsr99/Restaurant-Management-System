using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project2023
{
    public partial class Form1 : Form
    {
        SqlConnection connection;


        public Form1()
        {
            InitializeComponent();
            string connectionString = (@"Data Source=LAPTOP-IVCRLCUN\SQLEXPRESS01;Initial Catalog=FinalDB;Integrated Security=True");
            connection = new SqlConnection(connectionString);
        }
        public void AddItem(string itemName, decimal price)
        {
            string query = "INSERT INTO FoodMenu (ItemName, Price) VALUES (@ItemName, @Price)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ItemName", itemName);
                command.Parameters.AddWithValue("@Price", price);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable ViewItem()
        {
            string query = "SELECT * FROM FoodMenu";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();

            connection.Open();
            adapter.Fill(dataTable);
            connection.Close();

            return dataTable;
        }
        public void DeleteItem(string itemName)
        {
            string query = "DELETE FROM FoodMenu WHERE ItemName = @ItemName";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ItemName", itemName);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }



        private void button1_Click(object sender, EventArgs e) // Add
        {
            string itemName = txtItemName.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            AddItem(itemName, price);

            if (decimal.TryParse(txtPrice.Text, out price))
            {
                AddItem(itemName, price);
            }
            else
            {
                MessageBox.Show("Please enter a valid price.");
            }
        }

        private void button2_Click(object sender, EventArgs e) // View
        {
            dataGridView1.DataSource = ViewItem();
        }

        private void button3_Click(object sender, EventArgs e) // Del
        {
            string itemName = txtItemName.Text;
            DeleteItem(itemName);
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
