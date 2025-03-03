using System;

class StringRotation
{
    static void Main()
    {
        string s1 = "abcd";
        string s2 = "cdab";

        bool result = AreRotations(s1, s2);
        Console.WriteLine($"Are \"{s1}\" and \"{s2}\" rotations of each other? {result}");
    }

    static bool AreRotations(string s1, string s2)
    {
        // Step 1: Check if both strings have the same length
        if (s1.Length != s2.Length)
        {
            return false;
        }

        // Step 2: Concatenate s1 with itself
        string temp = s1 + s1;

        // Step 3: Check if s2 is a substring of the concatenated string
        return temp.Contains(s2);
    }
}
