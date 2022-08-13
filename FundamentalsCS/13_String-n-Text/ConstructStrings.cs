using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._13_String_n_Text
{
    class ConstructStrings
    {
        static void SBCl()
        {
            //Slow number Concatenator

            Console.WriteLine(DateTime.Now);

            string collector = "Numbers: ";
            for (int i = 1; i <= 200000 ; i++)
            {
                collector += i;
            }
            Console.WriteLine(collector.Substring(0, 1024));
            Console.WriteLine(DateTime.Now);


            //Elegant Numbers
            Console.WriteLine(DateTime.Now);

            StringBuilder sb = new StringBuilder();
            sb.Append("Numbers: ");

            for (int i = 1; i <= 200000; i++)
            {
                sb.Append(i);
            }
            Console.WriteLine(sb.ToString().Substring(0, 1024));
            Console.WriteLine(DateTime.Now);

            //Word Reverser
            string text = "EM edit";
            string reversed = ReverseText(text);
            Console.WriteLine(reversed);
            //Output:
            //tide ME

        }

        private static string ReverseText(string text)
        {
            StringBuilder sb2 = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb2.Append(text[i]);
            }
            return sb2.ToString();
        }

        //Extract Capital Letters
        public static string ExtractCapitals(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsUpper(ch))
                {
                    result.Append(ch);
                }
            }
            return result.ToString();
        }
    }
}
