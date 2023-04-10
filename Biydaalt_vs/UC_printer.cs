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
    public partial class UC_printer : UserControl
    {
         string connectionString = "server=localhost;Username=root;database=vs_bd;password = Doogii01";
        MySqlConnection con = new MySqlConnection();
        MySqlDataAdapter Dta = new MySqlDataAdapter();

        public UC_printer()
        {
            InitializeComponent();
        }

        public bool TopLevel { get; internal set; }

        private void button1_Click(object sender, EventArgs e)
        {
            con.ConnectionString = connectionString;
            con.Open();
            string query = "INSERT INTO Printer (print_address,print_name) VALUES (@val1,@val2)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@val1", txt_print_address.Text);
            cmd.Parameters.AddWithValue("@val2", txt_print_name.Text);

            cmd.ExecuteNonQuery();
        }

        private void UC_printer_Load(object sender, EventArgs e)
        {

        }
    }
}
