using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productShop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> products = new Dictionary<string, Dictionary<string, double>>();
            string command = Console.ReadLine();

            while(command != "Revision")
            {
                string[] tokens = command.Split(',');
                string shop = tokens[0];
                string product = tokens[1].TrimStart();
                double price = double.Parse(tokens[2].TrimStart());

                if(!products.ContainsKey(shop))
                {
                    products.Add(shop, new Dictionary<string, double>());
                }

                if (!products[shop].ContainsKey(product))
                {
                    products[shop].Add(product, price);
                }
                else
                {
                    products[shop][product] += price;
                }

                command = Console.ReadLine();
            }

            products = products.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach(var pair in products)
            {
                Console.WriteLine($"{pair.Key}->");

                foreach(var item in pair.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
