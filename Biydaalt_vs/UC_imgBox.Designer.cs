
namespace Biydaalt_vs
{
    partial class UC_imgBox
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_nomiinNer = new System.Windows.Forms.Label();
            this.lbl_hevlesenOgnoo = new System.Windows.Forms.Label();
            this.lbl_huudas = new System.Windows.Forms.Label();
            this.lbl_zohiolch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biydaalt_vs.Properties.Resources.Screenshot_2023_03_14_1731161;
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номын нэр :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Хэвлэсэн огноо :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Хуудас :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Зохиолч :";
            // 
            // lbl_nomiinNer
            // 
            this.lbl_nomiinNer.AutoSize = true;
            this.lbl_nomiinNer.Location = new System.Drawing.Point(382, 14);
            this.lbl_nomiinNer.Name = "lbl_nomiinNer";
            this.lbl_nomiinNer.Size = new System.Drawing.Size(18, 17);
            this.lbl_nomiinNer.TabIndex = 5;
            this.lbl_nomiinNer.Text = "--";
            // 
            // lbl_hevlesenOgnoo
            // 
            this.lbl_hevlesenOgnoo.AutoSize = true;
            this.lbl_hevlesenOgnoo.Location = new System.Drawing.Point(382, 53);
            this.lbl_hevlesenOgnoo.Name = "lbl_hevlesenOgnoo";
            this.lbl_hevlesenOgnoo.Size = new System.Drawing.Size(18, 17);
            this.lbl_hevlesenOgnoo.TabIndex = 6;
            this.lbl_hevlesenOgnoo.Text = "--";
            // 
            // lbl_huudas
            // 
            this.lbl_huudas.AutoSize = true;
            this.lbl_huudas.Location = new System.Drawing.Point(382, 94);
            this.lbl_huudas.Name = "lbl_huudas";
            this.lbl_huudas.Size = new System.Drawing.Size(18, 17);
            this.lbl_huudas.TabIndex = 7;
            this.lbl_huudas.Text = "--";
            // 
            // lbl_zohiolch
            // 
            this.lbl_zohiolch.AutoSize = true;
            this.lbl_zohiolch.Location = new System.Drawing.Point(382, 137);
            this.lbl_zohiolch.Name = "lbl_zohiolch";
            this.lbl_zohiolch.Size = new System.Drawing.Size(18, 17);
            this.lbl_zohiolch.TabIndex = 8;
            this.lbl_zohiolch.Text = "--";
            // 
            // UC_imgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_zohiolch);
            this.Controls.Add(this.lbl_huudas);
            this.Controls.Add(this.lbl_hevlesenOgnoo);
            this.Controls.Add(this.lbl_nomiinNer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_imgBox";
            this.Size = new System.Drawing.Size(949, 237);
            this.Load += new System.EventHandler(this.UC_imgBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_hevlesenOgnoo;
        public System.Windows.Forms.Label lbl_huudas;
        public System.Windows.Forms.Label lbl_zohiolch;
        public System.Windows.Forms.Label lbl_nomiinNer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
