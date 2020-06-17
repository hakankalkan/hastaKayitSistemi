namespace hastaKayitSistemi
{
    partial class hastaPanel
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBolum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSaat = new System.Windows.Forms.ComboBox();
            this.btnRandevuEkle = new System.Windows.Forms.Button();
            this.textBoxTCKimlikNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hastaKayitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaKayitDataSet = new hastaKayitSistemi.hastaKayitDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRandevuGuncelle = new System.Windows.Forms.Button();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.textBoxRandevuNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm Seçiniz";
            // 
            // comboBoxBolum
            // 
            this.comboBoxBolum.FormattingEnabled = true;
            this.comboBoxBolum.Items.AddRange(new object[] {
            "Cilt Hst.",
            "Dahiliye",
            "Diş",
            "Genel Cer.",
            "Göğüs Hst.",
            "Jinekoloji",
            "Nöroloji",
            "Onkoloji",
            "Ortopedi",
            "Üroloji"});
            this.comboBoxBolum.Location = new System.Drawing.Point(202, 204);
            this.comboBoxBolum.MaxDropDownItems = 10;
            this.comboBoxBolum.Name = "comboBoxBolum";
            this.comboBoxBolum.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBolum.Sorted = true;
            this.comboBoxBolum.TabIndex = 1;
            this.comboBoxBolum.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doktor Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tarih Seçiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Saat Seçiniz";
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.Location = new System.Drawing.Point(202, 248);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(171, 21);
            this.comboBoxDoktor.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 293);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // comboBoxSaat
            // 
            this.comboBoxSaat.FormattingEnabled = true;
            this.comboBoxSaat.Items.AddRange(new object[] {
            "09:00-10:00",
            "10:00-11:00",
            "11:00-12:00",
            "13:00-14:00",
            "14:00-15:00",
            "15:00-16:00"});
            this.comboBoxSaat.Location = new System.Drawing.Point(202, 333);
            this.comboBoxSaat.Name = "comboBoxSaat";
            this.comboBoxSaat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSaat.TabIndex = 7;
            // 
            // btnRandevuEkle
            // 
            this.btnRandevuEkle.Location = new System.Drawing.Point(202, 394);
            this.btnRandevuEkle.Name = "btnRandevuEkle";
            this.btnRandevuEkle.Size = new System.Drawing.Size(75, 23);
            this.btnRandevuEkle.TabIndex = 8;
            this.btnRandevuEkle.Text = "Ekle";
            this.btnRandevuEkle.UseVisualStyleBackColor = true;
            this.btnRandevuEkle.Click += new System.EventHandler(this.btnRandevuOnay_Click);
            // 
            // textBoxTCKimlikNo
            // 
            this.textBoxTCKimlikNo.Location = new System.Drawing.Point(202, 161);
            this.textBoxTCKimlikNo.Name = "textBoxTCKimlikNo";
            this.textBoxTCKimlikNo.Size = new System.Drawing.Size(121, 20);
            this.textBoxTCKimlikNo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "TCKimlik No giriniz";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(683, 134);
            this.dataGridView1.TabIndex = 11;
            // 
            // hastaKayitDataSetBindingSource
            // 
            this.hastaKayitDataSetBindingSource.DataSource = this.hastaKayitDataSet;
            this.hastaKayitDataSetBindingSource.Position = 0;
            // 
            // hastaKayitDataSet
            // 
            this.hastaKayitDataSet.DataSetName = "hastaKayitDataSet";
            this.hastaKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Randevular:";
            // 
            // btnRandevuGuncelle
            // 
            this.btnRandevuGuncelle.Location = new System.Drawing.Point(307, 394);
            this.btnRandevuGuncelle.Name = "btnRandevuGuncelle";
            this.btnRandevuGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnRandevuGuncelle.TabIndex = 13;
            this.btnRandevuGuncelle.Text = "Güncelle";
            this.btnRandevuGuncelle.UseVisualStyleBackColor = true;
            this.btnRandevuGuncelle.Click += new System.EventHandler(this.btnRandevuGuncelle_Click);
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.Location = new System.Drawing.Point(617, 394);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(75, 23);
            this.btnRandevuSil.TabIndex = 14;
            this.btnRandevuSil.Text = "Sil";
            this.btnRandevuSil.UseVisualStyleBackColor = true;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click);
            // 
            // textBoxRandevuNo
            // 
            this.textBoxRandevuNo.Location = new System.Drawing.Point(571, 336);
            this.textBoxRandevuNo.Name = "textBoxRandevuNo";
            this.textBoxRandevuNo.Size = new System.Drawing.Size(121, 20);
            this.textBoxRandevuNo.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(492, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Randevu No";
            // 
            // hastaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxRandevuNo);
            this.Controls.Add(this.btnRandevuSil);
            this.Controls.Add(this.btnRandevuGuncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTCKimlikNo);
            this.Controls.Add(this.btnRandevuEkle);
            this.Controls.Add(this.comboBoxSaat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxDoktor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxBolum);
            this.Controls.Add(this.label1);
            this.Name = "hastaPanel";
            this.Text = "Hasta Paneli";
            this.Load += new System.EventHandler(this.randevuAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBolum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDoktor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxSaat;
        private System.Windows.Forms.Button btnRandevuEkle;
        private System.Windows.Forms.TextBox textBoxTCKimlikNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hastaKayitDataSetBindingSource;
        private hastaKayitDataSet hastaKayitDataSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRandevuGuncelle;
        private System.Windows.Forms.Button btnRandevuSil;
        private System.Windows.Forms.TextBox textBoxRandevuNo;
        private System.Windows.Forms.Label label7;
    }
}