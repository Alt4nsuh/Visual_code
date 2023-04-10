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
    public partial class UC_Ajilchin : UserControl
    {
        string connectionString = "server=localhost;Username=root;database=vs_bd;password = Doogii01";
        MySqlConnection con = new MySqlConnection();
        MySqlDataAdapter Dta = new MySqlDataAdapter();

        public bool TopLevel { get; internal set; }

        public UC_Ajilchin()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_burtgeh_ajilchin_Click(object sender, EventArgs e)
        {
            con.ConnectionString = connectionString;
            con.Open();
            string query = "INSERT INTO Employee (e_lname, e_fname,e_address,e_phone) VALUES (@val1, @val2, @val3,@val4)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@val1", txt_e_lname.Text);
            cmd.Parameters.AddWithValue("@val2", txt_e_fname.Text);
            cmd.Parameters.AddWithValue("@val3", txt_e_address.Text);
            cmd.Parameters.AddWithValue("@val4", txt_e_phone.Text);
            cmd.ExecuteNonQuery();
        }

        private void UC_Ajilchin_Load(object sender, EventArgs e)
        {

        }
    }
}
