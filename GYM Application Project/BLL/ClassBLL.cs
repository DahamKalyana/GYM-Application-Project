﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Application_Project
{
    class ClassBLL1
    {
        #region Save Items
        public bool SaveItems(Image img, string name,  string email, string age, string experience, string rate)
        {
            try
            {
                ClassDAL objdal = new ClassDAL(); //data access layer class object to access functions
                return objdal.AddItemsToTable(img, name, email, age, experience, rate); // pass values to data access layer function
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
                ClassDAL objdal = new ClassDAL(); //data access layer class object to access functions
                return objdal.ReadItemsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        #endregion
    }
}
