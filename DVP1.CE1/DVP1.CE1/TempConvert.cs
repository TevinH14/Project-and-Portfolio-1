using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class TempConvert
    {
        public static void UserTempConvert()
        {
            Console.WriteLine("Welcome to TempConvert. Would you like to...");
            Console.WriteLine("1. Convert temperatrue from fahrenheit to celsius\r\n2. Convert temperature from celsius to fehrentheit");
            string userChoiceString = Console.ReadLine();
            int userChoice;
            while (!(int.TryParse(userChoiceString, out userChoice)))
            {
                Console.WriteLine("please only enter numbers to convert ");
                Console.WriteLine("1. Convert temperatrue from fahrenheit to celsius\r\n2. Convert temperature from celsius to fehrentheit");
                userChoiceString = Console.ReadLine();
            }
            if (userChoice == 1)
            {
                Console.WriteLine("Ok, what temperatrue would you like to convert (example:72)");
                string fehrenheitString = Console.ReadLine();
                double fehrenheit;
                while (!(double.TryParse(fehrenheitString, out fehrenheit)))
                {
                    Console.WriteLine("please only enter a number ");
                    fehrenheitString = Console.ReadLine();
                }
                double fehrenheitConvert = (fehrenheit - 32) * 5 / 9;
                Console.WriteLine($"Excellent! {fehrenheit} fehrenheit would be {fehrenheitConvert} celsius");
            }
            else if (userChoice == 2 )
            {
                Console.WriteLine("Ok, what temperatrue would you like to convert (example:72)");
                string celsiusString = Console.ReadLine();
                double celsius;
                while (!(double.TryParse(celsiusString, out celsius)))
                {
                    Console.WriteLine("please only enter a number ");
                    celsiusString = Console.ReadLine();
                }
                double celsiusConvert = celsius * 9 / 5 + 32;
                Console.WriteLine($"Excellent! {celsius}celsius would be {celsiusConvert} fehrenheit");
            }
            Console.WriteLine("press any key to return to the main menu ");
            Console.ReadLine();
            Menu.MenuSelection();
        }
    }
}
