using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming.Exam_1
{
    class HtmlTagRemover
    {
        private const string InputFileName = "Problem1.html";
        private const string OutputFileName = "Problem11.txt";
        private const string Charset = "windows-1251";

        static void solveTag()
        {
            if (!File.Exists(InputFileName))
            {
                Console.WriteLine("File " + InputFileName +" not found.");
                return;
            }

            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                Encoding encoding = Encoding.GetEncoding(Charset);
                reader = new StreamReader(InputFileName, encoding);
                writer = new StreamWriter(OutputFileName, false, encoding);

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //Find what we need and save it in the result
                    line = RemoveAllTags(line);
                    line = RemoveNewLinesWithWhiteSpace(line);
                    line = TrimNewlines(line);
                    if (!string.IsNullOrEmpty(line))
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            catch (IOException)
            {

                Console.WriteLine("Cannot Read File " + InputFileName+".");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        /// <summary>
        /// Replaces every tag with new line
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string RemoveAllTags(string str)
        {
            string strWithoutTags = Regex.Replace(str, "<[^>]*>", "\n");
            return strWithoutTags;
        }

        /// <summary>
        /// Replaces sequence of new lines with only one new line
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string RemoveNewLinesWithWhiteSpace(string str)
        {
            //string pattern = "[\n]+";
            string pattern = "\n\\s+";
            return Regex.Replace(str, pattern, "\n");
            //return str.Remove("\n\n", "\n");
        }

        /// <summary>
        /// Removes new lines from start and end of string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string TrimNewlines(string str)
        {
            int start = 0;
            while (start < str.Length && str[start] == '\n')
            {
                start++;
            }
            int end = str.Length - 1;
            while (end >= 0 && str[end] == '\n')
            {
                end--;
            }
            if (start > end)
            {
                return string.Empty;
            }

            string trimmed = str.Substring(start, end - start + 1);
            return trimmed;
        }
    }
}
