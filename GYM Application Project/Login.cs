﻿using System;
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
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Users.mdf;Integrated Security=True;Connect Timeout=30");

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
                String query = "select id from users where username = '" + Tuser.Text.Trim() + "' and password = '"+Tpass.Text.Trim()+"'";
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
