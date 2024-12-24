using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    public class Game
    {
        public static void GameMainAnimation(PlayerProfile _playerOne)
        {
            int i = 0;

            while (i < 4)
            {
                Console.Clear();
                Console.WriteLine("                                                         " + "Console Poker" + "                                                         ");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Shuffling");
                Console.Write(" .");
                Thread.Sleep(500);
                Console.Write("  .");
                Thread.Sleep(500);
                Console.Write("   .");
                Thread.Sleep(500);
                i++;
            }
            GameMain(_playerOne);
        }

        public static void GameMain(PlayerProfile _playerOne)
        {
            Console.Clear();
            Console.WriteLine("                                                         " + "Console Poker" + "                                                         ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please place a bet... OR enter 0 to return to menu...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(_playerOne.GetBal());
            Console.Write("Bet amount: ");
            string? betAmount = Console.ReadLine();

            if (betAmount!.Equals("0"))
            {
                Menus.MainMenu(_playerOne);
            }
            else
            {
                CheckBet(_playerOne, betAmount);
            }
        }

        public static void GameMainTwo(PlayerProfile _playerOne, List<PlayerCardData> playerHand, float _winnings) 
        {
            Console.Clear();
            Console.WriteLine("                                                         " + "Console Poker" + "                                                         ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please place a bet... OR enter 0 to return to menu...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            foreach (PlayerCardData playerCard in playerHand)
            {
                Console.Write(playerCard.GetCard());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Multiplier: " + _winnings.ToString());
            Console.WriteLine(_playerOne.GetBal());
            Console.Write("Bet amount: ");
            string? betAmount = Console.ReadLine();

            if (betAmount!.Equals("0"))
            {
                Menus.MainMenu(_playerOne);
            }
            else
            {
                CheckBet(_playerOne, betAmount);
            }
        }

        // Checking if bet is valid then moving to gen hand.

        private static void CheckBet(PlayerProfile _playerOne, string _betAmount)
        {
            if(_betAmount.Equals(" "))
            {
                Console.WriteLine();
                Console.WriteLine("Please insert a vaild bet...");
                Console.WriteLine("Press space to go again.");
                Console.ReadKey();
                GameMain(_playerOne);
            }

            int betAmountI = Convert.ToInt32(_betAmount);
            float betAmountF = (float)betAmountI;

            if (betAmountF > _playerOne.Bal)
            {
                Console.WriteLine();
                Console.WriteLine("Please insert a vaild bet...");
                Console.WriteLine("Press space to go again.");
                Console.ReadKey();
                GameMain(_playerOne);
            }
            else
            {
                HandGenerationDeckReset.CardGen(_playerOne);
            }
        }
    }
}
