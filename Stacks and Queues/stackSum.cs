using System;
using System.Linq;
using System.Collections.Generic;

namespace stackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> stackOfNumbers = new Stack<int>(numbers);

            string command = "";

            while(command != "end")
            {
                command = Console.ReadLine().ToLower();

                if(command != "end")
                {
                    string[] tokens = command.Split(" ");

                    if(tokens[0] == "add")
                    {
                        int n1 = int.Parse(tokens[1]);
                        int n2 = int.Parse(tokens[2]);
                        stackOfNumbers.Push(n1);
                        stackOfNumbers.Push(n2);
                    }

                    else if(tokens[0] == "remove")
                    {
                        int count = int.Parse(tokens[1]);

                        if(stackOfNumbers.Count >= count)
                        {
                            for(int i = 0; i < count; i++)
                            {
                                stackOfNumbers.Pop();
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {stackOfNumbers.Sum()}");
        }
    }
}
