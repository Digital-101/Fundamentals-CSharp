using System;

public class PairSumBruteForce
{
    public static void FindPairs(int[] arr, int target)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    Console.WriteLine($"Pair: ({arr[i]}, {arr[j]})");
                }
            }
        }
    }

    public static void Main()
    {
        int[] numbers = { 1, 5, 7, -1, 5 };
        int target = 6;
        FindPairs(numbers, target);
    }
}
