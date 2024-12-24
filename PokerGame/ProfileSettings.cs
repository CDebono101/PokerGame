using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    public class ProfileSettings
    {
        public static void ProfileSettingsMenu(PlayerProfile playerOne)
        {
            Console.Clear();
            Console.WriteLine("Please select an option...\n");
            Console.WriteLine("1. View Profile");
            Console.WriteLine("2. View Balance");
            Console.WriteLine("3. Change Name");
            Console.WriteLine("4. Return to main menu\n");
            string? userOption = Console.ReadLine();
            UserInputCheck(playerOne, userOption!);
        }

        private static void UserInputCheck(PlayerProfile playerOne, string _userChoice)
        {
            if (_userChoice == "1" || _userChoice == "2" || _userChoice == "3" || _userChoice == "4" || _userChoice == "5")
            {
                ProfileMenuSwitch(playerOne, _userChoice);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please insert a valid number.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                ProfileSettingsMenu(playerOne);
            }
        }

        private static void ProfileMenuSwitch(PlayerProfile playerOne, string _userChoice)
        {
            switch (_userChoice)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(playerOne.GetData() + "\n");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    ProfileSettingsMenu(playerOne);
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine(playerOne.GetBal() + "\n");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    ProfileSettingsMenu(playerOne);
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Please insert new name.");
                    string? newName = Console.ReadLine();
                    Console.WriteLine(playerOne.UpdateName(newName!) + "\n");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    ProfileSettingsMenu(playerOne);
                    break;

                case "4":
                    Menus.MainMenu(playerOne);
                    break;

            }
        }

    }
}
