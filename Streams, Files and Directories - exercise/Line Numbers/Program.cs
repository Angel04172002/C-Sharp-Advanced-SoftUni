namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            string[] fileLines = File.ReadAllLines(inputFilePath);
            int count = 0;

            foreach(var line in fileLines)
            {
                count++;
                int letters = 0;
                int punctuationMarks = 0;

                foreach(var symbol in line)
                {
                    if(symbol >= 65 && symbol <= 90 || symbol >= 97 && symbol <= 122)
                    {
                        letters++;
                    }
                    
                    else if(symbol == '!' || symbol == '?' || symbol == ','
                        || symbol == '.' || symbol == '\'' || symbol == '-')
                    {
                        punctuationMarks++;
                    }
                }

                sb.AppendLine($"Line {count}: {line} ({letters}) ({punctuationMarks})");
            }

            File.WriteAllText(outputFilePath, sb.ToString());
        }
    }
}
