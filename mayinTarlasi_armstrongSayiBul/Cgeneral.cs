using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayinTarlasi_armstrongSayiBul
{
    class Cgeneral
    {

        #region tanımlamalar
        const int mayinTarlasiSatirSayisi = 5;
        const int mayinTarlasiSütunSayisi = 5;
        public bool oyunDevamEdiyorMu = false;
        public static int acilanButonlar = 0;
        public static int[] sure = new int[] { 0, 0 };
        public Button[,] butonlar = new Button[5, 5];
        formPreview fp;
        #endregion

        //constructor method
        public Cgeneral(Button[,] btn)
        {
            this.butonlar = btn;
        }

        #region fonksiyonlar
        public bool armstrongSayiMi(double sayi)
        {
            string _sayi = sayi.ToString(); // basamaklara kolay erişim için string dönüşümü
            int basamakSayisi = _sayi.Length; // üssünü alabilmek için basamakSayisi sabiti
            sayi = 0; // sayi, _sayi string inde tutulduğu için artık toplam değişkeni olarak kullanılabilir

            for (int i = 0; i < basamakSayisi; i++)
                sayi += Math.Pow(Convert.ToInt32("0" + _sayi[i]), basamakSayisi); //her basamaktaki sayı basamakSayisi kuvveti alınıp sayi değişkenime eklenir ("0" + kullanımı ascii değeri alındığı için)

            if (sayi.ToString() == _sayi) //toplamlardan sonra sayi değişkeni baştaki _sayi string ine eşit ise armstrong demektir
                return true;
            return false;
        }

        public void butonlariSifirla()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    butonlar[i, j].BackColor = Color.Gray;
                    butonlar[i, j].Text = "";
                    butonlar[i, j].Tag = "";
                    butonlar[i, j].TabIndex = 0;
                }
            }
        }

        public void mayinTarlasiniOlustur(int mayinSayisi)
        {
            butonlariSifirla();

            Random rnd = new Random();
            int eklenenMayin = 0;

            do
            {
                int _ = rnd.Next(mayinTarlasiSatirSayisi);
                int __ = rnd.Next(mayinTarlasiSütunSayisi);
                if (butonlar[_, __].Tag.ToString() != "mayin")
                {
                    butonlar[_, __].Tag = "mayin";
                    eklenenMayin++;
                }
            } while (eklenenMayin < mayinSayisi);

            for (int i = 0; i < mayinTarlasiSatirSayisi; i++)
                for (int j = 0; j < mayinTarlasiSütunSayisi; j++)
                {
                    int etraftakiMayinSayisi = 0;
                    #region for ile dönerek etrafını inceleme
                    for (int k = i - 1; k <= i + 1; k++)
                        if (k >= 0 && k <= 4)
                            for (int l = j - 1; l <= j + 1; l++)
                                if (l >= 0 && l <= 4)
                                    if (!(k == i && l == j) && butonlar[k, l].Tag.ToString() == "mayin")
                                        etraftakiMayinSayisi++;
                    #endregion
                    #region if kontrolü ile etrafını inceleme
                    //if (i > 0 && j > 0 && mayinlar[i - 1, j - 1, 0] == -1)
                    //    etraftakiMayinSayisi++;
                    //if (i > 0 && mayinlar[i - 1, j, 0] == -1)
                    //    etraftakiMayinSayisi++;
                    //if (i > 0 && j < 4 && mayinlar[i - 1, j + 1, 0] == -1)
                    //    etraftakiMayinSayisi++;
                    //if (j > 0 && mayinlar[i, j - 1, 0] == -1)
                    //    etraftakiMayinSayisi++;
                    //if (j < 4 && mayinlar[i, j + 1, 0] == -1)
                    //    etraftakiMayinSayisi++;
                    //if (i < 4 && j > 0 && mayinlar[i + 1, j - 1, 0] == -1)
                    //    etraftakiMayinSayisi++;
                    //if (i < 4 && mayinlar[i + 1, j, 0] == -1)
                    //    etraftakiMayinSayisi++;
                    //if (i < 4 && j < 4 && mayinlar[i + 1, j + 1, 0] == -1)
                    //    etraftakiMayinSayisi;
                    #endregion
                    butonlar[i, j].TabIndex = etraftakiMayinSayisi;
                }
        }

        public void oyunBitti(Timer tKalanSure, Label lblKalanSure, int sure)
        {
            // değişkenleri default yapan kısım
            oyunDevamEdiyorMu = false;
            tKalanSure.Enabled = false;
            acilanButonlar = 0;
            lblKalanSure.Text = "Kalan Süre = " + sure;
            //butonlariSifirla();

            if (!(fp == null || fp.IsDisposed))
                fp.Close(); // oyun bitince form kapanır
        }

        public void yeniOyunBaslat(Timer tKalanSure, Label lblKalanSure, int mayinSayisi, int sure)
        {
            oyunBitti(tKalanSure, lblKalanSure, sure);
            butonlariSifirla();
            mayinTarlasiniOlustur(mayinSayisi);
            oyunDevamEdiyorMu = true;
            Cgeneral.sure[0] = sure;
            Cgeneral.sure[1] = sure;
            tKalanSure.Enabled = true;

            fp = new formPreview(butonlar);
            fp.Show();
        }

        #endregion

    }
}
