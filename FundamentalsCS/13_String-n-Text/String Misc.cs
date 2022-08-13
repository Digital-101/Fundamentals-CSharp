using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FundamentalsCS._13_String_n_Text
{
    class String_Misc
    {
        static void TextString()
        {
            string message = "This is a sample string message.";

            Console.WriteLine("message = {0}", message);
            Console.WriteLine("message.Length = {0}", message.Length);

            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine("message[{0}] = {1}", i, message[i]);
            }
            // Console output: 
            // message = This is a sample string message. 
            // message.Length = 31 
            // message[0] = T 
            // message[1] = h 
            // message[2] = i 
            // message[3] = s 
            // …

            //Searching into a string
            string book = "Introduction to C# book";
            int index = book.IndexOf("C#");

            Console.WriteLine(index);
            // index = 16 


            //Lexicographically 
            string score = "sCore";
            string scary = "scary";

            Console.WriteLine(score.CompareTo(scary));
            Console.WriteLine(scary.CompareTo(score));
            Console.WriteLine(scary.CompareTo(scary));
            //1 right
            //-1 left
            //0 equal


            // Find all occurence of a Substring
            string quote = "The main intent of the \"Intro C#\"" +
            " book is to introduce the C# programming to newbies.";

            string keyword = "C#";
            int index2 = quote.IndexOf(keyword);
            Console.WriteLine(quote);
            Console.WriteLine();
            while (index2 != -1)
            {
                Console.WriteLine("{0} found at index: {1}", keyword, index2);
                index2 = quote.IndexOf(keyword, index2 + 1);
            }

            //Extracting portion of a string
            string path = "C:\\Pics\\CoolPic.jpg";
            string fileName = path.Substring(8, 7);
            Console.WriteLine(fileName);

            //Splitting strings
            string listOfBeers = "Amstel, Heineken, Tuborg, Becks";

            char[] separators = new char[] { ' ', ',', '.' };
            string[] beersArr = listOfBeers.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string beer in beersArr)
            {
                if (beer != "")
                {
                    Console.WriteLine(beer);
                }
            }

            //Replacing Substrings
            string replicate = "repeat";
            string fix = replicate.Replace("repeat", "reload");
            Console.WriteLine(fix);

            //Regular Expressions
            //-The regular expressions are a powerful tool for text processing and allow 
            //searching matches by a pattern. They make text processing easier and more accurate.
            string doc = "Smith's number: 0898880022\nFranky can be " +
            "found at 0888445566.\nSteven's mobile number: 0887654321";
            string replacedDoc = Regex.Replace(doc, "(08)[0-9]{8}", "$1********");
            Console.WriteLine(replacedDoc);
            // Console output:
            // Smith's number: 08********
            // Franky can be found at 08********.
            // Steven' mobile number: 08********

            //Removing unnecessary characters
            string fileData = "     \n\n     David Allen ";
            string reduced = fileData.Trim();

            //Reduce by given List
            string fileData2 = " 111 $ % David Allen ### s ";
            char[] trimChars = new char[] { ' ', '1', '$', '%', '#', 's' };
            string reduced2 = fileData.Trim(trimChars);
            // reduced = "David Allen"

        }
    }
}
