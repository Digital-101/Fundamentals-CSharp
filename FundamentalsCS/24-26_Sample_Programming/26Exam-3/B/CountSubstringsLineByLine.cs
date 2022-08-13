using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming._26Exam_3.B
{
    public class CountSubstringsLineByLine
    {
        static void CSSLBL()
        {
            //Read the input list of words
            string[] words = File.ReadAllLines("wordsLL.txt");

            //Process the file line by line
            int[] occurrences = new int[words.Length];
            using (StreamReader text = File.OpenText("textLL.txt")) 
            {
                string line;
                while ((line = text.ReadLine()) != null)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        string word = words[i];
                        int wordOccurrences = CountOccurencesIgnoreCase(word, line);
                        occurrences[i] += wordOccurrences;
                    }
                }
            }

            //Print the result
            using (StreamWriter result = File.CreateText("resultLL.txt"))
            {
                for (int i = 0; i < words.Length; i++)
                {
                    result.WriteLine("{0} --> {1}", words[i], occurrences[i]);
                }
            }
        }

        private static int CountOccurencesIgnoreCase(string substring, string text)
        {
            int count = 0;
            int index = -1;
            while (true)
            {
                index = text.IndexOf(substring, index + 1, StringComparison.OrdinalIgnoreCase);
                if (index == -1)
                {
                    //No more matches
                    break;
                }
                count++;
            }
            return count;
        }
    }
}
