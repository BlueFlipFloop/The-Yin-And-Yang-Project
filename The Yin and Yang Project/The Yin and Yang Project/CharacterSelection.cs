using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Yin_and_Yang_Project
{
    internal class CharacterSelection
    {
        public static void Characterselection()
        {
            Console.WriteLine("\nCharacter Selection");
            Console.WriteLine("1.\tAlexander Mercioles");
            Console.WriteLine("2.\tArthur Dexmond");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Variables.AlexanderChosen = true;
                Opener.StartOfGame();
            }
            else if (userInput == "2")
            {
                Variables.ArthurChosen = true;
                Opener.StartOfGame();
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please try again.");
                Characterselection();
            }
        }
    }
}
