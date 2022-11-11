using System.IO;

namespace CopyBinaryFile
{
    public class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string inputPath = @"C:\Users\valoc\source\repos\Streams, Files and Directories - Exercises\03. Copy Binary File\copyMe.png";
            string outputPath = @"C:\Users\valoc\source\repos\Streams, Files and Directories - Exercises\03. Copy Binary File\copyMe-copy.png";

            CopyFile(inputPath, outputPath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using FileStream fileStreamReader = 
                new FileStream(inputFilePath, FileMode.Open);

            using FileStream fileStreamWriter =
                new FileStream(outputFilePath, FileMode.Create);

            byte[] bytes = new byte[256];

            while (true)
            {
                int currentBytes = fileStreamReader.Read(bytes, 0, bytes.Length);

                if (currentBytes == 0)
                {
                    break;
                }

                fileStreamWriter.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
