using System;
using System.Collections.Generic;

class RadixSortExample
{
    // Function to get the maximum value in an array
    static int GetMax(int[] arr)
    {
        int max = arr[0];
        foreach (int num in arr)
        {
            if (num > max)
                max = num;
        }
        return max;
    }

    // Function to perform counting sort based on a specific digit (place value)
    static void CountingSort(int[] arr, int place)
    {
        int n = arr.Length;
        int[] output = new int[n];
        int[] count = new int[10]; // 0-9 digits

        // Step 1: Count occurrences of digits at 'place' value
        for (int i = 0; i < n; i++)
        {
            int digit = (arr[i] / place) % 10;
            count[digit]++;
        }

        // Step 2: Compute cumulative count
        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }

        // Step 3: Place elements into output array based on digit position
        for (int i = n - 1; i >= 0; i--)
        {
            int digit = (arr[i] / place) % 10;
            output[count[digit] - 1] = arr[i];
            count[digit]--;
        }

        // Step 4: Copy sorted elements back to original array
        for (int i = 0; i < n; i++)
        {
            arr[i] = output[i];
        }
    }

    // Main Radix Sort function
    static void RadixSort(int[] arr)
    {
        int max = GetMax(arr);

        // Apply counting sort for each digit position
        for (int place = 1; max / place > 0; place *= 10)
        {
            CountingSort(arr, place);
        }
    }

    static void Main()
    {
        int[] numbers = { 170, 45, 75, 90, 802, 24, 2, 66 };

        Console.WriteLine("Original array: " + string.Join(", ", numbers));
        RadixSort(numbers);
        Console.WriteLine("Sorted array: " + string.Join(", ", numbers));
    }
}
