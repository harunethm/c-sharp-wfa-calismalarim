using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adamAsmaca
{
    class Game
    {
        private Player player1;
        private Player player2;
        private int currentPlayerID = -1;
        private bool isStart = false;
        private string guessWord = "";
        private int remRight = 6;
        private int trueLetterCount = 0;
        Txt txt = new Txt();

        public Game(string p1Name, string p2Name)
        {
            this.player1 = new Player(0, p1Name, true);
            this.player2 = new Player(1, p2Name, false);
        }

        #region getSet
        public Player Player1
        {
            get
            {
                return player1;
            }
            set
            {
                player1 = value;
            }
        }
        public Player Player2
        {
            get
            {
                return player2;
            }
            set
            {
                player2 = value;
            }
        }
        public int CurrentPlayerID
        {
            get
            {
                return currentPlayerID;
            }
            set
            {
                currentPlayerID = value;
            }
        }
        public int RemRight
        {
            get
            {
                return remRight;
            }
            set
            {
                remRight = value;
            }
        }
        public int TrueLetterCount
        {
            get
            {
                return trueLetterCount;
            }
            set
            {
                trueLetterCount = value;
            }
        }
        public bool IsStart
        {
            get
            {
                return isStart;
            }
            set
            {
                isStart = value;
            }
        }
        public string GuessWord
        {
            get
            {
                return guessWord;
            }
            set
            {
                guessWord = value;
            }
        }
        #endregion

        #region methods

        public bool StartGame(int letterCount, GroupBox gb)
        {
            try
            {
                isStart = true;
                currentPlayerID = 0;
                Txt txt = new Txt();
                guessWord = txt.PickWord(letterCount);
                remRight = 6;

                for (int i = 0; i < guessWord.Length; i++)
                {
                    TextBox tb = new TextBox();
                    tb.Name = "txt_" + i + "_" + guessWord[i];
                    tb.Location = new System.Drawing.Point(10 + 30 * i, 20);
                    tb.Size = new System.Drawing.Size(30, 30);
                    gb.Controls.Add(tb);
                }

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public bool NextPlayer()
        {
            return true;
        }

        public bool EndGame()
        {
            try
            {
                isStart = false;
                trueLetterCount = 0;
                guessWord = "";
                remRight = 6;
                currentPlayerID = -1;
                Form1 f1 = new Form1();
                f1.LvUpdate(txt.ScoreBoard());
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        #endregion
    }
}
