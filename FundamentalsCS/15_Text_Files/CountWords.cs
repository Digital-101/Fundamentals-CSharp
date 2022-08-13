using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FundamentalsCS._15_Text_Files
{
    class CountWords
    {
        static void Occurance()
        {
            string fileName = @"Occur.txt";
            string word = "C#";

            try
            {
                StreamReader reader = new StreamReader(fileName);
                using (reader)
                {
                    int occurrences = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        int index = line.IndexOf(word);
                        while (index != -1)
                        {
                            occurrences++;
                            index = line.IndexOf(word, (index + 1));
                        }
                        line = reader.ReadLine();
                    }
                    Console.WriteLine("The word {0} occurs {1} times.", word, occurrences);
                }
            }
            catch (FileNotFoundException)
            {

                Console.Error.WriteLine("Can not find file {0}.", fileName);
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Cannot read the file {0}", fileName);
            }
        }
    }
}
