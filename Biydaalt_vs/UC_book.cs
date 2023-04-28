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
    public partial class UC_book : UserControl
    {
        string connectionString = "server=localhost;Username=root;database=vs_bd;password = Doogii01";
        MySqlConnection con = new MySqlConnection();
        public UC_book()
        {
            InitializeComponent();
        }

        public bool TopLevel { get; internal set; }

        private void button1_Click(object sender, EventArgs e)
        {
            con.ConnectionString = connectionString;
            con.Open();
            string query = "INSERT INTO Book (b_huvilbar, b_name,b_huudas,b_niit_too,add_ID,print_ID) VALUES (@val1, @val2, @val3,@val4,@val5,@val6)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@val1", txt_b_huvilbar.Text);
            cmd.Parameters.AddWithValue("@val2", txt_b_name.Text);
            cmd.Parameters.AddWithValue("@val3", txt_b_huudas.Text);
            cmd.Parameters.AddWithValue("@val4", txt_b_niit_too.Text);
            cmd.Parameters.AddWithValue("@val5", txt_add_ID.Text);
            cmd.Parameters.AddWithValue("@val6", txt_print_ID.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Amjilttai burtgelee");

        }

        private void UC_book_Load(object sender, EventArgs e)
        {

        }
    }
}
