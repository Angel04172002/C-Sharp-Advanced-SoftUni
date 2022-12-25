using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            string[] firstFileLines = File.ReadAllLines(firstInputFilePath);
            string[] secondFileLines = File.ReadAllLines(secondInputFilePath);

            

            for(int i = 0; i < firstFileLines.Length; i++)
            {
                using(StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    writer.WriteLine(firstFileLines[i]);
                    writer.WriteLine(secondFileLines[i]);
                }
            }

            if(firstFileLines.Length > secondFileLines.Length)
            {
                for (int i = secondFileLines.Length; i < firstFileLines.Length; i++)
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        writer.WriteLine(firstFileLines[i]);
                
                    }
                }
            }
            else if(firstFileLines.Length < secondFileLines.Length)
            {
                for (int i = firstFileLines.Length; i < secondFileLines.Length; i++)
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        writer.WriteLine(secondFileLines[i]);
                    }
                }
            }
        }
    }
}
