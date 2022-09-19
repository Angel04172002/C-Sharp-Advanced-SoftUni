using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();   
            var rows = dimensions[0];
            var cols = dimensions[1];

            if (rows >= 2 && cols >= 2)
            {
                char[,] matrix = new char[rows, cols];
                var countSquareMatrixes = 0;

                for (int i = 0; i < rows; i++)
                {
                    var characters = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                    for (int k = 0; k < characters.Length; k++)
                    {
                        matrix[i, k] = characters[k];
                    }
                }

                for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                    {
                        if (matrix[i, k] == matrix[i, k + 1] && matrix[i, k] == matrix[i + 1, k]
                            && matrix[i, k] == matrix[i + 1, k + 1])
                        {
                            countSquareMatrixes++;
                        }
                    }
                }

                Console.WriteLine(countSquareMatrixes);
            }
        }
    }
}
