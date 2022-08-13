using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._16_Linear_DataStruct
{
    class GenericCollect
    {
       static List<int> GetPrimes(int start, int end)
        {
            List<int> primeList = new List<int>();
            for (int num = start; num <= end; num++)
            {
                bool prime = true;
                double numSqrt = Math.Sqrt(num);
                for (int div = 2; div <= numSqrt; div++)
                {
                    if (num % div == 0)
                    {
                        prime = false;
                        break;
                    }
                    if (prime)
                    {
                        primeList.Add(num);
                    }
                }
            }
            return primeList;

        }

        static void ANsr()
        {
            List<int> primes = GetPrimes(200, 300);
            foreach (var item in primes)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
