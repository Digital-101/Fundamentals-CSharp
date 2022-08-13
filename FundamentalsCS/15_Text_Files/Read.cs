using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._15_Text_Files
{
    class Read
    {
        static void Reader()
        {

            //Create an instance of StreamReader to read from a file
            StreamReader reader = new StreamReader("Sample.txt");

            int lineNumber = 0;

            //Read first line from the text file
            string line = reader.ReadLine();

            //Read the other lines from the text file
            while (line != null)
            {
                lineNumber++;
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                line = reader.ReadLine();
            }

            //Close the resource after you've finished using it
            reader.Close();
        }
    }
}
