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
    public partial class UC_tuluv : UserControl
    {
        string connectionString = "server=localhost;Username=root;database=vs_bd;password = Doogii01";
        MySqlConnection con = new MySqlConnection();
        public UC_tuluv()
        {
            InitializeComponent();
        }

        public bool TopLevel { get; internal set; }

        private void button1_Click(object sender, EventArgs e)
        {
            con.ConnectionString = connectionString;
            con.Open();
            string query = "INSERT INTO tuluv (tl_ID,t_ornoo,t_prise,t_size,t_sumprise,o_ID) VALUES (@val1, @val2, @val3,@val4,@val5,@val6)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            DateTime aaa = date_t_ognoo.Value;
            string date_d = aaa.ToString("yyyy-MM-dd");
            cmd.Parameters.AddWithValue("@val1", txt_tl_id.Text );
            cmd.Parameters.AddWithValue("@val2", date_d);
            cmd.Parameters.AddWithValue("@val3", txt_t_une.Text);
            cmd.Parameters.AddWithValue("@val4", txt_t_size.Text);
            cmd.Parameters.AddWithValue("@val5", txt_t_sumprise.Text);
            cmd.Parameters.AddWithValue("@val6", txt_o_ID.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Amjilttai burtgelee");

        }

        private void UC_tuluv_Load(object sender, EventArgs e)
        {

        }
    }
}
