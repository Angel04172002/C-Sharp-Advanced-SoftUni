using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countSymbols2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> characters = new Dictionary<char, int>();

            for(int i = 0; i < text.Length; i++)
            {
                if (!characters.ContainsKey(text[i]))
                {
                    characters.Add(text[i], 0);
                }

                characters[text[i]]++;
            }

            var sortedCharacters = characters.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach(var item in sortedCharacters)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
