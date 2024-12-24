using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    public class HandGenerationDeckReset
    {

        //Randmon generation of numbers

        public static void CardGen()
        {
            Console.Clear();
            List<int> pokerHand = new List<int>();
            Random random = new Random();
            for(int i = 1; i < 6; i++)
            {
                int deckGen = random.Next(1, 13);
                int suitGen = random.Next(1, 4);
                pokerHand.Add(deckGen);
                pokerHand.Add(suitGen);
            }

            HandSeperation(pokerHand);
        }

        // Seperates the suits and the cards into seperate lists.

        private static void HandSeperation(List<int> _pokerHand)
        {
            List<int> suitsInHand = new List<int>();
            List<int> cardsInHand = new List<int>();

            //Check that both of the values have the same amount of indexs. Last checked cards in hand = 5 suits in hand = 4.

            for ( int i = 0; i < _pokerHand.Count(); i++) 
            {
                if(i%2 == 0)
                {
                    cardsInHand.Add(_pokerHand[i]);
                }
                else
                {
                    suitsInHand.Add(_pokerHand[i]);
                }
            }

            HandBuilder(suitsInHand, cardsInHand);
        }

        //Handbuilder method builds hand by creating an object list.

        private static void HandBuilder(List<int> _suitsInHand, List<int> _cardsInHand)
        {
            List<PlayerCardData> playerHand = new List<PlayerCardData>();

            for (int i = 0; i < 5; i++)
            {
                playerHand.Add(new PlayerCardData(_cardsInHand[i], _suitsInHand[i]));
            }

            bool doopCheck = HandCheck(playerHand);
           
            if (doopCheck == true)
            {
                CardGen();
            }
            else
            {
                //Continue to HandClassification.
            }

        }

        private static bool HandCheck(List<PlayerCardData> _playerHand)
        {
            List<string> playerHandL = new List<string>();

            foreach (var card in _playerHand)
            {
                playerHandL.Add(card.GetCard());
            }

            for (var i = 0; i < 5; i++)
            {
                for (var j = i + 1; j < 5; j++)
                {
                    if (playerHandL[i] == playerHandL[j])
                    {
                        return true;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return false;

        }
    }
}
