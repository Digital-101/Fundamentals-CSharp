using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS.Console_InOut
{
    class SolveConsole
    {
        static void SolveIO(string[] args)
        {
            Console.WriteLine(DateTime.Now + "\n");

            //4.CONSOLE IN-OUT
            //###############################################################################################################
            //###############################################################################################################
            //###############################################################################################################

            //1.Write a program that reads from the console three numbers of type int and prints their sum.
            //Solution
            //1. Use the methods Console.ReadLine() and Int32.Parse(). 
            Console.WriteLine("Enter first number");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int num3 = Int32.Parse(Console.ReadLine());

            int sum = num1 + num2 + num3;
            Console.WriteLine("{0} + {1} + {2} = {3}", num1, num2, num3, sum);
            //###############################################################################################################
            //2.Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
            //Solution
            //2.Use Math.PI constant and the well-known geometric formulas. 
            Console.WriteLine("Enter radius of a circle");
            int radius = int.Parse(Console.ReadLine());

            int perimeter = radius + radius;
            double area = Math.PI * (radius * radius);
            Console.WriteLine("Perimeter = " + perimeter);
            Console.WriteLine("Area = " + area);

            //###############################################################################################################
            //3. A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. 
            //Write a program that reads information about the company and its manager and then prints it on the console. 
            //solution
            //3. Format the text with Write(…) or WriteLine(…) similar to the example with the letter that we looked at.

            Console.WriteLine("Enter company Name");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter company Address");
            string address = Console.ReadLine();

            Console.WriteLine("\nEnter company phone Number");
            string company_PhoneNum = Console.ReadLine();

            Console.WriteLine("\nEnter company fax Number");
            string fax_Num = Console.ReadLine();

            Console.WriteLine("\nEnter company Website");
            string website = Console.ReadLine();

            Console.WriteLine("\nEnter company Manager Title");
            string title = Console.ReadLine();

            Console.WriteLine("\nEnter Managers Surname");
            string surname = Console.ReadLine();

            Console.WriteLine("\nEnter Managers Phone Number");
            string manager_PhoneNum = Console.ReadLine();

            Console.WriteLine("\n##########################-Company Details-######################");
            Console.WriteLine("Company name : " + name);
            Console.WriteLine("Company address : " + address);
            Console.WriteLine("Company Phone Number : " + company_PhoneNum);
            Console.WriteLine("Company Fax Number : " + fax_Num);
            Console.WriteLine("Company Website : : " + website);
            Console.WriteLine("{0} Manager Title : {1} ", name, title);
            Console.WriteLine("{0} Manager Surname : {1} ", name, surname);
            Console.WriteLine("{0} Manager Phone Number : {1} ", name, manager_PhoneNum);

            //###############################################################################################################

            //4. Write a program that prints three numbers in three virtual columns on the console. 
            //Each column should have a width of 10 characters and the numbers should be left aligned. The first number should be an integer in hexadecimal; 
            //the second should be fractional positive; and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.
            //Solution
            //4. Use the format strings explained in the “Composite Formatting” section and the method Console.WriteLine(). Below is a piece of the code:
            //int hexNum = 2013; 
            //Console.WriteLine("|0x{0,-8:X}|", hexNum);
            //double fractNum = -1.856;
            //Console.WriteLine("|{0,-10:f2}|", fractNum);
         
            Console.WriteLine("Enter a number to be printed in 3 columns");
            int columnNum = int.Parse(Console.ReadLine());
            Console.WriteLine("|0x{0,-8:X}|", columnNum);
            double fractNum = -1.856;
            Console.WriteLine("|{0,-10:f2}|", fractNum);
            Console.ReadKey();

            //5.Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the
            //remainder of their division by 5 is 0.Example: in the range(14, 25) there are 3 such numbers: 15, 20 and 25.
            //For Loop
            Console.Write("Enter num1: ");
            int num11 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2: ");
            int num22 = int.Parse(Console.ReadLine());

            for (int i = num11; i <= num22; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //###############################################################################################################
            //6. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements
            //Solution
            //6. Since the problem requires a solution, which does not use conditional statements, you should use a different approach. 
            //Two possible solutions of the problem include the use of functions of class Math. The greater of the two numbers 
            //you can find with the function Math.Max(a, b) and the smaller with Math.Min(a, b)
            //
            Console.WriteLine("Enter first number");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Greater num is : {0}", Math.Max(firstNum, secondNum));

            //OR
            //taking the absolute value of a number Math.Abs(a)
            //Console.WriteLine("Greater: {0}", (a + b + Math.Abs(a - b)) / 2);
            //Console.WriteLine("Smaller: {0}", (a + b - Math.Abs(a - b)) / 2);

            //uses bitwise operations: 
            //int max = a - ((a - b) & ((a - b) >> 31)); 

            //hidden conditional statement (the ternary ?: operator): 
            //Console.WriteLine(max);
            //int max = a > b ? a : b; 
            //Console.WriteLine(max);

            //###############################################################################################################

            //7.Write a program that reads five integer numbers and prints their sum.If an invalid number is entered 
            //the program should prompt the user to enter another number. 
            //Solution
            //7. You can read the numbers in five different variables and finally sum them and print the obtained sum. 
            //Note that the sum of 5 int values may not fit in the int type so you should use long
            //
            try
            {
                Console.WriteLine("Enter first number");
                long lnum1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                long lnum2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter third number");
                long lnum3 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter fourth number");
                long lnum4 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter fifth number");
                long lnum5 = Int32.Parse(Console.ReadLine());

                long lsum = lnum1 + lnum2 + lnum3 + lnum4 + lnum5;
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", lnum1, lnum2, lnum3, lnum4, lnum5, lsum);

            }
            catch (Exception)
            {

                Console.WriteLine("\nInvalid Number!\n");
                Console.WriteLine("###-Try-again & Enter Numbers only-###");
            }
            Console.ReadKey();

            //or Use  While Loop
            //long num = 0;
            //int count = 1;
            //long sum = 0;

            //while (count <= 5)
            //{
            //    try
            //    {
            //        Console.Write("Enter num {0}: ", count);
            //        num = int.Parse(Console.ReadLine());
            //        count++;
            //        sum += num;
            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("Invalid Number Entered");
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Sum = " + sum);
            //    }

            //}

            //###############################################################################################################
            //8.Write a program that reads five numbers from the console and prints the greatest of them. 
            //Solution
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

            long great1 = Math.Max(gnum1, gnum2);//compare 1 n 2
            long great2 = Math.Max(gnum3, gnum4);// compare 3 n 4
            long great3 = Math.Max(great1, gnum5);//compare g1 n 5

            Console.WriteLine("Greatest number : {0}", Math.Max(great2, great3));//compare g2 n g3
            Console.ReadKey();

            ////Or use For loop
            //long great = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write("Enter number {0}: ", i);
            //    long gnum1 = Int32.Parse(Console.ReadLine());

            //    great = Math.Max(i, gnum1);
            //}

            //Console.WriteLine("Greatest: " + great);
            //Console.ReadKey();

            //#####################################################################################################################################
            //#####################################################################################################################################
            //9.Write a program that reads an integer number n from the console.After that reads n numbers from the console and prints their sum. 
            //Solution
            //9. You should use a for-loop (see the chapter "Loops"). Read the numbers one after another and accumulate their sum in a variable, 
            //which then display on the console at the end. 
            Console.WriteLine("Enter length of numbers");
            int numLength = int.Parse(Console.ReadLine());
            int sumS = 1;
            //int numS = 1;
            Console.Write("The sum 1");
            for (int f = 1; f < numLength; f++)
            {
                //f++;
                sumS += f;
                Console.Write(" + " + f);
            }
            Console.WriteLine(" = " + sumS);

            //Or this
            int numLengthS = int.Parse(Console.ReadLine());
            int Sum = 0;
            int numN = 0;
            for (int i = 1; i <= numLength; i++)
            {
                Console.WriteLine("Enter num {0}: ", i);
                numN = int.Parse(Console.ReadLine());

                Sum += numN;
            }
            Console.WriteLine("Sum = " + Sum);

            //#####################################################################################################################################
            //#####################################################################################################################################
            //10.Write a program that reads an integer number n from the console and prints all numbers in the range[1…n], each on a separate line.
            //Solution
            //10. Use a combination of loops (see the chapter "Loops") and the methods Console.ReadLine(), Console.WriteLine() and Int32.Parse(). 
            Console.WriteLine("Enter a number");
            int numPrint = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter <= numPrint)
            {
                Console.WriteLine(" " + counter);
                counter++;
            }
            Console.ReadKey();

            //#####################################################################################################################################
            //#####################################################################################################################################
            //11.Write a program that prints on the console the first 100 numbers in the 
            //Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
            Console.Write("Enter Fib length: ");
            int fibLen = int.Parse(Console.ReadLine());
            //first 2
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < fibLen; i++)//start at 2
            {
                c = a + b;//add
                Console.Write(" {0} ", c);
                //repeat logic
                a = b;
                b = c;
            }

            //#####################################################################################################################################
            //#####################################################################################################################################
            //12. Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1 / 2 - 1 / 3 + 1 / 4 - 1 / 5 + …
            // While Loop --> The expected result is 1.307.
        }

    }
}
