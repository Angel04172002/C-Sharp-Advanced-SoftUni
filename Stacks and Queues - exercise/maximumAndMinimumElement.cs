using System;
using System.Collections.Generic;
using System.Linq;

namespace maximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            int queriesCount = int.Parse(Console.ReadLine());

            for(int i = 0; i < queriesCount; i++)
            {
                string line = Console.ReadLine();
                int command = int.Parse(line[0].ToString());

                if(command == 1)
                {
                    int[] splittedElements = line.Split(" ").Select(int.Parse).ToArray();
                    int elementToPush = splittedElements[1];
                    myStack.Push(elementToPush);
                }
                else if(command == 2)
                {
                    if(myStack.Count > 0)
                    {
                        myStack.Pop();
                    }
                }
                else if(command == 3)
                {
                    if(myStack.Count > 0)
                    {
                        Console.WriteLine(myStack.Max());
                    }
                }
                else if(command == 4)
                {
                    if (myStack.Count > 0)
                    {
                        Console.WriteLine(myStack.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", myStack));
        }
    }
}
