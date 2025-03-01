using System;

class Program
{
    static void Main()
    {
        string input = "programming";  // Example string
        CountVowelsAndConsonants(input);
    }

    static void CountVowelsAndConsonants(string str)
    {
        int vowelCount = 0;
        int consonantCount = 0;

        // Define vowels
        string vowels = "aeiouAEIOU";

        foreach (char c in str)
        {
            // Check if character is a letter
            if (Char.IsLetter(c))
            {
                // Check if it's a vowel
                if (vowels.Contains(c))
                {
                    vowelCount++;
                }
                // If it's a letter but not a vowel, it's a consonant
                else
                {
                    consonantCount++;
                }
            }
        }

        Console.WriteLine("Vowels: " + vowelCount);
        Console.WriteLine("Consonants: " + consonantCount);
    }
}
