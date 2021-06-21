using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace GYM_Application_Project.profileDAL
{
    class profileclassDAL
    {
        #region Add Items to Table
        public bool AddItemsToMemberTable(Image img, string memberID, string name, string address, string email, int age, int weight, int height, string activityLevel, string gender, string target)
        {

            profileconnections con = new profileconnections(); // connection class created in Data Access Layer (DAL)
            if (ConnectionState.Closed == con.connect.State) //check if connection state is closed.
            {
                con.connect.Open(); //open connection.
            }



            //parametrized query to insert title, subtitle and image in table -> (Table_Items)
            string query = "INSERT INTO Members(member_id,name,address,email,age,weight,height,A_level,gender,target,image)VALUES(@member_id,@name,@address,@email,@age,@weight,@height,@A_level,@gender,@target,@image)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@member_id", memberID.Trim());
                    cmd.Parameters.AddWithValue("@name", name.Trim()); // set title to parameter.
                    cmd.Parameters.AddWithValue("@address", address.Trim());
                    cmd.Parameters.AddWithValue("@email", email.Trim());
                    // set sub-title to parameter.
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    cmd.Parameters.AddWithValue("@height", height);
                    cmd.Parameters.AddWithValue("@A_level", activityLevel.Trim());
                    cmd.Parameters.AddWithValue("@gender", gender.Trim());
                    cmd.Parameters.AddWithValue("@target", target.Trim());




                    //converting image to binary format to store in sql database.
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    cmd.Parameters.AddWithValue("@image", ms.ToArray()); //set binary formatted image to parameter.

                    cmd.ExecuteNonQuery(); //save to table
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Read Items Table
        public DataTable ReadItemsTable()
        {
            profileconnections con = new profileconnections();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            //query to select all records from table -> (Table_Items)
            string query = "SELECT * FROM Members";
            SqlCommand cmd = new SqlCommand(query, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt); //save all records coming from database in data table. 
                    return dt; // return data table.
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion


        //Update table data
        public bool UpdateMemberTable(Image img, string memberID, string name, string address, string email, int age, int weight, int height, string activityLevel, string gender, string target)
        {

            profileconnections con = new profileconnections(); // connection class created in Data Access Layer (DAL)
            if (ConnectionState.Closed == con.connect.State) //check if connection state is closed.
            {
                con.connect.Open(); //open connection.
            }


            //parametrized query to insert title, subtitle and image in table -> (Table_Items)
            string query = "UPDATE Members SET name=@name, address=@address, email=@email, age=@age, weight=@weight, height=@height, A_level=@A_level, gender=@gender, target=@target, image=@image WHERE member_id=@member_id";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@member_id", memberID.Trim());
                    cmd.Parameters.AddWithValue("@name", name.Trim()); // set title to parameter.
                    cmd.Parameters.AddWithValue("@address", address.Trim());
                    cmd.Parameters.AddWithValue("@email", email.Trim());
                    // set sub-title to parameter.
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    cmd.Parameters.AddWithValue("@height", height);
                    cmd.Parameters.AddWithValue("@A_level", activityLevel.Trim());
                    cmd.Parameters.AddWithValue("@gender", gender.Trim());
                    cmd.Parameters.AddWithValue("@target", target.Trim());


                    //converting image to binary format to store in sql database.
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    cmd.Parameters.AddWithValue("@Image", ms.ToArray()); //set binary formatted image to parameter.

                    cmd.ExecuteNonQuery(); //save to table
                }
                return true;
            }
            catch
            {
                throw;
            }


        }




        //Deleta data from table

        public bool DeleteMemberTableData(int memberID)
        {

            profileconnections con = new profileconnections(); // connection class created in Data Access Layer (DAL)
            if (ConnectionState.Closed == con.connect.State) //check if connection state is closed.
            {
                con.connect.Open(); //open connection.
            }



            //parametrized query to insert title, subtitle and image in table -> (Table_Items)
            string query = "DELETE FROM Members WHERE member_id=@member_id";

            try
            {

                SqlCommand cmd = new SqlCommand(query, con.connect);
                cmd.Parameters.AddWithValue("@member_id", memberID);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                throw;
            }

            finally
            {
                con.connect.Close();
            }



        }
    }
}
