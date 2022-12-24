namespace FolderSize 
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static long size;
        static void Main()
        { 
            string folderPath = @"..\..\..\Files\TestFolder"; 
            string outputPath = @"..\..\..\Files\output.txt"; 
            GetFolderSize(folderPath, outputPath); 
        }
        public static void GetFolderSize(string folderPath, string outputFilePath) 
        {

            FileInfo fileInfo = new FileInfo(folderPath);
            size += fileInfo.Length;

            string[] files = Directory.GetFiles(folderPath);

            foreach(var file in files)
            {
                FileInfo fileInfoFile = new FileInfo(file);
                size += fileInfoFile.Length;
            }

            string[] dirs = Directory.GetDirectories(folderPath);

            foreach(var dir in dirs)
            {
                GetFolderSize(dir, outputFilePath);
            }

            File.WriteAllText(outputFilePath, size.ToString());
        }
    }
}
