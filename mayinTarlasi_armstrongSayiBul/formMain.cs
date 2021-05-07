using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayinTarlasi_armstrongSayiBul
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        #region tanımlamalar
        Button[,] butonlar = new Button[5, 5];
        Cgeneral cg;
        #endregion

        #region fonksiyonlarım
        public void harfGirilmesin(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        } //altSinir ve ustSinir textBox larına sayı harici girişi engelleyen fonksiyon
        #endregion

        #region form fonksiyonları

        private void formMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = (Button)(this.Controls.Find("btn_" + i + "_" + j, true)[0]);
                    butonlar[i, j] = btn;
                }
            }// butonlar, kolay erişim için butonlar dizisine atanır
           cg = new Cgeneral(butonlar);
        }

        private void mayinTarlasi(object sender, EventArgs e)
        {
            if (cg.oyunDevamEdiyorMu)
            {
                Button btn = (Button)sender;

                if (btn.Tag.ToString() == "mayin")
                {
                    btn.BackColor = Color.Red;
                    btn.Text = btn.TabIndex.ToString();
                    cg.oyunBitti(tKalanSure, lblKalanSure, (int)nudSure.Value);
                    MessageBox.Show("Bombaya tıkladınız.", "BOOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btn.BackColor =Color.Green;
                    btn.Text = btn.TabIndex.ToString();
                    Cgeneral.acilanButonlar++;
                }
                Cgeneral.sure[0] = Cgeneral.sure[1];
                if (Cgeneral.acilanButonlar == 25 - nudMayinSayisi.Value)
                {
                    cg.oyunBitti(tKalanSure, lblKalanSure, (int)nudSure.Value);
                    MessageBox.Show("Kazandınız ...", "TEBRİKLER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (lbArmstrongSayilar.Items.Count > 0) // listBox dolu ise temizle
                lbArmstrongSayilar.Items.Clear();

            if (Convert.ToInt32(txtUstSinir.Text) < Convert.ToInt32(txtAltSinir.Text)) // alt sınır, üst sınırdan büyük olmamalı
                MessageBox.Show("Alt sınır, üst sınırdan büyük olmamalı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            for (int i = Convert.ToInt32(txtAltSinir.Text); i < Convert.ToInt32(txtUstSinir.Text); i++)
                if (cg.armstrongSayiMi(i))
                    lbArmstrongSayilar.Items.Add(i);
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (cg.oyunDevamEdiyorMu)
            {
                if (MessageBox.Show("Yeni oyuna başlamak istiyor musunuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    cg.yeniOyunBaslat(tKalanSure, lblKalanSure, (int)nudMayinSayisi.Value, (int)nudSure.Value);
            }
            else
                cg.yeniOyunBaslat(tKalanSure, lblKalanSure, (int)nudMayinSayisi.Value, (int)nudSure.Value);
        }

        private void tmrKalanSüre_Tick(object sender, EventArgs e)
        {
            if (cg.oyunDevamEdiyorMu && Cgeneral.sure[0] > 0)
            {
                lblKalanSure.Text = "Kalan Süre = " + Cgeneral.sure[0];
                Cgeneral.sure[0]--;
            }
            else
            {
                lblKalanSure.Text = "Kalan Süre = " + nudSure.Value;
                cg.oyunBitti(tKalanSure, lblKalanSure, (int)nudSure.Value);
                MessageBox.Show(nudSure.Value + " saniye boyunca hiçbir butona tıklamadınız.", "Süre Bitti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
