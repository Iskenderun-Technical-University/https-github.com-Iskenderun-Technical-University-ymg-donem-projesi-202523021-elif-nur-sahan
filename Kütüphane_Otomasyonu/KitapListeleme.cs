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
    public partial class KitapListeleme : Form
    {
        public KitapListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VAQ7C88\\SQLEXPRESS;Initial Catalog = KütüphaneOtomasyonu; Integrated Security = True");
        DataSet daset = new DataSet();
        SqlCommand cmd;
        SqlDataAdapter adtr;
        private void KitapListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from KitapEkleme", baglanti);
            adtr.Fill(daset, "KitapEkleme");
            dataGridView1.DataSource = daset.Tables["KitapEkleme"];
            baglanti.Close();
        }
        private void KitapListeleme_Load(object sender, EventArgs e)
        {
            KitapListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istiyor musunuz?", "SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                string var = "delete  from KitapEkleme where barkodno=@barkodno ";
                cmd = new SqlCommand(var, baglanti);
                cmd.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkod"].Value.ToString());
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi gerçekleşti.");
                daset.Tables["KitapEkleme"].Clear();
                KitapListele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "update KitapEkleme set kitapadi = @kitapadi,yazari = @yazari,yayinevi= @yayinevi,sayfasayisi= @sayfasayisi,turu= @turu,stoksayisi= @stoksayisi,rafno= @rafno,aciklama= @aciklama where barkodno=@barkodno";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            cmd.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
            cmd.Parameters.AddWithValue("@yazari",txtYazari.Text);
            cmd.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
            cmd.Parameters.AddWithValue("@Csayfasayisi", txtSayfaSayisi.Text);
            cmd.Parameters.AddWithValue("@turu", comboBox1.Text);
            cmd.Parameters.AddWithValue("@stoksayisi", txtStokSayisi.Text);
            cmd.Parameters.AddWithValue("@rafno", txtRafNo.Text);
            cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi geröekleşti");
            daset.Tables["KitapEkleme"].Clear();
            KitapListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {

            daset.Tables["KitapEkleme"].Clear();
            baglanti.Open();
            string sorgu = "select*from KitapEkleme where barkodno=@barkodno";
            cmd = new SqlCommand(sorgu, baglanti);
            adtr = new SqlDataAdapter(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            adtr.Fill(daset, "KitapEkleme");
            dataGridView1.DataSource = daset.Tables["KitapEkleme"];
            baglanti.Close();

        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KitapEkleme where barkodno like '" + txtBarkodAra.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKitapAdi.Text = read["kitapadi"].ToString();
                txtYazari.Text = read["yazari"].ToString();
                txtYayinevi.Text = read["yayinevi"].ToString();
                txtSayfaSayisi.Text = read["sayfasayisi"].ToString();
                comboBox1.Text = read["turu"].ToString();
                txtStokSayisi.Text = read["stoksayisi"].ToString();
                txtRafNo.Text = read["rafno"].ToString();
                txtAciklama.Text = read["aciklama"].ToString();



            }
            baglanti.Close();
        }
    }
}
