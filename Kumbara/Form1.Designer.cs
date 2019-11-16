namespace Kumbara
{
    partial class Kumbaram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kumbaram));
            this.cmbPara = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAT = new System.Windows.Forms.Button();
            this.btnKır = new System.Windows.Forms.Button();
            this.btnYapistir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamPara = new System.Windows.Forms.Label();
            this.lblToplamHacim = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBiriktirilen = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPara
            // 
            this.cmbPara.FormattingEnabled = true;
            this.cmbPara.Location = new System.Drawing.Point(73, 84);
            this.cmbPara.Name = "cmbPara";
            this.cmbPara.Size = new System.Drawing.Size(121, 21);
            this.cmbPara.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Para seç";
            // 
            // btnAT
            // 
            this.btnAT.Location = new System.Drawing.Point(12, 192);
            this.btnAT.Name = "btnAT";
            this.btnAT.Size = new System.Drawing.Size(182, 33);
            this.btnAT.TabIndex = 3;
            this.btnAT.Text = "Kumbaraya At";
            this.btnAT.UseVisualStyleBackColor = true;
            this.btnAT.Click += new System.EventHandler(this.BtnAT_Click);
            // 
            // btnKır
            // 
            this.btnKır.Location = new System.Drawing.Point(12, 274);
            this.btnKır.Name = "btnKır";
            this.btnKır.Size = new System.Drawing.Size(182, 39);
            this.btnKır.TabIndex = 5;
            this.btnKır.Text = "Kumbarayı Kır";
            this.btnKır.UseVisualStyleBackColor = true;
            this.btnKır.Click += new System.EventHandler(this.BtnKır_Click);
            // 
            // btnYapistir
            // 
            this.btnYapistir.Location = new System.Drawing.Point(12, 348);
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(182, 39);
            this.btnYapistir.TabIndex = 6;
            this.btnYapistir.Text = "Kumbarayı Yapıştır";
            this.btnYapistir.UseVisualStyleBackColor = true;
            this.btnYapistir.Click += new System.EventHandler(this.BtnYapistir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Toplam Para:";
            // 
            // lblToplamPara
            // 
            this.lblToplamPara.AutoSize = true;
            this.lblToplamPara.Location = new System.Drawing.Point(409, 300);
            this.lblToplamPara.Name = "lblToplamPara";
            this.lblToplamPara.Size = new System.Drawing.Size(13, 13);
            this.lblToplamPara.TabIndex = 8;
            this.lblToplamPara.Text = "0";
            // 
            // lblToplamHacim
            // 
            this.lblToplamHacim.AutoSize = true;
            this.lblToplamHacim.Location = new System.Drawing.Point(404, 334);
            this.lblToplamHacim.Name = "lblToplamHacim";
            this.lblToplamHacim.Size = new System.Drawing.Size(0, 13);
            this.lblToplamHacim.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Toplam Hacim";
            // 
            // lblBiriktirilen
            // 
            this.lblBiriktirilen.AutoSize = true;
            this.lblBiriktirilen.Location = new System.Drawing.Point(400, 371);
            this.lblBiriktirilen.Name = "lblBiriktirilen";
            this.lblBiriktirilen.Size = new System.Drawing.Size(13, 13);
            this.lblBiriktirilen.TabIndex = 12;
            this.lblBiriktirilen.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Biriktirilen Para:";
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(246, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 245);
            this.label3.TabIndex = 13;
            // 
            // Kumbaram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 449);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBiriktirilen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblToplamHacim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblToplamPara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYapistir);
            this.Controls.Add(this.btnKır);
            this.Controls.Add(this.btnAT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPara);
            this.Name = "Kumbaram";
            this.Text = "Kumbaram";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAT;
        private System.Windows.Forms.Button btnKır;
        private System.Windows.Forms.Button btnYapistir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamPara;
        private System.Windows.Forms.Label lblToplamHacim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBiriktirilen;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbPara;
        private System.Windows.Forms.Label label3;
    }
}

