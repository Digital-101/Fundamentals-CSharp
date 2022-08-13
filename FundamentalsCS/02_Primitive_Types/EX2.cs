using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._02_Primitive_Types
{
    class EX2
    {
        static void EXX2()
        {
            //1. Declare several variables
            //Ranges of Numeric Types in C#
            sbyte n1 = -128;
            byte n2 = 255;
            short n3 = -10000;
            ushort n4 = 0;
            int n5 = -100000000;
            uint n6 = 0;
            long n7 = -9000000000000000000;
            ulong n8 = 0;

            //2.float,decimal,...
            float f1 = 2.12345678f;
            double d2 = 14.2;
            decimal d1 = 3.4588m;

            //3. Write a program, which compares correctly two real numbers with accuracy at least 0.000001
            int a = 12;
            int b = 12;
            bool equal = Math.Abs(a - b) < 0.000001;

            //4.Initialize a variable of type int with a value of 256 in hexadecimal format(256 is 100 in a numeral system with base 16).            //Integer Literals
            int iL = 256;
            int conv = 0x256;
            Console.WriteLine(conv);

            //5. Declare a variable of type char and assign it as a value the character, which has Unicode code, 72
            //Character Literals
            char n72 = '\u0072';
            Console.WriteLine(n72);

            //6.Declare a variable isMale of type bool and assign a value to it depending on your gender
            bool IsMale = true;

            //10.10. Write a program to print a figure in the shape of a heart by the sign "0"
            Console.WriteLine("00000 00000");
            Console.WriteLine("0000 00000");
            Console.WriteLine(" 000 000");
            Console.WriteLine("  00000");
            Console.WriteLine("   000");
            Console.WriteLine("   00");

            //11.11. Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©".
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char tri = (char)(169);
            Console.WriteLine(tri);
            Console.WriteLine(tri + " " + tri);
            Console.WriteLine(tri + " " + tri + " " + tri);

            //12. Declare appropriate variables
            Console.WriteLine("Employees");
            string firstName;
            string lastName;
            int age;
            char gender;
            int empNum;

            //13.Exchange (swap) values of 2 digits
            int ab = 5;
            int ba = 10;
            Console.WriteLine("Before Swap");
            Console.WriteLine("a = " + ab);
            Console.WriteLine("b = " + ba);
            int temp = ab;
            ab = ba;
            ba = temp;
            //or
            //a=a+b;
            //b=a-b;
            //a=a-b;
            Console.WriteLine("After Swap");
            Console.WriteLine("a = " + ab);
            Console.WriteLine("b = " + ba);

        }
    }
}
