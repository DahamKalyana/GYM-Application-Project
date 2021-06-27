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
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GYM_Application_Project
{
    public partial class Newmember : Form
    {
        SqlConnection con;

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

            if (objbll.SaveItems(pb_image.Image, txt_memid.Text, txt_name.Text, txt_address.Text, txt_email.Text, int.Parse(txt_age.Text), int.Parse(txt_weight.Text), int.Parse(txt_height.Text), cb_Alevel.Text, cb_gender.Text, cb_target.Text))
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
            //OpenFileDialog opendlg = new OpenFileDialog();
            //if (opendlg.ShowDialog() == DialogResult.OK)
            //{
                //Image image = Image.FromFile(opendlg.FileName);
                //pb_image.Image = image;
            //}
        }

        private void btn_next_Click(object sender, EventArgs e)
        {


           //validation section 
            if (isValid())
            {
          
                    // string sql_query = "INSERT INTO Table(id,member_id,name,address,email,age,weight,height,a_level,gender,target) VALUES ('" + txt_memid .Text+ "''" + txt_name.Text + "','" + txt_address.Text + "','" + txt_email.Text + "','" + txt_age.Text + "','" + txt_weight.Text + "','" + txt_height.Text + "','" + cb_Alevel.Text + "','" + cb_gender.Text + "','" + cb_target.Text + "',) ";

                   //connecting to the database and open the connection 
                try
                {
                    con = connectionManager.GetConnection();
                    con.Open();
                    //SqlCommand sql_com = new SqlCommand(sql_query, con);
                    //sql_com.ExecuteNonQuery();
                    //MessageBox.Show(con.State.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                if (cb_gender.Text == "Male")
                {
                    men_bmr();
                    daily_cal();

                }
                else if (cb_gender.Text == "Female") {
                    female_bmr();
                    daily_cal();
                }
                //MessageBox.Show("submit");
                //PDF section 
                Document pdfdoc = new Document(PageSize.A4, 20f, 20f, 30f, 30f);
                PdfWriter pdfwrite = PdfWriter.GetInstance(pdfdoc, new FileStream("D:\\gym.pdf", FileMode.Create));
                pdfdoc.Open();
                    //Adding a CODEX logo 
                System.Drawing.Image codex_logo = System.Drawing.Image.FromFile("C:\\Users\\mihin\\Desktop\\New folder\\codex.jpeg");
                System.Drawing.Image header_1 = System.Drawing.Image.FromFile("C:\\Users\\mihin\\Desktop\\New folder\\header1.jpg");
                iTextSharp.text.Image iTextImage = iTextSharp.text.Image.GetInstance(codex_logo, System.Drawing.Imaging.ImageFormat.Jpeg);
                iTextSharp.text.Image header_image = iTextSharp.text.Image.GetInstance(header_1, System.Drawing.Imaging.ImageFormat.Jpeg);
                iTextImage.Alignment = Element.ALIGN_CENTER;
                header_image.Alignment = Element.ALIGN_CENTER;
                /*iTextImage.BackgroundColor = new BaseColor(255, 255, 255);*/
                iTextImage.ScaleAbsolute(120f, 55.25f);
                header_image.ScaleAbsolute(140f, 65.25f);
                pdfdoc.Add(iTextImage);
                pdfdoc.Add(header_image);
                // adding a paragraph 

                        System.Drawing.Image personal_in = System.Drawing.Image.FromFile("C:\\Users\\mihin\\Desktop\\New folder\\personal.jpg");
                        iTextSharp.text.Image personal_image = iTextSharp.text.Image.GetInstance(personal_in, System.Drawing.Imaging.ImageFormat.Jpeg);
                        personal_image.Alignment = Element.ALIGN_CENTER;
                        personal_image.ScaleAbsolute(180f, 30.25f);
                        pdfdoc.Add(personal_image);
                            Paragraph p_name = new Paragraph("Name : " + txt_name.Text);
                            Paragraph p_address = new Paragraph("Address: "+txt_address.Text);
                            Paragraph p_email= new Paragraph("E-mail : "+txt_email.Text);
                            Paragraph p_age = new Paragraph("Age : "+txt_age.Text);
                            Paragraph p_gender = new Paragraph(cb_gender.Text+ "\n\n");
                                p_name.Alignment = Element.ALIGN_CENTER;
                                p_address.Alignment = Element.ALIGN_CENTER;
                                p_email.Alignment = Element.ALIGN_CENTER;
                                p_age.Alignment = Element.ALIGN_CENTER;
                                p_gender.Alignment = Element.ALIGN_CENTER;
                                    pdfdoc.Add(p_name);
                                    pdfdoc.Add(p_address);
                                    pdfdoc.Add(p_email);
                                    pdfdoc.Add(p_age);
                                    pdfdoc.Add(p_gender);
                                        System.Drawing.Image physical = System.Drawing.Image.FromFile("C:\\Users\\mihin\\Desktop\\New folder\\phy.jpg");
                                        iTextSharp.text.Image physical_image = iTextSharp.text.Image.GetInstance(physical, System.Drawing.Imaging.ImageFormat.Jpeg);
                                        physical_image.Alignment = Element.ALIGN_CENTER;
                                        physical_image.ScaleAbsolute(180f, 30.25f);
                                        pdfdoc.Add(physical_image);
                                            Paragraph p_weight = new Paragraph("Weight : "+txt_weight.Text+"lbs");
                                            Paragraph p_height = new Paragraph("Height : "+txt_height.Text+"inches");
                                            Paragraph p_avtivity = new Paragraph("Activity Level : "+cb_Alevel.Text);
                                            Paragraph p_target = new Paragraph("Your Goal : "+ cb_target.Text);
                                            Paragraph p_bmr = new Paragraph("BMR :"+ bmr_static+"Cal");
                                            Paragraph p_daily_cal = new Paragraph("Daily Calories : "+ daily_calorie_out+"Cal"+"\n\n");
                                                p_weight.Alignment = Element.ALIGN_CENTER;
                                                p_height.Alignment = Element.ALIGN_CENTER;
                                                p_avtivity.Alignment = Element.ALIGN_CENTER;
                                                p_target.Alignment = Element.ALIGN_CENTER;
                                                p_bmr.Alignment = Element.ALIGN_CENTER;
                                                p_daily_cal.Alignment = Element.ALIGN_CENTER;
                                                    //pdfdoc.Add(pgraph_6);
                                                    pdfdoc.Add(p_weight);
                                                    pdfdoc.Add(p_height);
                                                    pdfdoc.Add(p_avtivity);
                                                    pdfdoc.Add(p_target);
                                                    pdfdoc.Add(p_bmr);
                                                    pdfdoc.Add(p_daily_cal);
                                                System.Drawing.Image workout = System.Drawing.Image.FromFile("C:\\Users\\mihin\\Desktop\\New folder\\workout.jpg");
                                                iTextSharp.text.Image workout_image = iTextSharp.text.Image.GetInstance(workout, System.Drawing.Imaging.ImageFormat.Jpeg);
                                                workout_image.Alignment = Element.ALIGN_CENTER;
                                                workout_image.ScaleAbsolute(180f, 30.25f);
                                                pdfdoc.Add(workout_image);


                                                    //adding tables 

                                                    //adding a Workout routine table 
                                                    PdfPTable table = new PdfPTable(3);
                                                    table.AddCell("EXERSISE NAME");
                                                    table.AddCell("Sets");
                                                    table.AddCell("Reps");

                                                    table.AddCell("barbell bench Press");
                                                    table.AddCell("4");
                                                    table.AddCell("12");

                                                    table.AddCell("Barbell Inclined bench Press");
                                                    table.AddCell("4");
                                                    table.AddCell("12");

                                                    table.AddCell("Dumbell Flies");
                                                    table.AddCell("4");
                                                    table.AddCell("12");

                                                    table.AddCell("Cable Flies");
                                                    table.AddCell("4");
                                                    table.AddCell("12");

                                                    table.AddCell("Dumbell Flies");
                                                    table.AddCell("4");
                                                    table.AddCell("12");

                                                    table.AddCell("Preacher Curl");
                                                    table.AddCell("4");
                                                    table.AddCell("12");

                                                    table.AddCell("Hammer Cur");
                                                    table.AddCell("4");
                                                    table.AddCell("10");

                                                    table.AddCell("Leg Extention");
                                                    table.AddCell("4");
                                                    table.AddCell("10");

                                                    table.AddCell("Leg Curl");
                                                    table.AddCell("4");
                                                    table.AddCell("10");

                                                    table.AddCell("Leg Curl");
                                                    table.AddCell("4");
                                                    table.AddCell("10");

                                                    table.AddCell("Barbell Squats");
                                                    table.AddCell("4");
                                                    table.AddCell("10");

                                                    table.HorizontalAlignment = Element.ALIGN_CENTER;
                                                    pdfdoc.Add(table);
                                                                            //
                                                        Paragraph spacer = new Paragraph("\n\n\n\n\n\n");
                                                        pdfdoc.Add(spacer);
                                                        //adding Meal Plan Table 
                                                        System.Drawing.Image meal = System.Drawing.Image.FromFile("C:\\Users\\mihin\\Desktop\\New folder\\Meal.jpg");
                                                        iTextSharp.text.Image meal_image = iTextSharp.text.Image.GetInstance(meal, System.Drawing.Imaging.ImageFormat.Jpeg);
                                                        meal_image.Alignment = Element.ALIGN_CENTER;
                                                        meal_image.ScaleAbsolute(180f, 30.25f);
                                                        pdfdoc.Add(meal_image);
                
                           
                                                                    PdfPTable table_2 = new PdfPTable(4);
                                                                    table_2.AddCell("");
                                                                    table_2.AddCell("Breakfast");
                                                                    table_2.AddCell("Lunch");
                                                                    table_2.AddCell("Dinner");

                                                                    table_2.AddCell("Monday");
                                                                    table_2.AddCell("3 Full eggs [Boiled or Fried with 1 teaspoon Virgin Coconut Oil]");
                                                                    table_2.AddCell("200g Cooked Basmathi Rice / Red Rice");
                                                                    table_2.AddCell("2 Brown bread toats");

                                                                    table_2.AddCell("Tuesday");
                                                                    table_2.AddCell("Black Cofee or Non Fact yoghurt");
                                                                    table_2.AddCell("1 Apple Watermellon 200g / Papaya 100g and 1 medium size Banana");
                                                                    table_2.AddCell("3 Full eggs (omelette or Boild)");

                                                                    table_2.AddCell("Wedenesday");
                                                                    table_2.AddCell("200ml non-fact Milk");
                                                                    table_2.AddCell("Calorie Green Veggies (choose 2-3 Veggies)");
                                                                    table_2.AddCell("Boild Veggies 150g ");

                                                                    table_2.AddCell("Thursday");
                                                                    table_2.AddCell("2 Bread Toast");
                                                                    table_2.AddCell("200g Cooked Basmathi Rice / Red Rice");
                                                                    table_2.AddCell("Green Tea ");

                                                                    table_2.AddCell("Friday");
                                                                    table_2.AddCell("3 Full eggs [Boiled or Fried with 1 teaspoon Virgin Coconut Oil]");
                                                                    table_2.AddCell("1 Apple Watermellon 200g / Papaya 100g and 1 medium size Banana");
                                                                    table_2.AddCell("Green Tea");

                                                                    table_2.AddCell("Saturday");
                                                                    table_2.AddCell("Black Cofee or Non Fact yoghurt");
                                                                    table_2.AddCell("Calorie Green Veggies (choose 2-3 Veggies)");
                                                                    table_2.AddCell("3 Full eggs (omelette or Boild)");

                                                                    table_2.AddCell("Sunday");
                                                                    table_2.AddCell("3 Full eggs [Boiled or Fried with 1 teaspoon Virgin Coconut Oil]");
                                                                    table_2.AddCell("200g Cooked Basmathi Rice / Red Rice");
                                                                    table_2.AddCell("2 Brown bread toats");


                                                                    table_2.HorizontalAlignment = Element.ALIGN_CENTER;
                                                                    pdfdoc.Add(table_2);
                                                        pdfdoc.Close();
                                                        //End of the PDF Section 
                                                    }
            
        }
       
        // submit button form validation section 

        private bool isValid() {
            if (txt_memid.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter your member id", "ERROR",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_name.Text.TrimStart() == string.Empty) {
                MessageBox.Show("Enter your name ", "ERRO",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_address.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter your address ", "ERROR",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_email.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter your email  ", "ERROR",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_age.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter your age ", "ERROR",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_weight.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter your weight ", "ERROR",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_height.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter your height ", "ERROR",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (cb_Alevel.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter your Avtivity level ", "ERROR",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cb_gender.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter your gender ", "ERROR",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cb_target.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter your tartget ", "ERROR",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        // .. End of the validation section 
        //bmr section
        //bmr_male
        public static string bmr_static  ;
                public void men_bmr(){
                    int age = int.Parse(txt_age.Text);
                    double weight = double.Parse(txt_weight.Text);
                    double height = double.Parse(txt_height.Text);
                    double men_bmr = weight * 6.23 + height * 12.7 - age * 6.8 + 66;
                    string men_bmr_out = men_bmr.ToString();
                    bmr_static = men_bmr_out; 
                    MessageBox.Show(men_bmr_out, "BMR");
                }
                //bmr_female
                    public void female_bmr() {
                    int age = int.Parse(txt_age.Text);
                    double weight = double.Parse(txt_weight.Text);
                    double height = double.Parse(txt_height.Text);
                    double we_bmr = weight * 4.23 + height * 4.7 - age * 4.8 + 65.5;
                    string we_bmr_out = we_bmr.ToString();
                    bmr_static = we_bmr_out;
                    MessageBox.Show(we_bmr_out, "BMR");
        }

        // ..end of the bmr section 
        //Daily calories 
        public static string daily_calorie_out;
        public void daily_cal() {

            if (cb_Alevel.Text == "sedentary")
            {
                double daily_calories = double.Parse(bmr_static) * 1.2;
                MessageBox.Show(daily_calories.ToString() , "Daily Calories");
                daily_calorie_out = daily_calories.ToString();
            }
            else if (cb_Alevel.Text == "Light")
            {
                double daily_calories = double.Parse(bmr_static) * 1.375;
                MessageBox.Show(daily_calories.ToString(), "Daily Calories");
                daily_calorie_out = daily_calories.ToString();
            }
            else if (cb_Alevel.Text == "Moderate") {
                double daily_calories = double.Parse(bmr_static) * 1.55;
                MessageBox.Show(daily_calories.ToString(), "Daily Calories" );
                daily_calorie_out = daily_calories.ToString();
            }
            else if (cb_Alevel.Text == "Active")
            {
                double daily_calories = double.Parse(bmr_static) * 1.725;
                MessageBox.Show(daily_calories.ToString(), "Daily Calories");
                daily_calorie_out = daily_calories.ToString();
            }

        }
        //end of the daily calories 
        // target 
        public static string target_message;
        public void cli_target() {
            string your_target = cb_target.Text;
            if (your_target == "Fat Lost")
            {
                target_message = "Take 250 - 500 Cal more than the daily calorie Limit";
            }
            else if (your_target == "gain Weight") {
                target_message = "Take 250-500 Cal less than the daily Calorie Limit";
            }
        }
        // end of the target

        private void NewmemberPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txt_height_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
