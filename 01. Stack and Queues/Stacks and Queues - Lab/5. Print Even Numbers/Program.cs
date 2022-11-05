using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                queue.Enqueue(nums[i]);
            }

            while (queue.Count > 1)
            {
                int currNum = queue.Dequeue();
                if (currNum % 2 == 0)
                {
                    Console.Write($"{currNum}, ");
                }
            }

            Console.Write(queue.Dequeue());
        }
    }
}
