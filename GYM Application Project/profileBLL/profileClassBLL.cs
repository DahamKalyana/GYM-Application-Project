using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Application_Project.profileBLL
{
    class profileClassBLL
    {
        #region Save Items
        public bool SaveItems(Image img, string memberID, string name, string address, string email, int age, int weight, int height, string activityLevel, string gender, string target)
        {
            try
            {
                profileDAL.profileclassDAL objdal = new profileDAL.profileclassDAL(); //data access layer class object to access functions
                return objdal.AddItemsToMemberTable(img, memberID, name, address, email, age, weight, height, activityLevel, gender, target); // pass values to data access layer function
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }

        }
        #endregion

        #region Get Items
        public DataTable GetItems()
        {
            try
            {
                profileDAL.profileclassDAL objdal = new profileDAL.profileclassDAL(); ; //data access layer class object to access functions
                return objdal.ReadItemsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        #endregion


        public bool UpdateItems(Image img, string memberID, string name, string address, string email, int age, int weight, int height, string activityLevel, string gender, string target)
        {
            try
            {
                profileDAL.profileclassDAL objdal = new profileDAL.profileclassDAL(); //data access layer class object to access functions
                return objdal.UpdateMemberTable(img, memberID, name, address, email, age, weight, height, activityLevel, gender, target); // pass values to data access layer function
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }

        }


        //Delete data
        public bool DeleteItems(int memberID)
        {
            try
            {
                profileDAL.profileclassDAL objdal = new profileDAL.profileclassDAL(); //data access layer class object to access functions
                return objdal.DeleteMemberTableData(memberID); // pass values to data access layer function
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }

        }
    }
}
