using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Queue<string> names = new Queue<string>();

            while (name != "End")
            {
                if (name == "Paid")
                {
                    while (names.Count > 0)
                    {
                        string currName = names.Dequeue();
                        Console.WriteLine(currName);
                    }
                }
                else
                {
                    names.Enqueue(name);
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
