using System;
using System.Windows.Forms;

namespace decimalToHexadecimalCevirici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int MainNumber = Convert.ToInt32(metingirdi.Text);

            int boyut = 1;

            char bölüm = '0';

            char[] sonuc = new char[30];

            char[] hexa = { 'A', 'B', 'C', 'D', 'E', 'F' };

            string yazdir = "";

            for (int i = 0; i < boyut; i++)
            {
                string kalan = "";
                if (MainNumber < 16)
                {
                    bölüm = Convert.ToChar(MainNumber + 48);
                    if (bölüm > 57)
                    {
                        bölüm = hexa[bölüm - 58];
                    }
                }
                else
                {
                    boyut++;
                    kalan += MainNumber % 16;
                    MainNumber /= 16;

                    int a = Convert.ToInt32(kalan);
                    if (a > 9)
                    {
                        kalan = "";
                        a -= 10;
                        kalan += hexa[a];
                    }
                    sonuc[i] = Convert.ToChar(kalan);
                }
            }

            for (int i = 29; i >= 0; --i)
            {
                if (sonuc[i] != 0)
                    yazdir += sonuc[i];
            }

            metincikti.Text = bölüm + yazdir;
        }
    }
}
