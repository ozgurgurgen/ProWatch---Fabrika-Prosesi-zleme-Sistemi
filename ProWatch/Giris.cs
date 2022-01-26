using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProWatch
{
    public partial class Giris : Form
    {
        public static string yetki;
        public Giris()
        {
            InitializeComponent();
        }

        private void GirisButonu_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void GirisYap()
        {
            ProWatchEntities db = new ProWatchEntities();

            var sorgu = from kullanici in db.Kullanıcılar
                        where kullanici.KullaniciAdi == KullaniciAdiTextBox.Text && kullanici.Parola == ParolaTextBox.Text
                        select kullanici;
            yetki = sorgu.FirstOrDefault().Yetkisi;
            if (sorgu.Any())
            {
                
                this.Hide();
                new GenelBilgiEkrani().Show();
            }
            else
            {
                MessageBox.Show("Herhangi bir kayıt bulunamadı");
            }
        }

        private void IptalButonu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KullaniciAdiTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GirisYap();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
