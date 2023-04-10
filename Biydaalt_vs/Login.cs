using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biydaalt_vs
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Home hm = new Home();
            hm.Hide();
        }

        private void lbl_burtguuleh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign sg = new Sign();
            sg.Show();
            this.Hide();
        }


        string connectionString = "server=localhost;Username=root;database=vs_bd;password = Doogii01";
        MySqlConnection con = new MySqlConnection();
        MySqlDataAdapter Dta = new MySqlDataAdapter();

        private void btn_login_Click(object sender, EventArgs e)
        {
            con.ConnectionString = connectionString;
            con.Open();
            string query = "SELECT COUNT(*) FROM Customer WHERE cus_gmail = @username AND cus_pass = @password";
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@username", txt_gmail_login.Text);
            command.Parameters.AddWithValue("@password", txt_pass_login.Text);
            int result = Convert.ToInt32(command.ExecuteScalar());
            Regex rg = new Regex(@"^[a-zA-Z0-9._%+-]+@gmail\.com$");
            Regex rp = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");

            if (rg.IsMatch(txt_gmail_login.Text) && rp.IsMatch(txt_pass_login.Text) && result > 0 
                && txt_gmail_login.Text == "admin@gmail.com"&&txt_pass_login.Text=="Admin!23")
                 {
                MessageBox.Show("Аdmin нэвтэрлээ");
                Home lg = new Home();
                lg.lbl_Admin.Enabled = true;
                lg.lbl_Admin.Visible = true;
                lg.Show();
                this.Hide();
            } else if (rg.IsMatch(txt_gmail_login.Text) && rp.IsMatch(txt_pass_login.Text) && result > 0)
            {
                MessageBox.Show("Амжилттай нэвтэрлээ");
            }
            else
            {
                MessageBox.Show("Оруулсан майл эсвэл нууц үг буруу байна");
            }
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Home lg = new Home();
            lg.Show();
            this.Hide();
        }
    }
}
