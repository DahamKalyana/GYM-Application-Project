using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Application_Project
{
    public partial class Newmember : Form
    {
        public Newmember()
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
            this.Show();
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

        private void btn_save_Click(object sender, EventArgs e)
        {

            Connection con = new Connection();
            con.connect.Open();
            string qry = "INSERT INTO Payments(member_id,name,email,January,February,March,April,May,June,July,August,September,October,November,December,image) VALUES(@member_id,@name,@email,@January,@February,@March,@April,@May,@June,@July,@August,@September,@October,@November,@December,@image)";
            
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con.connect))
                {
                    cmd.Parameters.AddWithValue("@member_id", int.Parse(txt_memid.Text));
                    cmd.Parameters.AddWithValue("@name", txt_name.Text);
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@January", "0");
                    cmd.Parameters.AddWithValue("@February", "0");
                    cmd.Parameters.AddWithValue("@March", "0");
                    cmd.Parameters.AddWithValue("@April", "0");
                    cmd.Parameters.AddWithValue("@May", "0");
                    cmd.Parameters.AddWithValue("@June", "0");
                    cmd.Parameters.AddWithValue("@July", "0");
                    cmd.Parameters.AddWithValue("@August", "0");
                    cmd.Parameters.AddWithValue("@September", "0");
                    cmd.Parameters.AddWithValue("@October", "0");
                    cmd.Parameters.AddWithValue("@November", "0");
                    cmd.Parameters.AddWithValue("@December", "0");

                    MemoryStream ms = new MemoryStream();
                    pb_image.Image.Save(ms, pb_image.Image.RawFormat);
                    cmd.Parameters.AddWithValue("@image", ms.ToArray());


                    cmd.ExecuteNonQuery();
                }
               
            }

            catch
            {
                throw;
            }


            profileBLL.profileClassBLL objbll = new profileBLL.profileClassBLL();
            Profile obj = new Profile();

            if(objbll.SaveItems(pb_image.Image, txt_memid.Text, txt_name.Text, txt_address.Text, txt_email.Text, int.Parse(txt_age.Text), int.Parse(txt_weight.Text), int.Parse(txt_height.Text), cb_Alevel.Text, cb_gender.Text, cb_target.Text))
            {
                MessageBox.Show("Member added succusfully..!");
                obj.Show();
                obj.GenerateDynamicUSerControlMembers();
                this.Hide();
            }
            
            else
            {
                MessageBox.Show("Failed to add member...!");
            }
        



        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(opendlg.FileName);
                pb_image.Image = image;
            }
        }
    }
}
