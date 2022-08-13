using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._11_Create_Obj
{
    class NameSpaceImportTest
    {
        static void MainCD()
        {
            List<int> ints = new List<int>();
            List<double> doubles = new List<double>();

            while (true)
            {
                int intResult;
                double doubleResult;
                Console.WriteLine("Enter an int or a double:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out intResult))
                {
                    ints.Add(intResult);
                }
                else if (double.TryParse(input, out doubleResult))
                {
                    doubles.Add(doubleResult);
                }
                else
                {
                    break;
                }
            }

            Console.Write("You entered {0} integers:", ints.Count);
            foreach (var item in ints)
            {
                Console.Write(" "+item);
            }
            Console.WriteLine();

            Console.Write("You entered {0} doubles:", doubles.Count);
            foreach (var d in doubles)
            {
                Console.Write(" " + d);
            }
            Console.WriteLine();

            //Output:
            //You entered 3 ints: 4 7 2
            //You entered 2 doubles: 1.53 0.26

        }
    }
}
