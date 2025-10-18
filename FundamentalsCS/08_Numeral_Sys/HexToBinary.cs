// HexToBinary.cs
using System;

class HexToBinary {
    static void Main() {
        Console.Write("Enter a hexadecimal number: ");
        string hex = Console.ReadLine()?.Trim();
        try {
            long val = Convert.ToInt64(hex, 16);
            Console.WriteLine("Binary: " + Convert.ToString(val, 2));
        } catch {
            Console.WriteLine("Invalid input or number too large for Int64.");
        }
    }
}
