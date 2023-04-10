using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Biydaalt_vs
{
    class Database
    {



        MySqlDataAdapter Dta = new MySqlDataAdapter();


        Admin ad = new Admin();
        public DataTable ViewTable(string a)
        {
            string connectionString = "server=localhost;Username=root;database=vs_bd;password = Doogii01";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            Dta = new MySqlDataAdapter(@"select*from " + a + "; ", con);
            DataTable dt = new DataTable();
            Dta.Fill(dt);

            return dt;
        }
     
    }
}
