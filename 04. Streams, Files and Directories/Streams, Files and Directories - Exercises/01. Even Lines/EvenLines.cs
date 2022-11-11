namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"C:\Users\valoc\source\repos\Streams, Files and Directories - Exercises\01. Even Lines\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StreamReader input = new StreamReader(inputFilePath);
            StringBuilder finalText = new StringBuilder();

            char[] symbols = { '-', ',', '.', '!', '?' };

            int index = 0;

            while (true)
            {
                string result = input.ReadLine();

                if (result == null)
                {
                    break;
                }

                if (!(index % 2 == 0))
                {
                    index++;
                    continue;
                }

                foreach (var symbol in symbols)
                {
                    result = result.Replace(symbol, '@');
                }

                result = string.Join(" ", result.Split().Reverse());
                finalText.AppendLine(result);

                index++;
            }

            return finalText.ToString().TrimEnd();
        }
        private static string ReverseWords(string replacedSymbols)
        {
            throw new NotImplementedException();
        }

        private static string ReplaceSymbols(string line)
        {
            throw new NotImplementedException();
        }
    }

}
