using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] values = input.Split();

            Stack<string> stack = new Stack<string>(values.Reverse());

            while (stack.Count > 1)
            {
                int firstNumber = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());

                if (operation == "+")
                {
                    int sum = firstNumber + secondNumber;
                    stack.Push(sum.ToString());
                }

                if (operation == "-")
                {
                    int sum = firstNumber - secondNumber;
                    stack.Push(sum.ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
