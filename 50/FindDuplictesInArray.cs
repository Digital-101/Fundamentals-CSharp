using System;

public class FindDuplicateIndexMarking
{
    public static int FindDuplicate(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int index = Math.Abs(arr[i]);
            if (arr[index] < 0) // Already visited
                return index;
            arr[index] = -arr[index]; // Mark as visited
        }
        return -1; // No duplicate found
    }

    public static void Main()
    {
        int[] numbers = { 2, 3, 1, 4, 2 };
        Console.WriteLine("Array: "+string.Join(", ",numbers));
        Console.WriteLine("Duplicate Number: " + FindDuplicate(numbers));
    }
}
