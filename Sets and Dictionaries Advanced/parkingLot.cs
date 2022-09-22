using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();
            string command = Console.ReadLine();

            while(command != "END")
            {
                string[] tokens = command.Split(", ");

                if (tokens[0] == "IN")
                {
                    cars.Add(tokens[1]);
                }

                else if (tokens[0] == "OUT")
                {
                    if (cars.Contains(tokens[1]))
                    {
                        cars.Remove(tokens[1]);
                    }
                }

                command = Console.ReadLine();
            }

            if (cars.Count > 0)
            {
                Console.WriteLine(string.Join("\n", cars));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
