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

                                    con.Close();

        }
        public void AjiltanHaih(string a, string b, string c, string d)
        {
            string connectionString = "server=localhost;Username=root;database=vs_bd;password=Doogii01";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            string query = "select * from Employee where e_lname = @val1 or e_fname = @val2 or e_address = @val3 or e_phone = @val4";

            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@val1", a);
            cmd.Parameters.AddWithValue("@val2", b);
            cmd.Parameters.AddWithValue("@val3", c);
            cmd.Parameters.AddWithValue("@val4", d);
            DataTable dt = new DataTable();
            Dta = new MySqlDataAdapter(cmd);
            Dta.Fill(dt);
            Admin ad = new Admin();
            ad.dataGridView2.DataSource = dt;
        }


    }
}
