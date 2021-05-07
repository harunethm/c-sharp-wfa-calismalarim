using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mikroGSShesaplayıcı
{
    public partial class Form1 : Form
    {

        decimal _gecikme = 0;
        decimal _frekans = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sonuc.Text = "";
            decimal gecikme = 0;
            decimal frekans = 0;


            gecikme = _gecikme * Convert.ToDecimal(txtIstenenGecikme.Text);
            sonuc.Text += "Gecikme: " + gecikme + System.Environment.NewLine;

            frekans = _frekans * Convert.ToDecimal(txtFrekans.Text);
            sonuc.Text += "Frekans: " + frekans + System.Environment.NewLine;

            frekans /= 4;

            decimal T = 1 / frekans;
            sonuc.Text += "T: " + T + System.Environment.NewLine;
            decimal N = (gecikme / T);
            sonuc.Text += "3N: " + N + System.Environment.NewLine;

            sonuc.Text += "N(10): " + (N / 3) + System.Environment.NewLine;
            sonuc.Text += "N(16): " + Convert.ToInt32(N / 3).ToString("X") + System.Environment.NewLine;

            sonuc.Text += "N(karekök:10): " + Math.Sqrt(Convert.ToDouble(N/3)) + System.Environment.NewLine;
            sonuc.Text += "N(karekök:16): " + Convert.ToInt32(Math.Sqrt(Convert.ToDouble(N / 3))).ToString("X") + System.Environment.NewLine;

        }

        private void rb_cc(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Name.Contains("mili"))
            {
                _gecikme = Convert.ToDecimal(Math.Pow(10, -3));
            }
            else if (rb.Name.Contains("mikro"))
            {
                _gecikme = Convert.ToDecimal(Math.Pow(10, -6));

            }
            else if (rb.Name.Contains("nano"))
            {
                _gecikme = Convert.ToDecimal(Math.Pow(10, -9));

            }
            else if (rb.Name.Contains("piko"))
            {
                _gecikme = Convert.ToDecimal(Math.Pow(10, -12));

            }
            else
            {
                _gecikme = 1;
            }
            sonuc.Text += "Gecikme: " + _gecikme + System.Environment.NewLine;
        }

        private void rb_cc_frekans(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Name.Contains("kilo"))
            {
                _frekans = Convert.ToDecimal(Math.Pow(10, 3));
            }
            else if (rb.Name.Contains("mega"))
            {
                _frekans = Convert.ToDecimal(Math.Pow(10, 6));
            }
            else if (rb.Name.Contains("giga"))
            {
                _frekans = Convert.ToDecimal(Math.Pow(10, 9));
            }
            else if (rb.Name.Contains("tera"))
            {
                _frekans = Convert.ToDecimal(Math.Pow(10, 12));
            }
            else
            {
                _frekans = 1;
            }
            sonuc.Text += "Frekans: " + _frekans + System.Environment.NewLine;

        }
    }
}
