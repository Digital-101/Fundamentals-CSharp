using System;

public class RemoveDuplicates
{
    public static int[] RemoveDuplicatesFromArray(int[] arr, int n)
    {
        if (n == 0 || n == 1)
            return arr; // Already unique or empty

        int[] temp = new int[n]; // Temporary array to store unique elements
        int j = 0;

        for (int i = 0; i < n; i++)
        {
            bool isDuplicate = false;

            // Check if the element is already present in temp
            for (int k = 0; k < j; k++)
            {
                if (arr[i] == temp[k])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                temp[j++] = arr[i]; // Store unique element
            }
        }

        // Copy unique elements back to the original array
        int[] result = new int[j];
        for (int i = 0; i < j; i++)
        {
            result[i] = temp[i];
        }

        return result;
    }

    public static void Main()
    {
        int[] arr = { 1, 2, 2, 3, 4, 4, 5, 6, 6, 7 };
        int[] uniqueArr = RemoveDuplicatesFromArray(arr, arr.Length);
        Console.WriteLine("Array before removing duplicates: "+string.Join(",",arr));
        Console.Write("Array after removing duplicates: ");
        foreach (int num in uniqueArr)
        {
            Console.Write(num + " ");
        }
    }
}
