using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class KitapEkleme : Form
    {
        public KitapEkleme()
        {
            InitializeComponent();
        } 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VAQ7C88\\SQLEXPRESS;Initial Catalog = KütüphaneOtomasyonu; Integrated Security = True");
        SqlCommand cmd;
        private void KitapEkleme_Load(object sender, EventArgs e)
        {
            
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "insert  into KitapEkleme(barkodno,kitapadi,yazari,yayinevi,sayfasayisi,turu,stoksayisi,rafno,aciklama,kayittarihi)values(@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@turu,@stoksayisi,@rafno,@aciklama,@kayittarihi)";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            cmd.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
            cmd.Parameters.AddWithValue("@yazari", txtYazari.Text);
            cmd.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
            cmd.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayisi.Text);
            cmd.Parameters.AddWithValue("@turu", comboBox1.Text);
            cmd.Parameters.AddWithValue("@stoksayisi", txtStokSayisi.Text);
            cmd.Parameters.AddWithValue("@rafno", txtRafNo.Text);
            cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@kayittarihi", DateTime.Now.ToString());


            cmd.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kitap  kaydı yapıldı.");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {       
                        item.Text = "";                

                }

            }


        }
    }
}
