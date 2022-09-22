using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                
                string[] tokens = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = tokens[0];
                string[] remainingClothes = tokens[1].Split(',');

                if(!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }

                for (int k = 0; k < remainingClothes.Count(); k++)
                {
                    if (!clothes[color].ContainsKey(remainingClothes[k]))
                    {
                        clothes[color].Add(remainingClothes[k], 0);
                    }

                    clothes[color][remainingClothes[k]]++;
                }
            }

            string[] tokens2 = Console.ReadLine().Split(' ');
            string colorToFind = tokens2[0];
            string clothToFind = tokens2[1];

            foreach(var item in clothes)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach(var pair in item.Value)
                {
                    if(item.Key == colorToFind && pair.Key == clothToFind)
                    {
                        Console.WriteLine($"* {pair.Key} - {pair.Value} (found!)");
                        continue;
                    }

                    Console.WriteLine($"* {pair.Key} - {pair.Value}");
                }
            }
        }
    }
}
