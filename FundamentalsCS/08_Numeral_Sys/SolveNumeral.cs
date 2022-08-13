using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._8_Numeral_Sys
{
    class SolveNumeral
    {
        static void NumSys()
        {
            //Exercises 1. 
            //Convert the numbers 151, 35, 43, 251, 1023 
            //and 1024 to the binary numeral system. 

            //Declare Number, array and index
            int Num, i;
            int[] array = new int[10];

            Console.WriteLine("Enter the number to convert: ");
            Num = int.Parse(Console.ReadLine());

            //Use a for loop to chexk num > 0
            for (i = 0; Num > 0; i++)
            {
                //Number of an Array rem 2 and num div by 2, ++
                array[i] = Num % 2;
                Num = Num / 2;
            }
            Console.Write("Binary of the given number = ");
            //Use loop to minus index - 1 and check index >=0 ,--
            for (i = i - 1; i >= 0; i--)
            {
                //Print the num
                Console.Write(array[i]);

            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
