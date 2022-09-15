using System;
using System.Collections.Generic;
using System.Linq;

namespace trafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenCarsToPass = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string command = "";
            int countPassedCars = 0;

            while(command != "end")
            {
                command = Console.ReadLine();

                if(command != "end")
                {
                    if(command == "green")
                    {
                        for (int i = 0; i < greenCarsToPass; i++)
                        {
                            if (cars.Count > 0)
                            {
                                string carToPass = cars.Dequeue();
                                countPassedCars++;
                                Console.WriteLine($"{carToPass} passed!");
                            }
                        }
                    }

                    else
                    {
                        cars.Enqueue(command);
                    }
                }
            }

            Console.WriteLine($"{countPassedCars} cars passed the crossroads.");

        }
    }
}
