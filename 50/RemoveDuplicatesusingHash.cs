using System;

public class RemoveDuplicatesUsingHash
{
    public static int[] RemoveDuplicates(int[] arr, int n)
    {
        if (n == 0 || n == 1)
            return arr;

        bool[] visited = new bool[1000]; // Assuming elements are within 1000
        int[] result = new int[n];
        int j = 0;

        for (int i = 0; i < n; i++)
        {
            if (!visited[arr[i]])
            {
                result[j++] = arr[i];
                visited[arr[i]] = true; // Mark as visited
            }
        }

        // Copy unique elements back
        int[] finalArr = new int[j];
        for (int i = 0; i < j; i++)
        {
            finalArr[i] = result[i];
        }

        return finalArr;
    }

    public static void Main()
    {
        int[] arr = { 4, 2, 2, 3, 1, 4, 6, 6, 7 };
        int[] uniqueArr = RemoveDuplicates(arr, arr.Length);
        Console.WriteLine("Original Array: "+string.Join(", ",arr));
        Console.Write("Array after removing duplicates: ");
        foreach (int num in uniqueArr)
        {
            Console.Write(num + " ");
        }
    }
}
