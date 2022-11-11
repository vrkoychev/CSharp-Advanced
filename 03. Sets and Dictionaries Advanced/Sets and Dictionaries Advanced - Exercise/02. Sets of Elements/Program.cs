using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = input[0];
            int m = input[1];

            List<int> nNumbers = new List<int>();
            List<int> mNumbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                nNumbers.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < m; i++)
            {
                mNumbers.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> repeatedNumbers = new HashSet<int>();

            for (int i = 0; i < nNumbers.Count; i++)
            {
                for (int j = 0; j < mNumbers.Count; j++)
                {
                    if (nNumbers[i] == mNumbers[j])
                    {
                        repeatedNumbers.Add(nNumbers[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(' ', repeatedNumbers));
        }
    }
}
