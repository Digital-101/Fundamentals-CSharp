using System;

class BinarySearchExample
{
    // Function to perform binary search iteratively
    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2; // Avoids overflow

            // If the target is found
            if (arr[mid] == target)
                return mid;

            // If target is greater, search the right half
            if (arr[mid] < target)
                left = mid + 1;
            else // If target is smaller, search the left half
                right = mid - 1;
        }

        return -1; // Target not found
    }

    static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 9, 11, 15, 18 };
        int target = 7;
        int index = BinarySearch(arr, target);

        if (index != -1)
            Console.WriteLine($"Element {target} found at index {index}");
        else
            Console.WriteLine($"Element {target} not found");
    }
}
