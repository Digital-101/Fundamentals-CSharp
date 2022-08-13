using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._6_Loops
{
    class OUtaloop
    {
        static void Pro()
        {
            Console.WriteLine("Enter n numbers");
            int nNumb1 = int.Parse(Console.ReadLine());
            int num123 = 0;
            int smallest = Int32.MinValue;
            int largest = int.MaxValue;
            for (int i = 0; i < nNumb1; i++)
            {

                Console.WriteLine("Enter number {0}", i);
                num123 = int.Parse(Console.ReadLine());

                smallest = num123;
                if (largest > smallest && smallest != largest)
                {
                    largest = num123;
                    //smallest = largest;
                }
            }

            Console.WriteLine("Smallest number " + smallest);
            Console.WriteLine("Largest number " + largest);
            Console.ReadKey();
        }
    }
}
