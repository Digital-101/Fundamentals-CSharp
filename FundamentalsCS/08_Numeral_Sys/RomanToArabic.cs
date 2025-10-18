// RomanToArabic.cs
using System;
using System.Collections.Generic;

class RomanToArabic {
    static void Main() {
        Console.Write("Enter Roman numeral (e.g. MCMXCIV): ");
        string roman = Console.ReadLine()?.ToUpper().Trim();
        try {
            Console.WriteLine("Arabic: " + RomanToInt(roman));
        } catch {
            Console.WriteLine("Invalid Roman numeral.");
        }
    }

    static int RomanToInt(string s) {
        if (string.IsNullOrEmpty(s)) throw new FormatException();
        var map = new Dictionary<char,int> {
            ['I']=1,['V']=5,['X']=10,['L']=50,['C']=100,['D']=500,['M']=1000
        };
        int total = 0;
        for (int i = 0; i < s.Length; i++) {
            if (!map.ContainsKey(s[i])) throw new FormatException();
            int value = map[s[i]];
            int next = (i+1 < s.Length) ? map[s[i+1]] : 0;
            if (next > value) { total += (next - value); i++; } 
            else { total += value; }
        }
        return total;
    }
}
