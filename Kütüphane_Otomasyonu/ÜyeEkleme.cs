﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kütüphane_Otomasyonu
{
    public partial class ÜyeEkleme : Form
    {
        public ÜyeEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti= new SqlConnection("Data Source=DESKTOP-VAQ7C88\SQLEXPRESS;Initial Catalog = KütüphaneOtomasyonu; Integrated Security = True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ÜyeEkleme_Load(object sender, EventArgs e)
        {

        }
        private void buttonÜyeEKle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert  into ÜyeEkleme(Tc,Ad-Soyad,Yas,Cinsiyet,Telefon,Adres,E-mail,Okudugu Kitap Sayısı)values(@Tc,@Ad-Soyad,@Yas,@Cinsiyet,@Telefon,@Adres,@E-mail,@Okudugu Kitap Sayısı)", baglanti);
            komut.Parameters.AddWithValue("@tc", textTC);
            komut.Parameters.AddWithValue("@Ad-Soyad", textAdsoyad);


        }
        private void buttonİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
