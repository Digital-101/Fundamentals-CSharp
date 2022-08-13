using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._6_Loops
{
    class SolveLoop
    {
        static void Pool2()
        {
            //LOOPS
            //############################################################################################################################
            //############################################################################################################################
            //############################################################################################################################
            //1.Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
            //Guide
            //1. Use a for-loop.
            Console.WriteLine("Enter a number");
            int numStnd = int.Parse(Console.ReadLine());

            for (int i = 1; i < numStnd; i++)
            {
                Console.WriteLine(" " + i);
            }

            //###############################################################################################################
            //2.Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously.
            //The number N should be read from the standard input. 
            //Guide
            //2. Use a for-loop and the operator % for finding the remainder in integer division. A number num is not divisible 
            //by 3 and 7 simultaneously exactly when (num % (3*7) == 0).
            Console.WriteLine("enter the value of N");
            int nValue = int.Parse(Console.ReadLine());
            for (int i = 0; i < nValue; i++)
            {
                if (nValue % (3*7) ==0)
                {
                    Console.WriteLine(" " + i);
                }
            }
            Console.ReadKey();

            //3.Write a program that reads from the console a series of integers and prints the smallest and largest of them. 
            //Guide
            //3. First read the count of numbers, for example in a variable n. Then consequently enter n numbers with one for loop. 
            //While entering each new number, save in two variables the smallest and the largest number until this moment. At the 
            //start initialize the smallest and the largest number with Int32.MaxValue and Int32.MinValue respectively. 
            Console.WriteLine("Enter n numbers");
            int nNumb1 = int.Parse(Console.ReadLine());
            //int num123 = 0;
            int smallest = Int32.MinValue;
            int largest = int.MaxValue;
            for (int i = 0; i < nNumb1; i++)
            {
               
                Console.WriteLine("Enter number {0}",i);
            }
            Console.WriteLine("Smallest number " + smallest);
            Console.WriteLine("Largest number " + largest);



            //4.Write a program that prints all possible cards from a standard deck of cards, 
            //without jokers(there are 52 cards: 4 suits of 13 cards). 
            //Guide
            //4. Number the cards from 2 to 14 (these numbers will match the cards 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A). 
            //Number the suits from 1 to 4 (1 – club, 2 – diamond, 3 – heart and 4 – spades). Now you can use the two nested loops and 
            //print each of the cards with two switch statements.

            int[] cards = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int[] suits = { 1, 2, 3, 4 };
            string cardName = "";
            string SuitName = "";

            foreach (var suit in suits)
            {
                switch (suit)
                {
                    case 1:
                        SuitName = "Club";
                        break;
                    case 2:
                        SuitName = "Diamond";
                        break;
                    case 3:
                        SuitName = "Heart";
                        break;
                    case 4:
                        SuitName = "Spade";
                        break;
                    default:
                        break;

                }

                foreach (var card in cards)
                {
                    switch (card)
                    {
                        case 11:
                            cardName = "J";
                            break;
                        case 12:
                            cardName = "Q";
                            break;
                        case 13:
                            cardName = "K";
                            break;
                        case 14:
                            cardName = "A";
                            break;
                        default:
                            cardName = card.ToString();
                            break;
                    }
                    Console.WriteLine(cardName + " " + SuitName);
                }
            }

            //5.Write a program that reads from the console number N and print the sum
            //of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 
            //13, 21, 34, 55, 89, 144, 233, 377, …

            //5.Fibonacci numbers start from 0 and 1, each additional is obtained as
            //the sum of the previous two.You can find the first n Fibonacci
            //numbers with a for-loop from 1 to n, and at each iteration calculate the
            //next number by using the previous two(which you will keep in two
            //additional variables).

            Console.WriteLine("Enter N Numbers");
            int d = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c = 0;

            Console.Write("Fibonnaci Sequence: {0} {1}", a, b);

            for (int i = 2; i < d; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                //iterate the sum till reach length
                a = b;
                b = c;
            }

            //6.Write a program that calculates N! / K! for given N and K(1 < K < N).
            //6. Multiply the numbers from K+1 to N (think why this is correct). You 
            //may check the properties of the factorial function in Wikipedia:
            //http://en.wikipedia.org/wiki/Factorial.

            Console.Write("Enter value of N = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter value of K = ");
            int k = int.Parse(Console.ReadLine());

            decimal fact1 = 1;
            decimal fact2 = 1;
            decimal Fdiv = 0;
            while (true)
            {
                if (n <= 1 && k <= 1)
                {
                    break;
                }

                fact1 *= n;
                fact2 *= k;
                n--;
                k--;
            }
            Console.WriteLine("N! = " + fact1);
            Console.WriteLine("K! = " + fact2);
            Fdiv = fact1 / fact2;
            Console.WriteLine("N! / K! = " + Fdiv);

            //7. Write a program that calculates N!*K!/(N-K)! for given N and K (1 < K < N).
            //7.You might need to use arrays num[0..N] and denum[0..n] to hold the factors
            //in the numerator and in the denominator and to cancel the fraction.
            //You may read about arrays in the chapter “Arrays”.

            Console.Write("Enter value of N = ");
            int n7 = int.Parse(Console.ReadLine());

            Console.Write("Enter value of K = ");
            int k7 = int.Parse(Console.ReadLine());

            decimal diff = n7 - k7;
            decimal fact17 = 1;
            decimal fact27 = 1;
            decimal Fmult = 0;
            while (true)
            {
                if (n7 <= 1 && k7 <= 1)
                {
                    break;
                }

                fact17 *= n7;
                fact27 *= k7;
                n7--;
                k7--;
            }
            Console.WriteLine("N! = " + fact17);
            Console.WriteLine("K! = " + fact27);
            Fmult = fact1 * fact2;
            decimal Fdiv7 = Fmult / diff;
            Console.WriteLine("N! * K! = " + Fmult);
            Console.WriteLine("(N - K) = " + diff);
            Console.WriteLine("N! * K! / (N - K) " + Fdiv7);
            Console.WriteLine();
            Console.ReadKey();

            //10. Write a program that reads from the console a positive integer number 
            //N(N < 20) and prints a matrix of numbers as on the figures below:
            //N = 3 
            //1 2 3
            //2 3 4
            //3 4 5

            //N = 4
            //1 2 3 4
            //2 3 4 5
            //3 4 5 6
            //4 5 6 7

            //10. You should use two nested loops, similar to the problem "Printing a 
            //Triangle". The outer loop must run from 1 to N, and the inner – from the 
            //value of the outer loop to the value of the outer loop +N - 1

            Console.Write("Enter value of P: ");
            int P = int.Parse(Console.ReadLine());
            for (int i = 1; i <= P; i++)
            {
                for (int j = i; j <= i + P - 1; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
