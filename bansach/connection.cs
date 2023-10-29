using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace bansach
{
    internal class connection
    {
        private static string connectionString = @"Data Source=DESKTOP-7T8I7HD\SQLEXPRESS;Initial Catalog=bansach;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
