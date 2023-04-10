
namespace Biydaalt_vs
{
    partial class UC_tabiur
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
            this.alla = new System.Windows.Forms.Label();
            this.txt_add_name = new System.Windows.Forms.TextBox();
            this.btn_tabiur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alla
            // 
            this.alla.AutoSize = true;
            this.alla.Location = new System.Drawing.Point(18, 25);
            this.alla.Name = "alla";
            this.alla.Size = new System.Drawing.Size(55, 17);
            this.alla.TabIndex = 0;
            this.alla.Text = "Тавиур";
            this.alla.Click += new System.EventHandler(this.alla_Click);
            // 
            // txt_add_name
            // 
            this.txt_add_name.Location = new System.Drawing.Point(21, 132);
            this.txt_add_name.Multiline = true;
            this.txt_add_name.Name = "txt_add_name";
            this.txt_add_name.Size = new System.Drawing.Size(217, 34);
            this.txt_add_name.TabIndex = 1;
            this.txt_add_name.TextChanged += new System.EventHandler(this.txt_add_name_TextChanged);
            // 
            // btn_tabiur
            // 
            this.btn_tabiur.Location = new System.Drawing.Point(44, 192);
            this.btn_tabiur.Name = "btn_tabiur";
            this.btn_tabiur.Size = new System.Drawing.Size(134, 34);
            this.btn_tabiur.TabIndex = 3;
            this.btn_tabiur.Text = "Бүртгэх";
            this.btn_tabiur.UseVisualStyleBackColor = true;
            this.btn_tabiur.Click += new System.EventHandler(this.btn_tabiur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Нэр";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UC_tabiur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_tabiur);
            this.Controls.Add(this.txt_add_name);
            this.Controls.Add(this.alla);
            this.Name = "UC_tabiur";
            this.Size = new System.Drawing.Size(1013, 293);
            this.Load += new System.EventHandler(this.UC_tabiur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alla;
        private System.Windows.Forms.TextBox txt_add_name;
        private System.Windows.Forms.Button btn_tabiur;
        private System.Windows.Forms.Label label1;
    }
}
