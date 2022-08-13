using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._22_Lambda_LINQ
{
    public static class ExtMethods
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?', '|' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        static void MainSE()
        {
            string helloString = "Hello, Extension Methods!";
            int wordCount = helloString.WordCount();
            Console.WriteLine(wordCount);
        }

        //EXTMethods For Interfaces

        public static void IncreaseWith(this IList<int> list, int amount)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += amount;
            }
        }

        public static string ToString<T>(this IEnumerable<T> enumeration)
        {
            StringBuilder result = new StringBuilder();
            result.Append("[");

            foreach (var item in enumeration)
            {
                result.Append(item.ToString());
                result.Append(", ");
            }
            if (result.Length > 1)
            {
                result.Remove(result.Length - 2, 2);
            }
            result.Append("]");

            return result.ToString();
        }

        static void MainEXTM()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5};
            Console.WriteLine(numbers.ToString<int>());
            numbers.IncreaseWith(5);
            Console.WriteLine(numbers.ToString<int>());

            //Output:
            //[1, 2, 3, 4, 5]
            //[6, 7, 8, 9, 10]

    }
}
}
