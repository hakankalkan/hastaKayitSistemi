namespace hastaKayitSistemi
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.doktorGiris = new System.Windows.Forms.Button();
            this.hastaGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doktorGiris
            // 
            this.doktorGiris.Location = new System.Drawing.Point(166, 264);
            this.doktorGiris.Name = "doktorGiris";
            this.doktorGiris.Size = new System.Drawing.Size(433, 101);
            this.doktorGiris.TabIndex = 1;
            this.doktorGiris.Text = "DOKTOR GİRİŞ";
            this.doktorGiris.UseVisualStyleBackColor = true;
            this.doktorGiris.Click += new System.EventHandler(this.doktorGiris_Click);
            // 
            // hastaGiris
            // 
            this.hastaGiris.Location = new System.Drawing.Point(166, 94);
            this.hastaGiris.Name = "hastaGiris";
            this.hastaGiris.Size = new System.Drawing.Size(433, 95);
            this.hastaGiris.TabIndex = 0;
            this.hastaGiris.Text = "HASTA GİRİŞ";
            this.hastaGiris.UseVisualStyleBackColor = true;
            this.hastaGiris.Click += new System.EventHandler(this.hastaGiris_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doktorGiris);
            this.Controls.Add(this.hastaGiris);
            this.Name = "AnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button doktorGiris;
        private System.Windows.Forms.Button hastaGiris;
    }
}

