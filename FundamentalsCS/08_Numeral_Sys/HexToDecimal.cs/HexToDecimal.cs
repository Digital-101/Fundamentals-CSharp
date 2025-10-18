// HexToDecimal.cs
using System;

class HexToDecimal {
    static void Main() {
        Console.Write("Enter a hexadecimal number (e.g. F59E): ");
        string hex = Console.ReadLine()?.Trim();
        try {
            long val = Convert.ToInt64(hex, 16);
            Console.WriteLine("Decimal: " + val);
        } catch {
            Console.WriteLine("Invalid hexadecimal input.");
        }
    }
}
