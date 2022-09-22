using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace periodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> chemicalElements = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string elements = Console.ReadLine();
                string[] arrayElements = elements.Split(' ');

                foreach(var el in arrayElements)
                {
                    chemicalElements.Add(el);
                }
            }

            chemicalElements = chemicalElements.OrderBy(x => x).ToHashSet();
            Console.WriteLine(String.Join(" ", chemicalElements));
        }
    }
}
