using System;
using System.Collections.Generic;

public class RemoveDuplicatesHashSet
{
    public static int[] RemoveDuplicates(int[] arr)
    {
        HashSet<int> uniqueElements = new HashSet<int>(arr);
        return new List<int>(uniqueElements).ToArray();
    }

    public static void Main()
    {
        int[] numbers = { 4, 5, 6, 4, 7, 8, 6, 9, 5 };
        int[] uniqueNumbers = RemoveDuplicates(numbers);
        Console.WriteLine("Array before removing duplicates: " + string.Join(", ", numbers));

        Console.WriteLine("Array after removing duplicates: " + string.Join(", ", uniqueNumbers));
    }
}
