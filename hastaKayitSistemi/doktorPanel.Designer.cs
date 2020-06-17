namespace hastaKayitSistemi
{
    partial class doktorPanel
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnRandevuListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hastaKayitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaKayitDataSet = new hastaKayitSistemi.hastaKayitDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRaporOlustur = new System.Windows.Forms.Button();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih Seç:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btnRandevuListele
            // 
            this.btnRandevuListele.Location = new System.Drawing.Point(280, 47);
            this.btnRandevuListele.Name = "btnRandevuListele";
            this.btnRandevuListele.Size = new System.Drawing.Size(75, 23);
            this.btnRandevuListele.TabIndex = 2;
            this.btnRandevuListele.Text = "Listele";
            this.btnRandevuListele.UseVisualStyleBackColor = true;
            this.btnRandevuListele.Click += new System.EventHandler(this.btnRandevuListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 301);
            this.dataGridView1.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Randevular:";
            // 
            // btnRaporOlustur
            // 
            this.btnRaporOlustur.Location = new System.Drawing.Point(692, 48);
            this.btnRaporOlustur.Name = "btnRaporOlustur";
            this.btnRaporOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnRaporOlustur.TabIndex = 5;
            this.btnRaporOlustur.Text = "Rapor Yaz";
            this.btnRaporOlustur.UseVisualStyleBackColor = true;
            this.btnRaporOlustur.Click += new System.EventHandler(this.btnRaporOlustur_Click);
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.Location = new System.Drawing.Point(577, 48);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(75, 23);
            this.btnRandevuSil.TabIndex = 6;
            this.btnRandevuSil.Text = "Sil";
            this.btnRandevuSil.UseVisualStyleBackColor = true;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(471, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Randevu No:";
            // 
            // doktorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRandevuSil);
            this.Controls.Add(this.btnRaporOlustur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRandevuListele);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "doktorPanel";
            this.Text = "doktorPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRandevuListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hastaKayitDataSetBindingSource;
        private hastaKayitDataSet hastaKayitDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRaporOlustur;
        private System.Windows.Forms.Button btnRandevuSil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}