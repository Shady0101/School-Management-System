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
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;
        string UserName;
        string Password;


        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Register where UserName=@UserName and Password=@Password", con);
            UserName = textBox1.Text;
            Password = textBox2.Text;

            cmd.Parameters.AddWithValue("username", UserName);
            cmd.Parameters.AddWithValue("password", Password);

            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    Menu menu = new Menu();
                    menu.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dr.Close();
                con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Log_in_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VTDGO4D\\SQLEXPRESS ;Initial Catalog=SManagement;Integrated Security=True";
        }
    }
}
