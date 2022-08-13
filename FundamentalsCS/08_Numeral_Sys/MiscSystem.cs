﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._8_Numeral_Sys
{
    class MiscSystem
    {
        static void Numer()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            decimal factorial = Factorial(n);
            Console.WriteLine("{0}! = {1}", n, factorial);
        }

        static decimal Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
