using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project2023
{
    public partial class Order : Form
    {
        SqlConnection connection;

        public Order()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LAPTOP-IVCRLCUN\SQLEXPRESS01;Initial Catalog=FinalDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        public void AddOrder(string itemName, decimal price)
        {
            string query = "INSERT INTO Orders (ItemName, Price) VALUES (@ItemName, @Price)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ItemName", itemName);
                command.Parameters.AddWithValue("@Price", price);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable ViewOrder()
        {
            string query = "SELECT * FROM Orders";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();

            connection.Open();
            adapter.Fill(dataTable);
            connection.Close();

            return dataTable;
        }

        public void DeleteOrder(string itemName)
        {
            string query = "DELETE FROM Orders WHERE ItemName = @ItemName";

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
            string itemName = textEmployeeName.Text;
            decimal price = decimal.Parse(txtEmployeeID.Text);
            AddOrder(itemName, price);
        }

        private void button2_Click(object sender, EventArgs e) // View
        {
            dataGridView1.DataSource = ViewOrder();
        }

        private void button3_Click(object sender, EventArgs e) // Del
        {
            string itemName = textEmployeeName.Text;
            DeleteOrder(itemName);
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }
    }
}
