using System;using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Biydaalt_vs
{
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();

            txt_pass2_sign.ReadOnly = true;
            txt_pass2_sign.BorderStyle = BorderStyle.Fixed3D;

        }
        string connectionString = "server=localhost;Username=root;database=vs_bd;password = Doogii01";
        MySqlConnection con = new MySqlConnection();
        MySqlDataAdapter Dta = new MySqlDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
           
            Regex rg = new Regex(@"^[a-zA-Z0-9._%+-]+@gmail\.com$");
            Regex rp = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");

            if (!rg.IsMatch(txt_gmail_sign.Text) && rp.IsMatch(txt_pass_sign.Text)
                 && txt_pass2_sign.Text == txt_pass_sign.Text)
            {
                MessageBox.Show("Мэдээллээ бүрэн зөв оруулна уу");
            }

            else
             if (!ck_box8.Checked == true || !ck_boxj.Checked == true || !ck_boxt.Checked == true || !ck_boxts.Checked == true || !ck_boxtd.Checked == true)
            {
                MessageBox.Show("Нууц үг шаардлага хангахгүй байна");

            }
            else if (rg.IsMatch(txt_gmail_sign.Text) && rp.IsMatch(txt_pass_sign.Text)
               && txt_pass2_sign.Text == txt_pass_sign.Text
               && ck_box8.Checked == true && ck_boxj.Checked == true && ck_boxt.Checked == true && ck_boxts.Checked == true && ck_boxtd.Checked == true)
            {
                con.ConnectionString = connectionString;
                con.Open();

                string query = "INSERT INTO Customer (cus_fname, cus_lname,cus_address,cus_pass,cus_pass2,cus_gmail,cus_date) VALUES (@val1, @val2, @val3,@val4,@val5,@val6,now())";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@val1", txt_ner_sign.Text);
                cmd.Parameters.AddWithValue("@val2", txt_ovog_sign.Text);
                cmd.Parameters.AddWithValue("@val3", txt_hayg_sign.Text);
                cmd.Parameters.AddWithValue("@val4", txt_pass_sign.Text);
                cmd.Parameters.AddWithValue("@val5", txt_pass2_sign.Text);
                cmd.Parameters.AddWithValue("@val6", txt_gmail_sign.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Amjilttai burteglee");
            }
        }

        private void lbl_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void txt_pass_sign_TextChanged(object sender, EventArgs e)
        {
            Regex l8 = new Regex(@".{8,}");
            Regex lj = new Regex(@"[a-z]");
            Regex lt = new Regex(@"[A-Z]");
            Regex lts = new Regex(@"[0-9]");
            Regex ltd = new Regex(@"[^\w\s]");


            ck_box8.Checked = l8.IsMatch(txt_pass_sign.Text);
            ck_boxj.Checked = lj.IsMatch(txt_pass_sign.Text);
            ck_boxt.Checked = lt.IsMatch(txt_pass_sign.Text);
            ck_boxts.Checked = lts.IsMatch(txt_pass_sign.Text);
            ck_boxtd.Checked = ltd.IsMatch(txt_pass_sign.Text);
            if (ck_box8.Checked == true && ck_boxj.Checked == true && ck_boxt.Checked == true && ck_boxts.Checked == true && ck_boxtd.Checked == true)
            {

                txt_pass2_sign.ReadOnly = false;
            }
            else {
                //txt_pass2_sign.ReadOnly = true;

            }

        }

        private void txt_pass2_sign_TextChanged(object sender, EventArgs e)
        {
            if (!ck_box8.Checked == true ||! ck_boxj.Checked == true || !ck_boxt.Checked == true || !ck_boxts.Checked == true || !ck_boxtd.Checked == true)
            {
                MessageBox.Show("Нууц үгээ бүрэн үүсгэсэний дараа ханадана уу");
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Home lg = new Home();
            lg.Show();
            this.Hide();
        }
    }
}
