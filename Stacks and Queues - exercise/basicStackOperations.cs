using System;
using System.Collections.Generic;
using System.Linq;

namespace basicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = parameters[0];
            int removeCount = parameters[1];
            int elementToLookFor = parameters[2];

            int[] numbersToAdd = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> myStack = new Stack<int>(numbersToAdd);

            for(int i = 0; i < removeCount; i++)
            {
                myStack.Pop();
            }


            if(myStack.Count == 0)
            {
                Console.WriteLine(0);
            }

            else if(myStack.Contains(elementToLookFor))
            {
                Console.WriteLine("true");
            }

            else if(!myStack.Contains(elementToLookFor))
            {
                Console.WriteLine(myStack.Min());
            }
        }
    }
}

