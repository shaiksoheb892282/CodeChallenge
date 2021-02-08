using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace MetalappsAutomation
{
    public class DBHandler  //DO NOT change the class name
    {
        //Implement the methods as per the description

        public SqlConnection GetConnection()
        {
            string con = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(con);

            return sqlConnection;
        }
    }
}
