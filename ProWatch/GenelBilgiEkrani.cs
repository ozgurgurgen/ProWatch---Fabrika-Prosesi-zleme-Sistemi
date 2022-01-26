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
    public partial class GenelBilgiEkrani : Form
    {
        string stringSonuc;
        bool messageBoxShowed;
        DialogResult cevap;

        public GenelBilgiEkrani()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void FormGuncelle()
        {
            ProWatchEntities db = new ProWatchEntities();
            var sorgu = from durum in db.Durumlar
                        where durum.DurusBitisZamani == null
                        select durum;
            var sonuc = sorgu.FirstOrDefault();
            MakineAdıLB.Text = sonuc.Makineler.MakineAd;
            OperatorAdıLB.Text = sonuc.Operatorler.OperatorAd;
            DurumLB.Text = sonuc.DurusTurleri.DurusAdı;
            TeknikerLB.Text = sonuc.TeknikerId == null ? "" : sonuc.Teknikerler.TeknikerAd;
            var tarih = Convert.ToDateTime(sonuc.DurusBaslamaZamani);
            SureLB.Text = DurusSuresi(tarih);

            switch (sonuc.DurumTuruId)
            {
                case 1:
                    Makine1.BackColor = Color.Green;
                    Makine1.ForeColor = Color.White;
                    break;
                case 2:
                    Makine1.BackColor = Color.DeepSkyBlue;
                    Makine1.ForeColor = Color.White;
                    break;
                case 3:
                    Makine1.BackColor = Color.DarkGray;
                    Makine1.ForeColor = Color.White;
                    break;
                case 4:
                    Makine1.BackColor = Color.RosyBrown;
                    Makine1.ForeColor = Color.White;
                    break;
                default:
                    break;
            }

        }

        private string DurusSuresi(DateTime time)
        {
            if (!(time.Year < 22))
            {
                var sure = DateTime.Now.Subtract(time);
                var saat = (byte)sure.Hours;
                var dakika = (byte)sure.TotalMinutes % 60;
                stringSonuc = saat > 0 ? saat + " Saat " + dakika + " Dakika" : dakika + " Dakika";
            }
            else
            {
                stringSonuc = "Bekleniyor";
            }
            return stringSonuc;
        }

        private void ArizaOnay()
        {
            ProWatchEntities db = new ProWatchEntities();
            var sorgu = from durum in db.Durumlar
                        where durum.DurusBaslamaZamani == null
                        select durum;
            var durums = sorgu.FirstOrDefault();
            if (sorgu.Any() && !messageBoxShowed)
            {
                var arızaNedeni = durums.DurusNedeni;
                var operatorAd = durums.Operatorler.OperatorAd;
                var makineAdı = durums.Makineler.MakineAd;
                if (durums.DurumTuruId == 2 && Giris.yetki == "Eloto")
                {
                    messageBoxShowed = true;
                    cevap = MessageBox.Show($"{makineAdı} adlı makinede '{arızaNedeni}' nedenli arıza Opr. {operatorAd} tarafından sisteme giriş yapılmıştır. Onaylıyor musunuz?",
                        "Arıza Bildirimi", MessageBoxButtons.YesNo);
                    TeknikerGiris(db, durums.Id);
                }
                else if(durums.DurumTuruId == 3 && Giris.yetki == "Mekanik")
                {
                    messageBoxShowed = true;
                    cevap = MessageBox.Show($"{makineAdı} adlı makinede '{arızaNedeni}' nedenli arıza Opr. {operatorAd} tarafından sisteme giriş yapılmıştır. Onaylıyor musunuz?",
                        "Arıza Bildirimi", MessageBoxButtons.YesNo);
                    TeknikerGiris(db, durums.Id);
                }
                if (cevap == DialogResult.Yes)
                {
                    messageBoxShowed = false;
                }
            }
        }
        private void TeknikerGiris(ProWatchEntities db, int id)
        {
            Durumlar durum = db.Durumlar.Find(id);
            string teknikerSicil = Microsoft.VisualBasic.Interaction.InputBox("Tekniker Şifrenizi Yazınız.", "Tekniker Girişi");
            byte sicil = Convert.ToByte(teknikerSicil);
            var tekniker = from teknikers in db.Teknikerler
                           where teknikers.TeknikerSicil == sicil
                           select teknikers;
            durum.TeknikerId = tekniker.FirstOrDefault().Id;
            durum.DurusBaslamaZamani = DateTime.Now.ToString();
            db.SaveChanges();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FormGuncelle();
            ArizaOnay();
        }

        private void GenelBilgiEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
