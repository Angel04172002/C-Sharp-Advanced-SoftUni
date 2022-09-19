using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int rightToLeftDiagonal = 0;
            int leftToRightDiagonal = 0;    

            for(int i = 0; i < n; i++)
            {
                int[] values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for(int k = 0; k < values.Length; k++)
                {
                    matrix[i, k] = values[k];
                }
            }

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                leftToRightDiagonal += matrix[i, i];
            }

            for(int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                rightToLeftDiagonal += matrix[matrix.GetLength(0) - 1 - i, i];
            }

            Console.WriteLine(Math.Abs(leftToRightDiagonal - rightToLeftDiagonal));
        }
    }
}
