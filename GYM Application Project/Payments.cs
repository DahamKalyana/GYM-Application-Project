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


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\paymentsDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataReader rd;
        

        private void Payments_Load(object sender, EventArgs e)
        {
            hide_cb();
        }

        private void PaymentsPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Payments_Shown(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void txtmemberid_TextChanged(object sender, EventArgs e)
        {

            string qry = "select name,email,January,February,March,April,May,June,July,August,September,October,November,December from Payments where member_id = '"+txtmemberid.Text+"'";

            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                open_connection();
                cmd.ExecuteNonQuery();

                rd = cmd.ExecuteReader();
                

                if (rd.Read())
                {
                    string name;
                    string email;
                    string january;
                    string february;
                    string march;
                    string april;
                    string may;
                    string june;
                    string july;
                    string august;
                    string september;
                    string october;
                    string november;
                    string december;

                    name = rd["name"].ToString();
                    email = rd["email"].ToString();
                    january = rd["January"].ToString();
                    february = rd["February"].ToString();
                    march = rd["March"].ToString();
                    april = rd["April"].ToString();
                    may = rd["May"].ToString();
                    june = rd["June"].ToString();
                    july = rd["July"].ToString();
                    august = rd["August"].ToString();
                    september = rd["September"].ToString();
                    october = rd["October"].ToString();
                    november = rd["November"].ToString();
                    december = rd["December"].ToString();

                    lblname.Text = name;
                    lblemail.Text = email;

                    unhide_cb();
                    if (january == "0")
                    {
                        cb_january.Checked = false;
                    }
                    else
                    {
                        cb_january.Checked = true;
                    }

                    if (february == "0")
                    {
                        cb_february.Checked = false;
                    }
                    else
                    {
                        cb_february.Checked = true;
                    }

                    if (march == "0")
                    {
                        cb_march.Checked = false;
                    }
                    else
                    {
                        cb_march.Checked = true;
                    }

                    if (april == "0")
                    {
                        cb_april.Checked = false;
                    }
                    else
                    {
                        cb_april.Checked = true;
                    }

                    if (may == "0")
                    {
                        cb_may.Checked = false;
                    }
                    else
                    {
                        cb_may.Checked = true;
                    }

                    if (june == "0")
                    {
                        cb_june.Checked = false;
                    }
                    else
                    {
                        cb_june.Checked = true;
                    }

                    if (july == "0")
                    {
                        cb_july.Checked = false;
                    }
                    else
                    {
                        cb_july.Checked = true;
                    }

                    if (august == "0")
                    {
                        cb_august.Checked = false;
                    }
                    else
                    {
                        cb_august.Checked = true;
                    }

                    if (september == "0")
                    {
                        cb_september.Checked = false;
                    }
                    else
                    {
                        cb_september.Checked = true;
                    }

                    if (october == "0")
                    {
                        cb_october.Checked = false;
                    }
                    else
                    {
                        cb_october.Checked = true;
                    }

                    if (november == "0")
                    {
                        cb_november.Checked = false;
                    }
                    else
                    {
                        cb_november.Checked = true;
                    }

                    if (december == "0")
                    {
                        cb_december.Checked = false;
                    }
                    else
                    {
                        cb_december.Checked = true;
                    }
                    
                }

            }
            catch (Exception se)
            {
                MessageBox.Show("error!" + se);


            }
            finally
            {
                close_connection();
            }

        }
        private void open_connection()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        private void close_connection()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {           
            clear();
        }
        private void clear()
        {
            hide_cb();
            txtmemberid.Clear();
            lblname.Text = "Member_Name";
            lblemail.Text = "Member Email";
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            string jan, feb, mar,apr,may,jun,jul,aug,sept,oct,nov,dec;
            if(cb_january.Checked == true)
            {
                jan = "1";
            }
            else
            {
                jan = "0";
            }
            if (cb_february.Checked == true)
            {
                feb = "1";
            }
            else
            {
                feb = "0";
            }
            if (cb_march.Checked == true)
            {
                mar = "1";
            }
            else
            {
                mar = "0";
            }
            if (cb_april.Checked == true)
            {
                apr = "1";
            }
            else
            {
                apr = "0";
            }
            if (cb_may.Checked == true)
            {
                may = "1";
            }
            else
            {
                may = "0";
            }
            if (cb_june.Checked == true)
            {
                jun = "1";
            }
            else
            {
                jun = "0";
            }
            if (cb_july.Checked == true)
            {
                jul = "1";
            }
            else
            {
                jul = "0";
            }
            if (cb_august.Checked == true)
            {
                aug = "1";
            }
            else
            {
                aug = "0";
            }
            if (cb_september.Checked == true)
            {
                sept = "1";
            }
            else
            {
                sept = "0";
            }
            if (cb_october.Checked == true)
            {
                oct = "1";
            }
            else
            {
                oct = "0";
            }
            if (cb_november.Checked == true)
            {
                nov = "1";
            }
            else
            {
                nov = "0";
            }
            if (cb_december.Checked == true)
            {
                dec = "1";
            }
            else
            {
                dec = "0";
            }
            //sdcsa

            open_connection();
            string query = "update Payments set january = '"+jan+ "',february = '" + feb + "' ,march = '" + mar + "' ,april = '" + apr + "' ,may = '" + may + "' ,june = '" + jun + "' ,july = '" + jul + "' ,august = '" + aug + "' ,september = '" + sept + "' ,october = '" + oct + "' ,november = '" + nov + "' ,december = '" + dec + "' where member_id = '" + txtmemberid.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            int result = cmd.ExecuteNonQuery();
            if (result != 0)
            {
                MessageBox.Show("Payment Succesful..!!", "Pyment", MessageBoxButtons.OK);
                clear();
            }
            else
            {
                MessageBox.Show("Payment Unsuccesful...!", "Error", MessageBoxButtons.OK);
            }
        }

        private void hide_cb()
        {
            cb_january.Visible = false;
            cb_february.Visible = false;
            cb_march.Visible = false;
            cb_april.Visible = false;
            cb_may.Visible = false;
            cb_june.Visible = false;
            cb_july.Visible = false;
            cb_august.Visible = false;
            cb_september.Visible = false;
            cb_october.Visible = false;
            cb_november.Visible = false;
            cb_december.Visible = false;
        }
            private void unhide_cb()//hide and refresh
            {
                
            cb_january.Visible = true;
            cb_february.Visible = true;
            cb_march.Visible = true;
            cb_april.Visible = true;
            cb_may.Visible = true;
            cb_june.Visible = true;
            cb_july.Visible = true;
            cb_august.Visible = true;
            cb_september.Visible = true;
            cb_october.Visible = true;
            cb_november.Visible = true;
            cb_december.Visible = true;


        }

            private void cb_january_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
