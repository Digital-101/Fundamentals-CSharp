using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS
{
    class BitwiseOperator
    {
        static void boost(string[] args)
        {
            byte a = 3;                 // 0000 0011 = 3 
            byte b = 5;                 // 0000 0101 = 5 

            Console.WriteLine(a | b);   // 0000 0111 = 7 
            Console.WriteLine(a & b);   // 0000 0001 = 1 
            Console.WriteLine(a ^ b);   // 0000 0110 = 6 
            Console.WriteLine(~a & b);  // 0000 0100 = 4 
            Console.WriteLine(a << 1);  // 0000 0110 = 6 
            Console.WriteLine(a << 2);  // 0000 1100 = 12 
            Console.WriteLine(a >> 1);  // 0000 0001 = 1 

            Console.ReadKey();

            //4
            int num = 25;
            bool bit3 = (num & 8) != 0;

            //11
            int n = 35; // 00100011 
            int p = 6; 
            int i = 1; // 00000001 
            int mask = i << p; // Move the 1-st bit left by p positions 

            // If i & mask are positive then the p-th bit of n is 1 
            Console.WriteLine((n & mask) != 0 ? 1 : 0);

            //
            //###############################################################################################################
            //
            //4. Write an expression that checks whether the third bit in a given integer is 1 or 0. 
            //Solution
            //4. Use bitwise "AND" on the current number and the number that has 1 only in the third bit (i.e. number 8, if bits start counting from 0). 
            //If the returned result is different from 0 the third bit is 1:
            //int num = 25;
            //bool bit3 = (num & 8) != 0;
            //HARD  

            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            //Confusing Exercises & | ? SOLUT!0NS
            //13. We are given the number n, the value v (v = 0 or 1) and the position p. write a sequence of operations that changes the value of n, 
            //so the bit on the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. Another example: n=35, p=2, v=1 -> n=39. 

            //CG. 13. Use bitwise operations by analogy with the previous two problems. You can reset the bit at position p in the number n as follows:
            //n = n & (~(1 << p));
            //You can set bits in the unit at position p in the number n as follows:
            //n = n | (1 << p); 
            //Think how you can combine the above two hints.

            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            //15. * Write a program that exchanges the values of the bits on positions 3, 4 and 5 with bits on positions 24, 25 and 26 
            //of a given 32-bit unsigned integer. 
            //CG. 15. Use 3 times a combination of getting and setting a bit at a given position. The first exchange is given below: 
            //int bit3 = (num >> 3) & 1; 
            //int bit24 = (num >> 24) & 1; 
            //num = num & (~(1 << 24)) | (bit3 << 24); 
            //num = num & (~(1 << 3)) | (bit24 << 3); 

            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            //16. * Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
            //CG. 16.Extend the solution of the previous problem to perform a sequence of bit exchanges in a loop. 
            //Read about loops in the chapter “Loops”. 



        }
    }
}
