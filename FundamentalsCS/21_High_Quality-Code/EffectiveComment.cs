using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._21_High_Quality_Code
{
    public class EffectiveComment
    {
        /// <summary>
        /// Finds the primes from a range [start, end] and
        /// returns them in a list.
        /// </summary>
        /// <param name="start">Top of range</param>
        /// <param name="end">End of range</param>
        /// <returns>a list of all the found primes</returns>
        public List<int> FindPrimes(int start, int end)
        {
            List<int> primesList = new List<int>();
            for (int num = start; num <= end; num++)
            {
                bool isPrime = IsPrime(num);
                if (isPrime)
                {
                    primesList.Add(num);
                }
            }
            return primesList;
        }

        /// <summary>
        /// Checks if a number is prime by checking for any dividers
        /// in the range [2, sqrt(number)].
        /// </summary>
        /// <param name="number">The number to be checked</param>
        /// <returns>True if prime</returns>
        public bool IsPrime(int number)
        {
            for (int div = 2; div <= Math.Sqrt(number); div++)
            {
                if (number % div == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
