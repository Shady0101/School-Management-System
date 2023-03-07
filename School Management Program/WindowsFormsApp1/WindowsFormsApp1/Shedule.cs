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
    public partial class Shedule : Form
    {
        public Shedule()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlDataAdapter ad;
        public DataSet ds = new DataSet();
        string Task;
        DateTime SDateAndTime;
        DateTime Duration;
        string Discription;
       


        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            ad = new SqlDataAdapter("select * from Shedule", con);
            ad.Fill(ds, "Shedule");
            con.Close();
            dataGridView1.DataSource= ds;
            dataGridView1.DataMember = "Shedule";


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Shedule_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VTDGO4D\\SQLEXPRESS ;Initial Catalog=SManagement;Integrated Security=True";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
