using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sezerAlgoritmasiSifrelemeveSifreCozme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCevir_Click(object sender, EventArgs e)
        {
            int[] solved = new int[MetinGirdi.Text.Length];
            if (ButtonSifrele.Checked == true && ButtonCoz.Checked == false)
            {
                for (int i = 0; i < MetinGirdi.Text.Length; i++)
                {
                    if (MetinGirdi.Text[i] == ' ')
                        solved[i] = MetinGirdi.Text[i];
                    else
                    {
                        solved[i] = Convert.ToInt32(MetinGirdi.Text[i]) + Convert.ToInt32(MetinKod.Text);
                        if (solved[i] > 126)
                            solved[i] -= 95;
                    }
                     ;
                }
            }

            if (ButtonSifrele.Checked == false && ButtonCoz.Checked == true)
            {
                for (int i = 0; i < MetinGirdi.Text.Length; i++)
                {
                    if (MetinGirdi.Text[i] == ' ')
                        solved[i] = MetinGirdi.Text[i];
                    else
                    {
                        solved[i] = Convert.ToInt32(MetinGirdi.Text[i]) - Convert.ToInt32(MetinKod.Text);
                        if (solved[i] < 32)
                            solved[i] += 95;
                    }
                    Console.Write(Convert.ToChar(solved[i]));
                }
            }

            string sonuc = "";
            for (int i = 0; i < solved.Length; i++)
            {
                sonuc = sonuc + Convert.ToChar(solved[i]).ToString();
            }
            MetinCikti.Text = sonuc;
        }
    }
}
