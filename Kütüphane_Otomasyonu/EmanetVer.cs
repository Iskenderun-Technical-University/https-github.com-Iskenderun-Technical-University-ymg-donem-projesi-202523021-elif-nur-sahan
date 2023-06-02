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
    public partial class EmanetVer : Form
    {
        public EmanetVer()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VAQ7C88\\SQLEXPRESS;Initial Catalog = KütüphaneOtomasyonu; Integrated Security = True");
        DataSet daset = new DataSet();

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adrt = new SqlDataAdapter("select * from sepet", baglanti);
            adrt.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["ÜyeEkleme"];
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("inser into sepet(barkodno,kitapadi,yazari,yayinevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi) values(@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@teslimtarihi,@iadetarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodno);
            komut.Parameters.AddWithValue("@kitapadi", txtKitapAdı);
            komut.Parameters.AddWithValue("@yazari", txtYazarı);
            komut.Parameters.AddWithValue("@yayinevi", txtYayınevi);
            komut.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayısı);
            komut.Parameters.AddWithValue("@kitapsayisi", int.Parse(txtKitapSayısı.Text));
            komut.Parameters.AddWithValue("@teslimtarihi", dateTimePicker1);
            komut.Parameters.AddWithValue("@iadetarihi", dateTimePicker2);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitaplar sepete eklendi.");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            lblKitapSayi.Text = "";
            kitapsayisi();
            foreach (Control item in grpKitapBilgi.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtKitapSayısı)
                    {
                        item.Text = "";
                    }
                }

            }


        }
        private void kitapsayisi()
        {
            baglanti.Open();
            string sorgu = "select sum(kitapsayisi) from sepet";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            lblKitapSayi.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }
        private void EmanetVer_Load(object sender, EventArgs e)
        {
            sepetlistele();
            kitapsayisi();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("selecet *from ÜyeEkleme where tc like '" + txtTcAra.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtYas.Text = read["yas"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(kitapsayisi) from emanetkitaplar", baglanti);
            lblKayıtlıKitapSayisi.Text = komut2. ExecuteScalar().ToString();
            baglanti.Close();
            if (txtTcAra.Text == "")
            {
                foreach (Control item in grpÜyeBilgi.Controls)
                {
                    item.Text = "";
                    lblKayıtlıKitapSayisi.Text = "";
                }
            }
        }

        private void txtBarkodno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from  KitapEkleme  where barkodno like '" + txtBarkodno.Text + "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKitapAdı.Text = read["kitapadi"].ToString();
                txtYazarı.Text = read["yazari"].ToString();
                txtYayınevi.Text = read["yayinevi"].ToString();
                txtSayfaSayısı.Text = read["sayfasayisi"].ToString();

                baglanti.Close();
                foreach (Control item in grpKitapBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtKitapSayısı)
                        {
                            item.Text = "";
                        }
                    }
                }

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno '"+dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+ "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi yapıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            lblKitapSayi.Text = "";
            kitapsayisi();
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (lblKitapSayi.Text!="")
            {
                if (lblKayıtlıKitapSayisi.Text == "" && int.Parse(lblKayıtlıKitapSayisi.Text) <= 3 || lblKayıtlıKitapSayisi.Text != "" && int.Parse(lblKayıtlıKitapSayisi.Text) + int.Parse(lblKayıtlıKitapSayisi.Text)<=3)

                {
                    if (txtTcAra.Text!=""&& txtAdSoyad.Text!=""&& txtYas.Text!=""&& txtTelefon.Text!="")
                    {

                        for (int i=0;i<dataGridView1.Rows.Count-1;i++)
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("insert into emanetkitaplar(tc, adsoyad,yas, telefon ,barkodno,kitapadi, yazari,yayinevi,teslimtarihi,iadetarihi)values(@tc, @adsoyad,@qyas, @telefon ,@barkodno,@kitapadi, @yazari,@yayinevi,@teslimtarihi,@iadetarihi)", baglanti);
                            komut.Parameters.AddWithValue("@btc", txtTcAra);
                            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad);
                            komut.Parameters.AddWithValue("@yas", txtYas);
                            komut.Parameters.AddWithValue("@telefon", txtTelefon);
                            komut.Parameters.AddWithValue("barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                            komut.Parameters.AddWithValue("kitapadi", dataGridView1.Rows[i].Cells["kitapadi"].Value.ToString());
                            komut.Parameters.AddWithValue("yazari", dataGridView1.Rows[i].Cells["yazari"].Value.ToString());
                            komut.Parameters.AddWithValue("yayinevi", dataGridView1.Rows[i].Cells["yayinevi"].Value.ToString());
                            komut.Parameters.AddWithValue("Sayfasayisi", dataGridView1.Rows[i].Cells["sayfasayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("Kitapsayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                            komut.Parameters.AddWithValue("teslimtarihi", dataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());
                            komut.ExecuteNonQuery();
                            SqlCommand komut2 = new SqlCommand("update ÜyeEkleme set Okuduğu Kitap Sayısı=Okuduğu Kitap Sayısı+'" +int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString())+"' where  Tc'" +txtTcAra+"' ", baglanti);
                            komut2.ExecuteNonQuery();
                            SqlCommand komut3 = new SqlCommand("update KitapEkleme stoksayisi=stoksayisi-'" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "' where  barkodno'" +dataGridView1.Rows[i].Cells["barkodno"].Value.ToString()+ "' ", baglanti);
                            komut3.ExecuteNonQuery();
                            baglanti.Close();
                        }
                        baglanti.Open();
                        SqlCommand komut4 = new SqlCommand("delete from sepet", baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kitaplar emanet edildi.");
                        daset.Tables["sepet"].Clear();
                        sepetlistele();
                        txtTcAra.Text="";
                        lblKitapSayi.Text = "";
                        kitapsayisi();
                        lblKayıtlıKitapSayisi.Text = "";
                        //komut satırları olarak belirledim.
                    }
                    else
                    {
                        MessageBox.Show("Önce üye ismini seçmeniz gerekir", "Uyarı");
                    }

                }
                else
                {
                    MessageBox.Show("Emanet kitap sayıs");
                }
            }

            else
            {
                MessageBox.Show("Önce sepete kitap eklemelisiniz...");
            }
        }



           
    }
}
