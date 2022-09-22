using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for(int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }

                numbers[number]++;
            }

            Console.WriteLine(numbers.Single(num => num.Value % 2 == 0).Key);
        }
    }
}
