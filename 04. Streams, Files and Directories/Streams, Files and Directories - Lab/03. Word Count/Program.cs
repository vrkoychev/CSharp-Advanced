using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordsLine = File.ReadAllText(@"C:\Users\valoc\source\repos\Streams, Files and Directories - Lab\03. Word Count\words.txt");
            string[] wordsToMatch = wordsLine.Split(' ');

            string text = File.ReadAllText(@"C:\Users\valoc\source\repos\Streams, Files and Directories - Lab\03. Word Count\text.txt");

            string pattern = @"[A-Za-z]+";
            MatchCollection words = Regex.Matches(text, pattern);

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            for (int i = 0; i < wordsToMatch.Length; i++)
            {
                wordsCount.Add((wordsToMatch[i]).ToLower(), 0);
            }

            foreach (var word in words)
            {
                string currWord = word.ToString().ToLower();
                if (wordsCount.ContainsKey(currWord))
                {
                    wordsCount[currWord]++;
                }
            }

            var orderedWordsCount = wordsCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key,x => x.Value);

            foreach (var kvp in orderedWordsCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
