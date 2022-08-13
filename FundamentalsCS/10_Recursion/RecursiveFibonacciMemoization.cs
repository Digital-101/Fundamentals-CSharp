using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._10_Recursion
{
    class RecursiveFibonacciMemoization
    {
        //Efficient Recursion - > optimize recursive method
    
        static long[] numbers;

        static void MainRECFib()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            numbers = new long[n + 2];
            numbers[1] = 1;
            numbers[2] = 1;

            long result = Fib(n);
            Console.WriteLine("fib({0}) = {1}", n, result);

            //Output:
            //n = 100
            //fib(100) = 3736710778780434371
        }

        private static long Fib(int n)
        {
            if (0 == numbers[n])
            {
                numbers[n] = Fib(n - 1) + Fib(n - 2);
            }
            return numbers[n];
        }
    }
}
