﻿
namespace Biydaalt_vs
{
    partial class UC_writers
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
            this.txt_b_ID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_w_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ном ID";
            // 
            // txt_b_ID
            // 
            this.txt_b_ID.Location = new System.Drawing.Point(68, 170);
            this.txt_b_ID.Multiline = true;
            this.txt_b_ID.Name = "txt_b_ID";
            this.txt_b_ID.Size = new System.Drawing.Size(175, 33);
            this.txt_b_ID.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Бүртгэх";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_w_ID
            // 
            this.txt_w_ID.Location = new System.Drawing.Point(68, 108);
            this.txt_w_ID.Multiline = true;
            this.txt_w_ID.Name = "txt_w_ID";
            this.txt_w_ID.Size = new System.Drawing.Size(175, 33);
            this.txt_w_ID.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Зохиолч ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Зохиолчид";
            // 
            // UC_writers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_b_ID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_w_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_writers";
            this.Size = new System.Drawing.Size(1013, 293);
          //  this.Load += new System.EventHandler(this.UC_writers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_b_ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_w_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
