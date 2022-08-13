using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming.Exam_1
{
    public class SimpleHtmlTagRemover
    {
        private const string InputFileName = "Problem11.html";
        private const string OutputFileName = "Problem11.txt";
        private const string Charset = "windows-1251";        private static Regex regexWhitespace = new Regex("\n\\s+");

        static void MainHTMR()
        {
            if (!File.Exists(InputFileName))
            {
                Console.WriteLine("File "+InputFileName+" not found.");
                return;
            }

            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                Encoding encoding = Encoding.GetEncoding(Charset);
                reader = new StreamReader(InputFileName, encoding);
                writer = new StreamWriter(OutputFileName, false, encoding);
                RemoveHtmlTags(reader, writer);
            }
            catch (IOException)
            {
                Console.WriteLine("Cannot read file "+InputFileName+".");
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
        /// Removes the tags from HTML text
        /// </summary>
        /// <param name="reader">Input text</param>
        /// <param name="writer">Output text (result)</param>
        private static void RemoveHtmlTags(StreamReader reader, StreamWriter writer)
        {
            int openedTags = 0;
            StringBuilder buffer = new StringBuilder();
            //bool inTag = false;
            while (true)
            {
                int nextChar = reader.Read();
                if (nextChar == -1)
                {
                    //End of file reached
                    PrintBuffer(writer, buffer);
                    break;
                }
                char ch = (char)nextChar;
                if (ch == '<')
                {
                    if (openedTags == 0)
                    {
                        PrintBuffer(writer, buffer);
                        buffer.Length = 0;
                    }
                    openedTags++;
                    //buffer.Clear();
                    //inTag = true;
                }
                else if (ch == '>')
                {
                    openedTags--;
                    //inTag = false;
                }
                else
                {
                    //We aren't in tags (not "<" or ">")
                    if (openedTags == 0)
                    {
                        buffer.Append(ch);
                    }
                }
            }
        }

        /// <summary>
        /// Removes the whitespace and prints the buffer in a file
        /// </summary>
        /// <param name="writer">The result file</param>
        /// <param name="buffer">The input for processing</param>
        private static void PrintBuffer(StreamWriter writer, StringBuilder buffer)
        {
            string str = buffer.ToString();
            string trimmed = str.Trim();
            string textOnly = regexWhitespace.Replace(trimmed, "\n");
            if (!string.IsNullOrEmpty(textOnly))
            {
                writer.WriteLine(textOnly);
            }
        }
    }
}
