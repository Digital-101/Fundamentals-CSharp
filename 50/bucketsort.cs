using System;
using System.Collections.Generic;

class BucketSortExample
{
    static void BucketSort(float[] arr, int bucketCount)
    {
        if (arr.Length == 0)
            return;

        // Step 1: Create empty buckets
        List<float>[] buckets = new List<float>[bucketCount];
        for (int i = 0; i < bucketCount; i++)
        {
            buckets[i] = new List<float>();
        }

        // Step 2: Place elements into appropriate buckets
        foreach (float num in arr)
        {
            int bucketIndex = (int)(num * bucketCount); // Assuming numbers are in [0,1)
            buckets[bucketIndex].Add(num);
        }

        // Step 3: Sort individual buckets (using Insertion Sort here)
        for (int i = 0; i < bucketCount; i++)
        {
            buckets[i].Sort();
        }

        // Step 4: Concatenate buckets back into the original array
        int index = 0;
        foreach (var bucket in buckets)
        {
            foreach (var num in bucket)
            {
                arr[index++] = num;
            }
        }
    }

    static void Main()
    {
        float[] numbers = { 0.78f, 0.17f, 0.39f, 0.26f, 0.72f, 0.94f, 0.21f, 0.12f, 0.23f, 0.68f };

        Console.WriteLine("Original array: " + string.Join(", ", numbers));
        BucketSort(numbers, 5); // Using 5 buckets
        Console.WriteLine("Sorted array: " + string.Join(", ", numbers));
    }
}
