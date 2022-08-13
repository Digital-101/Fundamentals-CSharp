using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming._25Exam_2.A
{
    public class WordsCounter
    {
        static void WCoun()
        {
            string text = ReadText();
            string[] words = ExtractWords(text);
            CountWords(words);
        }
        private static string ReadText()
        {
            Console.WriteLine("Enter text:");
            return Console.ReadLine();
        }
        private static char[] ExtractSeparators(string text)
        {
            HashSet<char> separators = new HashSet<char>();
            foreach (char character in text)
            {
                //If the character is not a letter,
                //then by definition it is a separator
                if (!char.IsLetter(character))
                {
                    separators.Add(character);
                }
            }
            return separators.ToArray();
        }
        private static string[] ExtractWords(string text)
        {
            char[] separators = ExtractSeparators(text);
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }


        private static bool IsUpperCase(string word)
        {
            bool result = word.Equals(word.ToUpper());
            return result;
        }
        private static bool IsLowerCase(string word)
        {
            bool result = word.Equals(word.ToLower());
            return result;
        }
        private static void CountWords(string[] words)
        {
            int allUpperCaseWordsCount = 0;
            int allLowerCaseWordsCount = 0;

            foreach (string word in words)
            {
                if (IsUpperCase(word))
                {
                    allUpperCaseWordsCount++;
                }
                else if (IsLowerCase(word))
                {
                    allLowerCaseWordsCount++;
                }
            }

            Console.WriteLine("Total words count: {0}", words.Length);
            Console.WriteLine("Upper case words count: {0}", allUpperCaseWordsCount);
            Console.WriteLine("Lower case words count: {0}", allLowerCaseWordsCount);
        }


    }
}

