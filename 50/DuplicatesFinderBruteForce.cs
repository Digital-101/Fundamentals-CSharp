using System;

public class DuplicateFinderBruteForce
{
    public static void FindDuplicates(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    Console.WriteLine($"Duplicate: {arr[i]}");
                    break; // Avoid multiple prints of the same duplicate
                }
            }
        }
    }

    public static void Main()
    {
        int[] numbers = { 4, 5, 6, 4, 7, 8, 6, 9 };
        Console.WriteLine("Array: "+string.Join(", ",numbers));
        FindDuplicates(numbers);
    }
}
