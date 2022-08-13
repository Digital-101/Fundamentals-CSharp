using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS
{
    class CodeExp
    {
        private void MoreWord()
        {
            int userNum;
            Console.WriteLine("Enter an Integer: ");
            userNum = int.Parse(Console.ReadLine());

            int first, second, third, temp;
            //divide 100
            first = userNum / 100;

            //saved in new var
            temp = first;

            //devide by 10
            temp = userNum / 10;

            //take rem
            second = temp % 10;

            //rem of div by 10 is 3rd
            third = (temp / 10) % 10;

            //Nice

            if (third == 7)
            {
                Console.WriteLine("Yes, Third Number is 7");
            }
            else
            {
                Console.WriteLine("No, Third Number is not 7");
            }
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@


            //Good
            Console.WriteLine("Enter four digit number");
            int num4 = int.Parse(Console.ReadLine());
            int a = num4 % 10;
            int b = (num4 / 10) % 10;
            int c = (num4 / 100) % 10;
            int d = (num4 / 1000) % 10;

            int sum = a + b + c + d;

            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", d, c, b, a, sum);
            //Reverse 
            Console.WriteLine("Reverse: {0}{1}{2}{3}", a, b, c, d);
            //swap first and last
            Console.WriteLine("Swap first and last: {0}{1}{2}{3}", d, b, c, a);
            //swap second and third
            Console.WriteLine("Swap second and third: {0}{1}{2}{3}", a, c, b, d);

            //14. Write a program that checks if a given number n (1 < n < 100) is a prime number 
            //(i.e. it is divisible without remainder only to itself and 1). 
            //CG. Read about loops in the Internet or in the chapter “Loops”. Use a loop and check the number for divisibility by all integers 
            //from 1 to the square root of the number. Since n < 100, you can find in advance all prime numbers from 1 to 100 and checks 
            //the input over them. The prime numbers in the range [1…100] are: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 
            //37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89 and 97.
            Console.Write("Enter an integer (1-100) ");
            int numInt = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(numInt);
            bool prime = false;
            while (prime && (divider <= maxDivider))
            {
                if (numInt % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("Prime? " + prime);
        }
    }
}
