using System;

class MergeSortExample
{
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            // Recursively sort first and second halves
            MergeSort(arr, left, middle);
            MergeSort(arr, middle + 1, right);

            // Merge the sorted halves
            Merge(arr, left, middle, right);
        }
    }

    static void Merge(int[] arr, int left, int middle, int right)
    {
        int leftSize = middle - left + 1;
        int rightSize = right - middle;

        int[] leftArray = new int[leftSize];
        int[] rightArray = new int[rightSize];

        // Copy data to temp arrays
        Array.Copy(arr, left, leftArray, 0, leftSize);
        Array.Copy(arr, middle + 1, rightArray, 0, rightSize);

        int i = 0, j = 0, k = left;

        // Merge temp arrays back into arr
        while (i < leftSize && j < rightSize)
        {
            if (leftArray[i] <= rightArray[j])
            {
                arr[k] = leftArray[i];
                i++;
            }
            else
            {
                arr[k] = rightArray[j];
                j++;
            }
            k++;
        }

        // Copy remaining elements from leftArray
        while (i < leftSize)
        {
            arr[k] = leftArray[i];
            i++;
            k++;
        }

        // Copy remaining elements from rightArray
        while (j < rightSize)
        {
            arr[k] = rightArray[j];
            j++;
            k++;
        }
    }

    static void Main()
    {
        int[] numbers = { 12, 11, 13, 5, 6, 7 };

        Console.WriteLine("Original array: " + string.Join(", ", numbers));
        MergeSort(numbers, 0, numbers.Length - 1);
        Console.WriteLine("Sorted array: " + string.Join(", ", numbers));
    }
}
