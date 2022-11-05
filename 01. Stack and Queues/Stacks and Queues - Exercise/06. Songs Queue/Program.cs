using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ");

            Queue<string> songsQueue = new Queue<string>(songs);

            while (songsQueue.Count != 0)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];
                if (command == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (command == "Add")
                {
                    string song = string.Empty;

                    for (int i = 1; i < input.Length - 1; i++)
                    {
                        song = song + input[i] + " ";
                    }

                    song = song + input[input.Length - 1];

                    if (songsQueue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(song);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
