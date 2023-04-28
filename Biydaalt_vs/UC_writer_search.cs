using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biydaalt_vs
{
    public partial class UC_writer_search : UserControl
    {
        public UC_writer_search()
        {
            InitializeComponent();
        }

        private void btn_haih_ajilchin_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;Username=root;database=vs_bd;password = Doogii01";
            MySqlConnection con = new MySqlConnection();

            con.ConnectionString = connectionString;
            con.Open();
            string query = "Select * from Writer where w_name = @val1";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@val1", txt_w_name.Text);
            cmd.ExecuteNonQuery();
           
        }

        private void btn_delete_ajiltan_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;Username=root;database=vs_bd;password = Doogii01";
            MySqlConnection con = new MySqlConnection();

            con.ConnectionString = connectionString;
            con.Open();
            string query = "delete from Writer where w_name = @val1";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@val1", txt_w_name.Text);
            cmd.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
