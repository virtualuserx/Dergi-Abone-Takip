using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abone_takip2.dao
{
   public static class connection
    {
        public static SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-V4K0APP\\SQLEXPRESS;Initial Catalog=abone_takip;Integrated Security=True");

        public static void open()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();
        }

        public static void close()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open) sqlConnection.Close();
        }
    }
}
