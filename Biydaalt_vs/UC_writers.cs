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
    public partial class UC_writers : UserControl
    {
        string connectionString = "server=localhost;Username=root;database=vs_bd;password = Doogii01";
        MySqlConnection con = new MySqlConnection();

        public UC_writers()
        {
            InitializeComponent();
        }

        public bool TopLevel { get; internal set; }

        private void button1_Click(object sender, EventArgs e)
        {
            con.ConnectionString = connectionString;
            con.Open();
            string query = "INSERT INTO Writers (ba_name, b_ID) VALUES (@val1, @val2)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@val1", txt_w_ID.Text);
            cmd.Parameters.AddWithValue("@val2", txt_b_ID.Text);
            cmd.ExecuteNonQuery();
        }

        
    }
}
