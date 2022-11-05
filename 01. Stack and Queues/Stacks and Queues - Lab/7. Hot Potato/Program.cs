using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Queue<string> players = new Queue<string>(names);
            int tossesToLeaveTheGames = int.Parse(Console.ReadLine());

            int toss = 1;
            while (players.Count > 1)
            {
                if (toss == tossesToLeaveTheGames)
                {
                    string removedPlayer = players.Dequeue();
                    Console.WriteLine($"Removed {removedPlayer}");
                    toss = 1;
                }
                else
                {
                    string currPlayer = players.Dequeue();
                    toss++;
                    players.Enqueue(currPlayer);
                }
            }

            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}
