using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._6_Loops
{
    class MiscLoop
    {
        static void Pool()
        {
            //WHILE COUNT
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            // Initialize the counter 
            int counter = 0;
            // Execute the loop body while the loop condition holds 
            while (counter <= 9)
            {
                // Print the counter value  
                Console.WriteLine("Number : " + counter);  
                // Increment the counter 
                counter++;
            }

            //WHILE SUM
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int num = 1;//start var
            int sum = 1;//start sum
            Console.Write("The sum 1");
            while (num < n)
            {
                //increament startvar n sumtonum
                num++;
                sum += num;
                Console.Write(" + " + num);
            }
            Console.WriteLine(" = " + sum);

            //WHILE PRIME -(no factor num n 1only)
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            Console.Write("Enter a positive number: ");
            int usernum = int.Parse(Console.ReadLine());
            int divider = 2;//start_div
            int maxDivider = (int)Math.Sqrt(usernum);//root_maxDiv
            bool prime = true;//bool
            while (prime && (divider <= maxDivider))//check_bool n dividers<=
            {
                if (usernum % divider == 0)
                {
                    prime = false;
                }
                divider++;//icreament_div
            }
            Console.WriteLine("Prime? " + prime);
            
            //INFINITELOOP - Factorial
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            Console.WriteLine("Enter a value ");
            int userfact = int.Parse(Console.ReadLine());
            //biggest c# type to hold int => decimal
            decimal factor7 = 1;
            //Infinite loop
            while (true)
            {
                if (userfact <= 1)
                {
                    break;
                }
                factor7 *= userfact;
                userfact--;
            }
            Console.WriteLine("n! = " + factor7);
            //DO-WHILE FACTORIAL
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            Console.Write("n = ");
            int v = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            do
            {
                //factor_product_v n decreament_v
                factorial *= v;
                v--;
            }
            while (v > 0);
            Console.WriteLine("n! = " + factorial);

            //FOR SUM
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            for (int i = 1, suml = 1; i <= 128; i = i * 2, suml += i)
            {
                Console.WriteLine("i={0}, sum={1}", i, suml);
            }

            //FOR POWER
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            Console.Write("n = ");
            int np = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());//length second var
            decimal result = 1;//start_var
            for (int i = 0; i < m; i++)
            {
                //start_var product user
                result *= np;
            }
            Console.WriteLine("n^m = " + result);

            //FOREACH NO-INDEX
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };
            foreach (int j in numbers)
            {
                Console.Write(" " + j);
            }
            Console.WriteLine();

            string[] towns = { "London", "Paris", "Milan", "New York" };
            foreach (string town in towns)//collection
            {
                Console.Write(" " + town);
            }

            //Nested FOR -(TRIANGLE)
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            Console.WriteLine("Enter a number to print triangle");
            int z = int.Parse(Console.ReadLine());
            for (int row = 1; row <= z; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }

            //LOOP COMBO (FOR-WHILE) -(Prime Numbers in an Interval)
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            Console.Write("n = ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m2 = int.Parse(Console.ReadLine());

            for (int numf = n2; numf <= m2; numf++)//newVar = n2; newVar<=m2 newVar++
            {
                //declare checkers
                bool prime2 = true;
                int divider2 = 2;
                int maxDivider2 = (int)Math.Sqrt(num);
                while (divider2 <= maxDivider2)//while divider<= max divider
                {
                    if (numf % divider2 == 0)//newVar % divider ==0
                    {
                        prime2 = false;
                        break;
                    }
                    divider2++;//decreament
                }
                if (prime2)//true
                {
                    Console.Write(" " + numf);
                }
                Console.ReadKey();

            }
            //LUCKY NUMBERS
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 0; d <= 9; d++)
                        {
                            if ((a + b) == (c + d))
                            {
                                Console.WriteLine(" " + a + " " + b + " " + c + " " + d);
                            }
                        }
                    }
                }
            }

            //LOTTERY 6/49 NUMBERS
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            for (int i1 = 1; i1 <= 44; i1++)
            {
                for (int i2 = i1 + 1; i2 <= 45; i2++)
                {
                    for (int i3 = i2 + 1; i3 <= 46; i3++)
                    {
                        for (int i4 = i3 + 1; i4 <= 47; i4++)
                        {
                            for (int i5 = i4 + 1; i5 <= 48; i5++)
                            {
                                for (int i6 = i5 + 1; i6 <= 49; i6++)
                                {
                                    Console.WriteLine(i1 + " " + i2 + " " + i3 + " " + i4 + " " + i5 + " " + i6);
                                }
                            }
                        }
                    }
                }
            }
            //
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@


        }
    }
}
