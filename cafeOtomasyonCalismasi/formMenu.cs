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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }
        private void BtnMasa_Click(object sender, EventArgs e)
        {
            formMasalar form = new formMasalar();
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
    }
}
