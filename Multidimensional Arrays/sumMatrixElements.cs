using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumMatrixElements
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
            int sum = 0;

            for(int i = 0; i < rows; i++)
            {
                var elements = Console.ReadLine().Split(',');

                for(int k = 0; k < elements.Length; k++)
                {
                    int currentElement = int.Parse(elements[k].TrimStart());
                    matrix[i, k] = currentElement;
                }
            }

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int k = 0; k < matrix.GetLength(1); k++)
                {
                    sum += matrix[i, k];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);

        }
    }
}
