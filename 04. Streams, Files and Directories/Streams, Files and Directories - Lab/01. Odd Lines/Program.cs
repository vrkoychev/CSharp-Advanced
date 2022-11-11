using System;
using System.IO;

namespace _01._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new StreamWriter(@"C:\Users\valoc\source\repos\Streams, Files and Directories - Lab\01. Odd Lines\output.txt");

            var reader = new StreamReader(@"C:\Users\valoc\source\repos\Streams, Files and Directories - Lab\01. Odd Lines\input.txt");

            var line = reader.ReadLine();
            int index = 1;

            while (line != null)
            {
                if (index % 2 == 0)
                {
                    writer.WriteLine(line);
                }

                index++;
                line = reader.ReadLine();
            }

            reader.Close();

            writer.Close();
        }
    }
}
