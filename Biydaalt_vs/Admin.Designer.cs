
namespace Biydaalt_vs
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_error_admin = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chbList_table = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel_ad = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_error_admin
            // 
            this.lbl_error_admin.AutoSize = true;
            this.lbl_error_admin.Location = new System.Drawing.Point(87, 338);
            this.lbl_error_admin.Name = "lbl_error_admin";
            this.lbl_error_admin.Size = new System.Drawing.Size(0, 17);
            this.lbl_error_admin.TabIndex = 42;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 325);
            this.dataGridView1.TabIndex = 43;
            // 
            // chbList_table
            // 
            this.chbList_table.FormattingEnabled = true;
            this.chbList_table.Items.AddRange(new object[] {
            "Ажилчин",
            "Ном",
            "Зохиолч",
            "Хэвлэсэн газар",
            "Уншигч",
            "Номын ангилал",
            "Тавиур",
            "Захиалга",
            "Зохиолчид",
            "Төлөв",
            "Төлөв лавлах",
            "Ном бүртгэл"});
            this.chbList_table.Location = new System.Drawing.Point(1031, 347);
            this.chbList_table.Name = "chbList_table";
            this.chbList_table.Size = new System.Drawing.Size(151, 293);
            this.chbList_table.TabIndex = 56;
            this.chbList_table.SelectedIndexChanged += new System.EventHandler(this.chbList_table_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Ажилчин",
            "Ном",
            "Зохиолч",
            "Хэвлэсэн газар",
            "Уншигч",
            "Номын ангилал",
            "Тавиур",
            "Захиалга",
            "Зохиолчид",
            "Төлөв",
            "Төлөв лавлах",
            "Ном бүртгэл"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 21);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(151, 293);
            this.checkedListBox1.TabIndex = 57;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // panel_ad
            // 
            this.panel_ad.Location = new System.Drawing.Point(169, 21);
            this.panel_ad.Name = "panel_ad";
            this.panel_ad.Size = new System.Drawing.Size(1013, 293);
            this.panel_ad.TabIndex = 58;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 657);
            this.ControlBox = false;
            this.Controls.Add(this.panel_ad);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.chbList_table);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_error_admin);
            this.Name = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_error_admin;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox chbList_table;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panel_ad;
    }
}