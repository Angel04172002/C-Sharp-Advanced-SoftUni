using System;
using System.Collections.Generic;

namespace supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            Queue<string> customers = new Queue<string>();

            while (command != "End")
            {
                command = Console.ReadLine();

                if (command != "End" && command != " ")
                {
                    if (command == "Paid")
                    {
                        Console.Write(string.Join("\n", customers));
                        customers.Clear();
                    }

                    else
                    {
                        customers.Enqueue(command);
                    }
                }
            }

             Console.WriteLine();
             Console.WriteLine($"{customers.Count} people remaining.");  
        }
    }
}
