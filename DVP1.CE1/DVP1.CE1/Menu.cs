using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class Menu
    {
        public static void MenuSelection()
        {
            Console.WriteLine("\r\nCoding challenge menu:\r\nPlease press the the number for he challenge you want to run\r\n");
            Console.WriteLine("[1] Swap Names.\r\n[2] Backwards.\r\n[3]Age Convert\r\n[4] Temp Convert\r\n[5] Big blue fish.\r\n\r\n[0] Exit");
            string userChoiceString = Console.ReadLine();
            int userChoice;
            while (!(int.TryParse(userChoiceString, out userChoice) || (userChoice>5) || userChoice<0))
            {
                Console.WriteLine("Please only pick 1-5 then hit enter");
                Console.WriteLine("[1] Swap Names.\r\n[2] Backwards.\r\n[3] Age Convert\r\n[4] Temp Convert\r\n[5] Big blue fish.");
                userChoiceString = Console.ReadLine();
            }
            if (userChoice == 1 )
            {
                SwapName.UserNameSwap();
            }
            else if (userChoice == 2)
            {
                Backwards.UserBackwards();
            }
            else if (userChoice == 3)
            {
                AgeConverter.UserAgeconverted();
            }
            else if (userChoice == 4)
            {
                TempConvert.UserTempConvert();
            }
            else if (userChoice == 5)
            {
                BigBlueFish.UserBigBlueFish();
            }
            else if (userChoice == 0)
            {
                Console.WriteLine("GoodBye!");
                Environment.Exit(0);
            }
        }
    }
}
