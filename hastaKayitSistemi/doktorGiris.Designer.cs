namespace hastaKayitSistemi
{
    partial class doktorGiris
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoktorGiris = new System.Windows.Forms.Button();
            this.textBoxDoktorGiris2 = new System.Windows.Forms.TextBox();
            this.textBoxDoktorGiris1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ŞİFRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC KİMLİK NO:";
            // 
            // btnDoktorGiris
            // 
            this.btnDoktorGiris.Location = new System.Drawing.Point(398, 188);
            this.btnDoktorGiris.Name = "btnDoktorGiris";
            this.btnDoktorGiris.Size = new System.Drawing.Size(75, 23);
            this.btnDoktorGiris.TabIndex = 9;
            this.btnDoktorGiris.Text = "GİRİŞ";
            this.btnDoktorGiris.UseVisualStyleBackColor = true;
            this.btnDoktorGiris.Click += new System.EventHandler(this.btnDoktorGiris_Click);
            // 
            // textBoxDoktorGiris2
            // 
            this.textBoxDoktorGiris2.Location = new System.Drawing.Point(346, 134);
            this.textBoxDoktorGiris2.Name = "textBoxDoktorGiris2";
            this.textBoxDoktorGiris2.Size = new System.Drawing.Size(127, 20);
            this.textBoxDoktorGiris2.TabIndex = 8;
            // 
            // textBoxDoktorGiris1
            // 
            this.textBoxDoktorGiris1.Location = new System.Drawing.Point(346, 79);
            this.textBoxDoktorGiris1.Name = "textBoxDoktorGiris1";
            this.textBoxDoktorGiris1.Size = new System.Drawing.Size(127, 20);
            this.textBoxDoktorGiris1.TabIndex = 7;
            // 
            // doktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoktorGiris);
            this.Controls.Add(this.textBoxDoktorGiris2);
            this.Controls.Add(this.textBoxDoktorGiris1);
            this.Name = "doktorGiris";
            this.Text = "Doktor Giriş";
            this.Load += new System.EventHandler(this.doktorGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoktorGiris;
        private System.Windows.Forms.TextBox textBoxDoktorGiris2;
        private System.Windows.Forms.TextBox textBoxDoktorGiris1;
    }
}