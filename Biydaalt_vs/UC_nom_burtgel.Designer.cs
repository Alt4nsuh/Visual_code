﻿
namespace Biydaalt_vs
{
    partial class UC_nom_burtgel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.txt_e_ID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_b_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_br_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ажилчин ID";
            // 
            // txt_e_ID
            // 
            this.txt_e_ID.Location = new System.Drawing.Point(69, 140);
            this.txt_e_ID.Multiline = true;
            this.txt_e_ID.Name = "txt_e_ID";
            this.txt_e_ID.Size = new System.Drawing.Size(200, 33);
            this.txt_e_ID.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "Бүртгэх";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Огноо";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ном бүртгэл";
            // 
            // txt_b_ID
            // 
            this.txt_b_ID.Location = new System.Drawing.Point(69, 196);
            this.txt_b_ID.Multiline = true;
            this.txt_b_ID.Name = "txt_b_ID";
            this.txt_b_ID.Size = new System.Drawing.Size(200, 33);
            this.txt_b_ID.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ном ID";
            // 
            // date_br_date
            // 
            this.date_br_date.Location = new System.Drawing.Point(69, 85);
            this.date_br_date.Name = "date_br_date";
            this.date_br_date.Size = new System.Drawing.Size(200, 22);
            this.date_br_date.TabIndex = 25;
            // 
            // UC_nom_burtgel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.date_br_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_b_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_e_ID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_nom_burtgel";
            this.Size = new System.Drawing.Size(1013, 293);
            this.Load += new System.EventHandler(this.UC_nom_burtgel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_e_ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_b_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_br_date;
    }
}
