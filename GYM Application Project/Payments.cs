﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Application_Project
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void NewmemberButton_Click(object sender, EventArgs e)
        {
            Newmember newmember = new Newmember();
            newmember.Show();
            this.Hide();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void TrainersButton_Click(object sender, EventArgs e)
        {
            Trainer trainer = new Trainer();
            trainer.Show();
            this.Hide();
            trainer.GenerateDynamicUSerControl();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Payments_Load(object sender, EventArgs e)
        {

        }

        private void PaymentsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textsearchbar_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Payments_Shown(object sender, EventArgs e)
        {

        }
    }
}
