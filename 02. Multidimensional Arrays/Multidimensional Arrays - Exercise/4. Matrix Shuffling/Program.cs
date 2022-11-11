using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = info[0];
            int cols = info[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string commands = Console.ReadLine();

            while (commands != "END")
            {
                string[] data = commands.Split();

                string command = data[0];

                if (command != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    commands = Console.ReadLine();
                    continue;
                }

                if (data.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    commands = Console.ReadLine();
                    continue;
                }

                int row1 = int.Parse(data[1]);
                int col1 = int.Parse(data[2]);
                int row2 = int.Parse(data[3]);
                int col2 = int.Parse(data[4]);

                if (row1 < 0 || row1 > rows || row2 < 0 || row2 > rows ||
                    col1 < 0 || col1 > cols || col2 < 0 || col2 > cols)
                {
                    Console.WriteLine("Invalid input!");
                    commands = Console.ReadLine();
                    continue;
                }

                string temp = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = temp;

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        Console.Write($"{matrix[row,col]} ");
                    }

                    Console.WriteLine();
                }

                commands = Console.ReadLine();
            }
        }
    }
}
