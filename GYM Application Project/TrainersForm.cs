using System;
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
    public partial class TrainersForm : Form
    {
        public TrainersForm()
        {
            InitializeComponent();
        }

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrainersForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_rate_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrainersForm2 home = new TrainersForm2();
            home.Show();
            this.Hide();
        }

        private void lbl_address_Click(object sender, EventArgs e)
        {

        }
    }
}
