using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> cities = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if(!cities.ContainsKey(continent))
                {
                    cities.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!cities[continent].ContainsKey(country))
                {
                    cities[continent].Add(country, new List<string>());

                }
             
                    cities[continent][country].Add(city);   
                
            }

            foreach(var item in cities)
            {
                Console.WriteLine($"{item.Key}:");

                foreach(var city in item.Value)
                {
                    Console.WriteLine($"  {city.Key} -> {string.Join(", ", city.Value)}");
                }
            }
        }
    }
}
