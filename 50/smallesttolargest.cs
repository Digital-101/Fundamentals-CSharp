using System;

public class MinMaxDivideConquer
{
    public static (int, int) FindMinMax(int[] arr, int left, int right)
    {
        if (left == right) return (arr[left], arr[left]); // Single element case

        if (right == left + 1) // Two-element case
            return (Math.Min(arr[left], arr[right]), Math.Max(arr[left], arr[right]));

        int mid = (left + right) / 2;
        var (leftMin, leftMax) = FindMinMax(arr, left, mid);
        var (rightMin, rightMax) = FindMinMax(arr, mid + 1, right);

        return (Math.Min(leftMin, rightMin), Math.Max(leftMax, rightMax));
    }

    public static void Main()
    {
        int[] numbers = { 15, 8, 3, 12, 20, 1 };
        Console.WriteLine("Numbers: "+string.Join(", ",numbers));
        var (min, max) = FindMinMax(numbers, 0, numbers.Length - 1);
        Console.WriteLine($"Smallest: {min}, Largest: {max}");
    }
}
