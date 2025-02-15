using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str1 = "listen";
        string str2 = "silent";

        bool result = AreAnagrams(str1, str2);
        Console.WriteLine(result ? "Anagrams" : "Not Anagrams");
    }

    static bool AreAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in str1)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        foreach (char c in str2)
        {
            if (!charCount.ContainsKey(c) || charCount[c] == 0)
                return false;

            charCount[c]--;
        }

        return true;
    }
}
