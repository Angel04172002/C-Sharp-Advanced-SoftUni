using System;
using System.Collections.Generic;
using System.Linq;

namespace reverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<List<int>, int, List<int>> filterCollection = (numbers, n) =>
            {
                List<int> filteredNumbers = new List<int>();

                for(int i = numbers.Count - 1; i >= 0; i--)
                {
                    if (numbers[i] % n != 0)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }    
                }

                return filteredNumbers;
            };

            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int number = int.Parse(Console.ReadLine());
            List<int> filteredCollection = filterCollection(numbers, number);

            foreach(var num in filteredCollection)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
