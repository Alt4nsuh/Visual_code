
namespace Biydaalt_vs
{
    partial class Login
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
            this.lbl_burtguuleh = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_pass_login = new System.Windows.Forms.TextBox();
            this.txt_gmail_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_burtguuleh
            // 
            this.lbl_burtguuleh.AutoSize = true;
            this.lbl_burtguuleh.Location = new System.Drawing.Point(340, 318);
            this.lbl_burtguuleh.Name = "lbl_burtguuleh";
            this.lbl_burtguuleh.Size = new System.Drawing.Size(79, 17);
            this.lbl_burtguuleh.TabIndex = 12;
            this.lbl_burtguuleh.TabStop = true;
            this.lbl_burtguuleh.Text = "Бүртгүүлэх";
            this.lbl_burtguuleh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_burtguuleh_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Бүртгэл үүсгээгүй бол энд дарна уу";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(163, 359);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(133, 51);
            this.btn_login.TabIndex = 10;
            this.btn_login.Text = "Нэвтрэх";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_pass_login
            // 
            this.txt_pass_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass_login.Location = new System.Drawing.Point(53, 225);
            this.txt_pass_login.Multiline = true;
            this.txt_pass_login.Name = "txt_pass_login";
            this.txt_pass_login.Size = new System.Drawing.Size(350, 48);
            this.txt_pass_login.TabIndex = 9;
            // 
            // txt_gmail_login
            // 
            this.txt_gmail_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_gmail_login.Location = new System.Drawing.Point(53, 138);
            this.txt_gmail_login.Multiline = true;
            this.txt_gmail_login.Name = "txt_gmail_login";
            this.txt_gmail_login.Size = new System.Drawing.Size(350, 48);
            this.txt_gmail_login.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Нэвтрэх";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mайл";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Нууц үг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Нүүрлүү буцах";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 423);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_burtguuleh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pass_login);
            this.Controls.Add(this.txt_gmail_login);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.LinkLabel lbl_burtguuleh;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_login;
        public System.Windows.Forms.TextBox txt_pass_login;
        public System.Windows.Forms.TextBox txt_gmail_login;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}