// BinaryToDecimalHorner.cs
using System;

class BinaryToDecimalHorner {
    static void Main() {
        Console.Write("Enter binary: ");
        string bin = Console.ReadLine()?.Trim();
        try {
            long res = 0;
            foreach (char ch in bin) {
                if (ch != '0' && ch != '1') throw new FormatException();
                res = checked(res * 2 + (ch - '0')); // checked to detect overflow
            }
            Console.WriteLine("Decimal: " + res);
        } catch (OverflowException) {
            Console.WriteLine("Overflow: number too big for Int64.");
        } catch {
            Console.WriteLine("Invalid binary input.");
        }
    }
}
