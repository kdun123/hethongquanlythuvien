using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace bansach
{
    internal class modify
    {
        public modify()
        {
        }

        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<taikhoan> Taikhoans(string query)
        { 
            List<taikhoan> Taikhoans = new List<taikhoan>();
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                    {
                        Taikhoans.Add(new taikhoan(dataReader.GetString(0), dataReader.GetString(1)));
                    }
                sqlConnection.Close();
            }
            return Taikhoans;
        }
    }
}
