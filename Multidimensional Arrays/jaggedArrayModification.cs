using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];
          

            for(int i = 0; i < rows; i++)
            {
                int[] values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                jaggedArray[i] = new int[values.Length];

                for(int k = 0; k < values.Length; k++)
                {
                    jaggedArray[i][k] = values[k];
                }
            }

            string command = Console.ReadLine();

            while(command != "END")
            {
                string[] splitted = command.Split(' ');
                int row = int.Parse(splitted[1]);
                int col = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);

                if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                {
                    if (splitted[0] == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }

                    else if (splitted[0] == "Subtract")
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                command = Console.ReadLine();
            }

            foreach (int[] array in jaggedArray)
            {
                Console.WriteLine(String.Join(" ", array));
            }
        }
    }
}
