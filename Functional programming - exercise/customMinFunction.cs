using System;
using System.Linq;

namespace customMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> printSmallestNumber = numbers =>
            {
                int min = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }

                return min;
            };

            Console.WriteLine(printSmallestNumber(numbers));
        }
    }
}
