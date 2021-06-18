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

        string g;

        private void button1_Click(object sender, EventArgs e)
        {

            if(rbtn_male.Checked == true)
            {
                g = "Male";
            }

            ClassBLL1 objbll = new ClassBLL1();
            Trainer obj = new Trainer();

            if (objbll.SaveItems(pb_Image.Image, txtbox_name.Text, txtbox_email.Text, txtbox_age.Text, txtbox_exp.Text, txtbox_rate.Text))
            {
                MessageBox.Show("Trainer added succusfully!");
                obj.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Failed to add trainer!");
            }
        }

        private void lbl_address_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_gender_Click(object sender, EventArgs e)
        {

        }

        private void btn_UserPicUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(opendlg.FileName);
                pb_Image.Image = image;
            }
        }
    }
}
