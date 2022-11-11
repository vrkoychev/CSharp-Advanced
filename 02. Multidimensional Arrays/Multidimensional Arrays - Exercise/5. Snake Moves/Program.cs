using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            int rows = info[0];
            int cols = info[1];

            char[,] matrix = new char[rows, cols];

            bool rightToLeft = true;
            int indexOfSymbol = 0;

            for (int row = 0; row < rows; row++)
            {
                if (rightToLeft)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = input[indexOfSymbol++];

                        if (indexOfSymbol == input.Length)
                        {
                            indexOfSymbol = 0;
                        }
                    }

                    rightToLeft = false;
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = input[indexOfSymbol++];

                        if (indexOfSymbol == input.Length)
                        {
                            indexOfSymbol = 0;
                        }
                    }

                    rightToLeft = true;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
