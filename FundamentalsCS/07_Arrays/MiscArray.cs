using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._7_Arrays
{
    class MiscArray
    {
        static void RRay()
        {
            //REVERSE ARRAY
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            int[] array = { 1, 2, 3, 4, 5 };   // Get array size   
            int length = array.Length;   // Declare and create the reversed array   
            int[] reversed = new int[length];

            // Initialize the reversed array   
            for (int index = 0; index < length; index++)
            {
                reversed[length - index - 1] = array[index];
            }
            // Print the reversed array   
            for (int index = 0; index < length; index++)
            {
                Console.Write(reversed[index] + " ");
            }
            //SYMMETRIC ARRAY
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            Console.Write("Enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());
            int[] array2 = new int[n];

            Console.WriteLine("Enter the values of the array:");

            for (int i = 0; i < n; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            bool symmetric = true;
            for (int i = 0; i < array2.Length / 2; i++)
            {
                if (array2[i] != array2[n - i - 1])
                {
                    symmetric = false;
                    break;
                }
            }

            Console.WriteLine("Is symmetric? {0}", symmetric);

            //Iteration with a loop
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            int[] array3 = new int[] { 1, 2, 3, 4, 5 };

            Console.Write("Output: ");
            for (int index = 0; index < array3.Length; index++)
            {
                // Doubling the number  
                array3[index] = 2 * array3[index];  
                // Print the number  
                Console.Write(array3[index] + " ");
            }


            //Reverse

            int[] array4 = new int[] { 1, 2, 3, 4, 5 };

            Console.Write("Reversed: ");
            for (int p = array4.Length - 1; p >= 0; p--)
            {
                Console.Write(array4[p] + " ");
            } // Reversed: 5 4 3 2 1 
            Console.ReadKey();
            //
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@


            /////////////////////////////////////////////////////////
            ///
            /// 
            Console.WriteLine("Enter Array 1 Length");
            int Larr1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Array 2 Length");
            int Larr2 = int.Parse(Console.ReadLine());

            int[] arr1 = new int[Larr1];
            int[] arr2 = new int[Larr2];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] += Larr1;
                Console.WriteLine("Enter Array 1 value: " + i + 1);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < arr2.Length; j++)
            {
                arr2[j] += Larr2;
                Console.WriteLine("Enter Array 2 value: " + j + 1);
                arr2[j] = int.Parse(Console.ReadLine());
            }

            if (arr1 == arr2)
            {
                Console.WriteLine("Arrays are Equal");
            }
            else
            {
                Console.WriteLine("Are Not Equal");
            }
            /// 
            ///////////////////////////////////////////////////////////
        }
    }
}
