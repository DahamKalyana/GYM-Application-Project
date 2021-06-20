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
using System.IO;

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

        
        //add trainer
        private void button1_Click(object sender, EventArgs e)
        {

            

            ClassBLL1 objbll = new ClassBLL1();
            Trainer obj = new Trainer();

            if(pb_Image.Image == null)
            {
               pb_Image.Image = Image.FromFile(@"C:/Users/Daham Kalyana/source/repos/GYM Application Project/GYM Application Project/Resources/usericon.jpg");
            }

            if (txtbox_name.Text== "" ||  txtbox_email.Text == "" || txt_newmail.Text=="" || txtbox_age.Text=="" || txtbox_exp.Text=="" || txtbox_rate.Text=="")
            {
                MessageBox.Show("Please fill all fields");
            }

            else
            {
                if (objbll.SaveItems(pb_Image.Image, int.Parse(txtbox_name.Text), txtbox_email.Text, txt_newmail.Text, txtbox_age.Text, txtbox_exp.Text, txtbox_rate.Text))
                {
                    MessageBox.Show("Trainer added succusfully!");
                    obj.Show();
                    obj.GenerateDynamicUSerControl();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Failed to add trainer!");
                }
            }
            
            
        }

        
        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_gender_Click(object sender, EventArgs e)
        {

        }


        //upload a image
        private void btn_UserPicUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(opendlg.FileName);
                pb_Image.Image = image;
            }
        }


        //update data
        private void update_Click(object sender, EventArgs e)
        {
            Connection update = new Connection();
            update.connect.Open();
            ClassBLL1 obj2 = new ClassBLL1();

            if (pb_Image.Image == null)
            {
                pb_Image.Image = Image.FromFile(@"C:/Users/Daham Kalyana/source/repos/GYM Application Project/GYM Application Project/Resources/usericon.jpg");
            }

            if (txtbox_name.Text == "" || txtbox_email.Text == "" || txt_newmail.Text == "" || txtbox_age.Text == "" || txtbox_exp.Text == "" || txtbox_rate.Text == "" || pb_Image.Image== null)
            {
                MessageBox.Show("Please update all fields");
            }

            else
            {
                if (obj2.UpdateItems(pb_Image.Image, int.Parse(txtbox_name.Text), txtbox_email.Text, txt_newmail.Text, txtbox_age.Text, txtbox_exp.Text, txtbox_rate.Text))
                {
                    MessageBox.Show("Updated Successfully!");
                    Trainer tr = new Trainer();
                    tr.GenerateDynamicUSerControl();
                    tr.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Failed to Update!");
                }
            }

            
         
        }


        //Delete data 
        private void delete_Click(object sender, EventArgs e)
        {

            ClassBLL1 obj2 = new ClassBLL1();

            if (txtbox_name.Text=="")
            {
                MessageBox.Show("Please enter the Trainer ID you want to delete");
            }

            else
            {
                
                if (obj2.DeleteItems(int.Parse(txtbox_name.Text)))
                {
                    MessageBox.Show("Deleted Successfully!");
                    Trainer tr = new Trainer();
                    tr.GenerateDynamicUSerControl();
                    tr.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Failed to delete!");
                }
            }

            
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
    }
}
