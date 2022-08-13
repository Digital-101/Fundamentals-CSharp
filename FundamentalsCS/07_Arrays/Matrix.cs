using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._7_Arrays
{
    class Matrix
    {
        static void Matrixxx()
        {
            //PRINT MATRICES
            //
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            // Declare and initialize a matrix of size 2 x 4 
            int[,] matrix = {  {1, 2, 3, 4}, // row 0 values  
                {5, 6, 7, 8}, // row 1 value 
            }; 

            // Print the matrix on the console 
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
            //READING MATRICES FROM INPUT
            //
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            Console.Write("Enter the number of the rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of the columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix22 = new int[rows, cols];

            Console.WriteLine("Enter the cells of the matrix:");

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    matrix22[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < matrix22.GetLength(0); row++)
            {
                for (int col = 0; col < matrix22.GetLength(1); col++)
                {
                    Console.Write(" " + matrix22[row, col]);
                }
                Console.WriteLine();
            }
            //Maximal Platform in a Matrix
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //
            // Declare and initialize the matrix   
            int[,] matrix44 = {
                { 0, 2, 4, 0, 9, 5 },
                { 7, 1, 3, 3, 2, 1 },
                { 1, 3, 9, 8, 5, 6 },
                { 4, 6, 7, 9, 1, 0 }
            };

            // Find the maximal sum platform of size 2 x 2   
            long bestSum = long.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix44.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix44.GetLength(1) - 1; col++)
                {
                    long sum = matrix44[row, col] + matrix44[row, col + 1] + matrix44[row + 1, col] + matrix44[row + 1, col + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            // Print the result   
            Console.WriteLine("The best platform is:");
            Console.WriteLine("  {0} {1}", matrix44[bestRow, bestCol], matrix44[bestRow, bestCol + 1]);
            Console.WriteLine("  {0} {1}", matrix44[bestRow + 1, bestCol], matrix44[bestRow + 1, bestCol + 1]);
            Console.WriteLine("The maximal sum is: {0}", bestSum);

            //PASCAL TRIANGLE
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //
            const int HEIGHT = 12;

            // Allocate the array in a triangle form   
            long[][] triangle = new long[HEIGHT + 1][]; 

            for (int row = 0; row < HEIGHT; row++)
            {
                triangle[row] = new long[row + 1];
            }

            // Calculate the Pascal's triangle   
            triangle[0][0] = 1;
            for (int row = 0; row < HEIGHT - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            // Print the Pascal's triangle   
            for (int row = 0; row < HEIGHT; row++)
            {
                Console.Write("".PadLeft((HEIGHT - row) * 2));
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,3} ", triangle[row][col]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //
        }
    } 
}
    
 

