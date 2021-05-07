using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikiSayiArasindaRandomSayiUretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(numericUpDown2.Value < numericUpDown1.Value))
            {
                int fark = (int)(numericUpDown2.Value - numericUpDown1.Value);
                if (listBox1.Items.Count < fark)
                {
                    bool flag = true;
                    do
                    {
                        Random rnd = new Random();
                        if (!listBox1.Items.Contains(rnd))
                        {
                            listBox1.Items.Add(rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1));
                            flag = false;
                        }
                    } while (flag);
                }
                else
                    label3.Text = "eklenebilecek tüm sayılar eklendi !!!";
            }
            else
            {
                label3.Text = "ilk sayı ikinci sayıdan küçük olmalı !!!";
            }
            
        }
    }
}
