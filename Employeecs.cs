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
    public partial class Employeecs : Form
    {
        
        SqlConnection connection;

        public Employeecs()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LAPTOP-IVCRLCUN\SQLEXPRESS01;Initial Catalog=FinalDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        public void AddEmployee(string employeeName, string employeeID)
        {
            string query = "INSERT INTO Employee (EmployeeName, EmployeeID) VALUES (@EmployeeName, @EmployeeID)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EmployeeName", employeeName);
                command.Parameters.AddWithValue("@EmployeeID", employeeID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable ViewEmployee()
        {
            string query = "SELECT * FROM Employee";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();

            connection.Open();
            adapter.Fill(dataTable);
            connection.Close();

            return dataTable;
        }

        public void DeleteEmployee(string employeeName)
        {
            string query = "DELETE FROM Employee WHERE EmployeeName = @EmployeeName";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EmployeeName", employeeName);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) // add
        {
            string employeeName = textEmployeeName.Text;
            string employeeID = txtEmployeeID.Text;
            AddEmployee(employeeName, employeeID);
        }

        private void button2_Click(object sender, EventArgs e) // View
        {
            dataGridView1.DataSource = ViewEmployee();
        }

        private void button3_Click(object sender, EventArgs e) // Del
        {
            string employeeName = textEmployeeName.Text;
            DeleteEmployee(employeeName);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Employeecs_Load(object sender, EventArgs e)
        {

        }
    }
}
