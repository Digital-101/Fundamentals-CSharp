using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._10_Recursion
{
    class RecursiveNestedLoops
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;

        static void MainRSLS()
        {
            Console.Write("N = ");
            numberOfLoops = int.Parse(Console.ReadLine());

            Console.Write("K = ");
            numberOfIterations = int.Parse(Console.ReadLine());

            loops = new int[numberOfLoops];

            NestedLoops(0);
        }

        private static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintLoops();
                return;
            }
            for (int counter = 1; counter <= numberOfIterations ; counter++)
            {
                loops[currentLoop] = counter;
                NestedLoops(currentLoop + 1);
            }
        }

        private static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }
    }
}
