using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._19_Data_Structures_Algor
{
    /// <summary>
    /// Finally, our algorithm looks something like this:
    //1. Let N be the number of elements in S.We start with a queue, 
    //containing the empty set { }.
    //2. We dequeue an element called subset.Let start be the biggest index
    //in subset.We add to subset all indices, which are bigger than start
    //and smaller than N.As a result we get several new subsets, which we
    //enqueue.
    //3. Repeat step 2 until the queue is empty.
    /// </summary>
    public class Subsets
    {
        static string[] words = {"ocean", "beer", "money", "happiness" };

        static void mainSol()
        {
            Queue<List<int>> subsetsQueue = new Queue<List<int>>();
            List<int> emptySet = new List<int>();
            subsetsQueue.Enqueue(emptySet);
            while (subsetsQueue.Count > 0)
            {
                List<int> subset = subsetsQueue.Dequeue();
                Print(subset);
                int start = -1;
                if (subset.Count > 0)
                {
                    start = subset[subset.Count - 1];
                }
                for (int i = start + 1; i < words.Length; i++)
                {
                    List<int> newSubset = new List<int>();
                    newSubset.AddRange(subset);
                    newSubset.Add(i);
                    subsetsQueue.Enqueue(newSubset);
                }
            }
        }

        private static void Print(List<int> subset)
        {
            Console.Write("[ ");
            for (int i = 0; i < subset.Count; i++)
            {
                int index = subset[i];
                Console.Write("{0} ", words[index]);
            }
            Console.WriteLine("]");
        }

        //Correct Result:
        //[ ]
        //[ocean]
        //[beer]
        //[money]
        //[happiness]
        //[ocean beer]
        //[ocean money]
        //[ocean happiness]
        //[beer money]
        //[beer happiness]
        //[money happiness]
        //[ocean beer money]
        //[ocean beer happiness]
        //[ocean money happiness]
        //[beer money happiness]
        //[ocean beer money happiness]
    }
}
