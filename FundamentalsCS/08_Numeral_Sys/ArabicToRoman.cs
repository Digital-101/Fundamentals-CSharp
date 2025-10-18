// ArabicToRoman.cs
using System;

class ArabicToRoman {
    static void Main() {
        Console.Write("Enter integer (1..3999): ");
        if (!int.TryParse(Console.ReadLine(), out int num) || num < 1 || num > 3999) {
            Console.WriteLine("Enter a number between 1 and 3999.");
            return;
        }
        Console.WriteLine("Roman: " + ToRoman(num));
    }

    static string ToRoman(int num) {
        var vals = new (int val, string sym)[] {
            (1000,"M"), (900,"CM"), (500,"D"), (400,"CD"),
            (100,"C"), (90,"XC"), (50,"L"), (40,"XL"),
            (10,"X"), (9,"IX"), (5,"V"), (4,"IV"), (1,"I")
        };
        var res = "";
        foreach (var p in vals) {
            while (num >= p.val) { res += p.sym; num -= p.val; }
        }
        return res;
    }
}
