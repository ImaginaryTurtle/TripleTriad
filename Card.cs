using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleTriad
{
    internal class Card
    {

        private int TopValue { get; set; }
        private int LeftValue { get; set; }
        private int RightValue { get; set; }
        private int BottomValue { get; set; }

        public string ImgSource { get; private set; }
        public string CardName { get; private set; }

        public bool IsPlayerCard { get; private set; }

        public Card (int topValue, int leftValue, int rightValue, int bottomValue, string imgSource, string cardName, bool isPlayerCard)
        {
            TopValue = topValue;
            LeftValue = leftValue;
            RightValue = rightValue;
            BottomValue = bottomValue;
            ImgSource = imgSource;
            CardName = cardName;
            IsPlayerCard = isPlayerCard;
        }


        private void CardFlip()
        {
            IsPlayerCard = !IsPlayerCard;
        }

        public bool CardFight(string attackDirection, int attackDamage)
        {
            bool wasFlipped = false;
            switch(attackDirection)
            {
                case "TOP":
                    if (TopValue < attackDamage)
                    {
                        this.CardFlip();
                        wasFlipped = true;
                    }
                    break;

                case "LEFT":
                    if (LeftValue < attackDamage)
                    {
                        this.CardFlip();
                        wasFlipped = true;
                    }
                    break;

                case "RIGHT":
                    if (RightValue < attackDamage)
                    {
                        this.CardFlip();
                        wasFlipped = true;
                    }
                    break;

                case "BOTTOM":
                    if (BottomValue < attackDamage)
                    {
                        this.CardFlip();
                        wasFlipped = true;
                    }
                    break;

                default:
                    break;
            }
            return wasFlipped;
        }
    }
}
