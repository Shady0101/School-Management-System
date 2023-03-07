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
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlDataAdapter ad;
        public DataSet ds = new DataSet();
        string EventName;
        DateTime EventDate;
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            ad = new SqlDataAdapter("select * from Events", con);
            ad.Fill(ds, "Events");
            con.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Events";
        }

        private void Event_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VTDGO4D\\SQLEXPRESS ;Initial Catalog=SManagement;Integrated Security=True";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
