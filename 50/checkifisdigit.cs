using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = "12345";  // Example input
        bool isDigitsOnly = input.All(char.IsDigit);

        if (isDigitsOnly)
        {
            Console.WriteLine("The string contains only digits.");
        }
        else
        {
            Console.WriteLine("The string contains non-digit characters.");
        }
    }
}
