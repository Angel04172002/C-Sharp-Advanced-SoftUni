using System;
using System.Collections.Generic;
using System.Linq;

namespace hotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfKids = Console.ReadLine().Split(" ").ToList();
            Queue<string> kids = new Queue<string>(listOfKids);
            int n = int.Parse(Console.ReadLine());
            int tosses = 1;

            while (kids.Count > 1)
            {
                string currentKid = kids.Dequeue();

                if (tosses == n)
                {
                    Console.WriteLine($"Removed {currentKid}");
                    tosses = 1;
                }

                else
                {
                    tosses++;
                    kids.Enqueue(currentKid);
                }
            }

            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
