using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Dictionary<double, int> dictionaryNumbers = new Dictionary<double, int>();

            for(int i = 0; i < numbers.Length; i++)
            {
                if (dictionaryNumbers.ContainsKey(numbers[i]) == false)
                {
                    dictionaryNumbers.Add(numbers[i], 0);
                }

                dictionaryNumbers[numbers[i]]++;
            }

            foreach (KeyValuePair<double, int> pair in dictionaryNumbers)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
        }
    }
}
