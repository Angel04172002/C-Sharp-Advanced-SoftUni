using System;
using System.Linq;

namespace AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> adder = p => p + (p * 0.2);
            double[] prices = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();

            double[] newPrices = prices
                .Select(adder)
                .ToArray();

            foreach(var price in newPrices)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
