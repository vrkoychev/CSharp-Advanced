using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> colors = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");

                string color = input[0];

                string[] items = input[1].Split(',');

                if (!colors.ContainsKey(color))
                {
                    colors[color] = new Dictionary<string, int>();
                }

                foreach (var item in items)
                {
                    if (!colors[color].ContainsKey(item))
                    {
                        colors[color][item] = 0;
                    }

                    colors[color][item]++;
                }
            }

            string[] info = Console.ReadLine().Split();

            string searchedColor = info[0];
            string searchedItem = info[1];

            foreach (var clr in colors)
            {
                Console.WriteLine($"{clr.Key} clothes:");

                foreach (var clothing in clr.Value)
                {
                    if (searchedColor == clr.Key && searchedItem == clothing.Key)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                        continue;
                    }

                    Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                }
            }
        }
    }
}
