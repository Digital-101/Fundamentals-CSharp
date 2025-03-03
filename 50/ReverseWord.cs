using System;

class ReverseWordProgram
{
    static void Main()
    {
        string input = "Hello world this is CSharp";
        string reversedSentence = ReverseWords(input);
        Console.WriteLine("Reversed Sentence:");
        Console.WriteLine(reversedSentence);
    }

    static string ReverseWords(string sentence)
    {
        char[] chars = sentence.ToCharArray();
        int length = chars.Length;
        string[] words = new string[length]; // Array to store words
        int wordCount = 0;

        string currentWord = "";
        
        // Step 1: Manually split the sentence into words
        for (int i = 0; i < length; i++)
        {
            if (chars[i] != ' ')
            {
                currentWord += chars[i]; // Build the word
            }
            else
            {
                if (currentWord != "")  // Store word in array
                {
                    words[wordCount++] = currentWord;
                    currentWord = "";
                }
            }
        }

        // Store the last word (if exists)
        if (currentWord != "")
        {
            words[wordCount++] = currentWord;
        }

        // Step 2: Reverse the words manually
        string reversedSentence = "";
        for (int i = wordCount - 1; i >= 0; i--)
        {
            reversedSentence += words[i];
            if (i != 0) // Add space between words
            {
                reversedSentence += " ";
            }
        }

        return reversedSentence;
    }
}
