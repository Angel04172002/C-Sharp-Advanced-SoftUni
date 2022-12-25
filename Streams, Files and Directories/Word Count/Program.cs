using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            using(StreamReader wordsReader = new StreamReader(wordsFilePath))
            {

                using(StreamReader textReader = new StreamReader(textFilePath))
                {
                    string text = textReader.ReadToEnd();
                    int i = 0;

                    string wordsLine = wordsReader.ReadLine();
                   

                    while (wordsLine != null)
                    {
                        string[] wordsLines = wordsLine.Split(' ');
                        string[] textLines = text.Split(new char[] { ' ', '.', ',', '-', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var word in wordsLines)
                        {


                            foreach (var txt in textLines)
                            {
                                if (txt.ToLower() == word.ToLower() && !words.ContainsKey(word.ToLower()))
                                {
                                    
                                    words.Add(word.ToLower(), 1);
                                }
                                else if (txt.ToLower() == word.ToLower())
                                {

                                    words[word.ToLower()]++;
                                }


                            }

                       
                        }
 wordsLine = wordsReader.ReadLine();
                         i = 0;
              
                    }
                }

                using(StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    words = words
                        .OrderByDescending(x => x.Value)
                        .ToDictionary(x => x.Key, x => x.Value);

                    foreach(var pair in words)
                    {
                        writer.WriteLine($"{pair.Key} - {pair.Value}");
                    }
                }
            }
        }
    }
}
