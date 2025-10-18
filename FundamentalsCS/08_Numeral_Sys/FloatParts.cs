// FloatParts.cs
using System;

class FloatParts {
    static void Main() {
        Console.Write("Enter a float (e.g. -27.25): ");
        if (!float.TryParse(Console.ReadLine(), out float f)) {
            Console.WriteLine("Invalid float.");
            return;
        }
        uint bits = (uint)BitConverter.ToInt32(BitConverter.GetBytes(f), 0);
        uint sign = bits >> 31;
        uint exponent = (bits >> 23) & 0xFF; // 8 bits
        uint mantissa = bits & 0x7FFFFF;     // 23 bits

        string expStr = Convert.ToString((int)exponent, 2).PadLeft(8, '0');
        string manStr = Convert.ToString((int)mantissa, 2).PadLeft(23, '0');

        Console.WriteLine($"sign = {sign}");
        Console.WriteLine($"exponent = {expStr}");
        Console.WriteLine($"mantissa = {manStr}");
    }
}
