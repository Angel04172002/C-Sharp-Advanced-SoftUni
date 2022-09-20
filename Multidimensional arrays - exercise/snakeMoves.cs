using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = new char[rows, cols];
            string word = Console.ReadLine();
            int currentIndex = 0;
            
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                if(i % 2 == 0)
                {

                    for(int k = 0; k < matrix.GetLength(1); k++)
                    {
                        if (currentIndex == word.Length)
                        {
                            currentIndex = 0;
                        }

                        matrix[i, k] = word[currentIndex];
                     
                        currentIndex++;
                    }
                }
                else
                {
                    for (int k = matrix.GetLength(1) - 1; k >= 0; k--)
                    {
                        if (currentIndex == word.Length)
                        {
                            currentIndex = 0;
                        }

                        matrix[i, k] = word[currentIndex];
                   
                        currentIndex++;
                    }
                }
            }

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write(matrix[i, k]);
                }

                Console.WriteLine();
            }
        }
    }
}
