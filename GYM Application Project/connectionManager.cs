using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace GYM_Application_Project
{
    public class connectionManager
    {
        public static SqlConnection newconnection;
        public static string Constr = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

        public static SqlConnection GetConnection() {
            newconnection = new SqlConnection(Constr);
            return newconnection;
        }
    }
}
