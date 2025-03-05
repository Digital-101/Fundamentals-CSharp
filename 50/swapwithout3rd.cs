using System;

class SwapNumbers
{
    static void Main()
    {
        int a = 5, b = 10;

        Console.WriteLine($"Before Swap: a = {a}, b = {b}");

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"After Swap: a = {a}, b = {b}");
    }
}
