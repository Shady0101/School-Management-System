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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;
        string AUserName;
        string APassword;

        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from ALog where AUserName=@AUserName and APassword=@APassword", con);
            AUserName = textBox1.Text;
            APassword = textBox2.Text;

            cmd.Parameters.AddWithValue("Ausername", AUserName);
            cmd.Parameters.AddWithValue("Apassword", APassword);

            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    Create_User create_User = new Create_User();
                    create_User.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dr.Close();
                con.Close();
            }
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con = new SqlConnection("Data Source=DESKTOP-VTDGO4D\\SQLEXPRESS ;Initial Catalog=SManagement;Integrated Security=True");
        }
    }
}
