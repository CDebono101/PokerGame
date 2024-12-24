using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokerGame
{
    public class Menus
    {
        public static void CreateOrExitProfile()
        {
            Console.Clear();
            Console.WriteLine("Please select an option.\n");
            Console.WriteLine("0: Create a new Player Profile");
            Console.WriteLine("1: Exit\n");
            string? userOption = Console.ReadLine();

            switch(userOption)
            {
                case "0":
                    CreateProfile();
                    break;
            }
        }

        private static void CreateProfile()
        {
            Console.Clear();
            Console.WriteLine("Please enter player name: ");
            string? name = Console.ReadLine();
            int id = 1;
            float bal = 0;
            PlayerProfile playerOne = new PlayerProfile(name!, id, bal);
            Console.WriteLine("Player Profile " +  name + " created.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            MainMenu(playerOne);
        }

        public static void MainMenu(PlayerProfile _playerOne)
        {
            Console.Clear();
            Console.WriteLine("Welcome " + _playerOne.Name + "\n");
            Console.WriteLine("Please select an option:\n");
            Console.WriteLine("1. Play");
            Console.WriteLine("2. View Balance");
            Console.WriteLine("3. Add to balance");
            Console.WriteLine("4. Player Settings");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            string? userChoice = Console.ReadLine();
            UserInputCheck(_playerOne, userChoice!);


        }

        private static void UserInputCheck(PlayerProfile playerOne, string _userChoice)
        {
            if(_userChoice == "1" || _userChoice == "2" || _userChoice == "3" || _userChoice == "4" || _userChoice == "5")
            {
                MainMenuSwitch(playerOne, _userChoice);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please insert a valid number.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                MainMenu(playerOne);
            }
        }

        private static void MainMenuSwitch(PlayerProfile playerOne, string _userChoice) 
        {
            switch (_userChoice)
            {
                case "1":
                    Game.GameMainAnimation(playerOne);
                    break;

                case "2":
                    Console.Clear ();
                    Console.WriteLine(playerOne.GetBal()+"\n");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    MainMenu(playerOne);
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Insert the amount you wish to top up.\n");
                    string? topUp = Console.ReadLine();
                    int topUpI = Convert.ToInt32(topUp);
                    playerOne.AddBal(topUpI);
                    Console.Clear();
                    Console.WriteLine("Top up sucessful...\n\n" + playerOne.GetBal() + "\n");
                    Console.WriteLine("Press any key to Continue.");
                    Console.ReadKey();
                    MainMenu(playerOne);
                    break;

                case "4":
                    ProfileSettings.ProfileSettingsMenu(playerOne);
                    break;

                case "5":
                    ExitConfirmation(playerOne);
                    break;
            }

        }

        public static void ExitConfirmation(PlayerProfile playerOne)
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to exit?\n");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No\n");
            string? userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Environment.Exit(0);
            }
            else if (userChoice == "2")
            {
                MainMenu(playerOne);
            }
            else
            {
                Console.Clear();
                Console.WriteLine(userChoice + " Is not a valid option please try again.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                ExitConfirmation(playerOne);
            }
        }
    }
}
