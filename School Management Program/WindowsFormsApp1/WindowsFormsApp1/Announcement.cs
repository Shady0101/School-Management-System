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
    public partial class Announcement : Form
    {
        public Announcement()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlDataAdapter ad;
        public DataSet ds = new DataSet();
        string Announce;
        private void Announcement_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VTDGO4D\\SQLEXPRESS ;Initial Catalog=SManagement;Integrated Security=True";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            ad = new SqlDataAdapter("select * from Announce", con);
            ad.Fill(ds, "Announce");
            con.Close();
            dataGridView1.DataSource= ds;
            dataGridView1.DataMember = "Announce";
           
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
