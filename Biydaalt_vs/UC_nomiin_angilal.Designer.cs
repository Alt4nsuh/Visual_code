﻿
namespace Biydaalt_vs
{
    partial class UC_nasnii_angilal
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_ba_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_b_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Бүртгэх";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ba_ID
            // 
            this.txt_ba_ID.Location = new System.Drawing.Point(36, 110);
            this.txt_ba_ID.Multiline = true;
            this.txt_ba_ID.Name = "txt_ba_ID";
            this.txt_ba_ID.Size = new System.Drawing.Size(175, 33);
            this.txt_ba_ID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Нэр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Насны ангилал";
            // 
            // txt_b_ID
            // 
            this.txt_b_ID.Location = new System.Drawing.Point(36, 172);
            this.txt_b_ID.Multiline = true;
            this.txt_b_ID.Name = "txt_b_ID";
            this.txt_b_ID.Size = new System.Drawing.Size(175, 33);
            this.txt_b_ID.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ном ID";
            // 
            // UC_nasnii_angilal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_b_ID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_ba_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_nasnii_angilal";
            this.Size = new System.Drawing.Size(1013, 293);
            this.Load += new System.EventHandler(this.UC_nasnii_angilal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_ba_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_b_ID;
        private System.Windows.Forms.Label label3;
    }
}
