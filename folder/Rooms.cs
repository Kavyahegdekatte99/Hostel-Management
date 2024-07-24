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

namespace hostel_management
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\Documents\HostelManagement.mdf;Integrated Security=True;Connect Timeout=30");
        void FillRoomsList()
        {
            connection.Open();
            string myquery = "Select * from Room_table";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myquery, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataset = new DataSet();
            dataAdapter.Fill(dataset);
            RoomsList.DataSource = dataset.Tables[0];

            connection.Close();
        }
        private void Rooms_Load(object sender, EventArgs e)
        {
            FillRoomsList();
        }

        private void Rooms_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void Rooms_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
                string roomstatus;
                if (Room.Text == " ")
                {
                    MessageBox.Show("ENTER THE ROOM NUMBER");
                }
                else
                {
                    if (Yesbutton.Checked == true)
                    {
                        roomstatus = "Busy";
                    }
                    else
                    {
                        roomstatus = "Free";
                    }
                    connection.Open();
                    String query = "insert into Room_table values(" + Room.Text + ", '" + RoomStatus.SelectedItem.ToString() + "','" + roomstatus + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Rooms Successfully Added");
                    connection.Close();
                    FillRoomsList();
                }
          
                

            
        }



        private void label7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Room_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         


                if (Room.Text == " ")
                {
                    MessageBox.Show("ENTER THE ROOM NUMBER");
                }
                else
                {
                    connection.Open();
                    String query = " delete from Room_table where RoomNumber=" + Room.Text + "";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Rooms Successfully Deleted");
                connection.Close();
                FillRoomsList();
                }
            
                  

            

        }
    


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Room.Text = RoomsList.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

                string roomstatus;
                if (Room.Text == " ")
                {
                    MessageBox.Show("ENTER THE ROOM NUMBER");
                }
                else
                {
                    if (Yesbutton.Checked == true)
                    {
                        roomstatus = "Busy";
                    }
                    else
                    {
                        roomstatus = "Free";
                    }
                    connection.Open();
                    String query = "update Room_table set RoomStatus = '" + RoomStatus.SelectedItem.ToString() + "',Booked ='" + roomstatus + "' where RoomNumber=" + Room.Text + "";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Rooms Successfully Updated");
                connection.Close();
                FillRoomsList();

                    

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
