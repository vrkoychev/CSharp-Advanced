using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                int currCh = input[i];
                if (currCh == '(')
                {
                    stack.Push(i);
                }

                if (currCh == ')')
                {
                    int startIndex = stack.Pop();
                    int lastIndex = i;

                    Console.WriteLine(input.Substring(startIndex, lastIndex - startIndex + 1));
                }
            }
        }
    }
}
