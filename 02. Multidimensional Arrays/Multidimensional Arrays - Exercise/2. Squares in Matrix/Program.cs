using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rows = info[0];
            int cols = info[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine()
                        .Split()
                        .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int squares = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col] &&
                        matrix[row, col] == matrix[row + 1, col + 1] &&
                        matrix[row, col] == matrix[row, col + 1])
                    {
                        squares++;
                    }
                }
            }

            Console.WriteLine(squares);
        }
    }
}
