namespace EvenLines
{
    using System;
    using System.Text;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            char[] symbols = new char[] { '-', ',', '.', '!', '?' };
            StringBuilder sb = new StringBuilder();
            int count = 0;

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (count % 2 == 0)
                    {
                        foreach (var symbol in symbols)
                        {
                            line = line.Replace(symbol, '@');
                        }

                        line = line.Reverse().ToString();
                        sb.AppendLine(line);
                    }
                }

                return sb.ToString().TrimEnd();
            }
        }
    }
}
