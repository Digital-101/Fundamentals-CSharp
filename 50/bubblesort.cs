using System;

class BubbleSort
{
    // Function to perform Bubble Sort
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j + 1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    swapped = true;
                }
            }

            // If no swapping happened, the array is already sorted
            if (!swapped)
                break;
        }
    }

    static void Main()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(" ", arr));

        BubbleSort(arr);

        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(" ", arr));
    }
}
