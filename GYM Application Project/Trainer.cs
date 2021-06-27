using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GYM_Application_Project;

namespace GYM_Application_Project
{
    public partial class Trainer : Form
    {
        public Trainer()
        {
            InitializeComponent();
        }


        public void GenerateDynamicUSerControl()
        {
            flowLayoutPanel1.Controls.Clear();

            
            ClassBLL1 objbll = new ClassBLL1();
            DataTable dt = objbll.GetItems();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    MyUserControl[] listItems = new MyUserControl[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new MyUserControl();

                            MemoryStream ms = new MemoryStream((byte[])row["Image"]);
                            listItems[i].Icon = new Bitmap(ms);

                            listItems[i].Name = row["Name"].ToString();
                            listItems[i].Email = row["Email"].ToString();
                            listItems[i].Rate = row["Rate"].ToString();
                            listItems[i].TrainerID = row["TrainerID"].ToString();

                            flowLayoutPanel1.Controls.Add(listItems[i]);

                        }
                    }

                }
            }

        }

        private void Trainer_Load(object sender, EventArgs e)
        {
            GenerateDynamicUSerControl();
        }
        //add trainer
        private void Btn_Addtrainer_Click(object sender, EventArgs e)
        {
            TrainersForm home = new TrainersForm();
            home.Show();
            this.Hide();
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
            this.Show();
            GenerateDynamicUSerControl();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.Show();
            this.Hide();
        }

        private void TrainerPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        //Refresh
        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            TrainersForm update = new TrainersForm();
            update.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            TrainersForm del = new TrainersForm();
            del.Show();
            this.Hide();
        }
    }

   
}
