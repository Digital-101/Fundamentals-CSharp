using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._5_Conditional_Stat
{
    class MiscState
    {
        static void StateCon()
        {
            //BIGGEST NUMBER
            Console.WriteLine("Enter two numbers.");
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int biggerNumber = firstNumber;

            if (secondNumber > firstNumber)
            {
                biggerNumber = secondNumber;
            }
            Console.WriteLine("The bigger number is: {0}", biggerNumber);

        }

    }
}
