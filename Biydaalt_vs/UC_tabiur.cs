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
  
    public partial class UC_tabiur : UserControl
    {
        string connectionString = "server=localhost;Username=root;database=vs_bd;password = Doogii01";
        MySqlConnection con = new MySqlConnection();
        MySqlDataAdapter Dta = new MySqlDataAdapter();

        public UC_tabiur()
        {
            InitializeComponent();
        }

        public bool TopLevel { get; internal set; }

        private void btn_tabiur_Click(object sender, EventArgs e)
        {
            con.ConnectionString = connectionString;
            con.Open();
            string query = "INSERT INTO BookAdd (add_name) VALUES (@val1)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@val1", txt_add_name.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Amjilttai burtgelee");

        }

        private void UC_tabiur_Load(object sender, EventArgs e)
        {

        }

        private void txt_add_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void alla_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
