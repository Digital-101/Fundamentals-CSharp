using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._9_Methods
{
    class SolveMethod
    {
        static void Meth()
        {
            //METHODS
            //############################################################################################################################
            //############################################################################################################################
            //############################################################################################################################
            //1. Write a code that by given name prints on the console "Hello, <name>!" (for example: "Hello, Peter!").

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " +name);

            //############################################################################################################################
            //############################################################################################################################
            //2.Create a method GetMax() with two integer(int) parameters, that returns maximal of the two numbers.Write a program that 
            //reads three numbers from the console and prints the biggest of them. Use the GetMax() method you just created. Write a 
            //test program that validates that the methods works correctly.
        }
        static void GetMax(int num1, int num2)
        {
            Console.WriteLine("Enter number 1");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 3");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("{0} is the Biggest", num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("{0} is the Biggest", num2);
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("{0} is the Biggest", num3);
            }
            else if ((num1 == num2) || (num2 == num3) || (num3 == num1))
            {
                Console.WriteLine("Numbers are equal!");
            }

        }
    }
}
