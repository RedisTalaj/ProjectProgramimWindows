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

namespace ProjectLogin
{
    public partial class UserData : Form
    {
        public UserData()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");

private void textBox2_TextChanged(object sender, EventArgs e)

        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserData_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }
    }
}
