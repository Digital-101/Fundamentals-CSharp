// BinaryToDecimal.cs
using System;

class BinaryToDecimal {
    static void Main() {
        Console.Write("Enter a binary number (e.g. 10101): ");
        string bin = Console.ReadLine()?.Trim();
        try {
            long result = 0;
            foreach (char c in bin) {
                if (c != '0' && c != '1') throw new FormatException();
                result = result * 2 + (c - '0');
            }
            Console.WriteLine("Decimal: " + result);
        } catch {
            Console.WriteLine("Invalid binary input.");
        }
    }
}
