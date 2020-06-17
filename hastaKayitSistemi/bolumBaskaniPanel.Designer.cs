namespace hastaKayitSistemi
{
    partial class bolumBaskaniPanel
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnRandevuGoruntule = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.hastaKayitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaKayitDataSet = new hastaKayitSistemi.hastaKayitDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRandevuSil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.btnRaporGoruntule = new System.Windows.Forms.Button();
            this.btnRaporYaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doktor Seç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih Seç:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnRandevuGoruntule
            // 
            this.btnRandevuGoruntule.Location = new System.Drawing.Point(279, 71);
            this.btnRandevuGoruntule.Name = "btnRandevuGoruntule";
            this.btnRandevuGoruntule.Size = new System.Drawing.Size(75, 23);
            this.btnRandevuGoruntule.TabIndex = 4;
            this.btnRandevuGoruntule.Text = "Görüntüle";
            this.btnRandevuGoruntule.UseVisualStyleBackColor = true;
            this.btnRandevuGoruntule.Click += new System.EventHandler(this.btnRandevuGoruntule_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(74, 103);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(714, 335);
            this.dataGridView2.TabIndex = 5;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Randevular:";
            // 
            // textBoxRandevuSil
            // 
            this.textBoxRandevuSil.Location = new System.Drawing.Point(539, 25);
            this.textBoxRandevuSil.Name = "textBoxRandevuSil";
            this.textBoxRandevuSil.Size = new System.Drawing.Size(100, 20);
            this.textBoxRandevuSil.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Randevu No:";
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.Location = new System.Drawing.Point(465, 69);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(75, 23);
            this.btnRandevuSil.TabIndex = 9;
            this.btnRandevuSil.Text = "Sil";
            this.btnRandevuSil.UseVisualStyleBackColor = true;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click);
            // 
            // btnRaporGoruntule
            // 
            this.btnRaporGoruntule.Location = new System.Drawing.Point(546, 69);
            this.btnRaporGoruntule.Name = "btnRaporGoruntule";
            this.btnRaporGoruntule.Size = new System.Drawing.Size(96, 23);
            this.btnRaporGoruntule.TabIndex = 10;
            this.btnRaporGoruntule.Text = "Rapor Görüntüle";
            this.btnRaporGoruntule.UseVisualStyleBackColor = true;
            this.btnRaporGoruntule.Click += new System.EventHandler(this.btnRaporGoruntule_Click);
            // 
            // btnRaporYaz
            // 
            this.btnRaporYaz.Location = new System.Drawing.Point(648, 69);
            this.btnRaporYaz.Name = "btnRaporYaz";
            this.btnRaporYaz.Size = new System.Drawing.Size(96, 23);
            this.btnRaporYaz.TabIndex = 11;
            this.btnRaporYaz.Text = "Rapor Yaz";
            this.btnRaporYaz.UseVisualStyleBackColor = true;
            this.btnRaporYaz.Click += new System.EventHandler(this.btnRaporYaz_Click);
            // 
            // bolumBaskaniPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRaporYaz);
            this.Controls.Add(this.btnRaporGoruntule);
            this.Controls.Add(this.btnRandevuSil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRandevuSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnRandevuGoruntule);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "bolumBaskaniPanel";
            this.Text = "bolumBaskaniPanel";
            this.Load += new System.EventHandler(this.bolumBaskaniPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRandevuGoruntule;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource hastaKayitDataSetBindingSource;
        private hastaKayitDataSet hastaKayitDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRandevuSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRandevuSil;
        private System.Windows.Forms.Button btnRaporGoruntule;
        private System.Windows.Forms.Button btnRaporYaz;
    }
}