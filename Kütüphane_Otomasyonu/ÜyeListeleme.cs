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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private const string CmdText = "select * from uye  where TC like  '";
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VAQ7C88\\SQLEXPRESS;Initial Catalog = KütüphaneOtomasyonu; Integrated Security = True");
        private void textTC_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(CmdText ${ txtTCarama.Text +}  var v = "' "; baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {


            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
