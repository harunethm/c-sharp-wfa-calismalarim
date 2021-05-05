
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adamAsmaca
{
    class Player
    {
        private int playerID = 0;
        private string name = "player";
        private int score = 0;
        private bool gameTurn = false;

        public Player(int id, string name, bool gameTurn)
        {
            this.playerID = id;
            this.name = name;
            this.gameTurn = gameTurn;
            //isme göre skor tablosunda aratıp skoru varsa eklenmeli yoksa sıfır yazılmalı
            Txt txt = new Txt();
        }

        #region getSet
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                this.score = value;
            }
        }
        public bool GameTurn
        {
            get
            {
                return gameTurn;
            }
            set
            {
                this.gameTurn = value;
            }
        }
        public int PlayerID
        {
            get
            {
                return playerID;
            }
            set
            {
                this.playerID = value;
            }
        }
        #endregion
    }
}
