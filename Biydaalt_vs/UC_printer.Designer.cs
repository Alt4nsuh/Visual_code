﻿
namespace Biydaalt_vs
{
    partial class UC_printer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_print_name = new System.Windows.Forms.TextBox();
            this.txt_print_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Хэвлэсэн газар";
            // 
            // txt_print_name
            // 
            this.txt_print_name.Location = new System.Drawing.Point(19, 76);
            this.txt_print_name.Multiline = true;
            this.txt_print_name.Name = "txt_print_name";
            this.txt_print_name.Size = new System.Drawing.Size(196, 39);
            this.txt_print_name.TabIndex = 1;
            // 
            // txt_print_address
            // 
            this.txt_print_address.Location = new System.Drawing.Point(19, 143);
            this.txt_print_address.Multiline = true;
            this.txt_print_address.Name = "txt_print_address";
            this.txt_print_address.Size = new System.Drawing.Size(196, 39);
            this.txt_print_address.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Нэр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Хаяг";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Бүртгэх";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_printer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_print_address);
            this.Controls.Add(this.txt_print_name);
            this.Controls.Add(this.label1);
            this.Name = "UC_printer";
            this.Size = new System.Drawing.Size(1013, 293);
            this.Load += new System.EventHandler(this.UC_printer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_print_name;
        private System.Windows.Forms.TextBox txt_print_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
