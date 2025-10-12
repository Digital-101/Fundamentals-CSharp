using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class SecondLargest
    {
        public static void SecL()
        {

            int[] numbers = { 42, 30, 12, 5, 26 };
            int? seclargest = FindSecLargest(numbers);
            Console.WriteLine("Second Largest: "+seclargest);
        }

        public static int? FindSecLargest(int[] array)
        {
            if (array.Length < 2) return null;
            var sortedArray = array.Distinct().OrderByDescending(x => x).ToArray();
            if (sortedArray.Length < 2) return null;
            return sortedArray[1];
        }
    }
}
