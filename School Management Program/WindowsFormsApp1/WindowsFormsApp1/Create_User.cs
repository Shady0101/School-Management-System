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
    public partial class Create_User : Form
    {
        public Create_User()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand cmd;
        string TUserName;
        string TPassword;
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            TUserName = textBox1.Text; 
            TPassword = textBox2.Text;
            cmd = new SqlCommand("Insert into TL values(@TUserName, @TPassword)", con);
            cmd.Parameters.AddWithValue("TUsername", TUserName);
            cmd.Parameters.AddWithValue("TPassword", TPassword); 
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("created");
        }

        private void Create_User_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con = new SqlConnection("Data Source=DESKTOP-VTDGO4D\\SQLEXPRESS ;Initial Catalog=SManagement;Integrated Security=True");
        }
    }
}
