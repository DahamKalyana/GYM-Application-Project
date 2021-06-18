using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;

namespace GYM_Application_Project
{
    class ClassDAL
    {
        #region Add Items to Table
        public bool AddItemsToTable(Image img, string name, string email, string age, string experience, string rate)
        {
            
            Connection con = new Connection(); // connection class created in Data Access Layer (DAL)
            if (ConnectionState.Closed == con.connect.State) //check if connection state is closed.
            {
                con.connect.Open(); //open connection.
            }

            

            //parametrized query to insert title, subtitle and image in table -> (Table_Items)
            string query = "Insert into CODEX_Trainers(Name,Email,Age,Experience,Rate,Image)values(@Name,@Email,@Age,@Experience,@Rate,@Image)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Name", name.Trim()); // set title to parameter.
                    cmd.Parameters.AddWithValue("@Email", email.Trim());
                    // set sub-title to parameter.
                    cmd.Parameters.AddWithValue("@Age", age.Trim());
                    cmd.Parameters.AddWithValue("@Experience", experience.Trim());
                    cmd.Parameters.AddWithValue("@Rate", rate.Trim());
                    
                    

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
        #endregion

        #region Read Items Table
        public DataTable ReadItemsTable()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            //query to select all records from table -> (Table_Items)
            string query = "SELECT * FROM CODEX_Trainers";
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
    }
}
