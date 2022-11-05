using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] query = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray(); 

                if (query[0] == 1)
                {
                    int x = query[1];
                    stack.Push(x);
                }

                if (query[0] == 2)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }

                    stack.Pop();
                }

                if (query[0] == 3)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }

                    Console.WriteLine(stack.Max());
                }

                if (query[0] == 4)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }

                    Console.WriteLine(stack.Min());
                }
            }

            while (stack.Count > 1)
            {
                Console.Write($"{stack.Pop()}, ");
            }

            Console.Write(stack.Pop());
        }
    }
}
