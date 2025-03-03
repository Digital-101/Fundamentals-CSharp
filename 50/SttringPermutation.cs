using System;
using System.Collections.Generic;

class StringPermutation
{
    static void Main()
    {
        string input = "abc";  // Example string
        List<string> permutations = GetPermutations(input);

        Console.WriteLine("All permutations of the string:");
        foreach (string perm in permutations)
        {
            Console.WriteLine(perm);
        }
    }

    static List<string> GetPermutations(string str)
    {
        List<string> result = new List<string>();

        // Base case: If the string is empty, return an empty list
        if (str.Length == 0)
        {
            result.Add("");
            return result;
        }

        // Recursive case: Take one character at a time and permute the rest
        for (int i = 0; i < str.Length; i++)
        {
            char currentChar = str[i];
            string remainingString = str.Substring(0, i) + str.Substring(i + 1);

            // Get all permutations of the remaining string
            List<string> subPermutations = GetPermutations(remainingString);

            // Add the current character to each permutation of the remaining string
            foreach (string perm in subPermutations)
            {
                result.Add(currentChar + perm);
            }
        }

        return result;
    }
}
