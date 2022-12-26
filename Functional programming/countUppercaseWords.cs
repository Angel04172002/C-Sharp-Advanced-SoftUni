using System;
using System.Linq;

namespace countUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> wordChecker = w => char.IsUpper(w[0]);
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            words = words
                .Where(wordChecker)
                .ToArray();

            Console.WriteLine(String.Join("\n", words));
   
        }
    }
}
