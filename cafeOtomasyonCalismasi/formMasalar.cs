using cafeOtomasyonu;
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

namespace cafeOtomasyonCalismasi
{
    public partial class formMasalar : Form
    {
        public formMasalar()
        {
            InitializeComponent();
        }
        cGenel gnl = new cGenel();

        private void FormMasalar_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select DURUM, ID from masalar", con);
            
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "1") //BOŞ
                        {
                            item.BackColor = Color.Lime;
                        }
                        else if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "2") //DOLU
                        {
                            cMasalar masa = new cMasalar();

                            DateTime dt1 = Convert.ToDateTime(masa.SessionSum(2, dr["ID"].ToString()));
                            DateTime dt2 = DateTime.Now;

                            string st1 = Convert.ToDateTime(masa.SessionSum(2, dr["ID"].ToString())).ToShortTimeString();
                            string st2 = DateTime.Now.ToShortTimeString();

                            DateTime t1 = dt1.AddMinutes(DateTime.Parse(st1).TimeOfDay.TotalMinutes);
                            DateTime t2 = dt2.AddMinutes(DateTime.Parse(st2).TimeOfDay.TotalMinutes);

                            var fark = t2 - t1;

                            item.Text = String.Format("Masa " + dr["ID"].ToString() + "\n{0}{1}",
                                fark.Hours > 0 ? string.Format(fark.Hours + " Saat\n") : "",
                                fark.Minutes > 0 ? string.Format(fark.Minutes + " Dakika") : "").Trim();

                            item.BackColor = Color.Red;
                            item.ForeColor = SystemColors.Control;
                        }
                        else if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "3") //REZERVE MÜŞTERİ GELMİŞ
                        {
                            item.BackColor = Color.Aqua;
                        }
                        else if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "4") //REZERVE
                        {
                            item.BackColor = Color.DarkTurquoise;
                        }
                    }
                }
            }

        }

        private void BtnGeriDon_Click(object sender, EventArgs e)
        {
            formMenu form = new formMenu();
            this.Close();
            form.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMasa1_Click(object sender, EventArgs e)
        {
            formSiparis form = new formSiparis();
            cGenel._buttonValue = btnMasa1.Text.Substring(0, 6);
            cGenel._buttonName = btnMasa1.Name;
            this.Close();
            form.ShowDialog();
        }

        private void BtnMasa2_Click(object sender, EventArgs e)
        {
            formSiparis form = new formSiparis();
            int uzunluk = btnMasa2.Text.Length;
            cGenel._buttonValue = btnMasa2.Text.Substring(0, 6);
            cGenel._buttonName = btnMasa2.Name;
            this.Close();
            form.ShowDialog();
        }

        private void BtnMasa3_Click(object sender, EventArgs e)
        {
            formSiparis form = new formSiparis();
            int uzunluk = btnMasa3.Text.Length;
            cGenel._buttonValue = btnMasa3.Text.Substring(0, 6);
            cGenel._buttonName = btnMasa3.Name;
            this.Close();
            form.ShowDialog();
        }

        private void BtnMasa4_Click(object sender, EventArgs e)
        {
            formSiparis form = new formSiparis();
            int uzunluk = btnMasa4.Text.Length;
            cGenel._buttonValue = btnMasa4.Text.Substring(0, 6);
            cGenel._buttonName = btnMasa4.Name;
            this.Close();
            form.ShowDialog();
        }

        private void BtnMasa5_Click(object sender, EventArgs e)
        {
            formSiparis form = new formSiparis();
            int uzunluk = btnMasa5.Text.Length;
            cGenel._buttonValue = btnMasa5.Text.Substring(0, 6);
            cGenel._buttonName = btnMasa5.Name;
            this.Close();
            form.ShowDialog();
        }

        private void BtnMasa6_Click(object sender, EventArgs e)
        {
            formSiparis form = new formSiparis();
            int uzunluk = btnMasa6.Text.Length;
            cGenel._buttonValue = btnMasa6.Text.Substring(0, 6);
            cGenel._buttonName = btnMasa6.Name;
            this.Close();
            form.ShowDialog();
        }

        private void BtnMasa7_Click(object sender, EventArgs e)
        {
            formSiparis form = new formSiparis();
            int uzunluk = btnMasa7.Text.Length;
            cGenel._buttonValue = btnMasa7.Text.Substring(0, 6);
            cGenel._buttonName = btnMasa7.Name;
            this.Close();
            form.ShowDialog();
        }

        private void BtnMasa8_Click(object sender, EventArgs e)
        {
            formSiparis form = new formSiparis();
            int uzunluk = btnMasa8.Text.Length;
            cGenel._buttonValue = btnMasa8.Text.Substring(0, 6);
            cGenel._buttonName = btnMasa8.Name;
            this.Close();
            form.ShowDialog();
        }

        private void BtnMasa9_Click(object sender, EventArgs e)
        {
            formSiparis form = new formSiparis();
            int uzunluk = btnMasa9.Text.Length;
            cGenel._buttonValue = btnMasa9.Text.Substring(0, 6);
            cGenel._buttonName = btnMasa9.Name;
            this.Close();
            form.ShowDialog();
        }

        private void BtnMasa10_Click(object sender, EventArgs e)
        {
            formSiparis form = new formSiparis();
            int uzunluk = btnMasa10.Text.Length;
            cGenel._buttonValue = btnMasa10.Text.Substring(0, 7);
            cGenel._buttonName = btnMasa10.Name;
            this.Close();
            form.ShowDialog();
        }
    }
}
