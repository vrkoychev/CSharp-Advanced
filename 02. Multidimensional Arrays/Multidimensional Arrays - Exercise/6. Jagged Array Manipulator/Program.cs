using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            long rows = long.Parse(Console.ReadLine());

            long[][] jaggedArray = new long[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine()
                    .Split()
                    .Select(long.Parse)
                    .ToArray();
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                    }

                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }

                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commands = input.Split();

                string command = commands[0];
                int rowIndex = int.Parse(commands[1]);
                int colIndex = int.Parse(commands[2]);
                long value = int.Parse(commands[3]);

                if (command == "Add")
                {
                    if (rowIndex < 0 || rowIndex > rows || colIndex < 0 || jaggedArray[rowIndex].Length < colIndex)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    jaggedArray[rowIndex][colIndex] += value;
                }
                else if (command == "Subtract")
                {
                    if (rowIndex < 0 || rowIndex > rows || colIndex < 0 || jaggedArray[rowIndex].Length < colIndex)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    jaggedArray[rowIndex][colIndex] -= value;
                }

                input = Console.ReadLine();
            }

            PrintJaggedArray(jaggedArray);
        }

        private static void PrintJaggedArray(long[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
