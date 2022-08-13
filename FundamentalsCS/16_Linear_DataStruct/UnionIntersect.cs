using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._16_Linear_DataStruct
{
    class UnionIntersect
    {
        static List<int> Union(List<int> firstList, List<int> secondList)
        {
            List<int> union = new List<int>();
            union.AddRange(firstList);
            foreach (var item in secondList)
            {
                if (!union.Contains(item))
                {
                    union.Add(item);
                }
            }
            return union;
        }

        static List<int> Intersect(List<int> firstList, List<int> secondList)
        {
            List<int> intersect = new List<int>();
            foreach (var item in firstList)
            {
                if (secondList.Contains(item))
                {
                    intersect.Add(item);
                }
            }
            return intersect;
        }

        static void PrintList(List<int> list)
        {
            Console.Write(" { ");
            foreach (var item in list)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine("}"); 
        }
        
        static void Main443()
        {
            List<int> firstList = new List<int>();
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            firstList.Add(4);
            firstList.Add(5);
            Console.Write("firstList = ");
            PrintList(firstList);

            List<int> secondList = new List<int>();
            secondList.Add(2);
            secondList.Add(4);
            secondList.Add(6);
            Console.Write("secondList = ");
            PrintList(secondList);



            //DEFINITIONS OF UNION AND INTERSECTION
            //List<int> unionList = Union(firstList, secondList);
            //Console.Write("union = ");
            //PrintList(unionList);

            //List<int> intersectList = Intersect(firstList, secondList);
            //Console.Write("intersect = ");
            //PrintList(intersectList);

            //ANOTHER WAY -> 
            //AddRange<T>(IEnumerable<T> collection) from the class List<T>:
            List<int> unionList = new List<int>();
            unionList.AddRange(firstList);//put all elements
            for (int i = unionList.Count - 1; i >= 0; i--)
            {
                if (secondList.Contains(unionList[i]))
                {
                    unionList.RemoveAt(i);//Remove elements
                }
            }
            unionList.AddRange(secondList);//add elements
            Console.Write("union = ");
            PrintList(unionList);

            List<int> intersectList = new List<int>();
            unionList.AddRange(firstList);
            for (int i = intersectList.Count - 1; i >= 0; i--)
            {
                if (!secondList.Contains(intersectList[i]))
                {
                    intersectList.RemoveAt(i);
                }
            }
            Console.Write("intersect = ");
            PrintList(intersectList);
        }

        //The problem can also be solved with -> 
        //RemoveAll(Predicate<T> match), from
        //delegates and lambda expressions
    }
}
