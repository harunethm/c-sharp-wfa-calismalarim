using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adamAsmaca
{
    class Txt
    {
        private string wordFile = Directory.GetCurrentDirectory() + @"\words.txt";
        private string scoreBoardFile = Directory.GetCurrentDirectory() + @"\scoreBoard.txt";

        #region methods
        public string PickWord(int letterCount)
        {
            try
            {
                string[] words = File.ReadAllLines(wordFile);
                string guessWord;
                Random rnd = new Random();
                if (letterCount == 0)
                {
                    guessWord = words[rnd.Next(words.Length)];
                }
                else
                {
                    List<string> _ = new List<string>();

                    foreach (var word in words)
                    {
                        if (word.Length == letterCount)
                            _.Add(word);
                    }

                    guessWord = _[rnd.Next(_.Count)];
                }
                return guessWord;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return "";
            }
        }

        public bool AddWord()
        {
            return false;
        }

        public bool DelWord()
        {
            return false;
        }
        public bool IsTherePlayer(string name)
        {
            string[] allLines = File.ReadAllLines(scoreBoardFile);
            foreach (string line in allLines)
            {
                if (line.Contains(name))
                    return true;
            }
            return false;
        }

        public int PlayerScore(string name)
        {
            string[] _ = File.ReadAllLines(scoreBoardFile);
            foreach (string item in _)
            {
                if (item.Contains(name))
                    return Convert.ToInt32(item.Substring(item.IndexOf('|') + 1));
            }
            return 0;
        }

        public string[,] ScoreBoard()
        {
            string[] _ = File.ReadAllLines(scoreBoardFile);
            string[,] scoreBoard = new string[_.Length, 2];

            for (int i = 0; i < _.Length; i++)
            {
                scoreBoard[i, 0] = _[i].Substring(0, _[i].IndexOf('|'));
                scoreBoard[i, 1] = _[i].Substring(_[i].IndexOf('|') + 1);
            }

            return scoreBoard;
        }

        public bool RegisterPlayerScore(string pName, int pScore)
        {
            try
            {
                if (!IsTherePlayer(pName))
                {
                    string _ = "";
                    _ += File.ReadAllLines(scoreBoardFile);
                    _ += pName + "|" + pScore;
                    File.WriteAllText(scoreBoardFile, _);
                }
                else
                {
                    string[] players = File.ReadAllLines(scoreBoardFile);

                    for (int i = 0; i < players.Length; i++)
                    {
                        if (players[i].Contains(pName) && Convert.ToInt32(players[i].Substring(players[i].IndexOf('|') + 1)) < pScore)
                        {
                            players[i] = pName + "|" + pScore;
                        }
                    }

                    File.WriteAllLines(scoreBoardFile, players);
                }
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