
namespace Kütüphane_Otomasyonu
{
    partial class Anasayfa
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
            this.btnUyeEkleme = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUyeListele = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKitapİade = new System.Windows.Forms.Button();
            this.btnKitapİşlemleri = new System.Windows.Forms.Button();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnSıralama = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUyeEkleme
            // 
            this.btnUyeEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeEkleme.Location = new System.Drawing.Point(40, 34);
            this.btnUyeEkleme.Name = "btnUyeEkleme";
            this.btnUyeEkleme.Size = new System.Drawing.Size(217, 35);
            this.btnUyeEkleme.TabIndex = 0;
            this.btnUyeEkleme.Text = "Üye Ekleme İşlemeri";
            this.btnUyeEkleme.UseVisualStyleBackColor = true;
            this.btnUyeEkleme.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUyeListele);
            this.groupBox1.Controls.Add(this.btnUyeEkleme);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(56, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            // 
            // btnUyeListele
            // 
            this.btnUyeListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeListele.Location = new System.Drawing.Point(40, 75);
            this.btnUyeListele.Name = "btnUyeListele";
            this.btnUyeListele.Size = new System.Drawing.Size(217, 38);
            this.btnUyeListele.TabIndex = 5;
            this.btnUyeListele.Text = "Üye Listeleme İşlemleri";
            this.btnUyeListele.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKitapListele);
            this.groupBox2.Controls.Add(this.btnKitapEkle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(422, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 129);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapListele.Location = new System.Drawing.Point(43, 75);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(181, 38);
            this.btnKitapListele.TabIndex = 1;
            this.btnKitapListele.Text = "Kitap Listeleme İşlemleri";
            this.btnKitapListele.UseVisualStyleBackColor = true;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.Location = new System.Drawing.Point(43, 34);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(181, 35);
            this.btnKitapEkle.TabIndex = 0;
            this.btnKitapEkle.Text = "Kitap Ekleme İşlemleri";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKitapİade);
            this.groupBox3.Controls.Add(this.btnKitapİşlemleri);
            this.groupBox3.Controls.Add(this.btnEmanetVer);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(56, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 174);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Kitap İşlemler";
            // 
            // btnKitapİade
            // 
            this.btnKitapİade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapİade.Location = new System.Drawing.Point(28, 111);
            this.btnKitapİade.Name = "btnKitapİade";
            this.btnKitapİade.Size = new System.Drawing.Size(229, 29);
            this.btnKitapİade.TabIndex = 2;
            this.btnKitapİade.Text = "Emanet Kitap İade İşlemleri";
            this.btnKitapİade.UseVisualStyleBackColor = true;
            // 
            // btnKitapİşlemleri
            // 
            this.btnKitapİşlemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapİşlemleri.Location = new System.Drawing.Point(28, 68);
            this.btnKitapİşlemleri.Name = "btnKitapİşlemleri";
            this.btnKitapİşlemleri.Size = new System.Drawing.Size(229, 37);
            this.btnKitapİşlemleri.TabIndex = 1;
            this.btnKitapİşlemleri.Text = "Emanet Kitap Listeleme İşlemleri";
            this.btnKitapİşlemleri.UseVisualStyleBackColor = true;
            this.btnKitapİşlemleri.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetVer.Location = new System.Drawing.Point(28, 35);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(229, 27);
            this.btnEmanetVer.TabIndex = 0;
            this.btnEmanetVer.Text = "Emanet Kitap İşlemleri";
            this.btnEmanetVer.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGrafik);
            this.groupBox4.Controls.Add(this.btnSıralama);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(422, 236);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 173);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralama ve Grafikler";
            // 
            // btnGrafik
            // 
            this.btnGrafik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGrafik.Location = new System.Drawing.Point(29, 90);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(195, 40);
            this.btnGrafik.TabIndex = 1;
            this.btnGrafik.Text = "Grafik";
            this.btnGrafik.UseVisualStyleBackColor = true;
            // 
            // btnSıralama
            // 
            this.btnSıralama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSıralama.Location = new System.Drawing.Point(29, 35);
            this.btnSıralama.Name = "btnSıralama";
            this.btnSıralama.Size = new System.Drawing.Size(195, 27);
            this.btnSıralama.TabIndex = 0;
            this.btnSıralama.Text = "Sıralama";
            this.btnSıralama.UseVisualStyleBackColor = true;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Anasayfa";
            this.Text = "Ana Sayfa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       private System.Windows.Forms.Button btnUyeEkleme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUyeListele;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnKitapİade;
        private System.Windows.Forms.Button btnKitapİşlemleri;
        private System.Windows.Forms.Button btnEmanetVer;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnSıralama;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}

