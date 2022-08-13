using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._5_Conditional_Stat
{
    class SolveCon
    {
        static void Condition()
        {
            //5.CONDITIONAL STATEMENTS
            //###############################################################################################################
            //###############################################################################################################
            //###############################################################################################################

            //1. Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one. 
            //Solution
            //1. Look at the section about if-statements. 
            Console.WriteLine("Enter first number");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nYou entered {0} and {1}", num1, num2);

            if (num1 > num2)
            {
                //store first in new_var && new_var == second
                int temp = num1;
                temp = num2;

                //second == second && first == new_var
                num2 = num1;
                num1 = temp;

                Console.WriteLine("First number is " + num1);
                Console.WriteLine("Second number is " + num2);
            }
            else
            {
                Console.WriteLine("\nNot exchanged");
            }

            //##################################################################################################################################
            //2.2. Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it.Use a sequence of if operators.
            Console.WriteLine("Enter first number");
            int num11 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num22 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int num33 = Int32.Parse(Console.ReadLine());
            int negativesCont = 0;

            if (num11 < 0 && num22 < 0 && num33 < 0)
            {
                negativesCont++;
                Console.WriteLine("+");
            }
            else if (num11 > 0 && num22 > 0 && num33 > 0)
            {
                Console.WriteLine("+");
            }
            else if (num33 == 0 || num22 == 0 || num11 == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine("-");
            }

            //##################################################################################################################################
            //3. Write a program that finds the biggest of three integers, using nested if statements. 
            //Solution
            //3. Use nested if-statements, first checking the first two numbers then checking the bigger of them with the third. 
            Console.WriteLine("Enter first number");
            int numb1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int numb2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int numb3 = Int32.Parse(Console.ReadLine());

            //check numbers using nested if statements
            if (numb1 > numb2)
            {
                Console.WriteLine("\n{0} is biggest", numb1);
            }
            else if (numb2 > numb3)
            {
                Console.WriteLine("\n{0} is biggest", numb2);

            }
            else if (numb3 > numb1)
            {
                Console.WriteLine("\n{0} is biggest", numb3);
            }

            //############################################################################################################################################
            //4.Sort 3 real numbers in descending order. Use nested if statements.
            //If-Statements Swaps
            int no1 = 5, no2 = 29, no3 = 18;
            Console.WriteLine("Default: {0} {1} {2}", no1, no2, no3);
            if (no1 < no2)
            {
                int temp = no1;
                no1 = no2;
                no2 = temp;
            }
            else if (no2 < no3)
            {
                int temp = no2;
                no2 = no3;
                no3 = temp;
            }
            else if (no3 < no1)
            {
                int temp = no3;
                no3 = no1;
                no1 = temp;
            }
            Console.WriteLine("Des: {0} {1} {2}", no1, no3, no2);

            //IF-ELSE STATEMENTS
            //int no1 = 5, no2 = 29, no3 = 18;
            Console.WriteLine("Default: {0} {1} {2}", no1, no2, no3);

            //Concept of --> Bubble, Insertion, Sorting
            if (no1 < no2)
            {
                if (no3 < no1)
                {
                    Console.Write("Des: {0} {1} {2}", no2, no1, no3);
                }
                else if (no2 < no3)
                {
                    Console.Write("Des: {0} {1} {2}", no2, no3, no1);
                }
                else
                {
                    Console.Write("Des: {0} {1} {2}", no2, no3, no1);
                }
            }
            else if (no1 < no3)
            {
                Console.Write("Des: {0} {1} {2}", no3, no1, no2);
            }
            else if (no3 < no2)
            {
                Console.Write("Des: {0} {1} {2}", no1, no2, no3);
            }
            else
            {
                Console.Write("Des: {0} {1} {2}", no1, no3, no2);
            }

            //Quick -->> List Sort
            List<int> numbd = new List<int>(3);
            numbd.Add(5);
            numbd.Add(29);
            numbd.Add(17);

            numbd.Sort();

            //LINQ
            //var ascending = numbd.OrderBy(i=>i);
            var descending = numbd.OrderByDescending(i => i);

            //CompareTo Methods
            //var asc = numbd.Sort((a, b) => a.CompareTo(b));
            //var des = numbd.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(String.Join(",", descending));
            //############################################################################################################################################
            //5. Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a switch statement. 
            //Solution
            //5. Just use a switch statement to check for all possible digits. 
            Console.WriteLine("Enter a digit (0-9)");
            int digit = int.Parse(Console.ReadLine());
            switch (digit)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;

                default:
                    break;
            }
            Console.ReadKey();

            //6. Quadratic Equation
            //discriment = b^2 - 4ac
            double a, b, c;
            double disc, deno, x1, x2;
            Console.WriteLine("ENTER THE VALUES OF A, B, C...");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                x1 = -c / b;
                Console.WriteLine("The roots are Linear: ", x1);
            }
            else
            {
                disc = (b * b) - (4 * a * c);
                deno = 2 * a;
                if (disc > 0)
                {
                    Console.WriteLine("THE ROOTS ARE REAL AND DISTINCT ROOTS");
                    x1 = (-b / deno) + (Math.Sqrt(disc) / deno);
                    x2 = (-b / deno) - (Math.Sqrt(disc) / deno);
                    Console.WriteLine("THE ROOTS ARE... " + x1 + " and " + x2);
                }
                else if (disc == 0)
                {
                    Console.WriteLine("THE ROOTS ARE REPEATED ROOTS");
                    x1 = -b / deno;
                    Console.WriteLine("THE ROOT IS...: " + x1);
                }
                else
                {
                    Console.WriteLine("THE ROOTS ARE IMAGINARY ROOTS\n");
                    x1 = -b / deno;
                    x2 = ((Math.Sqrt((4 * a * c) - (b * b))) / deno);
                    Console.WriteLine("THE ROOT 1: " + x1 + "+i" + x1);
                    Console.WriteLine("THE ROOT 2: " + x1 + "-i" + x2);
                }
            }

            //7.//Greatest Number using Array Max
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

            long[] array = { gnum1, gnum2, gnum3, gnum4, gnum5 };
            long big = array.Max();
            Console.WriteLine("Greatest: " + big);

            //For-Loop
            int[] numbers = new int[6];
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Enter number {0}: ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int great = numbers.Max();
            Console.WriteLine("Max: " + great);

            //############################################################################################################################################
            //8. Write a program that, depending on the user’s choice, inputs int, double or string variable. 
            //If the variable is int or double, the program increases it by 1. If the variable is a string, the program appends "*" at the end. 
            //Print the result at the console. Use switch statement
            //Solution
            //8. First input a variable, which indicates what type will be the input, i.e. by entering 0 the type is int, by 1 is double and by 2 is string.
            Console.WriteLine("Input a variable type( 0 -> int), (1 -> double) and (2 -> string)");
            string choose = Console.ReadLine();

            int zero = 0;
            double one = 0;
            string two = "";

            if (choose != "0" && choose != "1" && choose != "2")
            {
                Console.WriteLine("Invalid Input");
            }
            else if (choose == "0")
            {
                Console.WriteLine("Enter int Number: ");
                zero = int.Parse(Console.ReadLine());
            }
            else if (choose == "1")
            {
                Console.WriteLine("Enter double Number: ");
                one = double.Parse(Console.ReadLine());
            }
            else if (choose == "2")
            {
                Console.WriteLine("Enter string input: ");
                two = Console.ReadLine();
            }

            switch (choose)
            {
                case "0":
                    Console.WriteLine("You chosen int \n");
                    Console.WriteLine(zero + 1);
                    break;
                case "1":
                    Console.WriteLine("You chosen double \n");
                    Console.WriteLine(one + 1);
                    break;
                case "2":
                    Console.WriteLine("You chosen string \n");
                    Console.WriteLine(two + " * ");
                    break;
                default:
                    break;
            }

            Console.ReadKey();
            
            //############################################################################################################################################
            //9.

            //############################################################################################################################################
            //10. Write a program that applies bonus points to given scores in the range [1…9] by the following rules: - 
            //If the score is between 1 and 3, the program multiplies it by 10. - If the score is between 4 and 6, the program multiplies it by 100. - 
            //If the score is between 7 and 9, the program multiplies it by 1000. - If the score is 0 or more than 9, the program prints an error message.
            //Solution
            //10. Use switch statement or a sequence of if-else constructs and at the end print at the console the calculated points. 

            Console.WriteLine("Enter your score (1-9)");
            int scores = int.Parse(Console.ReadLine());
            int bonus;
            if (scores >= 1 && scores <= 3)
            {
                bonus = scores * 10;
                Console.WriteLine("Your bonus points : " + bonus);
            }
            else if (scores >= 4 && scores <= 6)
            {
                bonus = scores * 100;
                Console.WriteLine("Your bonus points : " + bonus);
            }
            else if (scores >= 7 && scores <= 9)
            {
                bonus = scores * 1000;
                Console.WriteLine("Your bonus points : " + bonus);
            }
            else if (scores == 0 && scores > 9)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            //############################################################################################################################################
            //11.11. * Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
            Console.WriteLine("Enter a number (0 - 999)");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 10:
                    Console.WriteLine("Ten");
                    break;
                case 11:
                    Console.WriteLine("Eleven");
                    break;
                case 12:
                    Console.WriteLine("Twelve");
                    break;
                case 13:
                    Console.WriteLine("Thirteen");
                    break;
                case 14:
                    Console.WriteLine("Fourteen");
                    break;
                case 15:
                    Console.WriteLine("Fifteen");
                    break;
                case 16:
                    Console.WriteLine("Sixteen");
                    break;
                case 17:
                    Console.WriteLine("Seventeen");
                    break;
                case 18:
                    Console.WriteLine("Eighteen");
                    break;
                case 19:
                    Console.WriteLine("Nineteen");
                    break;

                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
