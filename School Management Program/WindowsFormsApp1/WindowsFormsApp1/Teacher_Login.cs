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


namespace WindowsFormsApp1
{
    public partial class Teacher_Login : Form
    {
        public Teacher_Login()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;
        string TUserName;
        string TPassword;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Teacher_Login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con = new SqlConnection("Data Source=DESKTOP-VTDGO4D\\SQLEXPRESS ;Initial Catalog=SManagement;Integrated Security=True");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from TL where TUserName=@TUserName and TPassword=@TPassword", con);
            TUserName = textBox1.Text;
            TPassword = textBox2.Text;

            cmd.Parameters.AddWithValue("TUsername", TUserName);
            cmd.Parameters.AddWithValue("TPassword", TPassword);

            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    Teacher t1 = new Teacher();
                    t1.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dr.Close();
                con.Close();
            }
        }
    }
}
