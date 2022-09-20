using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[n][];

            for(int i = 0; i < n; i++)
            {
                double[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                jaggedArray[i] = numbers;
            }

            for(int i = 0; i < n - 1; i++)
            {
                var arrayOfNums1 = jaggedArray[i];
                var arrayOfNums2 = jaggedArray[i + 1];

                if (arrayOfNums1.Length == arrayOfNums2.Length)
                {

                    jaggedArray[i] = jaggedArray[i].Select(x => x * 2).ToArray();
                    jaggedArray[i + 1] = jaggedArray[i + 1].Select(x => x * 2).ToArray();
                }

                else
                {
                    jaggedArray[i] = jaggedArray[i].Select(x => x / 2).ToArray();
                    jaggedArray[i+1] = jaggedArray[i + 1].Select(x => x / 2).ToArray(); 
                }
            }

            string command = Console.ReadLine();

            while(command != "End")
            {
                string[] tokens = command.Split(' ');

                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                double value = double.Parse(tokens[3]);

                if (tokens[0] == "Add")
                { 
                    if(row >= 0 && row < jaggedArray.Length && col >= 0
                        && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] += value;
                    }
                }
                else if (tokens[0] == "Subtract")
                {
                    if (row >= 0 && row < jaggedArray.Length && col >= 0
                        && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
            }

            foreach (double[] array in jaggedArray)
            {
                Console.WriteLine(String.Join(" ", array));
            }
        }
    }
}
