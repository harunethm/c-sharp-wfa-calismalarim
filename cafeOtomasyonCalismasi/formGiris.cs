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
    public partial class formGiris : Form
    {
        public formGiris()
        {
            InitializeComponent();
        }
        private void formGiris_Load(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.personeGetByInformation(cbKullanıcıAdı);
        }

        cGenel gnl = new cGenel();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            bool result = p.PersonelEntryControl(txtSifre.Text, cGenel._personelId);

            if (result)
            {
                cPersonelHareketleri ph = new cPersonelHareketleri();
                ph.PersonelId = cGenel._personelId;
                ph.Islem = "Giriş yaptı.";
                ph.Tarih = DateTime.Now;
                ph.personelActionSave(ph);


                this.Hide();
                formMenu menu = new formMenu();
                menu.Show();
            }
            else
                MessageBox.Show("Şifreniz Yanlış.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CbKullanıcıAdı_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cbKullanıcıAdı.SelectedItem;
            cGenel._personelId = p.PersonelId;
            cGenel._gorevId = p.PersonelGorevId;
        }
    }
}
