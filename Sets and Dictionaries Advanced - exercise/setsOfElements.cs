using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] counts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count1 = counts[0];
            int count2 = counts[1];
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for(int i = 0; i < count1; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }

            for(int i = 0; i < count2; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            set1.IntersectWith(set2);

            foreach(var item in set1)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
