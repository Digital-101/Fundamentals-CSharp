using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._10_Recursion
{
    class MiscRecur
    {
        static void MiscRic()
        {

        }

        //Fib Numbers
        //        F1 = F2 = 1
        //Fi = Fi-1 + Fi-2 (for i > 2)
        static long Fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }

        //Recursive
        //Computes Factorial
        static decimal Factorial(int n)
        {
            //The bottom of the recursion
            if (n == 0)
            {
                return 1;
            }
            //Recursive call: the method calls itself
            else
            {
                return n * Factorial(n - 1);
            }
        }

        //Iteration
        static decimal IterFactorial(int n)
        {
            decimal result = 1;
            for (int i = 1; i <= n ; i++)
            {
                result = result * 1;
            }

            return result;
        }
    }
}
