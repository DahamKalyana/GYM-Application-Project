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
            TrainerSuccessMsg success = new TrainerSuccessMsg();
            TrainerFailMsg fail = new TrainerFailMsg();
            TrainerFillAll fill = new TrainerFillAll();


            if(pb_Image.Image == null)
            {
               pb_Image.Image = Image.FromFile(@"C:/Users/Daham Kalyana/source/repos/GYM Application Project/GYM Application Project/Resources/usericon.jpg");
            }

            if (txtbox_trainerid.Text== "" ||  txtbox_name.Text == "" || txt_email.Text=="" || txtbox_age.Text=="" || txtbox_exp.Text=="" || txtbox_rate.Text=="")
            {
                //MessageBox.Show("Please fill all fields");
                fill.Show();
            }

            else
            {
                if (objbll.SaveItems(pb_Image.Image, int.Parse(txtbox_trainerid.Text), txtbox_name.Text, txt_email.Text, txtbox_age.Text, txtbox_exp.Text, txtbox_rate.Text))
                {
                    // MessageBox.Show("Trainer added succusfully!");
                    success.Show();          
                                        
                }
                else
                {
                    fail.Show();
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

            TrainerUpdateMsg updatesuccess = new TrainerUpdateMsg();

            if (pb_Image.Image == null)
            {
                pb_Image.Image = Image.FromFile(@"C:/Users/Daham Kalyana/source/repos/GYM Application Project/GYM Application Project/Resources/usericon.jpg");
            }

            if (txtbox_trainerid.Text == "" || txtbox_name.Text == "" || txt_email.Text == "" || txtbox_age.Text == "" || txtbox_exp.Text == "" || txtbox_rate.Text == "" || pb_Image.Image== null)
            {
                MessageBox.Show("Please update all fields");
            }

            else
            {
                if (obj2.UpdateItems(pb_Image.Image, int.Parse(txtbox_trainerid.Text), txtbox_name.Text, txt_email.Text, txtbox_age.Text, txtbox_exp.Text, txtbox_rate.Text))
                {
                    //MessageBox.Show("Updated Successfully!");
                    updatesuccess.Show();
                    
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

            TrainerDeleteMsg deletesuccess = new TrainerDeleteMsg();

            if (txtbox_trainerid.Text=="")
            {
                MessageBox.Show("Please enter the Trainer ID you want to delete");
            }

            else
            {
                
                if (obj2.DeleteItems(int.Parse(txtbox_trainerid.Text)))
                {
                    //MessageBox.Show("Deleted Successfully!");
                    deletesuccess.Show();
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

        private void txtbox_trainerid_TextChanged(object sender, EventArgs e)
        {
            Connection objcon = new Connection();
            objcon.connect.Open();


            if (txtbox_trainerid.Text != "")
            {
                string qry = "SELECT Name, Email, Age, Experience, Rate, Image FROM GymTrainers WHERE TrainerID=@TrainerID ";

                SqlCommand cmd = new SqlCommand(qry, objcon.connect);
                cmd.Parameters.AddWithValue("@TrainerID", txtbox_trainerid.Text);
                SqlDataReader da = cmd.ExecuteReader();


                while (da.Read())
                {

                    txtbox_name.Text = da.GetValue(0).ToString();
                    txt_email.Text = da.GetValue(1).ToString();
                    txtbox_age.Text = da.GetValue(2).ToString();
                    txtbox_exp.Text = da.GetValue(3).ToString();
                    txtbox_rate.Text = da.GetValue(4).ToString();
                    byte[] picture = (byte[])da.GetValue(5);

                    MemoryStream ms = new MemoryStream(picture);
                    pb_Image.Image = Image.FromStream(ms);
                }
            }
        }

        public void clear()
        {
            txtbox_trainerid.Clear();
            txtbox_name.Clear();
            txt_email.Clear();
            txtbox_age.Clear();
            txtbox_exp.Clear();
            txtbox_rate.Clear();
            pb_Image.Image = null;
        }
        
        public void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
