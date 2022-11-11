using System;
using System.Collections.Generic;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();

            Dictionary<string, int> numbers = new Dictionary<string, int>();

            foreach (string num in nums)
            {
                if (numbers.ContainsKey(num))
                {
                    numbers[num] += 1; 
                }
                else
                {
                    numbers.Add(num, 1);
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
