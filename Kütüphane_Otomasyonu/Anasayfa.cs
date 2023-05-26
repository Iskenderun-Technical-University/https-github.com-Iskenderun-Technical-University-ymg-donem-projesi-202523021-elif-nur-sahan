using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            ÜyeEkleme uyeekle = new ÜyeEkleme();
            uyeekle.ShowDialog();
        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            ÜyeListeleme uyelist = new ÜyeListeleme();
            uyelist.ShowDialog();
        }
    }
}
