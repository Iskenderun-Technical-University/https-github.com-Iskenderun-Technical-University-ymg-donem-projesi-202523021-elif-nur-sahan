using System;
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
         SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VAQ7C88\\SQLEXPRESS;Initial Catalog = KütüphaneOtomasyonu; Integrated Security = True");
        SqlCommand cmd;

        private void ÜyeEkleme_Load(object sender, EventArgs e)
        {

        }
        private void buttonÜyeEKle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu= "insert  into ÜyeEkleme(Tc, [Ad Soyad],Yaş,Cinsiyet,Telefon,Adres,[E-mail],[Okuduğu Kitap Sayısı])values(@Tc,@AdSoyad,@Yas,@Cinsiyet,@Telefon,@Adres,@Email,@OkuduğuKitapSayısı)";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@Tc", txtTc.Text);
            cmd.Parameters.AddWithValue("@AdSoyad", textAdsoyad.Text);
            cmd.Parameters.AddWithValue("@Yas", textyas.Text);
            cmd.Parameters.AddWithValue("@Cinsiyet", comboCinsiyet.Text);
            cmd.Parameters.AddWithValue("@Telefon", textTelefon.Text);
            cmd.Parameters.AddWithValue("@Adres", textAdres.Text);
            cmd.Parameters.AddWithValue("@Email", textMail.Text);
            cmd.Parameters.AddWithValue("@OkuduğuKitapSayısı", textOkuduguKitapSayısı.Text);
           
            cmd.ExecuteNonQuery();
          
            baglanti.Close();
            MessageBox.Show("Üye kaydı yapıldı.");
            foreach(Control item in Controls)
            {
                if (item is TextBox)
                {
                    if( item!= textOkuduguKitapSayısı)
                    {
                        item.Text = "";
                    }
                    
                }

            }


        }
        private void buttonİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
