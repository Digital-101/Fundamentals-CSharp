using System;

public class MissingNumber
{
    public static int FindMissingNumber(int[] arr, int n)
    {
        int expectedSum = (n * (n + 1)) / 2;  // Sum formula
        int actualSum = 0;

        foreach (int num in arr)
        {
            actualSum += num;
        }

        return expectedSum - actualSum;  // Missing number
    }

    public static void Main()
    {
        int[] numbers = new int[99]; // Array with one missing number
        int missingNumber = 45; // Assume 45 is missing

        // Fill the array (excluding 45)
        int index = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i != missingNumber)
                numbers[index++] = i;
        }
        Console.WriteLine("Numbers: "+string.Join(", ",numbers));
        Console.WriteLine("Missing Number: " + FindMissingNumber(numbers, 100));
    }
}
