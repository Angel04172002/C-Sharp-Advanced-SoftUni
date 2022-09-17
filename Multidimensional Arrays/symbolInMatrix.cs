using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            bool isContaining = false;
            int rowIndex = 0;
            int colIndex = 0;

            for(int i = 0; i < n; i++)
            {
                string elements = Console.ReadLine();

                for(int k = 0; k < n; k++)
                {
                    matrix[i, k] = elements[k];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                for(int k = 0; k < n; k++)
                {
                    if (matrix[i, k] == symbol)
                    {
                        rowIndex = i;
                        colIndex = k;
                        isContaining = true;
                        break;
                    }
                }
            }

            if(isContaining)
            {
                Console.WriteLine($"({rowIndex}, {colIndex})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
