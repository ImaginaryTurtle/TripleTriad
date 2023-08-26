using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleTriad
{
    internal class Board
    {
        private Card[,] cards = new Card[3, 3];
        public Card[,] Cards { get; set; }

        private int PlayerPoints { get; set; }
        private int EnemyPoints { get; set; }

        public Board()
        {
            PlayerPoints = 0;
            EnemyPoints = 0;
        }

        public void PlaceCard(int cardLoc, Card card)
        {
            
        }
    }
}
