using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming._26Exam_3.B
{
    public class CountSubstringsAhoCorasick
    {
        static void CSAC()
        {
            DateTime startTime = DateTime.Now;

            //Read the input list of words
            string[] wordsOriginal = File.ReadAllLines("words.txt");
            string[] wordLowercase = wordsOriginal.Select(w => w.ToLower()).ToArray();

            //Read the text
            string text = File.ReadAllText("text.txt").ToLower();

            //Find all word matches and count them

            //AhoCorasickSearch search = new AhoCorasickSearch();

            var search = new AhoCorasickSearch();
            var matches = search.SearchAll(text, wordLowercase);
            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            foreach (string word in wordLowercase)
            {
                occurrences[word] = 0;
            }
            foreach (var match in matches)
            {
                string word = match.Match;
                occurrences[word]++;
            }

            //Print the result
            using (StreamWriter result = File.CreateText("result.txt"))
            {
                foreach (string word in wordsOriginal)
                {
                    result.WriteLine("{0} --> {1}", word, occurrences[word.ToLower()]);
                }
            }

            Console.WriteLine(DateTime.Now-startTime);
        }
    }
}
