using cafeOtomasyonu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeOtomasyonCalismasi
{
    public partial class formSiparis : Form
    {
        public formSiparis()
        {
            InitializeComponent();
        }

        int adisyonId, masaId;

        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            cMasalar masa = new cMasalar();
            masaId = masa.masaNoAl(cGenel._buttonName);

            lblMasaNo.Text = "Masa " + masaId;

            if (masa.masaDurumAl(masaId, 2) == true || masa.masaDurumAl(masaId, 4) == true)// 1 - boş, 2 - dolu, 3 - rezerve, 4 - rezerve edenler gelmiş oturmuş
            {
                cAdisyon adisyon = new cAdisyon();
                adisyonId = adisyon.adisyondanAl(masaId);

                cSiparis siparis = new cSiparis();
                siparis.siparisGetir(lvSiparişler, adisyonId);
            }
            else //doluysa
            {
                //sql den o masaya ait olan siparişleri alıp lvSiparişlere eklemeli
                cSiparis cs = new cSiparis();
                //int[] urunIds = cs.urunIdAl(masaId, adisyonId);

            }
        }

        private void Klavye_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "<-":
                    if (txtAdet.Text.Length > 0)
                        txtAdet.Text = txtAdet.Text.Substring(0, txtAdet.Text.Length - 1);
                    break;
                case "C":
                    txtAdet.Text = "";
                    break;
                default:
                    txtAdet.Text += btn.Text;
                    break;
            }
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnGeriDon_Click(object sender, EventArgs e)
        {
            formMasalar frm = new formMasalar();
            this.Close();
            frm.Show();
        }

        private void BtnAnaMenu_Click(object sender, EventArgs e)
        {
            formMenu frm = new formMenu();
            this.Close();
            frm.Show();
        }
        cUrunCesitleri cUC = new cUrunCesitleri();
        private void BtnKahvalti4_Click(object sender, EventArgs e)
        {
            cUC.urunTipiAl(lvMenu, btnKahvalti4);
        }

        private void BtnMakarna2_Click(object sender, EventArgs e)
        {
            cUC.urunTipiAl(lvMenu, btnMakarna2);
        }

        private void BtnIcecek3_Click(object sender, EventArgs e)
        {
            cUC.urunTipiAl(lvMenu, btnIcecek3);
        }

        private void BtnTatlı5_Click(object sender, EventArgs e)
        {
            cUC.urunTipiAl(lvMenu, btnTatlı5);
        }

        private void BtnTost1_Click(object sender, EventArgs e)
        {
            cUC.urunTipiAl(lvMenu, btnTost1);
        }

        private void BtnWrap6_Click(object sender, EventArgs e)
        {
            cUC.urunTipiAl(lvMenu, btnWrap6);
        }

        int sayac, sayac2;
        string[] silinenler = new string[20];
        private void BtnSiparis_Click(object sender, EventArgs e)
        {
            /*
             * 1 - Masa Boş
             * 2 - Masa Dolu
             * 3 - Masa Rezerve
             */

            cMasalar masa = new cMasalar();
            cAdisyon adisyonYeni = new cAdisyon();
            cSiparis siparisKayıt = new cSiparis();

            bool sonuc = false;

            if (masa.masaDurumAl(masaId, 1) == true)
            {
                adisyonYeni.ServisTurNo = 1;
                adisyonYeni.PersonelId = 1;
                adisyonYeni.MasaId = masaId;
                adisyonYeni.Tarih = DateTime.Now;
                sonuc = adisyonYeni.adisyonaYazYeni(adisyonYeni);

                masa.masaDurumDegistir(cGenel._buttonName, 2);

                if (lvSiparişler.Items.Count > 0)
                {
                    for (int i = 0; i < lvSiparişler.Items.Count; i++)
                    {
                        siparisKayıt.MasaId = masaId;
                        siparisKayıt.UrunId = Convert.ToInt32(lvSiparişler.Items[i].SubItems[3].Text);
                        siparisKayıt.AdisyonId = adisyonYeni.adisyondanAl(masaId);
                        siparisKayıt.Adet = Convert.ToInt32(lvSiparişler.Items[i].SubItems[1].Text);
                        siparisKayıt.siparisKaydet(siparisKayıt);
                    }
                    this.Close();
                    formMasalar fmasa = new formMasalar();
                    fmasa.Show();
                }
            }
            else if (masa.masaDurumAl(masaId, 2) == true)
            {
                if (lvYeniEklenenler.Items.Count > 0)
                {
                    for (int i = 0; i < lvYeniEklenenler.Items.Count; i++)
                    {
                        siparisKayıt.MasaId = masaId;
                        siparisKayıt.UrunId = Convert.ToInt32(lvYeniEklenenler.Items[i].SubItems[1]);
                        siparisKayıt.AdisyonId = adisyonYeni.adisyondanAl(masaId);
                        siparisKayıt.Adet = Convert.ToInt32(lvYeniEklenenler.Items[i].SubItems[2]);
                        siparisKayıt.siparisKaydet(siparisKayıt);
                    }
                }
                if (silinenler.Length > 0)
                {
                    foreach (string item in silinenler)
                    {
                        siparisKayıt.siparisSil(Convert.ToInt32(item));
                    }
                }
            }
        }

        private void LvMenu_DoubleClick(object sender, EventArgs e)
        {
            if (txtAdet.Text == "")
                txtAdet.Text = "1";

            if (true)
            {
                sayac = lvSiparişler.Items.Count;

                lvSiparişler.Items.Add(lvMenu.SelectedItems[0].Text);
                lvSiparişler.Items[sayac].SubItems.Add(txtAdet.Text);
                lvSiparişler.Items[sayac].SubItems.Add((Convert.ToDecimal(txtAdet.Text) * Convert.ToDecimal(lvMenu.SelectedItems[0].SubItems[1].Text)).ToString());
                lvSiparişler.Items[sayac].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvSiparişler.Items[sayac].SubItems.Add("0");
                lvSiparişler.Items[sayac].SubItems.Add(sayac.ToString());

                sayac2 = lvYeniEklenenler.Items.Count;

                lvYeniEklenenler.Items.Add(adisyonId.ToString());
                lvYeniEklenenler.Items[sayac2].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvYeniEklenenler.Items[sayac2].SubItems.Add(txtAdet.Text);
                lvYeniEklenenler.Items[sayac2].SubItems.Add(masaId.ToString());
                lvYeniEklenenler.Items[sayac2].SubItems.Add(sayac2.ToString());

                sayac2++;

                txtAdet.Text = "";

            }
        }
        private void LvSiparişler_DoubleClick(object sender, EventArgs e)
        {
            if (lvSiparişler.SelectedItems[0].SubItems[4].Text != "0")
            {
                cSiparis csip = new cSiparis();
                csip.siparisSil(Convert.ToInt32(lvSiparişler.SelectedItems[0].SubItems[4].Text));
            }
            else
            {
                for (int i = 0; i < lvYeniEklenenler.Items.Count; i++)
                {
                    if (lvYeniEklenenler.SelectedItems[0].SubItems[4].Text == lvSiparişler.SelectedItems[0].SubItems[5].Text)
                    {
                        lvYeniEklenenler.Items.RemoveAt(i);
                    }
                }
            }
            lvSiparişler.Items.RemoveAt(lvSiparişler.SelectedItems[0].Index);
        }
    }
}
