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
using System.Net;

namespace hostel_management
{
    public partial class Fees : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\HostelManagement.mdf;Integrated Security=True;Connect Timeout=30");
        public Fees()
        {
            InitializeComponent();
        }
        public void FillUSN()
        {
            connection.Open();

            String query = "select StudentUSN from Student_table ";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("StudentUSN", typeof(string));
            dataTable.Load(reader);

            USN.ValueMember = "StudentUSN";
            USN.DisplayMember = "StudentUSN";
            USN.DataSource = dataTable;

            connection.Close();
        }

        void FillPayments()
        {
            connection.Open();
            string myquery = "Select * from Fees_table";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myquery, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataset = new DataSet();
            dataAdapter.Fill(dataset);
            Payments.DataSource = dataset.Tables[0];

            connection.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fees_Load(object sender, EventArgs e)
        {
            FillUSN();
            FillPayments();


        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void USN_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrWhiteSpace(paymentId.Text) || string.IsNullOrWhiteSpace(USN.Text) || string.IsNullOrWhiteSpace(Amount.Text))
                {
                    MessageBox.Show("No empty fields accepted");
                }
                else
                {
                    string paymentperiode = Periode.Value.Month.ToString() + Periode.Value.Year.ToString();


                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT(*) FROM fees_table WHERE StudentUSN='" + USN.SelectedValue.ToString() + "' AND PaymentMonth='" + paymentperiode + "'", connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("There is no due for this Month");
                    }
                    else
                    {
                        string query = "INSERT INTO Fees_table VALUES('" + paymentId.Text + "', '" + USN.SelectedValue.ToString() + "', '" + paymentperiode + "', '" + Amount.Text + "')";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Payment Successful");
                    connection.Close();
                    FillPayments();

                }
                }
            
           
                 
                
            
        }
        private void button6_Click(object sender, EventArgs e)
        {


            if (paymentId.Text == " ")
            {
                MessageBox.Show("ENTER THE Payment NUMBER");
            }
            else
            {

                connection.Open();
                string paymentperiode = Periode.Value.Month.ToString() + Periode.Value.Year.ToString();

                String query = "update Fees_table set Amount = '" + Amount.Text + "',StudentUSN='" + USN.SelectedItem.ToString() + "',PaymentMonth='" + paymentperiode + "' where PaymentId='" + paymentId.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Fees details Successfully Updated");





                connection.Close();
                FillPayments();
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (paymentId.Text == " ")
            {
                MessageBox.Show("ENTER THE Student university NUMBER");
            }

            else
            {
                connection.Open();
                String query = " delete from Fees_table where PaymentId= '" + paymentId.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Deleted");
                connection.Close();
                FillPayments();
            }





        }

        private void Payments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // string paymentperiode = Periode.Value.Month.ToString() + Periode.Value.Year.ToString();
            if (e.RowIndex >= 0 && e.RowIndex < Payments.Rows.Count)
            {
                paymentId.Text = Payments.SelectedRows[0].Cells[0].Value.ToString();
                USN.Text = Payments.SelectedRows[0].Cells[0].Value.ToString();
                Amount.Text = Payments.SelectedRows[0].Cells[0].Value.ToString();
                Periode.Text = Payments.SelectedRows[0].Cells[0].Value.ToString();

            }
        }
    }

}

       
    
    

