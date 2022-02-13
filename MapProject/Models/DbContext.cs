using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MapProject.Models
{

    public class MssqlContext
    {

        public static string conn = "Server=localhost\\MSSQLSERVER01;Database=MapProject;Trusted_Connection=True;";



        public static DbConnection OpenConnection()
        {
            SqlConnection con = new SqlConnection(conn);
            return con;
        }
    }
    public class DbContext
    {
        public DbConnection GetConnection()
        {
            return MssqlContext.OpenConnection();
        }
    }
}
