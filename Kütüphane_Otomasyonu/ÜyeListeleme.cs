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
    public partial class ÜyeListeleme : Form
    {
        public ÜyeListeleme()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlDataAdapter adtr;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["Tc"].Value.ToString();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VAQ7C88\\SQLEXPRESS;Initial Catalog = KütüphaneOtomasyonu; Integrated Security = True");
        private void textTC_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from ÜyeEkleme where Tc like '"+txtTc.Text+ "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textAdsoyad.Text = read["[Ad Soyad]"].ToString();
                textyas.Text = read["Yaş"].ToString();
                comboCinsiyet.Text = read["Cinsiyet"].ToString();
                textTelefon.Text = read["Telefon"].ToString();
                textAdres.Text = read["Adres"].ToString();
                textMail.Text = read["[E-mail]"].ToString();
                textOkuduguKitapSayısı.Text = read["[Okudugu Kitap Sayısı]"].ToString();


            }
            baglanti.Close();
        }

    
        DataSet daset = new DataSet();
        private void textAraTc_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["ÜyeEkleme"].Clear();
            baglanti.Open();
            string sorgu = "select*from ÜyeEkleme where Tc=@Tc";
            cmd = new SqlCommand(sorgu, baglanti);
            adtr= new SqlDataAdapter(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@Tc",textAraTc.Text);
            adtr.Fill(daset, "ÜyeEkleme");
            dataGridView1.DataSource = daset.Tables["ÜyeEkleme"];
            baglanti.Close();

            /*daset.Tables["ÜyeEkleme"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr=  new SqlDataAdapter("select * from ÜyeEkleme where Tc like '%" + textAraTc.Text + "%'",baglanti);
            adtr.Fill(daset,"ÜyeEkleme");
            dataGridView1.DataSource = daset.Tables["ÜyeEkleme"];
            baglanti.Close();*/
        }

        private void buttonİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "delete  from ÜyeEkleme where Tc=@Tc ";
             cmd= new SqlCommand(sorgu,baglanti);
            cmd.Parameters.AddWithValue("@Tc", dataGridView1.CurrentRow.Cells["Tc"].Value.ToString());
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi gerçekleşti.");
            daset.Tables["ÜyeEkleme"].Clear();
            Üyelisteleme();
            foreach(Control item in Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private  void Üyelisteleme()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from ÜyeEkleme", baglanti);
            adtr.Fill(daset, "ÜyeEkleme");
            dataGridView1.DataSource = daset.Tables["ÜyeEkleme"];
            baglanti.Close();
        }

        private void ÜyeListeleme_Load(object sender, EventArgs e)
        {
            Üyelisteleme();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "update ÜyeEkleme set  [Ad Soyad] = @AdSoyad,Yaş = @Yas, Cinsiyet = @Cinsiyet,Telefon = @Telefon,Adres = @Adres,[E-mail] = @Email,[Okuduğu Kitap Sayısı] = @OkuduguKitapSayısı, Tc = @Tc";
            cmd= new SqlCommand(sorgu,baglanti);
            cmd.Parameters.AddWithValue("@Tc",txtTc.Text);
            cmd.Parameters.AddWithValue("@AdSoyad", textAdsoyad.Text);
            cmd.Parameters.AddWithValue("@Yas", textyas.Text);
            cmd.Parameters.AddWithValue("@Cinsiyet", comboCinsiyet.Text);
            cmd.Parameters.AddWithValue("@Telefon", textTelefon.Text);
            cmd.Parameters.AddWithValue("@Adres", textAdres.Text);
            cmd.Parameters.AddWithValue("@Email", textMail.Text);
            cmd.Parameters.AddWithValue("@OkuduguKitapSayısı",textOkuduguKitapSayısı.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["ÜyeEkleme"].Clear();
            Üyelisteleme();
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
