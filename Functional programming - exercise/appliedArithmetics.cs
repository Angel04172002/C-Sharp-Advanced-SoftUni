using System;
using System.Collections.Generic;
using System.Linq;

namespace appliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Action<List<int>, string> operations = (numbers, command) =>
            {
                for(int i = 0; i < numbers.Count; i++)
                {
                    if(command == "add")
                    {
                        numbers[i] += 1;
                    }
                    else if(command == "multiply")
                    {
                        numbers[i] *= 2;
                    }
                    else if(command == "subtract")
                    {
                        numbers[i] -= 1;
                    }
                    else
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }
            };

            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while(command != "end")
            {
                switch(command)
                {
                    case "add":
                        operations(numbers, "add");
                        break;

                    case "multiply":
                        operations(numbers, "multiply");
                        break;

                    case "subtract":
                        operations(numbers, "subtract");
                        break;

                    case "print":
                        operations(numbers, "print");
                        break;
                }

                command = Console.ReadLine();
            }

        }
    }
}
