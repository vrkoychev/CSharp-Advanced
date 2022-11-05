using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new Stack<int>();

            foreach (int n in nums)
            {
                numbers.Push(n);
            }

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputs = input.Split();

                string command = inputs[0];

                if (command == "add")
                {
                    int firstNumber = int.Parse(inputs[1]);
                    int secondNumber = int.Parse(inputs[2]);

                    numbers.Push(firstNumber);
                    numbers.Push(secondNumber);
                }

                if (command == "remove")
                {
                    int n = int.Parse(inputs[1]);

                    if (n >= numbers.Count)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }

                input = Console.ReadLine();
            }

            int sum = 0;
            while (numbers.Count > 0)
            {
                sum += numbers.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
