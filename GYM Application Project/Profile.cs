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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        public void GenerateDynamicUSerControlMembers()
        {
            flowLayoutProfile.Controls.Clear();


            ClassBLL1 objbll = new ClassBLL1();
            DataTable dt = objbll.GetItems();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    profileuser[] listItems = new profileuser[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new profileuser();

                            MemoryStream ms = new MemoryStream((byte[])row["image"]);
                            listItems[i].Icon = new Bitmap(ms);

                            listItems[i].Name = row["name"].ToString();
                            listItems[i].Email = row["email"].ToString();
                            listItems[i].Age = row["age"].ToString();

                            flowLayoutProfile.Controls.Add(listItems[i]);

                        }
                    }

                }
            }

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            GenerateDynamicUSerControlMembers();
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
            this.Show();
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
