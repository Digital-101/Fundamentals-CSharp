using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._01_Intro_Programming
{
    class EXE
    {
        static void EXX1()
        {
            //9.Write a program that prints the square root of 12345.
            //Find out what features are offered by the System.Math class.
            Console.WriteLine(Math.Sqrt(12345));

            //10.Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8.
            //For Loop
            for (int i = 2; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("-"+i);
                }
                else
                {
                    Console.WriteLine(i); 
                }
            }

            //11.Write a program that reads your age from the console and prints your age after 10 years.
            //methods System.Console.ReadLine(), int.Parse() and System.DateTime.AddYears().
            Console.Write("Enter your Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("After 10 years you will be: "+ (age + 10));
        }
    }
}
