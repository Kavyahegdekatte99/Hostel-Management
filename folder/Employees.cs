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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace hostel_management
{
    public partial class Employees : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\HostelManagement.mdf;Integrated Security=True;Connect Timeout=30");
        public Employees()
        {
            InitializeComponent();
        }
        void FillEmployeeList()
        {
            connection.Open();
            string myquery = "Select * from Employee_table";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myquery, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataset = new DataSet();
            dataAdapter.Fill(dataset);
           EmployeeList.DataSource = dataset.Tables[0];

            connection.Close();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            FillEmployeeList();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (EmployeeId.Text == " " || EmployeeName.Text == " " || PhoneNumber.Text.ToString() == " " || Address.Text == " ")
                {
                    MessageBox.Show("NO empty accepted");
                }


                else
                {

                    connection.Open();
                    String query = "insert into Employee_table values('" + EmployeeId.Text + "', '" + EmployeeName.Text + " ', '" + PhoneNumber.Text + "' , '" + Address.Text + " ', '" + Position.SelectedItem.ToString() + "','" + Employeestatus.SelectedItem.ToString() + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Employee details Successfully Added");
                connection.Close();
                FillEmployeeList();
                }
        
                    
                

               
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (EmployeeId.Text == " ")
                {
                    MessageBox.Show("ENTER THE Student university NUMBER");
                }
                else
                {

                    connection.Open();
                    String query = "update Employee_table set EmployeeName = '" + EmployeeName.Text + "',EmployeePhone='" + PhoneNumber.Text + "' ,EmployeeAddress='" + Address.Text + "',EmployeePosition='" +Position.SelectedItem.ToString() + "',EmployeeStatus='" + Employeestatus.SelectedItem.ToString() + "' where EmployeeId='" + EmployeeId.Text + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("employee details Successfully Updated");
                connection.Close();
                FillEmployeeList();
                }

            
           
               
                

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

         
                if (EmployeeId.Text == " ")
                {
                    MessageBox.Show("ENTER THE Student university NUMBER");
                }

                else
                {
                    connection.Open();
                    String query = " delete from Employee_table where EmployeeId= '" + EmployeeId.Text + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student Successfully Deleted");
                connection.Close();
                FillEmployeeList();
                }
        
                    
                }
            }
        
    
        }
    

