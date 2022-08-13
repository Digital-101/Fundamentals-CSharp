using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._18_Dict_Hash_Sets
{

    class WordCountingWithSortedDictionary
    {
        private static readonly string Text = "Mary had a little lamb " + 
            "little Lamb, little Lamb, " + 
            "Mary had a Little lamb, " + 
            "whose fleece were white as snow.";

        static void MainWCD()
        {
            IDictionary<String, int> wordOccurrenceMap = GetWordOccurrenceMap(Text);
            PrintWordOccurrenceCount(wordOccurrenceMap);
        }


        private static IDictionary<string, int> GetWordOccurrenceMap(string text)
        {
            string[] tokens = text.Split(' ', '.', ',', '-', '?', '!');

            //IDictionary<string, int> words = new SortedDictionary<string, int>();

            //ICompare<E>
            IDictionary<string, int> words = new SortedDictionary<string, int>(new CaseInsensitiveComparer());

            //

            foreach (string word in tokens)
            {
                if (!string.IsNullOrEmpty(word.Trim()))
                {
                    int count;
                    if (!words.TryGetValue(word, out count))
                    {
                        count = 0;
                    }
                    words[word] = count + 1;

                }
            }
            return words;
        }

        private static void PrintWordOccurrenceCount(IDictionary<string, int> wordOccurrenceMap)
        {
            foreach (var wordEntry in wordOccurrenceMap)
            {
                Console.WriteLine("Word '{0}' occurs {1} time(s) in the text", wordEntry.Key, wordEntry.Value);
            }
        }
    }
}
