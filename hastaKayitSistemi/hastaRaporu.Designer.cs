namespace hastaKayitSistemi
{
    partial class hastaRaporu
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDoktorTC = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBoxTani = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTedavi = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRaporOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor TC Kimlik No:";
            // 
            // textBoxDoktorTC
            // 
            this.textBoxDoktorTC.Location = new System.Drawing.Point(121, 22);
            this.textBoxDoktorTC.Name = "textBoxDoktorTC";
            this.textBoxDoktorTC.Size = new System.Drawing.Size(100, 20);
            this.textBoxDoktorTC.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 323);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Uygulanan Tedavi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tanı:";
            // 
            // richTextBoxTani
            // 
            this.richTextBoxTani.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBoxTani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxTani.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.richTextBoxTani.Location = new System.Drawing.Point(121, 71);
            this.richTextBoxTani.Name = "richTextBoxTani";
            this.richTextBoxTani.Size = new System.Drawing.Size(446, 96);
            this.richTextBoxTani.TabIndex = 9;
            this.richTextBoxTani.Text = "";
            // 
            // richTextBoxTedavi
            // 
            this.richTextBoxTedavi.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBoxTedavi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxTedavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.richTextBoxTedavi.Location = new System.Drawing.Point(121, 221);
            this.richTextBoxTedavi.Name = "richTextBoxTedavi";
            this.richTextBoxTedavi.Size = new System.Drawing.Size(446, 96);
            this.richTextBoxTedavi.TabIndex = 10;
            this.richTextBoxTedavi.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rapor Tarihi:";
            // 
            // btnRaporOlustur
            // 
            this.btnRaporOlustur.Location = new System.Drawing.Point(121, 406);
            this.btnRaporOlustur.Name = "btnRaporOlustur";
            this.btnRaporOlustur.Size = new System.Drawing.Size(86, 23);
            this.btnRaporOlustur.TabIndex = 12;
            this.btnRaporOlustur.Text = "Rapor Oluştur";
            this.btnRaporOlustur.UseVisualStyleBackColor = true;
            this.btnRaporOlustur.Click += new System.EventHandler(this.btnRaporOlustur_Click);
            // 
            // hastaRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRaporOlustur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxTedavi);
            this.Controls.Add(this.richTextBoxTani);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxDoktorTC);
            this.Controls.Add(this.label1);
            this.Name = "hastaRaporu";
            this.Text = "hastaRaporu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDoktorTC;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBoxTani;
        private System.Windows.Forms.RichTextBox richTextBoxTedavi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRaporOlustur;
    }
}