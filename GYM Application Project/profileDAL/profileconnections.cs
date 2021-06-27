using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_Application_Project.profileDAL
{
    class profileconnections
    {
        public SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DB_Items.mdf;Integrated Security=True;Connect Timeout=30");
    }
}
