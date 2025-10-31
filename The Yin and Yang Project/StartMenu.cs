using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Yin_and_Yang_Project
{
    internal class StartMenu
    {
        public static void Startmenu() 
        {
            Console.WriteLine("Welcome to The Yin and Yang Project!");
            Console.WriteLine("PLEASE JUST INPUT THE NUMBER");
            Console.WriteLine("1.\tPlay Game");
            Console.WriteLine("2.\tSettings");
            Console.WriteLine("3.\tExit");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    CharacterSelection.Characterselection();
                    break;
                case "2":
                    SettingsMenu.Settingsmenu();
                    break;
                case "3":
                    Console.WriteLine("\nAre you sure?");
                    string exitInput = Console.ReadLine().ToLower();
                    if (exitInput == "yes" || exitInput == "y")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Startmenu();
                    }
                    break;
                default:
                    Console.WriteLine("\nInvalid input. Please try again.");
                    Startmenu();
                    break;
            }
        }
    }
}
