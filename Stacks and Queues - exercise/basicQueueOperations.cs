using System;
using System.Linq;
using System.Collections.Generic;

namespace basicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = parameters[0];
            int deleteCount = parameters[1];
            int elementToLookFor = parameters[2];

            int[] elementsToAdd = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> myQueue = new Queue<int>(elementsToAdd);

            for(int i = 0; i < deleteCount; i++)
            {
                myQueue.Dequeue();
            }

            if(myQueue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if(myQueue.Contains(elementToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(myQueue.Min());
            }
        }
    }
}
