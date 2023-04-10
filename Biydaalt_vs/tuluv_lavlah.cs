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
    public partial class tuluv_lavlah : UserControl
    {
        string connectionString = "server=localhost;Username=root;database=vs_bd;password = Doogii01";
        MySqlConnection con = new MySqlConnection();
        public tuluv_lavlah()
        {
            InitializeComponent();
        }

        public bool TopLevel { get; internal set; }

        private void button1_Click(object sender, EventArgs e)
        {
            con.ConnectionString = connectionString;
            con.Open();
            string query = "INSERT INTO tuluv_lavlah (t_name) VALUES (@val1)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@val1", txt_tl_name.Text);
            cmd.ExecuteNonQuery();
        }
    }
}
