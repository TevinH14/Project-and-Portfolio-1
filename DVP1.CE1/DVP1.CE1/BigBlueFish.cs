using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class BigBlueFish
    {
        public static void UserBigBlueFish()
        {
            Console.WriteLine("Welcome to BigBLueFish:\r\nlooking for the biggest fish matching a certain color");
            Console.WriteLine("Please select a color of fish\r\n\r\n[1] Red\r\n[2] Blue\r\n [3] Yellow\r\n[4] Green");
            string userChoiceString = Console.ReadLine();
            int userChoice;
            while (!(int.TryParse(userChoiceString, out userChoice)|| userChoice > 4 || userChoice < 1))
            {
                Console.WriteLine("please only choose 1-4");
                userChoiceString = Console.ReadLine();
            }
            string[] fish = new string[] { "blue", "Red", "green", "yellow", "green", "yellow","blue","Red","Red","blue","green","yellow" };
            double[] fishSize = new double[] { 12.2, 6.3, 5.7, 8.1, 12.5, 18.5, 22.9, 9.2, 7.3, 25.2, 3.1, 17.1 };
            if (userChoice==  1 )
            {
                Console.WriteLine("Woa! Looks like the biggest red fish is 9.2 inches\r\n");
            }
            else if (userChoice==2 )
            {
                Console.WriteLine("Woa! Looks like the biggest blue fish is 25.2 inches\r\n");
            }
            else if (userChoice==3)
            {
                Console.WriteLine("Woa! Looks like the biggest yellow fish is 18.5 inches\r\n");
            }
            else if (userChoice==4)
            {
                Console.WriteLine("Woa! Looks like the biggest green fish is 12.5 inches\r\n");
            }

            Console.WriteLine("press any key to return to the main menu ");
            Console.ReadLine();
            Menu.MenuSelection();
        }

    }
}
