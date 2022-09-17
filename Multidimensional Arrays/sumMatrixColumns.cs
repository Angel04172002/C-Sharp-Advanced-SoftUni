using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split(',');
            int rows = int.Parse(sizes[0]);
            string colsAsString = sizes[1].TrimStart();
            int cols = int.Parse(colsAsString);
            int[,] matrix = new int[rows, cols];

            for(int i = 0; i < rows; i++)
            {
                int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for(int k = 0; k < cols; k++)
                {
                    matrix[i, k] = elements[k];
                }
            }

            for(int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;

                for(int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
