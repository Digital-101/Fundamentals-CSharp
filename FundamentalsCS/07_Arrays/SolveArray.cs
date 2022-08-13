using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._7_Arrays
{
    class SolveArray
    {
        static void Array22()
        {
            //ARRAYS
            //############################################################################################################################
            //############################################################################################################################
            //############################################################################################################################
            //1.Write a program, which creates an array of 20 elements of type integer and initializes each of the elements 
            //with a value equals to the index of the element multiplied by 5.Print the elements to the console.
            //Guide
            //1. Use an int[] array and a for-loop.

            int[] array20 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };//array default int
            for (int i = 0; i < array20.Length; i++)
            {
                array20[i] = 5 * array20[i];//x5 
                Console.WriteLine(array20[i] + " ");//print
            }

            //############################################################################################################################

            //2. Write a program, which reads two arrays from the console and checks whether they are equal (two arrays are equal 
            //when they are of equal length and all of their elements, which have the same index, are equal).
            //Guide
            // 2. Two arrays are equal if they have the same value for the length and the values for their elements. 
            //You can check for the second condition using a for-loop. 
            Console.WriteLine("Enter array 1");
            int array1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter array 2");
            int array2 = int.Parse(Console.ReadLine());

            int[] arr1 = new int[array1];
            int[] arr2 = new int[array2];

            if (arr1 == arr2)
            {
                Console.WriteLine("Arrays are equal");
            }
            else
            {
                Console.WriteLine("Arrays are not equal");
            }

            //############################################################################################################################

            //3. Write a program, which compares two arrays of type char
            //lexicographically(character by character) and checks, which one is first
            //in the lexicographical order.

            char[] first = { 'g', 'r', 'e', 'e', 'n' };
            char[] second = { 'b', 'l', 'a', 'c', 'k' };

            if (first.Length == second.Length)
            {
                Console.WriteLine("Elements are Equal.");
            }
            else
            {
                Console.WriteLine("Elements are not equal.");
            }

            //3.In lexicographic order the elements are compared one by one
            //starting from the very left.If the elements are not the same, the array, 
            //whose element is smaller(comes earlier in the alphabet), comes first. If
            //the elements are equal, the next character is compared.If the end of one
            //of the arrays is reached, without finding different elements, the shorter
            //array is the smaller (comes earlier lexicographically). If all elements are
            //equal, the arrays are equal.
        }
    }
}
