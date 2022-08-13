using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming._25Exam_2.B
{
    public class PrimeMatrix
    {
        static void MIOY()
        {
            int n = ReadInput();
            PrintMatrixOfPrimes(n);
        }

        private static int ReadInput()
        {
            Console.Write("N = ");
            string input = Console.ReadLine(); 
            int n = int.Parse(input);
            return n;
        }

        private static bool IsPrime(int number)
        {
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }

            int maxDivider = (int)Math.Sqrt(number);
            for (int divider = 2; divider <= maxDivider; divider++)
            {
                if (number % divider == 0)
                {
                    return false;
                }
            }
            return true;
        } 

        private static int FindNextPrime(int startNumber)
        {
            int number = startNumber;
            while (!IsPrime(number))
            {
                number++;
            }
            return number;
        }

        private static void PrintMatrixOfPrimes(int dimension)
        {
            int lastPrime = 1;
            for (int row = 0; row < dimension; row++)
            {
                for (int col = 0; col < dimension; col++)
                {
                    int nextPrime = FindNextPrime(lastPrime + 1);
                    Console.Write("{0,4}", nextPrime);
                    lastPrime = nextPrime;
                }
                Console.WriteLine();
            }
        }
    }
}
