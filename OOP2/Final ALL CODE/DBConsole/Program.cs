using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace DBConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = @"Server =LAPTOP-D1FAH94M\SQLEXPRESS; Database =demo; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = "insert into users values ('Honey Singh','4555','User')";
            SqlCommand cmd = new SqlCommand(query,conn);
            int row_affected = cmd.ExecuteNonQuery();

            if(row_affected > 0)
            {
                Console.WriteLine("Successfully Added");
            }
            else { Console.WriteLine("Not Added"); }
            conn.Close();
            conn.Open();

            query = "select * from users"; //string
            cmd = new SqlCommand(query, conn); // SqlCommand
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("ID\t\tName\t\t\tType");
            while(reader.Read())
            {
                long id = reader.GetInt64(reader.GetOrdinal("id"));
                string uname = reader.GetString(1); 
                string type = reader.GetString(reader.GetOrdinal("type"));
                Console.WriteLine("{0}\t\t{1}\t{2}",id,uname,type);
            }
            conn.Close();
        }
    }
}
