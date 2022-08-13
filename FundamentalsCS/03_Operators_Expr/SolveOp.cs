using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS.Operators_Expr
{
    class SolveOp
    {
        static void Operate()
        {

            //3.OPERATORS
            //###############################################################################################################
            //###############################################################################################################
            //###############################################################################################################

            // 1.Write an expression that checks whether an integer is odd or even.

            int userNum = 0;
            Console.WriteLine("Enter an Integer: ");
            userNum = int.Parse(Console.ReadLine());

            if (userNum % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

            //#############################################################################################################################
            // 2. Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.
            //int userNum;
            //bool isdivided = true;
            //Console.WriteLine("Enter an Integer: ");
            //userNum = int.Parse(Console.ReadLine());

            //if (userNum % 5 == 0 && userNum % 7 == 0)
            //{
            //    Console.WriteLine("Yes, its Divisable by 5 and 7 " + isdivided);
            //}
            //else
            //{
            //    Console.WriteLine("No, its Not Divisable by 5 and 7 ");
            //}

            //#############################################################################################################################
            //3. Write an expression that looks for a given integer if its third digit (right to left) is 7.
            //Solution
            //3. Divide the number by 100 and save it in a new variable, which then divide by 10 and take the remainder. 
            //The remainder of the division by 10 is the third digit of the original number. Check if it is equal to 7.
            //int userNum;
            //Console.WriteLine("Enter an Integer: ");
            //userNum = int.Parse(Console.ReadLine());

            //int first, second, third, temp;
            ////divide 100
            //first = userNum / 100;

            ////saved in new var
            //temp = first;

            ////devide by 10
            //temp = userNum / 10;

            ////take rem
            //second = temp % 10;

            ////rem of div by 10 is 3rd
            //third = (temp / 10) % 10;

            ////Nice

            //if (third == 7)
            //{
            //    Console.WriteLine("Yes, First Number is 7");
            //}
            //else
            //{
            //    Console.WriteLine("No, First Number is not 7");
            //}

            //#############################################################################################################################

            //4. Write an expression that checks whether the third bit in a given integer is 1 or 0. 
            //Solution
            //4. Use bitwise "AND" on the current number and the number that has 1 only in the third bit (i.e. number 8, if bits start counting from 0). 
            //If the returned result is different from 0 the third bit is 1:
            int num = 25;
            bool bit3 = (num & 8) != 0;
            Console.WriteLine(bit3);
            //HARD

            //#############################################################################################################################

            //5. Write an expression that calculates the area of a trapezoid by given sides a, b and height h. 
            //int a, b, c;
            //Console.WriteLine("Enter a value: ");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter b value: ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter c value: ");
            //c = int.Parse(Console.ReadLine());

            //int area = ((a + b) * c) / 2;
            //Console.WriteLine("Area = ({0} + {1}) X {2} / 2 = {3}", a, b, c, area);
            //Console.ReadKey();

            //#############################################################################################################################

            //6. Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
            //int sidea, sideb;
            //Console.WriteLine("Enter Side A of a rect: ");
            //sidea = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Side b of a rect: ");
            //sideb = int.Parse(Console.ReadLine());

            //int perimtr=2*(sideb+sidea);
            //int area = sidea * sideb;
            //Console.WriteLine("Perimtr = 2 X ({0} + {1}) = {2}", sidea, sideb, perimtr);
            //Console.WriteLine("Area = {0} X {1} = {2}", sidea, sideb, area);

            //Console.ReadKey();

            //#############################################################################################################################

            //7. The gravitational field of the Moon is approximately 17% of that on the Earth. 
            //Write a program that calculates the weight of a man on the moon by a given weight on the Earth. 
            Console.WriteLine("Enter weigth of man on earth: ");
            int weightEarth = int.Parse(Console.ReadLine());

            double Moonweight = (double)weightEarth * 0.17;
            Console.WriteLine("Weight of man in moon is: " + Moonweight);

            //#############################################################################################################################

            //8. Write an expression that checks for a given point {x, y} if it is within the circle K({0, 0}, R=5). 
            //Explanation: the point {0, 0} is the center of the circle and 5 is the radius. 
            //no radius
            //Console.WriteLine("Enter Point x: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Point y: ");
            //int y = int.Parse(Console.ReadLine());
            //if (x==0 && y==0)
            //{
            //    Console.WriteLine("x and y is in the circle point (0, 0)");
            //}
            //else
            //{
            //    Console.WriteLine("({0}, {1}) is not the circle point (0, 0)" ,x,y);
            //}
            //radius of 5

            //#############################################################################################################################

            //8. Use the Pythagorean Theorem a2 + b2 = c2. The point is inside the circle when (x*x) + (y*y) ≤ 5*5.
            Console.WriteLine("Enter Point x: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Point y: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Point y: ");
            int c = int.Parse(Console.ReadLine());
            int pythagThrm = (a * a) + (b * b);
            int PTCr = 0;
            PTCr = c * c;

            if (pythagThrm <= PTCr)
            {
                Console.WriteLine("The point is inside circle");
            }
            else
            {
                Console.WriteLine("Point not inside");
            }

            //#############################################################################################################################

            //9. Write an expression that checks for given point {x, y} if it is within the circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. 
            //Clarification: for the rectangle the lower left and the upper right corners are given.
            //Solution
            //9.Use the code from the previous task and add a check for the rectangle. A point is inside a rectangle with walls parallel to the axes, 
            //when in the same time it is right of the left wall, left of the right wall, down from the top wall and above the bottom wall.
            //Console.WriteLine("Enter Point a: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Point b: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Point c: ");
            //int c = int.Parse(Console.ReadLine());
            //int pythagThrm = (a * a) + (b * b);
            //int PTCr = pythagThrm;
            //PTCr = c * c;

            //if (pythagThrm <= PTCr)
            //{
            //    Console.WriteLine("The point is inside circle");
            //}
            //else
            //{
            //    if (a == -1 || a == 5 && b == 1 || b == 5)
            //    {
            //        Console.WriteLine("outside rect");
            //    }

            //    Console.WriteLine("Point not inside");
            //}

            //#############################################################################################################################

            //10. Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions: 
            //- Calculates the sum of the digits (in our example 2+0+1+1 = 4). 
            //- Prints on the console the number in reversed order: dcba (in our example 1102). 
            //- Puts the last digit in the first position: dabc (in our example 1201). 
            //- Exchanges the second and the third digits: acbd (in our example 2101).
            //Solution
            //10. To get the individual digits of the number you can divide by 10 and take the remainder of the division by 10:
            Console.WriteLine("Enter four digit number");
            int num4 = int.Parse(Console.ReadLine());
            int aa = num4 % 10;
            int bb = (num4 / 10) % 10;
            int cc = (num4 / 100) % 10;
            int d = (num4 / 1000) % 10;


            int sum = aa + bb + cc + d;

            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", d, cc, bb, aa, sum);
            //Reverse 
            Console.WriteLine("Reverse: {0}{1}{2}{3}", aa, bb, cc, d);
            //swap first and last
            Console.WriteLine("Swap second and third: {0}{1}{2}{3}", d, bb, cc, aa);
            //swap first and last
            Console.WriteLine("Swap first and last: {0}{1}{2}{3}", aa, cc, bb, d);

            //#############################################################################################################################

            //11. We are given a number n and a position p. Write a sequence of operations that prints the value of the bit on the position p in the 
            //number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0
            //Solution
            //Use bitwise operations: 
            int n = 35; // 0010 0011 
            int p = 6;
            int i = 1; // 0000 0001 
            int mask = i << p; // Move the 1-st bit left by p positions ->64 = 0100 0000
            Console.WriteLine(mask);

            // If i & mask are positive then the p-th bit of n is 1 
            Console.WriteLine((n & mask) != 0 ? 1 : 0);

            //#############################################################################################################################

            //12.12. Write a Boolean expression that checks if the bit on position p in the integer v has the value 1. Example v=5, p=1 -> false.
            Console.WriteLine("Enter n value");
            int nVal = int.Parse(Console.ReadLine());
            int pp = 1;
            int bit = 1;
            int shift = nVal << pp;
            bool check = false;
            if ((bit & shift) == 1)
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine(check);
            }
            //Confusing
            //Console.WriteLine((nVal & shift) != 0 ? 1 : 0);

            //13.13. We are given the number n, the value v (v = 0 or 1) and the position p. 
            //write a sequence of operations that changes the value of n, so the bit on
            //the position p has the value of v. Example: n = 35, p = 5, v = 0->n = 3.
            //Another example: n = 35, p = 2, v = 1->n = 39.
            //Hints
            //reset the bit at posion p in the number n --> [ n = n & (~(1 << p)); ]
            //sets bits in the unit at position p in the number n --> [ n = n | ( 1 << p); ]

            //14. Write a program that checks if a given number n (1 < n < 100) is a prime number(i.e.it is divisible without remainder only to itself and 1).
            Console.WriteLine("Enter n value");
            Console.Write("Enter an integer (1-100) ");
            int numInt = int.Parse(Console.ReadLine());
            bool prime = false;
            if (numInt < 1)
            {
                prime = false;
            }
            else
            {
                prime = true;
            }
            for (int ii = 2; i <= numInt / 2; ii++)
            {
                if (numInt % 2 == 0)
                {
                    prime = false;
                }
            }
            Console.WriteLine("Prime? " + prime);

            //[Hard *]
            //15. Write a program that exchanges the values of the bits on positions 
            //3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32 - bit unsigned integer.
            //Getting and setting a bit at a given position
            int bit33 = (num >> 3) & 1;
            int bit24 = (num >> 24) & 1;
            num = num & (~(1 << 24)) | (bit33 << 24);
            num = num & (~(1 << 3)) | (bit33 << 3);

            //16.Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, 
            //q + 1, …, q + k - 1} of a given 32-bit unsigned integer.
            //Sequence of bit exchanges in a loop.
        }
    }
}
