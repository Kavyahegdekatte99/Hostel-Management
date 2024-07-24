using System;
using System.Windows.Forms;

namespace hostel_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student mystudent = new Student();
            mystudent.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Rooms myroom = new Rooms();
            myroom.Show();
            this.Hide();


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Employees myemployee = new Employees();
            myemployee.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fees myfees= new Fees();
            myfees.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Salary mysalary= new Salary();
            mysalary.Show();
            this.Hide();
        }
    }
}
