using System;

class InsertionSortExample
{
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i]; // Element to be inserted
            int j = i - 1;

            // Move elements that are greater than key to one position ahead
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key; // Insert the key at its correct position
        }
    }

    static void Main()
    {
        int[] numbers = { 12, 11, 13, 5, 6 };

        Console.WriteLine("Original array: " + string.Join(", ", numbers));
        InsertionSort(numbers);
        Console.WriteLine("Sorted array: " + string.Join(", ", numbers));
    }
}
