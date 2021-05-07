using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAelementsCalismasi
{
    public partial class Form1 : Form
    {
        private void KayitSayisi()
        {
            int KayitSayisi = listView1.Items.Count;
            labelKayitSayisi.Text = Convert.ToString(KayitSayisi);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxTC.MaxLength = 11;
            textBoxTel.MaxLength = 11;
            progressBar1.Maximum = 50;
            progressBar1.Step = 1;
            progressBar1.Value = 25;

            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider2.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider3.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider4.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider5.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider6.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider7.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider8.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            errorProvider1.SetError(textBoxTC, "Alan Boş Bırakılamaz");
            errorProvider2.SetError(textBoxAd, "Alan Boş Bırakılamaz");
            errorProvider3.SetError(textBoxSoyad, "Alan Boş Bırakılamaz");
            errorProvider4.SetError(textBoxYas, "Alan Boş Bırakılamaz");
            errorProvider5.SetError(textBoxTel, "Alan Boş Bırakılamaz");
            errorProvider6.SetError(comboBoxEgitimDurumu, "Alan Boş Bırakılamaz");
            errorProvider7.SetError(textBoxDogumYeri, "Alan Boş Bırakılamaz");
            errorProvider8.SetError(radioButtonBayan, "Alan Boş Bırakılamaz");

            listView1.Columns.Add("TC Kimlik No", 125);
            listView1.Columns.Add("Yaş", 50);
            listView1.Columns.Add("Ad", 125);
            listView1.Columns.Add("Soyad", 100);
            listView1.Columns.Add("Doğum Yeri", 125);
            listView1.Columns.Add("Eğitim Durumu", 150);
            listView1.Columns.Add("Cinsiyeti", 100);
            listView1.Columns.Add("Tel. No", 130);
            listView1.Columns.Add("Şikayet Tanımı", 200);

            string[] EgitimDurumu = { "", "İLKÖĞRETİM", "ORTAÖĞRETİM", "LİSANS", "YÜKSEK LİSANS", "DOKTORA" };
            comboBoxEgitimDurumu.Items.AddRange(EgitimDurumu);

            KayitSayisi();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBay.Checked == false && radioButtonBayan.Checked == false)
                errorProvider8.SetError(radioButtonBayan, "Alan Boş Bırakılamaz");
            else
                errorProvider8.Clear();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDogumYeri.Text.Length < 1)
                errorProvider7.SetError(textBoxDogumYeri, "Alan Boş Bırakılamaz");
            else
                errorProvider7.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == textBoxTC.Text)
                {
                    textBoxYas.Text = listView1.Items[i].SubItems[1].Text;
                    textBoxAd.Text = listView1.Items[i].SubItems[2].Text;
                    textBoxSoyad.Text = listView1.Items[i].SubItems[3].Text;
                    textBoxDogumYeri.Text = listView1.Items[i].SubItems[4].Text;
                    comboBoxEgitimDurumu.Text = listView1.Items[i].SubItems[5].Text;
                    textBoxTel.Text = listView1.Items[i].SubItems[7].Text;
                    textBoxSikayetTanimi.Text = listView1.Items[i].SubItems[8].Text;
                    if (listView1.Items[i].SubItems[6].Text == "BAY")
                        radioButtonBay.Checked = true;
                    else if (listView1.Items[i].SubItems[6].Text == "BAYAN")
                        radioButtonBayan.Checked = true;
                }
                else
                {
                    textBoxAd.Clear(); textBoxSoyad.Clear(); textBoxYas.Clear(); textBoxTel.Clear(); textBoxSikayetTanimi.Clear(); textBoxDogumYeri.Clear(); comboBoxEgitimDurumu.Text = "";
                    MessageBox.Show("Kayıtlı Değil", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string TC = textBoxTC.Text, Ad = textBoxAd.Text, Soyad = textBoxSoyad.Text, Yas = textBoxYas.Text, Tel = textBoxTel.Text, EgitimDurumu = comboBoxEgitimDurumu.Text, DogumYeri = textBoxDogumYeri.Text, SikayetTanimi = textBoxSikayetTanimi.Text, Cinsiyet = "";

            if (radioButtonBay.Checked == true)
                Cinsiyet = radioButtonBay.Text;
            else if (radioButtonBayan.Checked == true)
                Cinsiyet = radioButtonBayan.Text;

            if (TC.Length > 10 && Ad != "" && Soyad != "" && Yas != "" && Tel.Length > 10 && EgitimDurumu != "" && DogumYeri != "" && Cinsiyet != "")
            {
                string[] bilgiler = { TC, Yas, Ad, Soyad, DogumYeri, EgitimDurumu, Cinsiyet, Tel, SikayetTanimi };
                bool KayitKontrol = true;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == textBoxTC.Text)
                    {
                        KayitKontrol = false;
                        MessageBox.Show("TC Kimlik Numaralı Kişi Zaten Kayıtlı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (KayitKontrol == true)
                {
                    ListViewItem lst = new ListViewItem(bilgiler);
                    listView1.Items.Add(lst);
                    textBoxTC.Clear(); textBoxAd.Clear(); textBoxSoyad.Clear(); textBoxYas.Clear(); textBoxTel.Clear(); textBoxSikayetTanimi.Clear(); textBoxDogumYeri.Clear(); comboBoxEgitimDurumu.Text = "";
                }
            }
            else
                MessageBox.Show("Bilgiler Eksik", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            KayitSayisi();
            label10.Text = (labelKayitSayisi.Text + "/50");
            progressBar1.PerformStep();

        }

        private void TextBoxTC_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTC.Text.Length < 11)
                errorProvider1.SetError(textBoxTC, "TC Kimlik Numarası 11 Haneli Olmalı");
            else
                errorProvider1.Clear();
        }

        private void TextBoxYas_TextChanged(object sender, EventArgs e)
        {
            if (textBoxYas.Text.Length < 1)
                errorProvider4.SetError(textBoxYas, "Alan Boş Bırakılamaz");
            else
                errorProvider4.Clear();
        }

        private void RadioButtonBay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBay.Checked == true || radioButtonBayan.Checked == true)
                errorProvider8.Clear();
        }

        private void TextBoxAd_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAd.Text.Length < 1)
                errorProvider2.SetError(textBoxAd, "Alan Boş Bırakılamaz");
            else
                errorProvider2.Clear();
        }

        private void TextBoxSoyad_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSoyad.Text.Length < 1)
                errorProvider3.SetError(textBoxSoyad, "Alan Boş Bırakılamaz");
            else
                errorProvider3.Clear();
        }

        private void TextBoxTel_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTel.Text.Length < 11)
                errorProvider5.SetError(textBoxTel, "Alan Boş Bırakılamaz");
            else
                errorProvider5.Clear();
        }

        private void ComboBoxEgitimDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEgitimDurumu.Text.Length < 1)
                errorProvider6.SetError(comboBoxEgitimDurumu, "Alan Boş Bırakılamaz");
            else
                errorProvider6.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult Dogrulama = MessageBox.Show("Seçili Kayıtları Silmek İstediğinize Emin Misiniz ?", "Doğrulama", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Dogrulama == DialogResult.Yes)
            {
                int a = 0;
                foreach (ListViewItem Bilgi in listView1.CheckedItems)
                {
                    a++;
                    Bilgi.Remove();
                }
                progressBar1.Value -= a;
                label10.Text = (Convert.ToInt32(labelKayitSayisi.Text) - a + "/50");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DialogResult Dogrulama = MessageBox.Show("Tüm Kayıtları Silmek İstediğinize Emin Misiniz ?", "Doğrulama", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Dogrulama == DialogResult.Yes)
            {
                foreach (ListViewItem Bilgi in listView1.Items)
                {
                    Bilgi.Remove();
                }

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBoxTC.Clear(); textBoxAd.Clear(); textBoxSoyad.Clear(); textBoxYas.Clear(); textBoxTel.Clear(); textBoxSikayetTanimi.Clear(); textBoxDogumYeri.Clear(); comboBoxEgitimDurumu.Text = "";
        }
    }
}
