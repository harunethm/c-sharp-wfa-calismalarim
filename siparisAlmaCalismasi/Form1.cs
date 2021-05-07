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

namespace siparisAlmaCalismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region MenuTuslari
        private void TxtAciklama_Enter(object sender, EventArgs e)
        {
            if (txtAciklama.Text == "Açıklama Giriniz...")
                txtAciklama.Text = "";
        }

        private void TxtAciklama_Leave(object sender, EventArgs e)
        {
            if (txtAciklama.Text == "")
                txtAciklama.Text = "Açıklama Giriniz...";
        }

        private void BtnCikis_Click(object sender, EventArgs e)

        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            //frmMasalar fm = new frmMasalar();
            //this.Hide();
            //fm.Show();
        }

        private void BtnMakarna_Click(object sender, EventArgs e)
        {
            cGenel cg = new cGenel();
            cg.lvYaz(lvIcindekiler, 10);
        }

        private void BtnYemek_Click(object sender, EventArgs e)
        {
            cGenel cg = new cGenel();
            cg.lvYaz(lvIcindekiler, 11);
        }

        private void BtnKahvaltı_Click(object sender, EventArgs e)
        {
            cGenel cg = new cGenel();
            cg.lvYaz(lvIcindekiler, 12);
        }

        private void BtnTatlı_Click(object sender, EventArgs e)
        {
            cGenel cg = new cGenel();
            cg.lvYaz(lvIcindekiler, 13);
        }

        private void BtnIcecek_Click(object sender, EventArgs e)
        {
            cGenel cg = new cGenel();
            cg.lvYaz(lvIcindekiler, 14);
        }
        #endregion

        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            cGenel cg = new cGenel();
            cMasalar cm = new cMasalar();
            lblMasaNo.Text = "MASA > " + cGenel.masaNumarası + " <";
            cm.masaOdenenTutarEkle(0);
            SqlConnection baglanti = new SqlConnection(cg.baglantiMetni);
            SqlCommand komut = new SqlCommand("select URUNAD, ADET, satislar.FIYAT, satislar.ACIKLAMA, urunler.ID, KATEGORIID from urunler inner join satislar on urunler.ID=satislar.URUNID where MASAID=@masaId", baglanti);
            komut.Parameters.AddWithValue("@masaId", cGenel.masaNumarası);
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            SqlDataReader okuma = komut.ExecuteReader();
            int i = 0;
            while (okuma.Read())
            {
                lvSiparisler.Items.Add(okuma["URUNAD"].ToString());
                lvSiparisler.Items[i].SubItems.Add(okuma["ADET"].ToString());
                lvSiparisler.Items[i].SubItems.Add(okuma["FIYAT"].ToString());
                lvSiparisler.Items[i].SubItems.Add(okuma["ACIKLAMA"].ToString());
                lvSiparisler.Items[i].SubItems.Add(okuma["ID"].ToString());
                lvSiparisler.Items[i].SubItems.Add(okuma["KATEGORIID"].ToString());
                i++;
            }
            okuma.Close();
            baglanti.Close();
            cSiparisler cs = new cSiparisler();
            txtKalanBorc.Text = "Borç: " + cs.borcCek() + "TL";
        }

        private void LvIcindekiler_DoubleClick(object sender, EventArgs e)
        {
            cSiparisler cs = new cSiparisler();
            bool sayac = true;
            int i = lvSiparisler.Items.Count;
            for (int k = 0; k < i; k++)
            {
                if (lvIcindekiler.SelectedItems[0].SubItems[2].Text == lvSiparisler.Items[k].SubItems[4].Text)
                {
                    i = k;
                    sayac = false;
                }
            }
            if (sayac)
            {
                lvSiparisler.Items.Add(lvIcindekiler.SelectedItems[0].Text);    //Ad
                lvSiparisler.Items[i].SubItems.Add(nudAdet.Value.ToString());   //Adet
                string fiyat = (nudAdet.Value * Convert.ToDecimal(lvIcindekiler.SelectedItems[0].SubItems[1].Text)).ToString();
                lvSiparisler.Items[i].SubItems.Add(fiyat); //Fiyat
                lvSiparisler.Items[i].SubItems.Add(txtAciklama.Text);   //Açıklama
                lvSiparisler.Items[i].SubItems.Add(lvIcindekiler.SelectedItems[0].SubItems[2].Text);    //ID
                lvSiparisler.Items[i].SubItems.Add(lvIcindekiler.SelectedItems[0].SubItems[3].Text);        //KategoriId                       
                cs.siparisEkle(Convert.ToInt32(lvSiparisler.Items[i].SubItems[4].Text), Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text), fiyat, lvSiparisler.Items[i].SubItems[3].Text);
                nudAdet.Value = 1;
            }
            else
            {
                lvSiparisler.Items[i].SubItems[1].Text = (Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text) + nudAdet.Value).ToString();  //Adet

                int _adet = Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text);
                decimal _fiyat = Convert.ToDecimal(lvIcindekiler.SelectedItems[0].SubItems[1].Text);

                lvSiparisler.Items[i].SubItems[2].Text = (Convert.ToDecimal(_adet) * _fiyat).ToString();   //Fiyat
                cs.siparisEkle(Convert.ToInt32(lvSiparisler.Items[i].SubItems[4].Text), Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text), lvSiparisler.Items[i].SubItems[2].Text, lvSiparisler.Items[i].SubItems[3].Text);
            }
            txtKalanBorc.Text = "Borç: " + cs.borcCek() + "TL";
        }

        private void LvSiparisler_DoubleClick(object sender, EventArgs e)
        {
            cSiparisler cs = new cSiparisler();
            cMasalar cm = new cMasalar();
            int urunId = Convert.ToInt32(lvSiparisler.SelectedItems[0].SubItems[4].Text);
            lvSiparisler.Items.RemoveAt(lvSiparisler.SelectedItems[0].Index);
            cs.siparisSil(urunId);
            txtKalanBorc.Text = "Borç: " + cs.borcCek() + "TL";
            if (cs.borcCek() == 0)
                cm.masaDurumDegistir(cGenel.masaNumarası, 1);
        }

        private void BtnOde_Click(object sender, EventArgs e)
        {
            /*
                kredi kartı , nakit ödeme seçeneklerini çıkar , indirim comboboxu ekle miktara göre indirim yapsın
            */
            cSiparisler cs = new cSiparisler();
            cMasalar cm = new cMasalar();
            if (txtBorcOdeme.Text != "")
                cm.masaOdenenTutarEkle(Convert.ToInt32(txtBorcOdeme.Text));
            //cGenel.odenenMiktar[cGenel.masaNumarası] += Convert.ToInt32(txtBorcOdeme.Text);
            else
                txtBorcOdeme.Text = "Miktar giriniz...";

            txtKalanBorc.Text = "Borç: " + cs.borcCek() + "TL";
            if (cs.borcCek() == 0)
            {
                cm.masaDurumDegistir(cGenel.masaNumarası, 1);
                //frmMasalar fm = new frmMasalar();
                //this.Close();
                //fm.Show();
            }
            else
                txtBorcOdeme.Text = "";
        }

        private void btnPaketSiparis_Click(object sender, EventArgs e)
        {
            formPaketServis fm = new formPaketServis();
            this.Close();
            fm.Show();
        }
    }
}
