using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher_Login teacher_Login = new Teacher_Login();
            teacher_Login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Event e1 = new Event();
            e1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Announcement a1 = new Announcement();   
            a1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Shedule shedule = new Shedule();    
            shedule.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Admin_login a = new Admin_login();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
