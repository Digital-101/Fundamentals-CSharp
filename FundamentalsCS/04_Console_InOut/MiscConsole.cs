using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FundamentalsCS._4_Console_InOut
{
    class MiscConsole
    {
        static void MiscIO(string[] args)
        {
            //Days of the week
            Console.WriteLine("{0:G}", DayOfWeek.Tuesday);//string
            Console.WriteLine("{0:D}", DayOfWeek.Tuesday);//num
            Console.WriteLine("{0:X}", DayOfWeek.Tuesday);//hex

            //CULTURE INFO
            DateTime d = new DateTime(2020, 12, 08, 22, 30, 22);

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine("{0:N}", 1234.56);
            Console.WriteLine("{0:D}", d);

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-ZA");
            Console.WriteLine("{0:N}", 1234.56);
            Console.WriteLine("{0:D}", d);

            //TRYPARSE
            Console.WriteLine("Enter a number to be squared");
            string str = Console.ReadLine();
            int intValue;
            bool parseSuccess = Int32.TryParse(str, out intValue);
            Console.WriteLine(parseSuccess ? "The square of the number is " + intValue * intValue + "." : "Invalid number!");

            //Reading Keys
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Character entered: " + key.KeyChar);
            Console.WriteLine("Special keys: " + key.Modifiers);

            ///////
            ///
            bool noPrime = false;
            int j;

            Console.Write("Enter target: ");
            int target = int.Parse(Console.ReadLine());

            for (int i = 2; i <= target; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        noPrime = true;
                        break;
                    }
                }
                if (!noPrime)
                {
                    Console.Write("{0} ", j);
                }
                else
                {
                    noPrime = false;
                }
                //Console.WriteLine();
            }
        }
     }
}
