using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Yin_and_Yang_Project
{
    internal class SettingsMenu
    {
        public static void Settingsmenu()
        {
            Console.WriteLine("Settings Menu");
            Console.WriteLine("No current settings available.");
            Console.WriteLine("1.\tBack to Main Menu");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "1":
                    StartMenu.Startmenu();
                    break;
                case "back to main menu":
                    StartMenu.Startmenu();
                    break;
                case "extra health":
                    Console.WriteLine("Cheat code activated: Extra Health!");
                    Variables.PlayerHealth += 100;
                    Settingsmenu();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    Settingsmenu();
                    break;
            }
        }
    }
}
