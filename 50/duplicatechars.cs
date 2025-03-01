using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "programming";  // Example string
        PrintDuplicateCharacters(input);
    }

    static void PrintDuplicateCharacters(string str)
    {
        // Create a dictionary to store the frequency of each character
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Loop through the string and count the frequency of each character
        foreach (char c in str)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        // Loop through the dictionary and print characters that appear more than once
        Console.WriteLine("Duplicate characters:");
        foreach (var entry in charCount)
        {
            if (entry.Value > 1)
            {
                Console.WriteLine(entry.Key + " appears " + entry.Value + " times.");
            }
        }
    }
}
