using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string commands = Console.ReadLine();

            while (commands != "END")
            {
                string[] data = commands.Split();

                string command = data[0];
                int r = int.Parse(data[1]);
                int c = int.Parse(data[2]);
                int value = int.Parse(data[3]);

                if (r < 0 || c < 0 || r >= n || c >= n)
                {
                    Console.WriteLine("Invalid coordinates");
                    commands = Console.ReadLine();
                    continue;
                }
                    
                if (command == "Add") 
                {
                    matrix[r, c] += value; 
                }
                else if (command == "Subtract")
                {
                    matrix[r, c] -= value;
                }

            commands = Console.ReadLine();
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
