using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var matrix = new string[dimensions[0], dimensions[1]];

            for (int i = 0; i < dimensions[0]; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int k = 0; k < numbers.Length; k++)
                {
                    matrix[i, k] = numbers[k];
                }
            }

            var command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (AreTokensValid(tokens, matrix))
                {
                    int rowIndex1 = int.Parse(tokens[1]);
                    int colIndex1 = int.Parse(tokens[2]);
                    int rowIndex2 = int.Parse(tokens[3]);
                    int colIndex2 = int.Parse(tokens[4]);

                    string temp = matrix[rowIndex1, colIndex1];
                    matrix[rowIndex1, colIndex1] = matrix[rowIndex2, colIndex2];
                    matrix[rowIndex2, colIndex2] = temp;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }

        static void PrintMatrix(string[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write($"{matrix[i, k]} ");
                }

                Console.WriteLine();
            }    
        }

        static bool AreTokensValid(string[] tokens, string[,] matrix)
        {
            var result =
                tokens.Length == 5
                && tokens[0] == "swap"
                && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < matrix.GetLength(0)
                && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < matrix.GetLength(1)
                && int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < matrix.GetLength(0)
                && int.Parse(tokens[4]) >= 0 && int.Parse(tokens[4]) < matrix.GetLength(1);

            return result;
        }
    }
}
