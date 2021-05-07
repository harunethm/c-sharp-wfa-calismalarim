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
    public partial class formSayiGirisi : Form
    {
        public formSayiGirisi()
        {
            InitializeComponent();
        }
        public formSayiGirisi(String isim)
        {
            InitializeComponent();
            lblUyari.Text = lblUyari.Text.Replace("_", isim.ToString());
        }
        private void btn_Sayilar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals("Sil") && txtTahminSayisi.Text.Length > 0)
                txtTahminSayisi.Text = txtTahminSayisi.Text.Substring(0, txtTahminSayisi.Text.Length - 1);
            else
                txtTahminSayisi.Text += btn.Text;
        }

        private void btn_Onayla_Click(object sender, EventArgs e)
        {
            if (!txtTahminSayisi.Text.Equals("") && !(txtTahminSayisi.Text.Length < 4))
            {
                bool esitlik = true;
                for (int i = 0; i < txtTahminSayisi.Text.Length; i++)
                {
                    for (int j = i + 1; j + 1 <= txtTahminSayisi.Text.Length; j++)
                    {
                        if (txtTahminSayisi.Text[i].Equals(txtTahminSayisi.Text[j]))
                        {
                            esitlik = false;
                            break;
                        }
                    }
                }
                if (esitlik)
                {
                    formAnaEkran.tahminEdilecekSayi = Convert.ToInt32(txtTahminSayisi.Text);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Rakamlar tekrar etmemeli.");
                }
            }
            else
            {
                MessageBox.Show("Tahmin kutusu boş geçilemez.");
            }
        }
    }
}
