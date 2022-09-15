using System;
using System.Linq;
using System.Collections.Generic;

namespace printEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> queueOfnumbers = new Queue<int>();

            for(int i = 0; i < numbers.Length; i++)
            {
                queueOfnumbers.Enqueue(numbers[i]);
            }

            int[] newNumbers = queueOfnumbers.Where(number => number % 2 == 0).ToArray();
            Queue<int> correctNumbers = new Queue<int>(newNumbers);

            while(correctNumbers.Count > 0)
            {
                if (correctNumbers.Count != 1)
                {
                    Console.Write($"{correctNumbers.Dequeue()}, ");
                }

                else
                {
                    Console.Write(correctNumbers.Dequeue());
                }
            }
        }
    }
}
