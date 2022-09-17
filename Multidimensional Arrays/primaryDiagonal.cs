using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                int[] values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for(int k = 0; k < n; k++)
                {
                    matrix[i, k] = values[k];
                }
            }


            int sum = 0;

            for(int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}
