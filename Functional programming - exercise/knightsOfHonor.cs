using System;

namespace knightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] knightsOfHonor = Console.ReadLine()
                .Split(' ');

            Action<string[]> knights = knightsOfHonor =>
            {
                foreach (var knight in knightsOfHonor)
                {
                    Console.WriteLine($"Sir {knight}");
                }
            };

            knights(knightsOfHonor);
        }
    }
}
