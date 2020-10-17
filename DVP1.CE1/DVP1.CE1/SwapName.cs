using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class SwapName
    {
        public static void UserNameSwap()
        {
            Console.WriteLine("Please enter your first Name then press enter.");
            string userFirstName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(userFirstName))
            {

            }

            Console.WriteLine("Please enter your Last Name then press enter.");
            string userLastName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(userLastName))
            {

            }
            Console.WriteLine($"\r\nExcellent! Your name ({userFirstName} " +
                $"{userLastName}) Reversed would be {userLastName}, {userFirstName}" +
                $".\r\n");

            Console.WriteLine("press any key to return to the main menu ");
            Console.ReadLine();
            Menu.MenuSelection();

        }
    }
}
