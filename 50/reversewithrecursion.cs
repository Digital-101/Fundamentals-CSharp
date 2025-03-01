using System;

class Program
{
    static void Main()
    {
        string input = "visa";  // Example string
        string reversed = ReverseString(input);
        Console.WriteLine("Reversed string: " + reversed);
    }

    static string ReverseString(string str)
    {
        // Base case: if the string is empty or has one character, return it
        if (str.Length <= 1)
        {
            return str;
        }

        // Recursive case: take the first character and append it to the reversed rest of the string
        return ReverseString(str.Substring(1)) + str[0];
    }
}
