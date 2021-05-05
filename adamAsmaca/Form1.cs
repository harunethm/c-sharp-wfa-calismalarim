using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adamAsmaca
{
    public partial class Form1 : Form
    {
        Player p1;
        Player p2;
        Game game;
        Txt txt;
        public Form1()
        {
            InitializeComponent();
            p1 = new Player(0, "harun", true);
            p2 = new Player(1, "ethem", false);
            game = new Game(p1.Name, p2.Name);
            txt = new Txt();
            lblTahminci.Text = "-";
            lblKalanHak.Text = "0";
            lblSkor.Text = "0";
            LvUpdate(txt.ScoreBoard());
        }

        private void Klavye_Click(object sender, EventArgs e)
        {
            if (game.IsStart)
            {
                Button btn = (Button)sender;
                //doğru tuş
                if (game.GuessWord.Contains(btn.Text.ToLower()))
                {
                    for (int i = 0; i < game.GuessWord.Length; i++)
                    {
                        if (game.GuessWord[i].ToString() == (btn.Text.ToLower()))
                        {
                            TextBox txt = (TextBox)Controls.Find("txt_" + i + "_" + game.GuessWord[i], true)[0];
                            txt.Text = game.GuessWord[i].ToString();
                            game.TrueLetterCount++;
                        }
                    }
                }
                //yanlış tuş
                else
                {
                    Label lbl = (Label)Controls.Find("lbl_" + game.RemRight, true)[0];
                    lbl.Visible = true;
                    btn.BackColor = Color.Red;
                    btn.Enabled = false;
                    game.RemRight--;
                    p1.Score -= 10;
                }
                //hak bitmesiyle kaybedilen oyun
                if (game.RemRight == 0)
                {
                    //lose conditions
                    game.EndGame();
                    gbKelime.Controls.Clear();
                    lblKalanHak.Text = "6";
                    lblSkor.Text = "0";
                    btnBaslat.Text = "Başlat";
                    nudHarfSayisi.Enabled = true;
                    ResetKnowledge();
                }
                //doğru bilerek kazanılan oyun
                if (game.TrueLetterCount == game.GuessWord.Length)
                {
                    //win conditions
                    game.EndGame();
                    gbKelime.Controls.Clear();
                    lblKalanHak.Text = "6";
                    lblSkor.Text = "0";
                    btnBaslat.Text = "Başlat";
                    nudHarfSayisi.Enabled = true;
                    txt.RegisterPlayerScore(p1.Name, p1.Score);
                    txt.RegisterPlayerScore(p2.Name, p2.Score);
                    ResetKnowledge();
                    for (int i = 1; i < 7; i++)
                    {
                        Label lbl = (Label)Controls.Find("lbl_" + i, true)[0];
                        lbl.Visible = false;
                    }
                }
            }
        }
        private void ResetKnowledge()
        {
            string _ = "qwertyuıopğüasdfghjklşizxcvbnmöç";
            for (int i = 0; i < 32; i++)
            {
                Button btn = (Button)Controls.Find("btn_" + _[i], true)[0];
                btn.Enabled = true;
                btn.BackColor = SystemColors.ButtonFace;
            }

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (!game.IsStart)
            {
                game.StartGame((int)nudHarfSayisi.Value, gbKelime);
                lblTahminci.Text = p1.Name;
                p1.Score += game.GuessWord.Length * 10;
                lblKalanHak.Text = game.RemRight.ToString();
                lblSkor.Text = p1.Score.ToString();
                btnBaslat.Text = "Durdur";
                nudHarfSayisi.Enabled = false;
                //-----
                label4.Text = game.GuessWord;
            }
            else
            {
                game.EndGame();
                gbKelime.Controls.Clear();
                lblKalanHak.Text = "6";
                lblSkor.Text = "0";
                btnBaslat.Text = "Başlat";
                nudHarfSayisi.Enabled = true;
            }
        }

        public void LvUpdate(string[,] scoreBoard)
        {
            for (int i = 0; i < scoreBoard.Length / 2; i++)
            {
                string[] _ = { scoreBoard[i, 0], scoreBoard[i, 1] };
                ListViewItem itm = new ListViewItem(_);
                lvSkorTablosu.Items.Add(itm);
            }
        }
    }
}
