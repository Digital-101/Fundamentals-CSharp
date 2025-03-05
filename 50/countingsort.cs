using System;

class CountingSortExample
{
    static void CountingSort(int[] arr)
    {
        if (arr.Length == 0)
            return;

        // Step 1: Find the maximum value in the array
        int max = arr[0];
        foreach (int num in arr)
        {
            if (num > max)
                max = num;
        }

        // Step 2: Initialize the count array
        int[] count = new int[max + 1];

        // Step 3: Count occurrences of each element
        foreach (int num in arr)
        {
            count[num]++;
        }

        // Step 4: Reconstruct the sorted array
        int index = 0;
        for (int i = 0; i < count.Length; i++)
        {
            while (count[i] > 0)
            {
                arr[index++] = i;
                count[i]--;
            }
        }
    }

    static void Main()
    {
        int[] numbers = { 4, 2, 2, 8, 3, 3, 1 };

        Console.WriteLine("Original array: " + string.Join(", ", numbers));
        CountingSort(numbers);
        Console.WriteLine("Sorted array: " + string.Join(", ", numbers));
    }
}
