namespace hastaKayitSistemi
{
    partial class bashekimPanel
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnRandevuListeleBashekim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hastaKayitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaKayitDataSet = new hastaKayitSistemi.hastaKayitDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.btnRaporGoruntule = new System.Windows.Forms.Button();
            this.textBoxrandevuNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm Seç:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(77, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doktor Seç:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(77, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarih Seç:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnRandevuListeleBashekim
            // 
            this.btnRandevuListeleBashekim.Location = new System.Drawing.Point(283, 86);
            this.btnRandevuListeleBashekim.Name = "btnRandevuListeleBashekim";
            this.btnRandevuListeleBashekim.Size = new System.Drawing.Size(75, 23);
            this.btnRandevuListeleBashekim.TabIndex = 6;
            this.btnRandevuListeleBashekim.Text = "Listele";
            this.btnRandevuListeleBashekim.UseVisualStyleBackColor = true;
            this.btnRandevuListeleBashekim.Click += new System.EventHandler(this.btnRandevuListeleBashekim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 320);
            this.dataGridView1.TabIndex = 7;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Randevular:";
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.Location = new System.Drawing.Point(591, 86);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(75, 23);
            this.btnRandevuSil.TabIndex = 9;
            this.btnRandevuSil.Text = "Sil";
            this.btnRandevuSil.UseVisualStyleBackColor = true;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click);
            // 
            // btnRaporGoruntule
            // 
            this.btnRaporGoruntule.Location = new System.Drawing.Point(693, 86);
            this.btnRaporGoruntule.Name = "btnRaporGoruntule";
            this.btnRaporGoruntule.Size = new System.Drawing.Size(95, 23);
            this.btnRaporGoruntule.TabIndex = 10;
            this.btnRaporGoruntule.Text = "Rapor Görüntüle";
            this.btnRaporGoruntule.UseVisualStyleBackColor = true;
            this.btnRaporGoruntule.Click += new System.EventHandler(this.btnRaporGoruntule_Click);
            // 
            // textBoxrandevuNo
            // 
            this.textBoxrandevuNo.Location = new System.Drawing.Point(485, 87);
            this.textBoxrandevuNo.Name = "textBoxrandevuNo";
            this.textBoxrandevuNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxrandevuNo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Randevu No";
            // 
            // bashekimPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxrandevuNo);
            this.Controls.Add(this.btnRaporGoruntule);
            this.Controls.Add(this.btnRandevuSil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRandevuListeleBashekim);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "bashekimPanel";
            this.Text = "bashekimPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRandevuListeleBashekim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hastaKayitDataSetBindingSource;
        private hastaKayitDataSet hastaKayitDataSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRandevuSil;
        private System.Windows.Forms.Button btnRaporGoruntule;
        private System.Windows.Forms.TextBox textBoxrandevuNo;
        private System.Windows.Forms.Label label5;
    }
}