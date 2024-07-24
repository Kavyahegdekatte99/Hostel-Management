using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostel_management
{
    public partial class Salary : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\HostelManagement.mdf;Integrated Security=True;Connect Timeout=30");
        public Salary()
        {
            InitializeComponent();
        }

        public void FillEmployeeId()
        {
            connection.Open();

            String query = "select EmployeeId from Employee_table ";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("EmployeeId", typeof(string));
            dataTable.Load(reader);

            EmployeeId.ValueMember = "EmployeeId";
         EmployeeId.DisplayMember = "EmployeeId";
            EmployeeId.DataSource = dataTable;

            connection.Close();
        }

        void FillSalaryList()
        {
            connection.Open();
            string myquery = "Select * from Salary_table";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myquery, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataset = new DataSet();
            dataAdapter.Fill(dataset);
            SalaryList.DataSource = dataset.Tables[0];

            connection.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SalaryId.Text == " ")
            {
                MessageBox.Show("ENTER THE Student university NUMBER");
            }

            else
            {
                connection.Open();
                String query = " delete from Salary_table where SalaryId= '" + SalaryId.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Deleted");
                connection.Close();
                FillSalaryList();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SalaryId.Text == " ")
            {
                MessageBox.Show("ENTER THE Payment NUMBER");
            }
            else
            {

                connection.Open();
                string salaryperiode = Periode.Value.Month.ToString() + Periode.Value.Year.ToString();

                String query = "update Salary_table set Amount = '" + Amount.Text + "',EmployeeId='" + EmployeeId.SelectedItem.ToString() + "',SalaryMonth='" + salaryperiode + "' where SalaryId='" + SalaryId.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Salary details Successfully Updated");





                connection.Close();
                FillSalaryList();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SalaryId.Text) || string.IsNullOrWhiteSpace(EmployeeId.Text) || string.IsNullOrWhiteSpace(Amount.Text))
            {
                MessageBox.Show("No empty fields accepted");
            }
            else
            {
                string salaryperiode = Periode.Value.Month.ToString() + Periode.Value.Year.ToString();


                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT(*) FROM Salary_table WHERE EmployeeId='" + EmployeeId.SelectedValue.ToString() + "' AND SalaryMonth='" + salaryperiode + "'", connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("There is no due for this Month");
                }
                else
                {
                    string query = "INSERT INTO Salary_table VALUES('" + SalaryId.Text + "', '" + EmployeeId.SelectedValue.ToString() + "', '" + salaryperiode + "', '" + Amount.Text + "')";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Payment Successful");
                    connection.Close();
                    FillSalaryList();

                }
            }



        }


        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Salary_Load(object sender, EventArgs e)
        {
            FillEmployeeId();
            FillSalaryList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
