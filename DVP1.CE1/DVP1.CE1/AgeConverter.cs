using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class AgeConverter
    {
       public static void UserAgeconverted()
        {
            Console.WriteLine("welcome to AgeConverter:\r\n\r\nPlease enter your firstname");
            string userFName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(userFName))
            {
                Console.WriteLine("please only enter your name\r\n\r\nplease enter your first name");
                userFName = Console.ReadLine();
            }
            Console.WriteLine($"Thank you {userFName}, now i know this personal but how old are you");
            string userAgeString  = Console.ReadLine();
            int userAge;
            while (!(int.TryParse(userAgeString, out userAge)))
            {
                Console.WriteLine("please only enter whole numbers\r\n\r\nplease enter your current age ");
                userAgeString = Console.ReadLine();
            }
            int days = userAge * 365;
            int hours= userAge* 8760;
            int mins=userAge* 525600;
            int secs=userAge* 31557600;
            //Test
            //Console.WriteLine($"{days.ToString("N0")}\r\n{hours.ToString("N0")}\r\n{mins.ToString("N0")}\r\n{secs.ToString("N0")}");
            Console.WriteLine($"{userAge} years, Fantastic! Next time someone asks, try\r\nanswering with:\r\n"+
            $"{days.ToString("N0")} days -or-\r\n{hours.ToString("N0")} hours -or-\r\n{mins.ToString("N0")} minutes -or-\r\n{secs.ToString("N0")} secounds\r\n\r\n");

            Console.WriteLine("press any key to return to the main menu ");
            Console.ReadLine();           
            Menu.MenuSelection();

        }
    }
}
