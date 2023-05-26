
namespace Kütüphane_Otomasyonu
{
    partial class ÜyeListeleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonİptal = new System.Windows.Forms.Button();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.comboCinsiyet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textOkuduguKitapSayısı = new System.Windows.Forms.TextBox();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textAdres = new System.Windows.Forms.TextBox();
            this.textTelefon = new System.Windows.Forms.TextBox();
            this.textyas = new System.Windows.Forms.TextBox();
            this.textAdsoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.textAraTc = new System.Windows.Forms.TextBox();
            this.txtTcarama = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(488, 319);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonİptal
            // 
            this.buttonİptal.Location = new System.Drawing.Point(223, 424);
            this.buttonİptal.Name = "buttonİptal";
            this.buttonİptal.Size = new System.Drawing.Size(75, 23);
            this.buttonİptal.TabIndex = 38;
            this.buttonİptal.Text = "İptal";
            this.buttonİptal.UseVisualStyleBackColor = true;
            this.buttonİptal.Click += new System.EventHandler(this.buttonİptal_Click);
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.Location = new System.Drawing.Point(99, 424);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(75, 23);
            this.buttonGüncelle.TabIndex = 37;
            this.buttonGüncelle.Text = "Güncelle";
            this.buttonGüncelle.UseVisualStyleBackColor = true;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // comboCinsiyet
            // 
            this.comboCinsiyet.FormattingEnabled = true;
            this.comboCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.comboCinsiyet.Location = new System.Drawing.Point(186, 199);
            this.comboCinsiyet.Name = "comboCinsiyet";
            this.comboCinsiyet.Size = new System.Drawing.Size(121, 24);
            this.comboCinsiyet.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Okuduğu kitap sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "E-Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Yaş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ad-Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tc";
            // 
            // textOkuduguKitapSayısı
            // 
            this.textOkuduguKitapSayısı.Location = new System.Drawing.Point(186, 378);
            this.textOkuduguKitapSayısı.Name = "textOkuduguKitapSayısı";
            this.textOkuduguKitapSayısı.Size = new System.Drawing.Size(121, 22);
            this.textOkuduguKitapSayısı.TabIndex = 27;
            this.textOkuduguKitapSayısı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(186, 337);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(121, 22);
            this.textMail.TabIndex = 26;
            // 
            // textAdres
            // 
            this.textAdres.Location = new System.Drawing.Point(186, 289);
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(121, 22);
            this.textAdres.TabIndex = 25;
            // 
            // textTelefon
            // 
            this.textTelefon.Location = new System.Drawing.Point(186, 240);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(121, 22);
            this.textTelefon.TabIndex = 24;
            // 
            // textyas
            // 
            this.textyas.Location = new System.Drawing.Point(186, 154);
            this.textyas.Name = "textyas";
            this.textyas.Size = new System.Drawing.Size(121, 22);
            this.textyas.TabIndex = 23;
            // 
            // textAdsoyad
            // 
            this.textAdsoyad.Location = new System.Drawing.Point(186, 116);
            this.textAdsoyad.Name = "textAdsoyad";
            this.textAdsoyad.Size = new System.Drawing.Size(121, 22);
            this.textAdsoyad.TabIndex = 22;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(186, 78);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(121, 22);
            this.txtTc.TabIndex = 21;
            this.txtTc.TextChanged += new System.EventHandler(this.textTC_TextChanged);
            // 
            // textAraTc
            // 
            this.textAraTc.Location = new System.Drawing.Point(499, 47);
            this.textAraTc.Name = "textAraTc";
            this.textAraTc.Size = new System.Drawing.Size(121, 22);
            this.textAraTc.TabIndex = 39;
            this.textAraTc.TextChanged += new System.EventHandler(this.textAraTc_TextChanged);
            // 
            // txtTcarama
            // 
            this.txtTcarama.AutoSize = true;
            this.txtTcarama.Location = new System.Drawing.Point(405, 47);
            this.txtTcarama.Name = "txtTcarama";
            this.txtTcarama.Size = new System.Drawing.Size(75, 17);
            this.txtTcarama.TabIndex = 40;
            this.txtTcarama.Text = "T.C Arama";
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(831, 81);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 41;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // ÜyeListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 499);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.txtTcarama);
            this.Controls.Add(this.textAraTc);
            this.Controls.Add(this.buttonİptal);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.comboCinsiyet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textOkuduguKitapSayısı);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.textAdres);
            this.Controls.Add(this.textTelefon);
            this.Controls.Add(this.textyas);
            this.Controls.Add(this.textAdsoyad);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ÜyeListeleme";
            this.Text = "ÜyeListeleme";
            this.Load += new System.EventHandler(this.ÜyeListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonİptal;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.ComboBox comboCinsiyet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOkuduguKitapSayısı;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textAdres;
        private System.Windows.Forms.TextBox textTelefon;
        private System.Windows.Forms.TextBox textyas;
        private System.Windows.Forms.TextBox textAdsoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox textAraTc;
        private System.Windows.Forms.Label txtTcarama;
        private System.Windows.Forms.Button btnsil;
    }
}