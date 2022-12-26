namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";
            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);
            WriteReportToDesktop(reportContent, reportFileName);
        }
        public static string TraverseDirectory(string inputFolderPath)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, List<FileInfo>> extensionFiles = new Dictionary<string, List<FileInfo>>();
            string[] files = Directory.GetFiles(inputFolderPath);

            foreach(var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                if(!extensionFiles.ContainsKey(fileInfo.Extension))
                {
                    extensionFiles[fileInfo.Extension] = new List<FileInfo>();
                }

                extensionFiles[fileInfo.Extension].Add(fileInfo);
            }

            var orderedExtensionFiles = extensionFiles
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
                
                 foreach(var file in orderedExtensionFiles)
            {
                var extensionOrderedFiles = file.Value
                    .OrderBy(f => f.Length);

                foreach(var eof in extensionOrderedFiles)
                {
                    sb.AppendLine(eof.Extension);
                    sb.AppendLine($"--{eof.Name} - {(double)(eof.Length / 1024):f3}");
                }
            }

            return sb.ToString().TrimEnd();
        }
        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(textContent, path);
        }
    }
}
