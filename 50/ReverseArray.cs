using System;

public class ReverseArray
{
    public static void Reverse(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            // Swap elements at left and right indexes
            (arr[left], arr[right]) = (arr[right], arr[left]);

            left++;
            right--;
        }
    }

    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine("Original Array: " + string.Join(", ", arr));

        Reverse(arr);

        Console.WriteLine("Reversed Array: " + string.Join(", ", arr));
    }
}
