using System;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] orderedNums = nums.OrderByDescending(x => x).ToArray();

            for (int i = 0; i < orderedNums.Length; i++)
            {
                if (i == 3)
                {
                    break;
                }

                Console.Write($"{orderedNums[i]} ");
            }
        }
    }
}
