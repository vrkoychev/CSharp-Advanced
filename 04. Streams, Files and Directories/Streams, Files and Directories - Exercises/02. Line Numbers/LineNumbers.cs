namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LineNumbers
    {
        static void Main(string[] args)
        {
            string inputPath = @"C:\Users\valoc\source\repos\Streams, Files and Directories - Exercises\02. Line Numbers\text.txt";
            string outputPath = @"C:\Users\valoc\source\repos\Streams, Files and Directories - Exercises\02. Line Numbers\output.txt";

            ProcessLines(inputPath, outputPath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            string[] lines = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < lines.Length; i++)
            {
                string currLine = lines[i];
                int letters = currLine.Count(char.IsLetter);
                int symbols = currLine.Count(char.IsPunctuation);

                sb.AppendLine($"Line {i + 1}: {currLine} ({letters})({symbols})");
            }

            File.WriteAllText(outputFilePath, sb.ToString().TrimEnd());
        }
    }
}
