using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(orders.Max());

            Queue<int> orderQueue = new Queue<int>(orders);

            while (orderQueue.Count > 0 && quantity >= 0)
            {
                int currOrder = orderQueue.Peek();

                if (quantity - currOrder < 0)
                {
                    break;
                }

                orderQueue.Dequeue();
                quantity -= currOrder;
            }

            if (orderQueue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");

                while (orderQueue.Count > 0)
                {
                    Console.Write($"{orderQueue.Dequeue()} ");
                }
            }
        }
    }
}
