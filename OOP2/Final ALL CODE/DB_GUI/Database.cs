using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_GUI
{
    class Database
    {
        public static SqlConnection ConnectDB()
        {
            string connString = @"Server =LAPTOP-D1FAH94M\SQLEXPRESS; Database =demo; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
