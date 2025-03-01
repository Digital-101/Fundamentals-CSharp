using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "programming";  // Example string
        char result = FirstNonRepeatedCharacter(input);
        
        if (result != '\0') // If a non-repeated character is found
        {
            Console.WriteLine("First non-repeated character: " + result);
        }
        else
        {
            Console.WriteLine("No non-repeated character found.");
        }
    }

    static char FirstNonRepeatedCharacter(string str)
    {
        // Dictionary to store character frequency
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Count the frequency of each character in the string
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

        // Loop through the string to find the first non-repeated character
        foreach (char c in str)
        {
            if (charCount[c] == 1)
            {
                return c;
            }
        }

        // Return null character if no non-repeated character is found
        return '\0';
    }
}
