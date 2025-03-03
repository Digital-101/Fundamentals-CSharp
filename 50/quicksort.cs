using System;
using System.Collections.Generic;

class QuickSortIterative
{
    // Partition function
    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; // Select last element as pivot
        int i = low - 1; // Index of smaller element

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]); // Swap
            }
        }

        // Swap pivot with the correct position
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }

    // Iterative QuickSort function
    public static void QuickSort(int[] arr)
    {
        int low = 0, high = arr.Length - 1;
        Stack<int> stack = new Stack<int>();

        stack.Push(low);
        stack.Push(high);

        while (stack.Count > 0)
        {
            high = stack.Pop();
            low = stack.Pop();

            int pivotIndex = Partition(arr, low, high);

            // Push left subarray to stack if it has more than one element
            if (pivotIndex - 1 > low)
            {
                stack.Push(low);
                stack.Push(pivotIndex - 1);
            }

            // Push right subarray to stack if it has more than one element
            if (pivotIndex + 1 < high)
            {
                stack.Push(pivotIndex + 1);
                stack.Push(high);
            }
        }
    }

    static void Main()
    {
        int[] arr = { 10, 80, 30, 90, 40, 50, 70 };

        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(" ", arr));

        QuickSort(arr);

        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(" ", arr));
    }
}
