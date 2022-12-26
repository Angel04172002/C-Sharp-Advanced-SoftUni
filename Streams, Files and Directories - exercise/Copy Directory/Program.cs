namespace CopyDirectory
{
    using System;
    using System.IO;
    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath);
            }

            Directory.CreateDirectory(outputPath);

            string[] files = Directory.GetFiles(inputPath);

            foreach (var file in files)
            {
                string path = Path.GetFileName(file);
                string combined = Path.Combine(outputPath, path);
                File.Copy(file, combined);
            }
        }
    }
}
