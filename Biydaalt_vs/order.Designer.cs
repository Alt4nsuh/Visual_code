
namespace Biydaalt_vs
{
    partial class order
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
            this.txt_cus_ID = new System.Windows.Forms.TextBox();
            this.txt_br_ID = new System.Windows.Forms.TextBox();
            this.txt_e_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.date_ehleh = new System.Windows.Forms.DateTimePicker();
            this.date_duusah = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_cus_ID
            // 
            this.txt_cus_ID.Location = new System.Drawing.Point(269, 149);
            this.txt_cus_ID.Multiline = true;
            this.txt_cus_ID.Name = "txt_cus_ID";
            this.txt_cus_ID.Size = new System.Drawing.Size(171, 32);
            this.txt_cus_ID.TabIndex = 1;
            // 
            // txt_br_ID
            // 
            this.txt_br_ID.Location = new System.Drawing.Point(35, 205);
            this.txt_br_ID.Multiline = true;
            this.txt_br_ID.Name = "txt_br_ID";
            this.txt_br_ID.Size = new System.Drawing.Size(171, 32);
            this.txt_br_ID.TabIndex = 2;
            // 
            // txt_e_ID
            // 
            this.txt_e_ID.Location = new System.Drawing.Point(269, 87);
            this.txt_e_ID.Multiline = true;
            this.txt_e_ID.Name = "txt_e_ID";
            this.txt_e_ID.Size = new System.Drawing.Size(171, 32);
            this.txt_e_ID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Захиалга";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Эхлэх огноо";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дуусах огноо";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Номын ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ажилчин ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Уншигч ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Бүртгэх";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date_ehleh
            // 
            this.date_ehleh.Location = new System.Drawing.Point(35, 87);
            this.date_ehleh.Name = "date_ehleh";
            this.date_ehleh.Size = new System.Drawing.Size(200, 22);
            this.date_ehleh.TabIndex = 13;
            // 
            // date_duusah
            // 
            this.date_duusah.Location = new System.Drawing.Point(35, 149);
            this.date_duusah.Name = "date_duusah";
            this.date_duusah.Size = new System.Drawing.Size(200, 22);
            this.date_duusah.TabIndex = 14;
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.date_duusah);
            this.Controls.Add(this.date_ehleh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_e_ID);
            this.Controls.Add(this.txt_br_ID);
            this.Controls.Add(this.txt_cus_ID);
            this.Name = "order";
            this.Size = new System.Drawing.Size(1013, 293);
            this.Load += new System.EventHandler(this.order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_cus_ID;
        private System.Windows.Forms.TextBox txt_br_ID;
        private System.Windows.Forms.TextBox txt_e_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker date_ehleh;
        private System.Windows.Forms.DateTimePicker date_duusah;
    }
}
