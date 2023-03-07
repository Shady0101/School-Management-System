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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand cmd;
        string UserName;
        string Password;
        string PhoneNumber;
        string EmailAddress;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            UserName = textBox1.Text;
            Password = textBox2.Text;
            PhoneNumber = textBox3.Text;
            EmailAddress = textBox4.Text;
            cmd= new SqlCommand("Insert into Register values (@UserName, @Password, @PhoneNumber, @EmailAddress)", con);
            cmd.Parameters.AddWithValue("UserName", UserName);
            cmd.Parameters.AddWithValue("Password", Password);
            cmd.Parameters.AddWithValue("PhoneNumber", PhoneNumber);
            cmd.Parameters.AddWithValue("EmailAddress", EmailAddress);
            cmd.ExecuteNonQuery();
            cmd.Clone();
            MessageBox.Show("Record Inserted-Congratulations!!!");
        }

        private void Register_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString= "Data Source=DESKTOP-VTDGO4D\\SQLEXPRESS ;Initial Catalog=SManagement;Integrated Security=True";

        }
    }
}
