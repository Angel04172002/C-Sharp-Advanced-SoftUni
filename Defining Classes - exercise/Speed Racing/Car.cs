using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance {get; set;}

        public void CanCarMoveDistance(double kilometres)
        {
            var usedFuel = kilometres * this.FuelConsumptionPerKilometer;

            if(this.FuelAmount - usedFuel >= 0)
            {
                this.FuelAmount -= usedFuel;
                this.TravelledDistance += kilometres;
                return;
            }

            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}
