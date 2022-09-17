using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareWithMaximumSum
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
                string[] elements = Console.ReadLine().Split(',');

                for(int k = 0; k < elements.Length; k++)
                {
                    int currentEl = int.Parse(elements[k].TrimStart());
                    matrix[i, k] = currentEl;
                }
            }

            int maxSum = 0;
            int indexOfBiggestSquare1 = 0;
            int indexOfBiggestSquare2 = 0;

            for (int k = 0; k < matrix.GetLength(0) - 1; k++)
            {


                for (int i = 0; i < matrix.GetLength(1) - 1; i++)
                { 

                    int sum = 0;
                    sum += matrix[k, i];
                    sum += matrix[k + 1, i];
                    sum += matrix[k, i + 1];
                    sum += matrix[k + 1, i + 1];

                    if(sum > maxSum)
                    {
                        maxSum = sum;
                        indexOfBiggestSquare1 = k;
                        indexOfBiggestSquare2 = i;
                    }
                }
            }

            Console.Write($"{matrix[indexOfBiggestSquare1, indexOfBiggestSquare2]} {matrix[indexOfBiggestSquare1, indexOfBiggestSquare2 + 1]}");
            Console.WriteLine();
            Console.Write($"{matrix[indexOfBiggestSquare1 + 1, indexOfBiggestSquare2]} {matrix[indexOfBiggestSquare1 + 1, indexOfBiggestSquare2 + 1]}");
            Console.WriteLine();
            Console.WriteLine(maxSum);
        }
    }
}
