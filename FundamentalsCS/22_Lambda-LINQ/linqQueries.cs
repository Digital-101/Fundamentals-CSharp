using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._22_Lambda_LINQ
{
    class linqQueries
    {
        static void LINQQ()
        {
            //Result Queries
            List<int> numbers = new List<int>()
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item + " ");
            }

            //Result:
            //2 4 6 8 10

            //Sorting Data with LINQ
            string[] words = { "cherry", "apple", "blueberry" };
            var wordSortedByLength = from word in words
                                     orderby word.Length descending
                                     select word;

            foreach (var word in wordSortedByLength)
            {
                Console.WriteLine(word);
            }
            //Result
            //blueberry
            //cherry
            //apple

            //Grouping Results
            //Pattern
            //group [variable name] by [grouping condition] into [group name]
            int[] numbersG = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 10, 11, 12, 13 };            int divisor = 5;            var numberGroups = from number in numbers                               group number by number % divisor into Group                               select new { Remainder = Group.Key, Numbers = Group };            foreach (var group in numberGroups)
            {
                Console.WriteLine("Numbers with a remainder of {0} when divided by {1}:", group.Remainder, divisor);
                foreach (var number in group.Numbers)
                {
                    Console.WriteLine(number);
                }
            }            //            The result is:
            //Numbers with a remainder of 0 when divided by 5:
            //5
            //0
            //10
            //Numbers with a remainder of 4 when divided by 5:
            //4
            //9
            //Numbers with a remainder of 1 when divided by 5:
            //1
            //6
            //11
            //Numbers with a remainder of 3 when divided by 5:
            //3
            //8
            //13
            //Numbers with a remainder of 2 when divided by 5:
            //7
            //2
            //12
            //LINQ Perfomance
            List<int> l1 = new List<int>();
            DateTime startTime = DateTime.Now;
            l1.AddRange(Enumerable.Range(1, 50000000));
            Console.WriteLine("Ext. method:\t{0}", DateTime.Now - startTime);

            startTime = DateTime.Now;
            List<int> l2 = new List<int>();
            for (int i = 0; i < 50000000; i++)
            {
                l2.Add(i);
            }
            Console.WriteLine("For-loop:\t{0}", DateTime.Now - startTime);

            //The result might be as follows (depends on the computer’s CPU speed):
            //Ext.method:       00:00:01.6430939
            //For - loop:       00:00:00.9120522

            //Expression Trees
            List<int> list = new List<int>();
            list.AddRange(Enumerable.Range(1, 100000));

            DateTime start = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                var elements = list.Where(e => e > 20000);
            }
            Console.WriteLine("No exectution:\t{0}", DateTime.Now - start);

            start = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                var elements = list.Where(e => e > 20000).First();
            }
            Console.WriteLine("Execution:\t{0}", DateTime.Now - start);

            //The result might be as follows (depends on the computer’s CPU speed):
            //No execution: 00:00:00.0070004
            //Execution: 00:00:02.7231558

            //.Net Framework collections works fast with linq --> 
            //Lits<T>, HashSet<T>, Dictionary<K, V>
            HashSet<Guid> set = new HashSet<Guid>();
            for (int i = 0; i < 50000; i++)
            {
                set.Add(Guid.NewGuid()); // Add random GUID
            }

            Guid keyForSearching = new Guid();
            DateTime start1 = DateTime.Now;
            for (int i = 0; i < 50000; i++)
            {
                //Use HashSet.Cointains(...)
                bool found = set.Contains(keyForSearching);
            }
            Console.WriteLine("HashSet: {0}", DateTime.Now - start1);

            start1 = DateTime.Now;
            for (int i = 0; i < 50000; i++)
            {
                //Use IEnumerable<Guid>.Contains(...) ext method
                bool found = set.Contains<Guid>(keyForSearching);
            }
            Console.WriteLine("Contains: {0}", DateTime.Now - start1);

            start1 = DateTime.Now;
            for (int i = 0; i < 50000; i++)
            {
                //Use IEnumerable<Guid>.Where(...) ext method
                bool found = set.Where(g => g == keyForSearching).Count() > 0;
            }
            Console.WriteLine("Where: {0}", DateTime.Now - start1);

            //The result is as follows (though it depends on the computer’s CPU speed):
            //HashSet: 00:00:00.0030002
            //Contains: 00:00:00.0040003
            //Where: 00:02:49.9717218
        }
    }
}
