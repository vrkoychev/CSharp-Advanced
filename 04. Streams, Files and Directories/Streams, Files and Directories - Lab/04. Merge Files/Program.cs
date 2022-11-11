using System;
using System.IO;

namespace _04._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = @"C:\Users\valoc\source\repos\Streams, Files and Directories - Lab\04. Merge Files\input1.txt";
            string input2 = @"C:\Users\valoc\source\repos\Streams, Files and Directories - Lab\04. Merge Files\input2.txt";
            string output = @"C:\Users\valoc\source\repos\Streams, Files and Directories - Lab\04. Merge Files\output.txt";

            string[] firstText = File.ReadAllLines(input1);
            string[] secondText = File.ReadAllLines(input2);

            int n = Math.Min(firstText.Length, secondText.Length);
        }
    }
}
