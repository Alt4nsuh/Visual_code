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
    public partial class order : UserControl
    {
        string connectionString = "server=localhost;Username=root;database=vs_bd;password = Doogii01";
        MySqlConnection con = new MySqlConnection();
        MySqlDataAdapter Dta = new MySqlDataAdapter();

        public order()
        {
            InitializeComponent();
        }

        public bool TopLevel { get; internal set; }

        private void button1_Click(object sender, EventArgs e)
        {
            con.ConnectionString = connectionString;
            con.Open();
            string query = "INSERT INTO Orders (o_ehleh,o_duusah,br_ID,e_ID,cus_ID) VALUES (@val1, @val2, @val3,@val4,@val5)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            DateTime aaa = date_ehleh.Value;
            string date_e = aaa.ToString("yyyy-MM-dd");
            DateTime aa = date_duusah.Value;
            string date_d = aa.ToString("yyyy-MM-dd");
            cmd.Parameters.AddWithValue("@val1", date_e);
            cmd.Parameters.AddWithValue("@val2", date_d);
            cmd.Parameters.AddWithValue("@val3", txt_br_ID.Text);
            cmd.Parameters.AddWithValue("@val4", txt_e_ID.Text);
            cmd.Parameters.AddWithValue("@val5", txt_cus_ID.Text);
            cmd.ExecuteNonQuery();
        }

        private void order_Load(object sender, EventArgs e)
        {

        }
    }
}
