using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._16_Linear_DataStruct
{
    class QueueUsage
    {
        static void BASEG()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Message One");
            queue.Enqueue("Message Two");
            queue.Enqueue("Message Three");
            queue.Enqueue("Message Four");

            //FIFO
            while (queue.Count > 0)
            {
                string msg = queue.Dequeue();
                Console.WriteLine(msg);
            }
        }

        //Sequence N, N+1, 2*N - Example
        //Sequence of numbers
        //S = N, N+1, 2*N, N+2, 2*(N+1), 2*N+1, 4*N, ... T(+1), B(*2)
        static void SeqNN()
        {
            int n = 3;
            int p = 16;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            int index = 0;
            Console.WriteLine("S =");
            while (queue.Count > 0)
            {
                index++;
                int current = queue.Dequeue();
                Console.WriteLine(" " +current);
                if (current == p)
                {
                    Console.WriteLine();
                    Console.WriteLine("Index = " + index);
                    return;
                }
                //Up(+1), Bot(*2)
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current);
            }

            //OUTPUT
            //S = 3 4 6 5 8 7 12 6 10 9 16 
            //Index = 11
        }
    }
}
