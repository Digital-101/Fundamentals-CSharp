using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming._26Exam_3.B
{
    //Non generic class
    public static class CountSubstringsCharByChar
    {
        static void CSCBC()
        {
            //Read the input list of words
            string[] wordsOriginal = File.ReadAllLines("words.txt");
            string[] wordsLowercase = wordsOriginal.Select(w => w.ToLower()).ToArray();

            //Process the file char by char
            int[] occureences = new int[wordsLowercase.Length];
            StringBuilder buffer = new StringBuilder();
            using (StreamReader text = File.OpenText("text.txt"))
            {
                int nextChar;
                while ((nextChar = text.Read()) != -1)
                {
                    char ch = (char)nextChar;
                    if (char.IsLetter(ch))
                    {
                        //A letter is found --> check all words for matches
                        ch = char.ToLower(ch);
                        buffer.Append(ch);
                        for (int i = 0; i < wordsLowercase.Length; i++)
                        {
                            string word = wordsLowercase[i];
                            if (buffer.EndsWith(word))
                            {
                                occureences[i]++;
                            }
                        }
                    }
                    else
                    {
                        //A non-letter is found --> clean the buffer
                    }
                }
            }

            //Print the result
            using (StreamWriter result = File.CreateText("result.txt"))
            {
                for (int i = 0; i < wordsOriginal.Length; i++)
                {
                    result.WriteLine("{0} --> {1}", wordsOriginal[i], occureences[i]);
                }
            }
        }

        static bool EndsWith(this StringBuilder buffer, string str)
        {
            if (buffer.Length < str.Length)
            {
                return false;
            }

            //Need Fix bug
            //for (int bufIndex = buffer.Length-str.Length; int strIndex=0; strIndex < str.Length; bufIndex++, strIndex++)
            //{
            //    if (buffer[bufIndex] != str[strIndex])
            //    {
            //        return false;
            //    }
            //}

            return true;
        }
    }
}
