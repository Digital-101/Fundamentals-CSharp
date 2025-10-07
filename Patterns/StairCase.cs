using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        Staircase(n);
    }
    
    public static void Staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            // Print spaces
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            
            // Print hashes
            for (int k = 1; k <= i; k++)
            {
                Console.Write("#");
            }
            
            Console.WriteLine();
        }
    }
}
