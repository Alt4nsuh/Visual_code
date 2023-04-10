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
    public partial class UC_nom_burtgel : UserControl
    {
        string connectionString = "server=localhost;Username=root;database=vs_bd;password = Doogii01";
        MySqlConnection con = new MySqlConnection();
        public UC_nom_burtgel()
        {
            InitializeComponent();
        }

        public bool TopLevel { get; internal set; }

        private void UC_nom_burtgel_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.ConnectionString = connectionString;
            con.Open();
            string query = "INSERT INTO BookReg (br_date,e_ID,b_ID) VALUES (@val1,@val2,@val3)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            DateTime aaa = date_br_date.Value;
            string date_e = aaa.ToString("yyyy-MM-dd");
            cmd.Parameters.AddWithValue("@val1", date_e);
            cmd.Parameters.AddWithValue("@val2", txt_e_ID.Text);
            cmd.Parameters.AddWithValue("@val3", txt_b_ID.Text);
            cmd.ExecuteNonQuery();
        }
    }
}
