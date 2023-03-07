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
namespace WindowsFormsApp1
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
        public SqlConnection con;
        public SqlCommand cmd;
        string EventName;
        DateTime EventDate;
        string Announce;
        string Task;
        DateTime SDateAndTime;
        DateTime Duration;
        string Discription;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            Task = textBox2.Text;
            SDateAndTime = dateTimePicker2.Value;
            Duration = dateTimePicker3.Value;
            Discription = textBox4.Text;
            cmd = new SqlCommand("Insert into Shedule values (@Task, @SDateAndTime, @Duration, @Discription)", con);
            cmd.Parameters.AddWithValue("Task", Task);
            cmd.Parameters.AddWithValue("SDateAndTime", SDateAndTime);
            cmd.Parameters.AddWithValue("Duration", Duration);
            cmd.Parameters.AddWithValue("Discription", Discription);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted-Congratulations!!");

        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VTDGO4D\\SQLEXPRESS ;Initial Catalog=SManagement;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            EventName = textBox1.Text; 
            EventDate = dateTimePicker1.Value;
            cmd = new SqlCommand("Insert into Events values(@EventName, @EventDate)", con);
            cmd.Parameters.AddWithValue("Eventname", EventName);
            cmd.Parameters.AddWithValue("Eventdate", EventDate);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted-Congratulations!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            Announce = textBox3.Text;
            cmd = new SqlCommand("Insert into Announce values(@Announce)", con);
            cmd.Parameters.AddWithValue("Announce", Announce);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted - Congratulations!!");
        }
    }
}
