using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._4_Console_InOut
{
    class Out
    {
        static void Outside()
        {
            //5. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, 
            //such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25
            //Solution
            //5. There are two approaches for solving the problem: First approach: Use mathematical tricks for optimized calculation based on 
            //the fact that every fifth number is divisible by 5. Think how to implement this correctly and about the borderline cases. 
            //The second approach is easier but it works slower. With a for-loop each number within the given range can be checked. 
            //You should read in Internet or in the chapter "Loops" how to use for-loops. 

            Console.WriteLine("Enter 2 Integers that");
            Console.WriteLine("Enter first integer");
            int firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer");
            int secondInt = int.Parse(Console.ReadLine());

            int numbers = 0;
            int count = 0;

            //first approach
            if (firstInt % 5 == 0 && secondInt % 5 == 0)
            {
                int one = firstInt / 5;
                int two = secondInt / 5;
                numbers = (firstInt + secondInt) / 5;
                count += numbers;
                Console.WriteLine("({0}, {1}) there are {2} such numbers: {4}", firstInt, secondInt, count.ToString().Split(','), numbers);
            }
            else
            {
                Console.WriteLine("({0}, {1}) there are no numbers exist", firstInt, secondInt);
            }
            //second approach
            for (int p = 0; p < firstInt; p++)
            {

            }

            //#####################################################################################################################################
            //#####################################################################################################################################

            //7.Another approach is using loops. When parsing the consecutive numbers use conditional parsing with TryParse(…). 
            //When an invalid number is entered, repeat reading of the number. You can do this through while loop with an appropriate exit condition. 
            //To avoid repetitive code you can explore the for-loops from the chapter "Loops". 

            int[] num5 = new int[5];
            int sum = 0, i = 0;
            while (num5[i] > 0)
            {
                sum += num5[i];
                Console.WriteLine("Enter number {0} ", num5[i]++);
            }
            Console.WriteLine(sum);
            Console.ReadLine();

            //#####################################################################################################################################
            //#####################################################################################################################################
            //8. You can use the comparison statement "if" (you can read about it on the Internet or from the chapter "Conditional Statements"). 
            //To avoid repeating code you can use the looping construct "for" (you could read about it online or in the chapter "Loops")

            for (int v = 0; v < 5; v++)
            {
                Console.WriteLine("Enter number {0}", v);
                int userNum = int.Parse(Console.ReadLine());
                //int max = Math.Abs([v]);
            }



            //#####################################################################################################################################
            //#####################################################################################################################################

            //11.Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … 
            //Solution
            //11. More about the Fibonacci sequence can be found in Wikipedia at: http://en.wikipedia.org/wiki/Fibonacci_sequence. For the solution of 
            //the problem use 2 temporary variables in which store the last 2 calculated values and with a loop calculate 
            //the rest (each subsequent number in the sequence is a sum of the last two). Use a for-loop to implement the repeating logic (see the chapter "Loops").
            Console.WriteLine("Enter Fib length");
            int len = int.Parse(Console.ReadLine());

            //two variables
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int d = 2; d < len; d++)//loop start @ 2
            {
                //sum of the 2
                c = a + b;
                Console.Write(" {0} ", c);//print next value
                //repeat logic
                a = b;
                b = c;
            }
            //#####################################################################################################################################
            //#####################################################################################################################################

            //12.Write a program that calculates the sum(with precision of 0.001) of the following sequence: 1 + 1 / 2 - 1 / 3 + 1 / 4 - 1 / 5 + … 
            //Solution
            //12. Accumulate the sum of the sequence in a variable inside a while-loop (see the chapter "Loops"). At each step compare 
            //the old sum with the new sum. If the difference between the two sums Math.Abs(current_sum – old_sum) is less than 
            //the required precision (0.001), the calculation should finish because the difference is constantly decreasing and 
            //the precision is constantly increasing at each step of the loop. The expected result is 1.307
        }
    }
}
