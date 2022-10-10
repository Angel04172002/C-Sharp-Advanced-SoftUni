using System;
using System.Linq;

namespace findEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            Predicate<int> printNumbers = i =>
            {
                if(command == "even")
                {
                    return i % 2 == 0;
                }
                else
                {
                    return i % 2 == 1;
                }
            };

            for(int i = bounds[0]; i <= bounds[1]; i++)
            {
                if(printNumbers(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
