
namespace Biydaalt_vs
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_home = new System.Windows.Forms.LinkLabel();
            this.lbl_holboo = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.lbl_tuhai = new System.Windows.Forms.LinkLabel();
            this.lbl_Admin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-5, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 693);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_home
            // 
            this.lbl_home.AutoSize = true;
            this.lbl_home.Location = new System.Drawing.Point(25, 29);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(40, 17);
            this.lbl_home.TabIndex = 0;
            this.lbl_home.TabStop = true;
            this.lbl_home.Text = "Нүүр";
            this.lbl_home.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_home_LinkClicked);
            // 
            // lbl_holboo
            // 
            this.lbl_holboo.AutoSize = true;
            this.lbl_holboo.Location = new System.Drawing.Point(303, 29);
            this.lbl_holboo.Name = "lbl_holboo";
            this.lbl_holboo.Size = new System.Drawing.Size(99, 17);
            this.lbl_holboo.TabIndex = 1;
            this.lbl_holboo.TabStop = true;
            this.lbl_holboo.Text = "Холбоо барих";
            this.lbl_holboo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_holboo_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(1097, 29);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(60, 17);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Нэвтрэх";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // lbl_tuhai
            // 
            this.lbl_tuhai.AutoSize = true;
            this.lbl_tuhai.Location = new System.Drawing.Point(134, 29);
            this.lbl_tuhai.Name = "lbl_tuhai";
            this.lbl_tuhai.Size = new System.Drawing.Size(97, 17);
            this.lbl_tuhai.TabIndex = 3;
            this.lbl_tuhai.TabStop = true;
            this.lbl_tuhai.Text = "Бидний тухай";
            this.lbl_tuhai.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_tuhai_LinkClicked);
            // 
            // lbl_Admin
            // 
            this.lbl_Admin.AutoSize = true;
            this.lbl_Admin.Location = new System.Drawing.Point(462, 29);
            this.lbl_Admin.Name = "lbl_Admin";
            this.lbl_Admin.Size = new System.Drawing.Size(46, 17);
            this.lbl_Admin.TabIndex = 4;
            this.lbl_Admin.TabStop = true;
            this.lbl_Admin.Text = "admin";
            this.lbl_Admin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Admin_LinkClicked);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 753);
            this.Controls.Add(this.lbl_Admin);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.lbl_tuhai);
            this.Controls.Add(this.lbl_holboo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_home);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lbl_home;
        private System.Windows.Forms.LinkLabel lbl_holboo;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel lbl_tuhai;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.LinkLabel lbl_Admin;
    }
}

