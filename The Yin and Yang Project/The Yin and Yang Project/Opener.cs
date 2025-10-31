using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Yin_and_Yang_Project
{
    internal class Opener
    {
        public static void TypeEffect(string message, int delay)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
        public static void StartOfGame()
        {
            string message = "Long ago sourcerers could be found in plenty.";
            TypeEffect(message, 50); // adjust delay for faster/slower typing

            Thread.Sleep(500); // pause between messages

            string message2 = "That was nearly 2,000 years ago now...";
            TypeEffect(message2, 50); // adjust delay for faster/slower typing
            Thread.Sleep(500); // pause between messages

            string message3 = "The time in specific most people look at is the time two great sourcerers lived...";
            TypeEffect(message3, 50); // adjust delay for faster/slower typing

            Thread.Sleep(500); // pause between messages

            string message4 = "This time was the 1200s during the great crusades.";
            TypeEffect(message4, 50); // adjust delay for faster/slower typing

            Thread.Sleep(500); // pause between messages

            string message5 = "These two men were one and the same... yet so different";
            TypeEffect(message5, 50); // adjust delay for faster/slower typing

            Thread.Sleep(500); // pause between messages

            string message6 = "The two men were not anywhere near related, but they were closely connected.";
            TypeEffect(message6, 50); // adjust delay for faster/slower typing

            Thread.Sleep(500); // pause between messages

            string message7 = "One was known for his kindness and mercy...";
            TypeEffect(message7, 50); // adjust delay for faster/slower typing

            Thread.Sleep(500); // pause between messages

            string message8 = "The other for his crualty and bloodshed...";
            TypeEffect(message8, 50); // adjust delay for faster/slower typing

            Thread.Sleep(500); // pause between messages

            string message9 = "They were both knights who had the greatest techniques in mana manipulation.";
            TypeEffect(message9, 50); // adjust delay for faster/slower typing

            Thread.Sleep(500); // pause between messages

            string message10 = "The two men had deals with the highest orders to exist.";
            TypeEffect(message10, 50); // adjust delay for faster/slower typing

            Thread.Sleep(500); // pause between messages

            string message11 = "One was to protect the weak and innocent...";
            TypeEffect(message11, 50); // adjust delay for faster/slower typing

            Thread.Sleep(500); // pause between messages

            string message12 = "The other was to destroy and conquer all who opposed him...";
            TypeEffect(message12, 50); // adjust delay for faster/slower typing

            Thread.Sleep(500); // pause between messages

            string message13 = "Thus, the Yin and Yang were born...";
            TypeEffect(message13, 50); // adjust delay for faster/slower typing

            Thread.Sleep(1000); // pause before character selection

            if (Variables.AlexanderChosen == true)
            {
                Alexander.AlexanderChosen();
            }
            else if (Variables.ArthurChosen == true)
            {
                Arthur.ArthurChosen();
            }
        }
    }
}
