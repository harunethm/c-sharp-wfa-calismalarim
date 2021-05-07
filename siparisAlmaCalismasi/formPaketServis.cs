using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siparisAlmaCalismasi
{
    public partial class formPaketServis : Form
    {
        public formPaketServis()
        {
            InitializeComponent();
        }
        #region görmesek de olur
        private void BtnCikis_Click(object sender, EventArgs e)

        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            formPaketServis fm = new formPaketServis();
            this.Close();
            fm.Show();
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

        private void TxtAdSoyad_Enter(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "Ad Soyad")
                txtAdSoyad.Text = "";
        }

        private void TxtTelefonNo_Enter(object sender, EventArgs e)
        {
            if (txtTelefonNo.Text == "Telefon No")
                txtTelefonNo.Text = "";
        }

        private void TxtAdres_Enter(object sender, EventArgs e)
        {
            if (txtAdres.Text == "Adres")
                txtAdres.Text = "";
        }

        private void TxtAdSoyad_Leave(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "")
                txtAdSoyad.Text = "Ad Soyad";
        }

        private void TxtTelefonNo_Leave(object sender, EventArgs e)
        {
            if (txtTelefonNo.Text == "")
                txtTelefonNo.Text = "Telefon No";
        }

        private void TxtAdres_Leave(object sender, EventArgs e)
        {
            if (txtAdres.Text == "")
                txtAdres.Text = "Adres";
        }
        #endregion

        private void LvIcindekiler_DoubleClick(object sender, EventArgs e)
        {
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
                lvSiparisler.Items[i].SubItems.Add(lvIcindekiler.SelectedItems[0].SubItems[2].Text);    //ID
                lvSiparisler.Items[i].SubItems.Add(lvIcindekiler.SelectedItems[0].SubItems[3].Text);        //KategoriId
                nudAdet.Value = 1;
            }
            else
            {
                lvSiparisler.Items[i].SubItems[1].Text = (Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text) + nudAdet.Value).ToString();  //Adet

                int _adet = Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text);
                decimal _fiyat = Convert.ToDecimal(lvIcindekiler.SelectedItems[0].SubItems[1].Text);

                lvSiparisler.Items[i].SubItems[2].Text = (Convert.ToDecimal(_adet) * _fiyat).ToString();   //Fiyat              
            }
        }

        private void LvSiparisler_DoubleClick(object sender, EventArgs e)
        {
            lvSiparisler.Items.RemoveAt(lvSiparisler.SelectedItems[0].Index);
        }

        private void BtnSiparisVer_Click(object sender, EventArgs e)
        {
            //tek seferde verilen sipariş numarası aynı olcak şekilde düzenleme yap daha sonrasında sipariş numarası aynı olanları çekerek ulaşılabilir
            cPaketSiparis cps = new cPaketSiparis();
            for (int i = 0; i < lvSiparisler.Items.Count; i++)
            {
                cps.siparisVer(Convert.ToInt32(lvSiparisler.Items[i].SubItems[3].Text), Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text), txtAciklama.Text, txtAdSoyad.Text, txtTelefonNo.Text, txtAdres.Text);
            }
        }
    }
}