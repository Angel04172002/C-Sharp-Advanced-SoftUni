using System;
using System.Linq;
using System.Collections.Generic;

namespace listOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<int[], int, bool> isDivisible = (dividers, i) =>
            {
                for(int k = 0; k < dividers.Length; k++)
                {
                    if(i % dividers[k] != 0)
                    {
                        return false;
                    }
                }

                return true;
            };

            Func<int[], int, List<int>> generateNumbers = (dividers, end) =>
            {
                List<int> newNumbers = new List<int>();

                for(int i = 1; i <= end; i++)
                {
                    if(isDivisible(dividers, i))
                    {
                        newNumbers.Add(i);
                    }
                }

                return newNumbers;
            };

            int end = int.Parse(Console.ReadLine());
            int[] dividers =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            List<int> generatedNumbers = generateNumbers(dividers, end);

            foreach(var num in generatedNumbers)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
