using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS
{
     class ReverseString
    {
        static void Reverse(string[] args)
        {
            Console.WriteLine(DateTime.Now + "\n");

            string user_input;
            string rev = "";

            Console.WriteLine("Enter the string to reverse");
            user_input = Console.ReadLine();
            Console.Write("\n");

            //get length and decrement user string
            int length;
            length = user_input.Length - 1;

            //loop to reverse user input according to length
            while (length >= 0)
            {
                //rev = increment_user[lenght] and index decrement[length]--
                rev += user_input[length];
                length--;
            }

            Console.WriteLine("Reverse string of '{0}' is: '{1}'", user_input.ToUpper(), rev.ToUpper());//Display strings in UpperCases
            Console.ReadKey();
        }
        
    }
}
