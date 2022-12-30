using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = new Engine() { Speed = int.Parse(input[1]), Power = int.Parse(input[2]) };
                Cargo cargo = new Cargo() { Weight = int.Parse(input[3]), Type = input[4] };
                Tire[] tires = new Tire[4]
                {
                    new Tire(){Pressure = double.Parse(input[5]), Age = int.Parse(input[6])},
                    new Tire(){Pressure = double.Parse(input[7]), Age = int.Parse(input[8])},
                    new Tire(){Pressure = double.Parse(input[9]), Age = int.Parse(input[10])},
                    new Tire(){Pressure = double.Parse(input[11]), Age = int.Parse(input[12])}
                };

                Car car = new Car(input[0], engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();
            string[] carModels = null;
            
             if(command == "fragile")
            {
                carModels = cars
                    .Where(c => c.Cargo.Type == "fragile")
                    .Where(c => c.Tires.Any(k => k.Pressure < 1))
                    .Select(c => c.Model)
                    .ToArray();
            }
            else if(command == "flammable")
            {
                carModels = cars
                  .Where(c => c.Cargo.Type == "flammable")
                  .Where(c => c.Engine.Power > 250)
                  .Select(c => c.Model)
                  .ToArray();
            }

            foreach(var car in carModels)
            {
                Console.WriteLine(car);
            }
        }
    }
}
