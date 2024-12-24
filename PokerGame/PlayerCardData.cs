using PokerGame.Enums;
using PokerGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    public class PlayerCardData : ICard 
    {
        private int suit;
        private int card;
        private string suitValue;
        private string cardValue;

        public PlayerCardData(int card, int suit)
        {
            Card = card;
            Suit = suit;
            Enums.Enums.Suits suitValue = (Enums.Enums.Suits)suit;
            Enums.Enums.Cards cardValue = (Enums.Enums.Cards)card;
            this.suitValue = suitValue.ToString();
            this.cardValue = cardValue.ToString();
        }

        public int Card {
            get { return card; }
            set { card = value; }
        }
        public int Suit 
        {
            get { return suit; }
            set { suit = value; } 
        }


        public string GetCard()
        {
            return cardValue.ToString() + suitValue.ToString();
        }
    }
}
