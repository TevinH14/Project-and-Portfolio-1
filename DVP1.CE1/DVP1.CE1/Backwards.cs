using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DVP1.CE1
{
    class Backwards
    {
        public static void UserBackwards()
        {
            Console.WriteLine("Welcome to Backwards:\r\nTo begin, please enter a sentence containing at least 6 \r\nwords...\r\n");
            string userSentence = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(userSentence))
            {
                Console.WriteLine("please only enter words");
                Console.WriteLine("Welcome to Backwards:\r\nTo begin, please enter a sentence containing at least 6 \r\nwords...");
                userSentence = Console.ReadLine();
            }
            string backwardsSentence = new string(userSentence.Reverse().ToArray());
            //test test test 
            //Console.WriteLine($"\r\n{backwardsSentence}");
            Console.WriteLine($"\r\nthank you, you entered the sentence\r\n{userSentence}\r\n");
            Console.WriteLine($"Backwards this sentence would read:\r\n{backwardsSentence}");

            Console.WriteLine("press any key to return to the main menu ");
            Console.ReadLine();
            Menu.MenuSelection();

        }
    }
}
