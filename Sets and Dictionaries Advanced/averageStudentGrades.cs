using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace averageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string name = tokens[0];
                decimal grade = decimal.Parse(tokens[1]);

                if(!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<decimal>());
                }

                studentGrades[name].Add(grade);
            }

            foreach(KeyValuePair<string, List<decimal>> pair in studentGrades)
            {
                Console.Write($"{pair.Key} -> ");

                foreach(decimal grade in pair.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {pair.Value.Average():f2})");
            }

        }
    }
}
