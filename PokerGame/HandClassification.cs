using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static PokerGame.Enums.Enums;

namespace PokerGame
{
    public class HandClassification
    {
        public static float BreakHand(List<PlayerCardData> _playerHand)
        {
            List<int> suits = new List<int>();
            List<int> cards = new List<int>();

            foreach(var card in _playerHand)
            {
                cards.Add(card.Card);
            }

            foreach (var card in _playerHand)
            {
                suits.Add(card.Suit);
            }

            return HandCheck(suits, cards);
        }

        private static float HandCheck(List<int> _suits, List<int> _cards)
        {
            _cards.Sort();

            bool quads = HandBool.Quads(_cards);
            bool flush = HandBool.Flush(_suits);
            bool straight = HandBool.Stright(_cards);
            bool trips = HandBool.Trips(_cards);
            bool twoPair = HandBool.TwoPair(_cards);
            bool pair = HandBool.Pair(_cards);

            if (flush == true && straight == true)
            {
                return 1000;
            }
            else if (quads == true)
            {
                return 500;
            }
            else if (trips == true && pair == true)
            {
                return 50;
            }
            else if (flush == true)
            {
                return 25;
            }
            else if (straight == true)
            {
                return 10;
            }
            else if (trips == true)
            {
                return 5;
            }
            else if (twoPair == true)
            {
                return 3;
            }
            else if (pair == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

    }

}
