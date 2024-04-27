using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class mysql 
    {

        public static MySqlConnection con;
        public static MySqlCommand cmd;
        public static MySqlDataAdapter da;
        public static MySqlDataReader dr;
        public static DataTable dt;
        public static DataSet ds;  

        static string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public static DataTable GetData(string sql)
        {
            using(con = new MySqlConnection(connection))
            {
                dt = new DataTable();
                using (da = new MySqlDataAdapter(sql, connection))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public static DataSet DataSet(string sql, string tbl)
        {
            using (con = new MySqlConnection(connection))
            {
                ds = new DataSet();
                using (da = new MySqlDataAdapter(sql, connection))
                {
                    da.Fill(ds, tbl);
                }
            }
            return ds;
        }
    }
}
