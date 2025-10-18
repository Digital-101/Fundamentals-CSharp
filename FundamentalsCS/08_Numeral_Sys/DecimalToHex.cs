// DecimalToHex.cs
using System;

class DecimalToHex {
    static void Main() {
        Console.Write("Enter a non-negative integer: ");
        if (!long.TryParse(Console.ReadLine(), out long n) || n < 0) {
            Console.WriteLine("Invalid input.");
            return;
        }
        Console.WriteLine("Hex: " + n.ToString("X"));
    }
}
