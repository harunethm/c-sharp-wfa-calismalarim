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
    public partial class formPreview : Form
    {
        #region tanımlamalar
        Button[,] butonlar = new Button[5, 5];
        #endregion

        #region form fonksiyonları
        public formPreview(Button[,] butonlar)
        {
            InitializeComponent();
            this.butonlar = butonlar;
        }

        private void formPreview_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = (Button)(this.Controls.Find("btn_" + i + "_" + j, true)[0]);
                    btn.BackColor = butonlar[i, j].Tag.ToString() == "mayin" ? Color.Red : Color.Green;
                    btn.Text = butonlar[i, j].TabIndex.ToString();
                }
            }
        }
        #endregion
    }
}
