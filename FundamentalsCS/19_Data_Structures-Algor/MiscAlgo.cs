using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._19_Data_Structures_Algor
{
    class MiscAlgo
    {
        //Estimating Complexity

        //Single Loop
        //Linear - O(N)
        //Works well even if huge number of Elements
        int FindMaxElement(int[] array)
        {
            int max = int.MinValue;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        //2 Nested Loops
        //Quadratic - O(N^2)
        //Works well if No more than 1000 || 10 000 elements
        int FindInversions(int[] array)
        {
            int inversion = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        inversion++;
                    }
                }
            }
            return inversion;
        }

        //3 Nested Loops
        //Cubic - O(N^3)
        //Works well if Elements < 1000
        long Sum3(int n)
        {
            long sum = 0;
            for (int a = 1; a < n; a++)
            {
                for (int b = 1; b < n; b++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        sum += a * b * c;
                    }
                }
            }
            return sum;
        }

        //2 Nested loops from 1toN && 1toM
        //Quadratic - O(N*M)
        //Speed depends on 2 var. --> M, N < 10 000 || if(var1 < small)
        long SumMN(int n, int m)
        {
            long sum = 0;
            for (int x = 1; x <= n; x++)
            {
                for (int y = 1; y <= m; y++)
                {
                    sum += x * y;
                }
            }
            return sum;
        }

        //Not all tree nested loops mean cubic
        //Complexity Quadratic - O(N*M)
        //Inner Loop - min(M, N) && speed100.
        //Outer Code - N*M + min(M,N)*N && quadratic
        long SumMN2(int n, int m)
        {
            long sum = 0;
            for (int x = 1; x <= n; x++)
            {
                for (int y = 1; y <= m; y++)
                {
                    if (x == y)
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            sum += i * x * y;
                        }
                    }
                }
            }
            return sum;
        }

        // Linear - O(N) coz 1...n
        //Recursion, the complexity is more difficult to be estimated
        long Factorial(int n)
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

        //difficult to estimate
        //Also exponential complexity - value > 20/30
        long Fibonacci(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        //Nth number of Fibonacci - linear complexity
        //predict whether a given code will work slowly
        long Fibonacci2(int n)
        {
            long fn = 1;
            long fn1 = 1;
            long fn2 = 1;
            for (int i = 2; i < n; i++)
            {
                fn = fn1+fn2;
                fn2 = fn1;
                fn1 = fn;
            }
            return fn;
        }

        //########################################################################################
        
        //Generating Subsets
        //It is given a set of strings S.For example S = {ocean, beer, money, 
        //happiness}. The task is to write a program, which prints all subsets of S.
        //classical algorithm -> "breadth-first search" (BFS).
        static void AlgoCla()
        {
            string[] words = { "ocean", "beer", "money", "happiness" };
            Queue<HashSet<string>> subsetsQueue = new Queue<HashSet<string>>();
            HashSet<string> emptySet = new HashSet<string>();
            subsetsQueue.Enqueue(emptySet);
            while (subsetsQueue.Count > 0)
            {
                HashSet<String> subset = subsetsQueue.Dequeue();

                //print current subset
                Console.Write("{ ");
                foreach (string word in subset)
                {
                    Console.Write("{0} ", word);
                }
                Console.WriteLine("}");

                //Generate and enqueue all possible child subsets
                foreach (string element in words)
                {
                    if (!subset.Contains(element))
                    {
                        HashSet<string> newSubset = new HashSet<string>();
                        newSubset.UnionWith(subset);
                        newSubset.Add(element);
                        subsetsQueue.Enqueue(newSubset);
                    }
                }
            }
        }
       
      }
}
