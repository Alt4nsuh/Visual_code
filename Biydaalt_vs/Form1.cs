using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biydaalt_vs
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            lbl_Admin.Enabled = false;
            lbl_Admin.Visible = false;
            Nuur Nr = new Nuur();
            Nr.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(Nr);
            Nr.Show();
        }

    

        private void lbl_holboo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Holboo_barih HB = new Holboo_barih();
            HB.Dock = DockStyle.Fill;
            HB.TopLevel = false;
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            panel1.Controls.Clear();
            panel1.Controls.Add(HB);
            HB.Show();
        }

        private void lbl_tuhai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Bidnii_tuhai BT = new Bidnii_tuhai();
            BT.TopLevel = false;
            BT.Dock = DockStyle.Fill;
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            panel1.Controls.Clear();
            panel1.Controls.Add(BT);
            BT.Show();
        }

        private void lbl_home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nuur Nr = new Nuur();
            Nr.TopLevel = false;
            Nr.Dock = DockStyle.Fill;
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            panel1.Controls.Clear();
            panel1.Controls.Add(Nr);
            Nr.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Admin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin ad = new Admin();
           

            panel1.Controls.Clear();
            ad.TopLevel = false;
            ad.Dock = DockStyle.Fill;
           panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            panel1.Controls.Clear();
           panel1.Controls.Add(ad);
            ad.Show();
        }
    }
}
