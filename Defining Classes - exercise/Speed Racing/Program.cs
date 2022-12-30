using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
                cars.Add(car);
            }

            string command = Console.ReadLine();    

            while(command != "End")
            {
                string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car foundCar = cars.Find(c => c.Model == input[1]);
                int index = cars.IndexOf(foundCar);
               
                if(foundCar != null)
                {
                    foundCar.CanCarMoveDistance(double.Parse(input[2]));
                    cars[index] = foundCar;
                }

                command = Console.ReadLine();
            }

            foreach(var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
