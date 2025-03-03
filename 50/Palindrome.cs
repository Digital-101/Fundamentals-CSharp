using System;

class PalindromeProgram
{
    static void Main()
    {
        string input = "racecar";
        bool isPalindrome = IsPalindrome(input);
        Console.WriteLine($"Is \"{input}\" a palindrome? {isPalindrome}");
    }

    static bool IsPalindrome(string str)
    {
        string reversed = ReverseString(str);
        return str == reversed;
    }

    static string ReverseString(string str)
    {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
