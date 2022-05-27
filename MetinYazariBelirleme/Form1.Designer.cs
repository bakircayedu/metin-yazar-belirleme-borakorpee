namespace MetinYazariBelirleme
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dosyaSec = new System.Windows.Forms.Button();
            this.fileNameTXT = new System.Windows.Forms.TextBox();
            this.filePathTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dosyaOku = new System.Windows.Forms.Button();
            this.metinIcerikTXT = new System.Windows.Forms.TextBox();
            this.agacaAktar = new System.Windows.Forms.Button();
            this.kelimeTXT = new System.Windows.Forms.TextBox();
            this.enSikKullanilanKelimeler = new System.Windows.Forms.Button();
            this.kelimeSayisiTXT = new System.Windows.Forms.TextBox();
            this.enSikKullanilanKelimelerTXT = new System.Windows.Forms.TextBox();
            this.hashOlusturBTN = new System.Windows.Forms.Button();
            this.hashTableTXT = new System.Windows.Forms.TextBox();
            this.uyari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dosyaSec
            // 
            this.dosyaSec.Location = new System.Drawing.Point(12, 2);
            this.dosyaSec.Name = "dosyaSec";
            this.dosyaSec.Size = new System.Drawing.Size(75, 23);
            this.dosyaSec.TabIndex = 0;
            this.dosyaSec.Text = "Dosya Seç";
            this.dosyaSec.UseVisualStyleBackColor = true;
            this.dosyaSec.Click += new System.EventHandler(this.dosyaSec_Click);
            // 
            // fileNameTXT
            // 
            this.fileNameTXT.Location = new System.Drawing.Point(137, 25);
            this.fileNameTXT.Name = "fileNameTXT";
            this.fileNameTXT.ReadOnly = true;
            this.fileNameTXT.Size = new System.Drawing.Size(100, 20);
            this.fileNameTXT.TabIndex = 1;
            // 
            // filePathTXT
            // 
            this.filePathTXT.Location = new System.Drawing.Point(137, 51);
            this.filePathTXT.Name = "filePathTXT";
            this.filePathTXT.ReadOnly = true;
            this.filePathTXT.Size = new System.Drawing.Size(100, 20);
            this.filePathTXT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seçilen Dosyanın Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seçilen Dosayanın Yolu";
            // 
            // dosyaOku
            // 
            this.dosyaOku.Enabled = false;
            this.dosyaOku.Location = new System.Drawing.Point(15, 80);
            this.dosyaOku.Name = "dosyaOku";
            this.dosyaOku.Size = new System.Drawing.Size(75, 23);
            this.dosyaOku.TabIndex = 5;
            this.dosyaOku.Text = "Dosyayı Oku";
            this.dosyaOku.UseVisualStyleBackColor = true;
            this.dosyaOku.Click += new System.EventHandler(this.dosyaOku_Click);
            // 
            // metinIcerikTXT
            // 
            this.metinIcerikTXT.BackColor = System.Drawing.SystemColors.Window;
            this.metinIcerikTXT.Location = new System.Drawing.Point(12, 128);
            this.metinIcerikTXT.Multiline = true;
            this.metinIcerikTXT.Name = "metinIcerikTXT";
            this.metinIcerikTXT.ReadOnly = true;
            this.metinIcerikTXT.Size = new System.Drawing.Size(200, 49);
            this.metinIcerikTXT.TabIndex = 6;
            // 
            // agacaAktar
            // 
            this.agacaAktar.Enabled = false;
            this.agacaAktar.Location = new System.Drawing.Point(137, 80);
            this.agacaAktar.Name = "agacaAktar";
            this.agacaAktar.Size = new System.Drawing.Size(75, 23);
            this.agacaAktar.TabIndex = 7;
            this.agacaAktar.Text = "Ağaca Aktar";
            this.agacaAktar.UseVisualStyleBackColor = true;
            this.agacaAktar.Click += new System.EventHandler(this.agacaAktar_Click);
            // 
            // kelimeTXT
            // 
            this.kelimeTXT.BackColor = System.Drawing.SystemColors.Window;
            this.kelimeTXT.Location = new System.Drawing.Point(648, 7);
            this.kelimeTXT.Multiline = true;
            this.kelimeTXT.Name = "kelimeTXT";
            this.kelimeTXT.ReadOnly = true;
            this.kelimeTXT.Size = new System.Drawing.Size(147, 90);
            this.kelimeTXT.TabIndex = 9;
            this.kelimeTXT.WordWrap = false;
            // 
            // enSikKullanilanKelimeler
            // 
            this.enSikKullanilanKelimeler.Enabled = false;
            this.enSikKullanilanKelimeler.Location = new System.Drawing.Point(254, 299);
            this.enSikKullanilanKelimeler.Name = "enSikKullanilanKelimeler";
            this.enSikKullanilanKelimeler.Size = new System.Drawing.Size(205, 23);
            this.enSikKullanilanKelimeler.TabIndex = 10;
            this.enSikKullanilanKelimeler.Text = "En Sık Kullanılan Kelimeleri Getir";
            this.enSikKullanilanKelimeler.UseVisualStyleBackColor = true;
            this.enSikKullanilanKelimeler.Click += new System.EventHandler(this.enSikKullanilanKelimeler_Click);
            // 
            // kelimeSayisiTXT
            // 
            this.kelimeSayisiTXT.Location = new System.Drawing.Point(465, 301);
            this.kelimeSayisiTXT.Name = "kelimeSayisiTXT";
            this.kelimeSayisiTXT.Size = new System.Drawing.Size(19, 20);
            this.kelimeSayisiTXT.TabIndex = 11;
            // 
            // enSikKullanilanKelimelerTXT
            // 
            this.enSikKullanilanKelimelerTXT.BackColor = System.Drawing.SystemColors.Window;
            this.enSikKullanilanKelimelerTXT.Location = new System.Drawing.Point(254, 328);
            this.enSikKullanilanKelimelerTXT.Multiline = true;
            this.enSikKullanilanKelimelerTXT.Name = "enSikKullanilanKelimelerTXT";
            this.enSikKullanilanKelimelerTXT.ReadOnly = true;
            this.enSikKullanilanKelimelerTXT.Size = new System.Drawing.Size(372, 20);
            this.enSikKullanilanKelimelerTXT.TabIndex = 12;
            // 
            // hashOlusturBTN
            // 
            this.hashOlusturBTN.Enabled = false;
            this.hashOlusturBTN.Location = new System.Drawing.Point(266, 78);
            this.hashOlusturBTN.Name = "hashOlusturBTN";
            this.hashOlusturBTN.Size = new System.Drawing.Size(259, 23);
            this.hashOlusturBTN.TabIndex = 13;
            this.hashOlusturBTN.Text = "Hash Tablosu Oluştur";
            this.hashOlusturBTN.UseVisualStyleBackColor = true;
            this.hashOlusturBTN.Click += new System.EventHandler(this.hashOlusturBTN_Click);
            // 
            // hashTableTXT
            // 
            this.hashTableTXT.BackColor = System.Drawing.SystemColors.Window;
            this.hashTableTXT.Location = new System.Drawing.Point(254, 138);
            this.hashTableTXT.Multiline = true;
            this.hashTableTXT.Name = "hashTableTXT";
            this.hashTableTXT.ReadOnly = true;
            this.hashTableTXT.Size = new System.Drawing.Size(372, 153);
            this.hashTableTXT.TabIndex = 14;
            // 
            // uyari
            // 
            this.uyari.AutoSize = true;
            this.uyari.Location = new System.Drawing.Point(263, 106);
            this.uyari.Name = "uyari";
            this.uyari.Size = new System.Drawing.Size(311, 26);
            this.uyari.TabIndex = 15;
            this.uyari.Text = "Hash tablosu kelimelerin cümledeki sayısına göre değil kelimenin \r\nuzunluğuna gör" +
    "e oluşturulmuştur.";
            this.uyari.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uyari);
            this.Controls.Add(this.hashTableTXT);
            this.Controls.Add(this.hashOlusturBTN);
            this.Controls.Add(this.enSikKullanilanKelimelerTXT);
            this.Controls.Add(this.kelimeSayisiTXT);
            this.Controls.Add(this.enSikKullanilanKelimeler);
            this.Controls.Add(this.kelimeTXT);
            this.Controls.Add(this.agacaAktar);
            this.Controls.Add(this.metinIcerikTXT);
            this.Controls.Add(this.dosyaOku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathTXT);
            this.Controls.Add(this.fileNameTXT);
            this.Controls.Add(this.dosyaSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button dosyaSec;
        private System.Windows.Forms.TextBox fileNameTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filePathTXT;
        private System.Windows.Forms.Button dosyaOku;
        private System.Windows.Forms.TextBox metinIcerikTXT;
        private System.Windows.Forms.Button agacaAktar;
        private System.Windows.Forms.Button enSikKullanilanKelimeler;
        private System.Windows.Forms.TextBox kelimeSayisiTXT;
        public System.Windows.Forms.TextBox kelimeTXT;
        public System.Windows.Forms.TextBox enSikKullanilanKelimelerTXT;
        private System.Windows.Forms.Button hashOlusturBTN;
        public System.Windows.Forms.TextBox hashTableTXT;
        private System.Windows.Forms.Label uyari;
    }
}

