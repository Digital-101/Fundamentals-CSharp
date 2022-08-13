using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._5_Conditional_Stat
{
    class FixState
    {
        static void FState()
        {

            //2. Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a sequence of if operators. 
            //Solution
            //2. A multiple of non-zero numbers has a positive product, if the negative multiples are even number. If the count of 
            //the negative numbers is odd, the product is negative. If at least one of the numbers is zero, the product is also zero. 
            //Use a counter negativeNumbersCount to keep the number of negative numbers. Check each number whether 
            //it is negative and change the counter accordingly. If some of the numbers is 0, print “0” as result (the zero has no sign). 
            //Otherwise print “+” or “-” depending on the condition (negativeNumbersCount % 2 == 0).

            Console.WriteLine("Enter first number");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int num3 = Int32.Parse(Console.ReadLine());

            //int negativeCount = -1;
            if (num1 * num2 * num3 != 0 && (-num1) * (-num2) * (-num3) != 0)
            {
                Console.WriteLine("\n+");
            }
            //else if (((-num1) * (num2 * num3) != 0) || (num1 * ((-num2) * num3) != 0) || ((num1 * num2) * (-num3) != 0))
            //{
            //    Console.WriteLine("\n-");
            //}
            //else if (negativeCount % 2 == 0 && num1 * num2 * num3 * -1 == negativeCount)
            //{
            //    Console.WriteLine("-");
            //}
            else if (num1 * num2 * num3 == 0)
            {
                Console.WriteLine("\n0");
            }

            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //6. Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its real roots 
            //(if they exist). Quadratic equations may have 0, 1 or 2 real roots. 
            //Solution
            //6. From math it is known, that a quadratic equation may have one or two real roots or no real roots at all. In order to calculate the 
            //real roots of a given quadratic equation, we first calculate the discriminant (D) by the formula: D = b2 - 4ac. If the discriminant is zero, 
            //then the quadratic equation has one double real root and it is calculated by the formula: 
            //


            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //7. Write a program that finds the greatest of given 5 numbers.
            //Solution
            //7. Use nested if statements. 
            Console.WriteLine("Enter first number");
            long gnum1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            long gnum2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            long gnum3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter fourth number");
            long gnum4 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter fifth number");
            long gnum5 = Int32.Parse(Console.ReadLine());

            if (gnum1 > gnum2)
            {
                Console.WriteLine("Greatest number is : {0}", gnum1);
            }
            else if (gnum2 > gnum3)
            {
                Console.WriteLine("Greatest number is : {0}", gnum2);
            }
            else if (gnum3 > gnum1)
            {
                Console.WriteLine("Greatest number is : {0}", gnum3);
            }
            else if (gnum4 > gnum3)
            {
                Console.WriteLine("Greatest number is : {0}", gnum4);
            }
            else if (gnum5 > gnum4)
            {
                Console.WriteLine("Greatest number is : {0}", gnum5);
            }

            //You could use the loop structure for, which you could read about in the “Loops” chapter of the book or in Internet. 
            int g5Num = 0;
            int biggest = 0;
            for (int i = 1; i <=5; i++)
            {
                Console.Write("Enter num {0}: ");
                g5Num = int.Parse(Console.ReadLine());
                int[] array = new int[5];
                g5Num = array[i];
                biggest = array.Max();
                //  int great = Math.Max(g5Num[i]);
            }
            Console.WriteLine("Biggest: "+biggest);
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //4. Sort 3 real numbers in descending order. Use nested if statements.
            //Solution
            //4. First find the smallest of the three numbers, and then swap it with the first one. Then check if the second is greater than 
            //the third number and if yes, swap them too. Another approach is to check all possible orders of the numbers with a series of 
            //if-else checks: a≤b≤c, a≤c≤b, b≤a≤c, b≤c≤a, c≤a≤b and c≤b≤a. A more complicated and more general solution of this problem is to 
            //put the numbers in an array and use the Array.Sort(…) method. You may read about arrays in the chapter “Arrays”. 
            //Console.WriteLine();

            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //9.We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0.Examples: -If we are given the numbers 
            //{ 3, -2, 1, 1, 8}, the sum of - 2, 1 and 1 is 0. - If we are given the numbers { 3, 1, -7, 35, 22}, there are no subsets with sum 0.
            //Solution
            //9. Use nested if statements or series of 31 comparisons, in order to check all the sums of the 31 subsets of the given numbers 
            //(without the empty one). Note that the problem in general (with N numbers) is complex and using loops will not be enough to solve it. 

            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //11. * Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. 
            //Examples: - 0 --> "Zero" - 12 --> "Twelve" - 98 --> "Ninety eight" - 273 --> "Two hundred seventy three" - 400 --> "Four hundred" - 501 --> 
            //"Five hundred and one" - 711 --> "Seven hundred and eleven" 
            //Solution
            //11. Use nested switch statements. Pay special attention to the numbers from 0 to 19 and those that end with 0. 
            //There are many special cases! You might benefit from using methods to reuse the code you write, because printing a single digit is 
            //part of printing a 2-digit number which is part of printing 3-digit number. You may read about methods in the chapter “Methods”.
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        }
    }
}
