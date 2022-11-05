using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int capacity = int.Parse(Console.ReadLine());

            Stack<int> box = new Stack<int>(clothes);

            int sum = 0;
            int racks = 1;
            while (box.Count > 0)
            {
                int currCloth = box.Peek();

                if (sum + currCloth == capacity)
                {
                    box.Pop();

                    if (box.Count > 0)
                    {
                        racks++;
                    }

                    sum = 0;
                }
                else if (sum + currCloth > capacity)
                {
                    sum = 0;
                    racks++;
                }
                else
                {
                    box.Pop();
                    sum += currCloth;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
