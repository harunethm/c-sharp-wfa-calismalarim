using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikiSayiArasindakiAsallar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox1.Text = "";

                for (int i = 2; i < Convert.ToInt32(textBox2.Text); i++)
                {
                    bool asalMi = true;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            asalMi = false;
                        }
                    }

                    if (asalMi)
                        textBox1.Text += i + System.Environment.NewLine;
                }
            }
        }
    }
}
