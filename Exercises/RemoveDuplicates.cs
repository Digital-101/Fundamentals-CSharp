using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class RemoveDuplicates
    {
        public static void RemoveDup()
        {

            int[] array = { 1, 2, 2, 3, 4, 4, 5 };
            int[] uniqueArray = RemoveDuplicate(array);
            Console.WriteLine("Unique: "+string.Join(", ", uniqueArray));
        }

        public static int[] RemoveDuplicate(int[] array)
        {
            return array.Distinct().ToArray();
        }
    }
}
