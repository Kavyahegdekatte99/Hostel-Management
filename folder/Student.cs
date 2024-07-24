using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace hostel_management
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\HostelManagement.mdf;Integrated Security=True;Connect Timeout=30");

        void FillStudentRoom()
        {
            connection.Open();



            String query = "select RoomNumber from Room_table ";
            SqlDataAdapter sqad = new SqlDataAdapter(query,connection);
          //  SqlCommand command = new SqlCommand(query, connection);
           // SqlDataReader reader = command.ExecuteReader();
           DataTable dataTable = new DataTable();
            sqad.Fill(dataTable);
           // dataTable.Columns.Add("StudentRoom", typeof(string));
           // dataTable.Load(reader);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                StudentRoom.Items.Add(dataTable.Rows[i]["RoomNumber"]);
               
            }

            connection.Close();


            // StudentRoom.ValueMember = "RoomNumber";
            //StudentRoom.DisplayMember = "RoomNumber";
            //StudentRoom.DataSource = dataTable;
        }






        
        void FillStudentList()
        {
            connection.Open();
            string myquery = "Select * from Student_table";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myquery, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataset = new DataSet();
            dataAdapter.Fill(dataset);
            StudentList.DataSource = dataset.Tables[0];

            connection.Close();
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {
            FillStudentRoom();
            FillStudentList();
           

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
        
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void StudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < StudentList.Rows.Count)
            {
                StudentUSN.Text = StudentList.SelectedRows[0].Cells[0].Value.ToString();
                StudentName.Text = StudentList.SelectedRows[0].Cells[0].Value.ToString();
                FatherName.Text = StudentList.SelectedRows[0].Cells[0].Value.ToString();
                MotherName.Text = StudentList.SelectedRows[0].Cells[0].Value.ToString();
                Address.Text = StudentList.SelectedRows[0].Cells[0].Value.ToString();
                PhoneNumber.Text = StudentList.SelectedRows[0].Cells[0].Value.ToString();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
                if (StudentUSN.Text == " ")
                {
                    MessageBox.Show("ENTER THE Student university NUMBER");
                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                    {

                        connection.Open();
                    }
                    String query = " update Student_table set StudentName = '" + StudentName.Text + "',FatherName ='" + FatherName.Text + "' ,MotherName='" + MotherName.Text + "',StudentAddress='" + Address.Text + "',PhoneNumber='" + PhoneNumber.Text + "',StudentRoom='" + StudentRoom.SelectedItem.ToString() + "',StudentStatus='" + Studentstatus.SelectedItem.ToString() + "'where StudentUSN= ' " + StudentUSN.Text + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student Successfully Updated");
                connection.Close();
                FillStudentList();
                }

           
                  
                

            
        }

        private void StudentRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addfees_Click(object sender, EventArgs e)
        {
            
                if (StudentUSN.Text == " " || StudentName.Text == " " || PhoneNumber.Text.ToString() == " " || Address.Text == " " || FatherName.Text == "" || MotherName.Text == "")
                {
                    MessageBox.Show("NO empty accepted");
                }


                else
                {

                    connection.Open();
                    String query = "insert into Student_table values('" + StudentUSN.Text + "', '" + StudentName.Text + " ', '" + FatherName.Text + "','" + MotherName.Text + "','" + PhoneNumber.Text + "' , '" + Address.Text + " ', '" + StudentRoom.SelectedItem.ToString() + "','" + Studentstatus.SelectedItem.ToString() + " ')";
                  SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                MessageBox.Show("Student details Successfully Added");
                //MessageBox.Show(StudentRoom.SelectedItem.ToString());

                //connection.Close();
                FillStudentList();

                }
         
                  
                


            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
                if (StudentUSN.Text == " ")
                {
                    MessageBox.Show("ENTER THE Student university NUMBER");
                }

                else
                {
                    connection.Open();
                    String query = " delete from Student_table where StudentUSN= '" + StudentUSN.Text + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student Successfully Deleted");
            connection.Close();
            FillStudentList();
          
                  
                }
            }
        }
    }
    

