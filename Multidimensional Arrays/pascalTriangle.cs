using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascal = new long[n][];

            for(int i = 0; i < n; i++)
            {
                pascal[i] = new long[i + 1];
            }

            for(int i = 0; i < n; i++)
            {
                if(i == 0)
                {
                    pascal[i][0] = 1;
                    continue;
                }

                else if(i == 1)
                {
                    pascal[i][0] = 1;
                    pascal[i][1] = 1;
                    continue;
                }

                pascal[i][0] = 1;

                for (int k = 1; k < pascal[i].Length; k++)
                {
                    if (k == pascal[i].Length - 1)
                    {
                        pascal[i][k] = 1;
                        continue;
                    }
                    pascal[i][k] = pascal[i - 1][k] + pascal[i - 1][k - 1];
                }
            }

            foreach (long[] array in pascal)
            {
                Console.WriteLine(String.Join(" ", array));
            }
        }
    }
}
