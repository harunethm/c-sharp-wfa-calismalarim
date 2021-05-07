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
    public partial class formAyarlar : Form
    {
        public formAyarlar()
        {
            InitializeComponent();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!txtP1.Text.Equals("") || !txtP2.Text.Equals("") || !txtP1.Text.ToLower().Equals(txtP2.Text.ToLower()) || Convert.ToInt32(nudHamleHakki.Value) > 0 || Convert.ToInt32(nudHamleSuresi.Value) > 0)
            {
                formAnaEkran st = new formAnaEkran(txtP1.Text.Trim().ToString(), txtP2.Text.Trim().ToString(), Convert.ToInt32(nudHamleHakki.Value), Convert.ToInt32(nudHamleSuresi.Value));
                st.Show();
                this.Hide();
            }
        }
    }
}
