using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new StreamWriter(@"C:\Users\valoc\source\repos\Streams, Files and Directories - Lab\02. Line Numbers\output.txt");

            var reader = new StreamReader(@"C:\Users\valoc\source\repos\Streams, Files and Directories - Lab\02. Line Numbers\input.txt");

            var line = reader.ReadLine();
            int index = 1;

            while (line != null)
            {
                writer.WriteLine($"{index}: {line}");
                index++;
                line = reader.ReadLine();
            }

            reader.Close();

            writer.Close();
        }
    }
}
