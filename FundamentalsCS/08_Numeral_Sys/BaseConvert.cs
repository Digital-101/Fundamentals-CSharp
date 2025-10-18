// BaseConvert.cs
using System;
using System.Numerics;

class BaseConvert {
    static void Main() {
        Console.Write("Enter number N: ");
        string N = Console.ReadLine()?.Trim().ToUpper();
        Console.Write("Enter source base S (2..16): ");
        int S = int.Parse(Console.ReadLine() ?? "10");
        Console.Write("Enter target base D (2..16): ");
        int D = int.Parse(Console.ReadLine() ?? "10");

        if (S < 2 || S > 16 || D < 2 || D > 16) {
            Console.WriteLine("Bases must be between 2 and 16.");
            return;
        }

        try {
            BigInteger value = ParseToBigInteger(N, S);
            string outStr = ToBase(value, D);
            Console.WriteLine($"Result in base {D}: {outStr}");
        } catch {
            Console.WriteLine("Invalid number for given base.");
        }
    }

    static BigInteger ParseToBigInteger(string s, int fromBase) {
        BigInteger res = 0;
        foreach (char c in s) {
            int digit;
            if (c >= '0' && c <= '9') digit = c - '0';
            else if (c >= 'A' && c <= 'F') digit = 10 + (c - 'A');
            else throw new FormatException();
            if (digit >= fromBase) throw new FormatException();
            res = res * fromBase + digit;
        }
        return res;
    }

    static string ToBase(BigInteger value, int toBase) {
        if (value == 0) return "0";
        string digits = "0123456789ABCDEF";
        bool negative = value < 0;
        if (negative) value = BigInteger.Negate(value);
        var s = "";
        while (value > 0) {
            BigInteger rem;
            value = BigInteger.DivRem(value, toBase, out rem);
            s = digits[(int)rem] + s;
        }
        return negative ? "-" + s : s;
    }
}
