using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hanoiKuleleriAlgoritmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.Text != "")
            {   
                //hesapla(diskSayısı, kaynakCubuk, hedefCubuk, araciCubuk)
                hesapla(Convert.ToInt32(textBox1.Text), "1", "3", "2");
                label2.Text = Convert.ToString(listBox1.Items.Count) + " hamle yapılır.";
                textBox1.Text = textBox1.Text.Substring(textBox1.Text.Length - 1);
            }
        }

        void hesapla(int diskSayısı, string kaynakCubuk, string hedefCubuk, string araciCubuk)
        {
            if (diskSayısı <= 1)
            {
                listBox1.Items.Add(string.Format(kaynakCubuk + " >> " + hedefCubuk));
            }
            else
            {
                hesapla(diskSayısı - 1, kaynakCubuk, araciCubuk, hedefCubuk);
                listBox1.Items.Add(string.Format(kaynakCubuk + " => " + hedefCubuk));
                hesapla(diskSayısı - 1, araciCubuk, hedefCubuk, kaynakCubuk);
            }
        }
    }
}
