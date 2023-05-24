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

namespace ProjectLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from login where Uname ='"+UnameTb.Text+"' and Password = '"+PasswordTb.Text+"'",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MainPage main = new MainPage();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!");
                }
                
                Con.Close();
            }
            catch
            {

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
