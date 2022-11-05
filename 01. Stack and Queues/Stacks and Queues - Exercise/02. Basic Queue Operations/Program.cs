using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int N = info[0];
            int S = info[1];
            int X = info[2];

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(nums[i]);
            }

            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine($"{queue.Min()}");
                }
            }
        }
    }
}
