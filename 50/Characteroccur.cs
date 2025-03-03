using System;

class CharOccur
{
    static void Main()
    {
        string input = "programming";  // Example string
        char targetChar = 'g';         // Character to count

        int count = CountCharacterOccurrences(input, targetChar);
        Console.WriteLine($"Character '{targetChar}' appears {count} times in \"{input}\".");
    }

    static int CountCharacterOccurrences(string str, char ch)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c == ch)
            {
                count++;
            }
        }
        return count;
    }
}
