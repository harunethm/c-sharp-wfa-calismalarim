using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayiTahmin2Kisilik
{
    public partial class formAnaEkran : Form
    {
        public formAnaEkran()
        {
            InitializeComponent();
        }
        String isimP1 = "Oyuncu 1";
        String isimP2 = "Oyuncu 2";

        int puanP1 = 0;
        int puanP2 = 0;

        Boolean aktifOyuncu = false;

        int hamleSayisi = 0;
        int hamleSuresi = 0;

        int kalanSure = 0;
        int kalanHamleSayisi = 0;

        public static int tahminEdilecekSayi = 0000;

        bool oyun = false;

        public formAnaEkran(String isimP1, String isimP2, int hamleSayisi, int hamleSuresi)
        {
            InitializeComponent();

            this.isimP1 = isimP1;
            this.isimP2 = isimP2;
            this.hamleSayisi = hamleSayisi;
            this.kalanHamleSayisi = hamleSayisi;
            this.hamleSuresi = hamleSuresi;
            this.kalanSure = hamleSuresi;

            lblTahminEdenOyuncu.Text = isimP2;
            lblKalanSüre.Text = sureHesapla(hamleSuresi);
            lblKalanHamleSayisi.Text = kalanHamleSayisi.ToString();

            lvSkorBoard.Items.Add(isimP1);
            lvSkorBoard.Items[0].SubItems.Add("0");
            lvSkorBoard.Items.Add(isimP2);
            lvSkorBoard.Items[1].SubItems.Add("0");
        }

        private String sureHesapla(int saniye)
        {
            String sure = "dd.ss";

            if (saniye / 60 > 0)
                sure = sure.Replace("dd", (saniye / 60).ToString());
            else
                sure = sure.Replace("dd", "00");
            sure = sure.Replace("ss", (saniye % 60).ToString());
            return sure;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (!oyun)
            {
                new formSayiGirisi(isimP1).ShowDialog();
                tmr.Enabled = true;
                oyun = true;
                kalanSure = hamleSuresi;
                kalanHamleSayisi = hamleSayisi;
                lvSkorBoard.Items[0].SubItems[1].Text = "0";
                lvSkorBoard.Items[1].SubItems[1].Text = "0";
                btnBaslat.Text = "BİTİR";
            }
            else
            {
                bitir();
            }
        }

        private void btnSayilar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals("Sil"))
                if (rtxtTahminSayisi.Text.Length > 0)
                    rtxtTahminSayisi.Text = rtxtTahminSayisi.Text.Substring(0, rtxtTahminSayisi.Text.Length - 1);
                else{}
            else if (rtxtTahminSayisi.Text.Length < 4)
                rtxtTahminSayisi.Text += btn.Text;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (kalanSure > 0)
            {
                lblKalanSüre.Text = sureHesapla(--kalanSure);
            }
            else // kalan süre biterse
            {
                bitir();
                MessageBox.Show("Süre Bitti." +
                    System.Environment.NewLine +
                    isimP1 + " skoru : " + lvSkorBoard.Items[0].SubItems[1].Text +
                    System.Environment.NewLine +
                    isimP2 + " skoru : " + lvSkorBoard.Items[1].SubItems[1].Text);
            }
        }

        private void bitir()
        {
            tmr.Enabled = false;
            oyun = false;
            kalanSure = hamleSuresi;
            kalanHamleSayisi = hamleSayisi;
            DosyaIslemleri di = new DosyaIslemleri();
            di.Yaz_skor(isimP1, kalanHamleSayisi * 10);
            puanP1 = 0;
            puanP2 = 0;
            btnBaslat.Text = "BAŞLAT";
        }

        private void renklendir()
        {
            for (int i = 0; i < rtxtTahminSayisi.Text.Length; i++)
            {
                if (rtxtTahminSayisi.Text[i] == tahminEdilecekSayi.ToString()[i])
                {
                    rtxtTahminSayisi.SelectionStart = i;
                    rtxtTahminSayisi.SelectionLength = 1;
                    rtxtTahminSayisi.SelectionColor = Color.Blue;
                }
                else if (tahminEdilecekSayi.ToString().Contains(rtxtTahminSayisi.Text[i]))
                {
                    rtxtTahminSayisi.SelectionStart = i;
                    rtxtTahminSayisi.SelectionLength = 1;
                    rtxtTahminSayisi.SelectionColor = Color.Red;
                }
            }
        }

        private void puanEkle()
        {
            //TODO aktif olan oyuncuya puan ekle
            if (aktifOyuncu)
            {
                //p1 e puan eklenir
                puanP1 += kalanHamleSayisi;
                lvSkorBoard.Items[0].SubItems[1].Text = puanP1.ToString();
            }
            else
            {
                //p2 ye puan eklenir
                puanP2 += kalanHamleSayisi;
                lvSkorBoard.Items[1].SubItems[1].Text = puanP2.ToString();
            }
        }

        private void btn_Dene_Click(object sender, EventArgs e)
        {
            if (oyun)
            {
                kalanSure = hamleSuresi;
                if (rtxtTahminSayisi.Text.Equals(tahminEdilecekSayi.ToString())) //doğru tahmin edildi ise
                {
                    rtxtTahminSayisi.ForeColor = Color.Green;
                    puanEkle();
                    bitir();
                    MessageBox.Show("Winner winner chicken dinner !!!");
                }
                else // daha bulunamadı ise
                {
                    renklendir();
                }

                lblKalanHamleSayisi.Text = --kalanHamleSayisi + "";
                if (kalanHamleSayisi == 0) // hamle sayısı biterse
                {
                    bitir();
                    MessageBox.Show("Hamle hakkı bitti." +
                        System.Environment.NewLine +
                        isimP1 + " skoru : " + lvSkorBoard.Items[0].SubItems[1].Text +
                        System.Environment.NewLine +
                        isimP2 + " skoru : " + lvSkorBoard.Items[1].SubItems[1].Text);
                }
                //TODO aktif oyuncuyu değiştir
                aktifOyuncu = !aktifOyuncu;
                if (aktifOyuncu)
                    lblTahminEdenOyuncu.Text = isimP1;
                else
                    lblTahminEdenOyuncu.Text = isimP1;

            }
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            formAyarlar frm = new formAyarlar();
            frm.Show();
        }
    }
}
