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
using System.Configuration;

namespace GYM_Application_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DB_Items.mdf;Integrated Security=True;Connect Timeout=30");
        

        private void AddGymOwenrs()
        {
            connection.Open();
            string qry = "INSERT INTO Admin(id,name,username,password) VALUES(1, 'DahamKalyana', 'Daham', 'Md1234'), (2, 'Nirasha Herath', 'Nirasha', 'Hm1234'), (3, 'Adeeshya Ekanayake', 'Adeeshya', 'Em1234'), (4, 'Dasanjith Gunaratne', 'Dasanjith', 'Kd1234'),  (5,'Mandakini Waranga','Mandakini','Wm1234'), (6,'Mihin Nimnaka','mihin','Km234') ";
            SqlCommand cmd = new SqlCommand(qry, connection);
            cmd.ExecuteNonQuery();
        }
        
        

        private void Tuser_Enter(object sender, EventArgs e)
        {
            Tuser.Text = "";
        }

        private void Tuser_MouseEnter(object sender, EventArgs e)
        {
            Tuser.Text = "";
        }

        private void Tpass_MouseEnter(object sender, EventArgs e)
        {
            Tpass.Text = "";
            Tpass.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AddGymOwenrs();
            if (Tuser.Text == "" || Tpass.Text == "")
            {
                showErrorMsg();
            }
            else
            {
                login();
            }
        }

        private void showErrorMsg()
        {
            MessageBox.Show("Login Faild. Try again", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void login()
        {
            try
            {
                connection.Open();
                String query = "select id from Admin where username = '" + Tuser.Text.Trim() + "' and password = '"+Tpass.Text.Trim()+"'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                
                if (!reader.HasRows)
                {
                    showErrorMsg();
                }
                else
                {
                    Form1 dashboard = new Form1();
                    dashboard.Show();
                    this.Hide();
            }
            connection.Close();
            }

            catch
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tpass_Enter(object sender, EventArgs e)
        {
            Tpass.Text = "";
            Tpass.PasswordChar = '*';
        }
    }
}
