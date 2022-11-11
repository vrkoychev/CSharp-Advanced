using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = data[0];
            int cols = data[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int biggestSquare = 2;

            int maxSum = 0;
            int maxRowIndex = 0;
            int maxColIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row + biggestSquare - 1 < rows && col + biggestSquare - 1 < cols)
                    {
                        int sum = matrix[row, col] + 
                            matrix[row + 1, col] + 
                            matrix[row, col + 1] + 
                            matrix[row + 1, col + 1];

                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            maxRowIndex = row;
                            maxColIndex = col;
                        }
                    }
                }
            }

            for (int row = maxRowIndex; row <= maxRowIndex + 1; row++)
            {
                for (int col = maxColIndex; col <= maxColIndex + 1; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
