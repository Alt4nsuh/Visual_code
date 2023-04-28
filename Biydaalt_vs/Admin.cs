using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biydaalt_vs
{
    public partial class Admin : Form
    {
        private string[] table = { "Ажилчин",
                           "Ном",
                           "Зохиолч",
                           "Хэвлэсэн газар",
                           "Уншигч",
                           "Номын ангилал",
                           "Тавиур",
                           "Захиалга",
                           "Зохиолчид",
                           "Төлөв","eТөлөв лавлах","Ном бүртгэл"};
        private string[] table1 = { "Employee",
                           "Book",
                           "Writer",
                           "Printer",
                           "Customer",
                           "Book_angilal",
                           "BookAdd",
                           "Orders",
                           "Writers",
                           "tuluv","tuluv_lavlah","BookReg"};
        private string[] table2 = { "e_name",
                           "b_name",
                           "w_name",
                           "print_name",
                           "cus_name",
                           "ba_name",
                           "add_name",
                           "o_ID",
                           "ws_ID",
                           "t_ID","tl_ID","br_ID"};
        public Admin()
        {
            InitializeComponent();

        }
     

        private void chbList_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chbList_table.CheckedItems.Count <= 1)
            {
                Database db = new Database();
                for (int i = 0; i < table.Length; i++) {
                    if (table[i] == Convert.ToString(chbList_table.SelectedItem)) {

                        dataGridView1.DataSource = db.ViewTable(table1[i]);
                    }
                }
            }
            else {
                MessageBox.Show("olon songolt hiih bolomjgui");
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count <=1 )
            {
                for (int i = 0; i < table.Length; i++)
                {
                    if (table[i] == Convert.ToString(checkedListBox1.SelectedItem))
                    {
                        switch (table[i])
                        {
                            case "Тавиур":
                                UC_tabiur Nr = new UC_tabiur();
                                Nr.TopLevel = false;
                                Nr.Dock = DockStyle.Fill;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(Nr);
                                Nr.Show();
                                break;
                            case "Ажилчин":
                                UC_Ajilchin Nr1 = new UC_Ajilchin();
                                Nr1.TopLevel = false;
                                Nr1.Dock = DockStyle.Fill;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(Nr1);
                                Nr1.Show();
                                break;
                            case "Хэвлэсэн газар":
                                UC_printer Nr2 = new UC_printer();
                                Nr2.TopLevel = false;
                                Nr2.Dock = DockStyle.Fill;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(Nr2);
                                Nr2.Show();
                                break;
                            case "Зохиолч":
                                UC_writer Nr3 = new UC_writer();
                                Nr3.TopLevel = false;
                                Nr3.Dock = DockStyle.Fill;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(Nr3);
                                Nr3.Show();
                                break;
                            case "Захиалга":
                                order o = new order();
                                o.TopLevel = false;
                                o.Dock = DockStyle.Fill;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(o);
                                o.Show();
                                break;
                            case "Ном":
                                UC_book b = new UC_book();
                                b.TopLevel = false;
                                b.Dock = DockStyle.Fill;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(b);
                                b.Show();
                                break;
                            case "Номын ангилал":
                                UC_nasnii_angilal b1 = new UC_nasnii_angilal();
                                b1.TopLevel = false;
                                b1.Dock = DockStyle.Fill;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(b1);
                                b1.Show();
                                break;
                            case "Зохиолчид":
                                UC_writers b2 = new UC_writers();
                                b2.TopLevel = false;
                                b2.Dock = DockStyle.Fill;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(b2);
                                b2.Show();
                                break;
                            case "Ном бүртгэл":
                                UC_nom_burtgel b3 = new UC_nom_burtgel();
                                b3.Dock = DockStyle.Fill;
                                b3.TopLevel = false;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(b3);
                                b3.Show();
                                break;
                            case "Төлөв лавлах":
                                tuluv_lavlah b4 = new tuluv_lavlah();
                                b4.Dock = DockStyle.Fill;
                                b4.TopLevel = false;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(b4);
                                b4.Show();
                                break;
                            case "Төлөв":
                                UC_tuluv b5 = new UC_tuluv();
                                b5.Dock = DockStyle.Fill;
                                b5.TopLevel = false;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(b5);
                                b5.Show();
                                break;



                        }
                    }
                }
            }
           
        }

        

        private void checkedListBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (checkedListBox2.CheckedItems.Count <= 1)
            {
                for (int i = 0; i < table.Length; i++)
                {
                    if (table[i] == Convert.ToString(checkedListBox2.SelectedItem))
                    {
                        switch (table[i])
                        {
                            case "Тавиур":
                                UC_tabiur Nr = new UC_tabiur();
                                Nr.TopLevel = false;
                                Nr.Dock = DockStyle.Fill;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(Nr);
                                Nr.Show();
                                break;
                            case "Ажилчин":
                                UC_Ajiltan_search1 Nr1 = new UC_Ajiltan_search1();
                                Nr1.TopLevel = false;
                                Nr1.Dock = DockStyle.Fill;
                                panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel1.Controls.Clear();
                                panel1.Controls.Add(Nr1);
                                Nr1.Show();
                                break;
                            case "Хэвлэсэн газар":
                                UC_printer Nr2 = new UC_printer();
                                Nr2.TopLevel = false;
                                Nr2.Dock = DockStyle.Fill;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(Nr2);
                                Nr2.Show();
                                break;
                            case "Зохиолч":
                                UC_writer Nr3 = new UC_writer();
                                Nr3.TopLevel = false;
                                Nr3.Dock = DockStyle.Fill;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(Nr3);
                                Nr3.Show();
                                break;
                            case "Захиалга":
                                order o = new order();
                                o.TopLevel = false;
                                o.Dock = DockStyle.Fill;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(o);
                                o.Show();
                                break;
                            case "Ном":
                                UC_book b = new UC_book();
                                b.TopLevel = false;
                                b.Dock = DockStyle.Fill;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(b);
                                b.Show();
                                break;
                            case "Номын ангилал":
                                UC_nasnii_angilal b1 = new UC_nasnii_angilal();
                                b1.TopLevel = false;
                                b1.Dock = DockStyle.Fill;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(b1);
                                b1.Show();
                                break;
                            case "Зохиолчид":
                                UC_writers b2 = new UC_writers();
                                b2.TopLevel = false;
                                b2.Dock = DockStyle.Fill;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(b2);
                                b2.Show();
                                break;
                            case "Ном бүртгэл":
                                UC_nom_burtgel b3 = new UC_nom_burtgel();
                                b3.Dock = DockStyle.Fill;
                                b3.TopLevel = false;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(b3);
                                b3.Show();
                                break;
                            case "Төлөв лавлах":
                                tuluv_lavlah b4 = new tuluv_lavlah();
                                b4.Dock = DockStyle.Fill;
                                b4.TopLevel = false;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(b4);
                                b4.Show();
                                break;
                            case "Төлөв":
                                UC_tuluv b5 = new UC_tuluv();
                                b5.Dock = DockStyle.Fill;
                                b5.TopLevel = false;
                                panel_ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                                panel_ad.Controls.Clear();
                                panel_ad.Controls.Add(b5);
                                b5.Show();
                                break;



                        }
                    }
                }
            }
        }
    }
    
}
