using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rows = sizes[0];
            var cols = sizes[1];
            int indexRow = 0;
            int indexCol = 0;

            if (rows >= 3 && cols >= 3)
            {

                int[,] matrix = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                    for (int k = 0; k < numbers.Length; k++)
                    {
                        matrix[i, k] = numbers[k];
                    }
                }

                int maxSum = 0;

                for (int i = 0; i < matrix.GetLength(0) - 2; i++)
                {
                    for (int k = 0; k < matrix.GetLength(1) - 2; k++)
                    {
                        int sum = matrix[i, k] + matrix[i, k + 1] + matrix[i, k + 2]
                            + matrix[i + 1, k] + matrix[i + 1, k + 1] + matrix[i + 1, k + 2]
                            + matrix[i + 2, k] + matrix[i + 2, k + 1] + matrix[i + 2, k + 2];

                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            indexRow = i;
                            indexCol = k;
                        }
                    }
                }

                Console.WriteLine($"Sum = {maxSum}");

                for (int i = indexRow; i < indexRow + 3; i++)
                {
                    for (int k = indexCol; k < indexCol + 3; k++)
                    {
                        Console.Write($"{matrix[i, k]} ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
