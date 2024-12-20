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
        public static void CreateDeckAndSuit()
        {
            List<int> deck = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13
            };

            List<int> suit = new List<int>()
            {
                1,2,3,4
            };

            test(deck, suit);

        }

        private static void test(List<int> deck,List<int> suit)
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

            for(int i = 0; i < pokerHand.Count(); i++)
            {
                Console.Write(pokerHand[i]);
            }

            Console.WriteLine();

            Console.ReadKey();

            HandSeperation(pokerHand, deck, suit);

        }

        private static void HandSeperation(List<int> _pokerHand, List<int> _deck, List<int> _suit)
        {
            List<int> suitsInHand = new List<int>();
            List<int> cardsInHand = new List<int>();

            Console.WriteLine(_pokerHand.Count());

            //Check that both of the values have the same amount of indexs. Last checked casrds in hand = 5 suts in hand = 4.

            for ( int i = 1; i <= _pokerHand.Count(); i++) 
            {
                if(i%2 == 0)
                {
                    suitsInHand.Add(_pokerHand[i]);
                }
                else
                {
                    cardsInHand.Add(_pokerHand[i]);
                }
            }

            Console.ReadKey();

            HandBuilder(suitsInHand, cardsInHand, _deck, _suit);
        }

        private static void HandBuilder(List<int> _suitsInHand, List<int> _cardsInHand, List<int> _deck, List<int> _suit)
        {
            List<string> handToDisplay = new List<string>();

            for(int i = 0; i <= _cardsInHand.Count(); i++)
            {
                switch(_cardsInHand[i])
                {
                    case 0:
                        handToDisplay.Add("A");
                        break;
                    case 1:
                        handToDisplay.Add(_cardsInHand[i].ToString());
                        break;
                    case 2:
                        handToDisplay.Add(_cardsInHand[i].ToString());
                        break;
                    case 3:
                        handToDisplay.Add(_cardsInHand[i].ToString());
                        break;
                    case 4:
                        handToDisplay.Add(_cardsInHand[i].ToString());
                        break;
                    case 5:
                        handToDisplay.Add(_cardsInHand[i].ToString());
                        break;
                    case 6:
                        handToDisplay.Add(_cardsInHand[i].ToString());
                        break;
                    case 7:
                        handToDisplay.Add(_cardsInHand[i].ToString());
                        break;
                    case 8:
                        handToDisplay.Add(_cardsInHand[i].ToString());
                        break;
                    case 9:
                        handToDisplay.Add(_cardsInHand[i].ToString());
                        break;
                    case 10:
                        handToDisplay.Add(_cardsInHand[i].ToString());
                        break;
                    case 11:
                        handToDisplay.Add("J");
                        break;
                    case 12:
                        handToDisplay.Add("Q");
                        break;
                    case 13:
                        handToDisplay.Add("K");
                        break;
                }

                switch (_suitsInHand[i])
                {
                    case 0:
                        handToDisplay.Add("h");
                        break;
                    case 1:
                        handToDisplay.Add("c");
                        break;
                    case 2:
                        handToDisplay.Add("d");
                        break;
                    case 3:
                        handToDisplay.Add("s");
                        break;
                    default:
                        continue;
                }
            }

            foreach (var card in _cardsInHand)
            {
                Console.Write(card);
            }
            
            Console.ReadKey();
        }
    }
}
