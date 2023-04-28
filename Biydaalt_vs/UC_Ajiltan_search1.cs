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
    public partial class UC_Ajiltan_search1 : UserControl
    {
        public UC_Ajiltan_search1()
        {
            InitializeComponent();
        }

        public bool TopLevel { get; internal set; }

        private void btn_haih_ajilchin_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;Username=root;database=vs_bd;password=Doogii01";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connection;
            con.Open();
            string query = "select * from Employee where e_lname = @val1 or e_fname = @val2 or e_address = @val3 or e_phone = @val4";

            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@val1", txt_e_lname.Text);
            cmd.Parameters.AddWithValue("@val2", txt_e_fname.Text);
            cmd.Parameters.AddWithValue("@val3", txt_e_address.Text);
            cmd.Parameters.AddWithValue("@val4", txt_e_phone.Text);
            DataTable dt = new DataTable();
            MySqlDataAdapter Dta = new MySqlDataAdapter(cmd);
            Dta.Fill(dt);
            Admin ad = (Admin)Application.OpenForms["Admin"];
            ad.dataGridView2.DataSource = dt;
            con.Close();
        }

      

        private void btn_delete_ajiltan_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;Username=root;database=vs_bd;password=Doogii01";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            string query = "delete from Employee where e_lname = @val1 or e_fname = @val2 or e_address = @val3 or e_phone = @val4";

            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@val1", txt_e_lname.Text);
            cmd.Parameters.AddWithValue("@val2", txt_e_fname.Text);
            cmd.Parameters.AddWithValue("@val3", txt_e_address.Text);
            cmd.Parameters.AddWithValue("@val4", txt_e_phone.Text);
            DataTable dt = new DataTable();
            MySqlDataAdapter Dta = new MySqlDataAdapter(cmd);
            Dta.Fill(dt);
            Admin ad = (Admin)Application.OpenForms["Admin"];
            ad.dataGridView2.DataSource = dt;
            con.Close();
        }

        private void UC_Ajiltan_search1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;Username=root;database=vs_bd;password=Doogii01";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
           
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@val1", txt_e_lname.Text);
            cmd.Parameters.AddWithValue("@val2", txt_e_fname.Text);
            cmd.Parameters.AddWithValue("@val3", txt_e_address.Text);
            cmd.Parameters.AddWithValue("@val4", txt_e_phone.Text);
            cmd.Parameters.AddWithValue("@val5", textBox1.Text);
            DataTable dt = new DataTable();
            MySqlDataAdapter Dta = new MySqlDataAdapter(cmd);
            Dta.Fill(dt);
            Admin ad = (Admin)Application.OpenForms["Admin"];
            ad.dataGridView2.DataSource = dt;
            con.Close();
        }
    }
}
