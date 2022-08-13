using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._9_Methods
{
    class MiscMeth
    {
        //Passing Arguments of Reference Type
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        static void ModifyArray(int[] arrParam)
        {
            arrParam[0] = 5;
            Console.Write("In ModifyArray() the param is: ");
            PrintArray(arrParam);
        }

        static void PrintArray(int[] arrParam)
        {
            Console.Write("[");
            int length = arrParam.Length;
            if (length > 0)
            {
                Console.Write(arrParam[0].ToString());
                for (int i = 1; i < length; i++)
                {
                    Console.Write(", {0}", arrParam[i]);
                }
            }
            Console.WriteLine("]");
        }
        static void MiscMet()
        {

            int[] arrArg = new int[] { 1, 2, 3 };

            Console.Write("Before ModifyArray() the argument is: "); PrintArray(arrArg);

            // Modifying the array's argument  
            ModifyArray(arrArg); 

            Console.Write("After ModifyArray() the argument is: "); PrintArray(arrArg);
        }
        //TRAINGLE
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        static void Triangle()
        {
            // Entering the value of the variable n   
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Printing the upper part of the triangle   
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }

            // Printing the bottom part of the triangle   
            // that is under the longest line   
            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        //TEMPERATURE CONVERTER
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        static double ConvertFahrenheitToCelsius(double temperatureF)
        {
            double temperatureC = (temperatureF - 32) * 5 / 9;
            return temperatureC;
        }

        static void Temp()
        {
            Console.Write("Enter your body temperature in Fahrenheit degrees: ");
            double temperature = double.Parse(Console.ReadLine());

            temperature = ConvertFahrenheitToCelsius(temperature);

            Console.WriteLine("Your body temperature in Celsius degrees is {0}.", temperature);

            if (temperature >= 37)
            {
                Console.WriteLine("You are ill!");
            }
        }
        //GETMONTHS
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        static string GetMonth(int monthNum)
        {
            string month="";
            switch (monthNum)
            {
                case 1:
                    month = "January";
                    break;
                case 2:
                    month = "February";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "December";
                    break;
                default:
                    Console.WriteLine("Invalid Month!");
                    return null;
                    //break;
            }
            return month;
        }
        static void SayPeriod(int startMonth, int endMonth)
        {
            int period = endMonth - startMonth;
            if (period < 0)
            {
                //Fix negative distance
                period += 12;
            }
            Console.WriteLine("There is {0} months period from {1} to {2}." ,period, GetMonth(startMonth), GetMonth(endMonth));
        }
        static void PrintMain()
        {
            Console.WriteLine("First month (1-12): ");
            int firstmonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Second month (1-12): ");
            int secondmonth = int.Parse(Console.ReadLine());

            SayPeriod(firstmonth, secondmonth);
        }
        //DATA VALIDATION
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        static void DataVa()
        {
            Console.WriteLine("What time is it?");

            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            bool isValidTime = ValidateHours(hours) && ValidateMinutes(minutes);
            if (isValidTime)
            {
                Console.WriteLine("The time is {0}:{1} now.", hours, minutes);
            }
            else
            {
                Console.WriteLine("Incorrect time!");
            }
        }
        static bool ValidateHours(int hours)
        {
            //conditions as in if statements
            bool result = (hours >= 0) && (hours < 24);
            return result;
        }
        static bool ValidateMinutes(int minutes)
        {
            bool result = (minutes >= 0) && (minutes <= 59);
            return result;
        }


        //SORTING (selection)
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        static int[] Sort(params int[] numbers)
        {
            //The sorting logic:
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                //Loop operating over the unsorted part of the array
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    //Swapping the values
                    if (numbers[i] > numbers[j])
                    {
                        int oldNum = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = oldNum;
                    }
                }
            }//End of the sorting logic
            return numbers;
        }
        static void PrintNumbers(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}", numbers[i]);
                if (i < (numbers.Length - 1))
                {
                    Console.Write(" , ");
                }
            }
        }
        static void Num()
        {
            int[] numbers = Sort(10, 3, 5, -1, 0, 12, 8);
            PrintNumbers(numbers);
        }
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    }
}
