using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            bool isBalanced = true;
            foreach (char ch in input)
            {
                if (ch == '{' || 
                    ch == '[' || 
                    ch == '(')
                {
                    stack.Push(ch);
                    continue;
                }

                if (stack.Count == 0)
                {
                    isBalanced = false;
                    break;
                }

                if (ch == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (ch == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (ch == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else
                {
                    isBalanced = false;
                    break;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
