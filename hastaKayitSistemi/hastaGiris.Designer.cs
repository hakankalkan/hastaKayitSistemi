﻿namespace hastaKayitSistemi
{
    partial class hastaGiris
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
            this.textBoxHastaGiris1 = new System.Windows.Forms.TextBox();
            this.textBoxHastaGiris2 = new System.Windows.Forms.TextBox();
            this.btnHastaGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHastaKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxHastaGiris1
            // 
            this.textBoxHastaGiris1.Location = new System.Drawing.Point(302, 62);
            this.textBoxHastaGiris1.Name = "textBoxHastaGiris1";
            this.textBoxHastaGiris1.Size = new System.Drawing.Size(127, 20);
            this.textBoxHastaGiris1.TabIndex = 0;
            // 
            // textBoxHastaGiris2
            // 
            this.textBoxHastaGiris2.Location = new System.Drawing.Point(302, 117);
            this.textBoxHastaGiris2.Name = "textBoxHastaGiris2";
            this.textBoxHastaGiris2.Size = new System.Drawing.Size(127, 20);
            this.textBoxHastaGiris2.TabIndex = 1;
            // 
            // btnHastaGiris
            // 
            this.btnHastaGiris.Location = new System.Drawing.Point(354, 171);
            this.btnHastaGiris.Name = "btnHastaGiris";
            this.btnHastaGiris.Size = new System.Drawing.Size(75, 23);
            this.btnHastaGiris.TabIndex = 2;
            this.btnHastaGiris.Text = "GİRİŞ";
            this.btnHastaGiris.UseVisualStyleBackColor = true;
            this.btnHastaGiris.Click += new System.EventHandler(this.btnHastaGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC KİMLİK NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ŞİFRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "KAYIT OLMAK İÇİN:";
            // 
            // btnHastaKayit
            // 
            this.btnHastaKayit.Location = new System.Drawing.Point(354, 317);
            this.btnHastaKayit.Name = "btnHastaKayit";
            this.btnHastaKayit.Size = new System.Drawing.Size(75, 23);
            this.btnHastaKayit.TabIndex = 6;
            this.btnHastaKayit.Text = "KAYIT OL";
            this.btnHastaKayit.UseVisualStyleBackColor = true;
            this.btnHastaKayit.Click += new System.EventHandler(this.btnHastaKayit_Click);
            // 
            // hastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHastaKayit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHastaGiris);
            this.Controls.Add(this.textBoxHastaGiris2);
            this.Controls.Add(this.textBoxHastaGiris1);
            this.Name = "hastaGiris";
            this.Text = "Hasta Giriş";
            this.Load += new System.EventHandler(this.hastaGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHastaGiris1;
        private System.Windows.Forms.TextBox textBoxHastaGiris2;
        private System.Windows.Forms.Button btnHastaGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHastaKayit;
    }
}