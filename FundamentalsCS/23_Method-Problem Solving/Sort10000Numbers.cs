using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._23_Method_Problem_Solving
{
    public class Sort10000Numbers
    {
        static void Sort10000Num()
        {
            int[] numbers = new int[10000];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(2 * numbers.Length);
            }
            SortNumbers(numbers);
            PrintNumbers(numbers);

        }

        private static void SortNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length -1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int oldNumber = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = oldNumber;
            }
        }

        private static void PrintNumbers(int[] numbers)
        {
            Console.Write("[");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                if (i < numbers.Length - 1)
                {
                    Console.WriteLine(", ");
                }
            }
            Console.WriteLine("]");
        }
        //Result:
        //[0, 14, 19, 20, 20, 22, …, 19990, 19993, 19995, 19996]
    }
}
