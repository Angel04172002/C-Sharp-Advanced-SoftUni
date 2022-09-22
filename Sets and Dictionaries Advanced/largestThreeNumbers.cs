using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] largestThree = numbers.OrderByDescending(x => x).Take(3).ToArray();

            for(int i = 0; i < largestThree.Length; i++)
            {
                Console.Write($"{largestThree[i]} ");
            }
        }
    }
}
