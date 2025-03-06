using System;

public class QuickSortExample
{
    // Quicksort Algorithm
    public static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            // Partition the array into two halves and get the pivot index
            int pi = Partition(arr, low, high);

            // Recursively sort the left and right sub-arrays
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    // Partition the array and return the index of the pivot
    private static int Partition(int[] arr, int low, int high)
    {
        // Choose the last element as the pivot
        int pivot = arr[high];

        // Pointer for the smaller element
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++; // increment the index of smaller element
                Swap(arr, i, j); // Swap if the current element is smaller than pivot
            }
        }

        // Swap the pivot element to its correct position
        Swap(arr, i + 1, high);
        return i + 1;
    }

    // Swap two elements in the array
    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    // Main function to test the quicksort implementation
    public static void Main()
    {
        int[] numbers = { 8, 2, 5, 1, 9, 3, 7, 4, 6 };

        Console.WriteLine("Array before sorting: " + string.Join(", ", numbers));

        QuickSort(numbers, 0, numbers.Length - 1);

        Console.WriteLine("Array after sorting: " + string.Join(", ", numbers));
    }
}
