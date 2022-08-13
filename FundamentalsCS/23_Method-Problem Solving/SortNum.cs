using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._23_Method_Problem_Solving
{
    public class SortNum
    {
        static void SortNMSBS()
        {
            List<int> numsort = new List<int>() { 7, 2, 4, 1, 8, 2};
            PrintNumbers();
            GetLowestNum(numsort);
        }

        private static void GetLowestNum(List<int> numsort)
        {
            throw new NotImplementedException();
        }

        static void PrintNumbers()
        {
            List<int> numsort = new List<int>() { 7, 2, 4, 1, 8, 2 };

            foreach (var num in numsort)
            {
                Console.WriteLine(num);
            }
        }

        //List<int> FindLowestNumber()
        //{
        //    List<int> numsort = new List<int>() { 7, 2, 4, 1, 8, 2 };
        //    int min = numsort.Min();
        //    return min;
        //}
    }
}
