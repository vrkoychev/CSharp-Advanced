using System;
using System.Linq;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] board = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    char currCh = input[col];
                    board[row, col] = currCh;
                }
            }

            int knightsToRemove = 0;

            while (true)
            {
                int maxAttack = 0;
                int knigthRow = 0;
                int knigthCol = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (board[row,col] == '0')
                        {
                            continue;
                        }

                        int currentAttack = 0;

                        if (IsInRange(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                        {
                            currentAttack++;
                        }

                        if (IsInRange(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                        {
                            currentAttack++;
                        }

                        if (IsInRange(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
                        {
                            currentAttack++;
                        }

                        if (IsInRange(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                        {
                            currentAttack++;
                        }

                        if (IsInRange(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                        {
                            currentAttack++;
                        }

                        if (IsInRange(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                        {
                            currentAttack++;
                        }

                        if (IsInRange(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                        {
                            currentAttack++;
                        }

                        if (IsInRange(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                        {
                            currentAttack++;
                        }

                        if (currentAttack > maxAttack)
                        {
                            maxAttack = currentAttack;
                            knigthRow = row;
                            knigthCol = col;
                        }
                    }
                }

                if (maxAttack > 0)
                {
                    knightsToRemove++;
                    board[knigthRow, knigthCol] = '0';
                }
                else
                {
                    Console.WriteLine(knightsToRemove);
                    break;
                }
            }
        }

        private static bool IsInRange(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) &&
                col >= 0 && col < board.GetLength(1);
        }
    }
}
