// BinaryToHex.cs
using System;

class BinaryToHex {
    static void Main() {
        Console.Write("Enter a binary number: ");
        string bin = Console.ReadLine()?.Trim();
        try {
            long val = Convert.ToInt64(bin, 2);
            Console.WriteLine("Hex: " + val.ToString("X"));
        } catch {
            Console.WriteLine("Invalid binary or too large for Int64.");
        }
    }
}
