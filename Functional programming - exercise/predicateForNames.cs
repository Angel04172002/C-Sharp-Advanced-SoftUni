using System;
using System.Collections.Generic;
using System.Linq;

namespace predicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Action<string[], int> printNames = (names, length) =>
            {
                foreach (var name in names)
                {
                    if (name.Length <= length)
                    {
                        Console.WriteLine(name);
                    }
                }
            };

            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ');

            printNames(names, length);

        }
    }
}
