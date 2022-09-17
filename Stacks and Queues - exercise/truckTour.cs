using System;
using System.Collections.Generic;
using System.Linq;

namespace truckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<PetrolPump> pumps = new Queue<PetrolPump>(n);
            Queue<PetrolPump> loopPumps = new Queue<PetrolPump>(n);
            Queue<PetrolPump> allPumps = new Queue<PetrolPump>(n);
            int index = -1;
        

            for (int i = 0; i < n; i++)
            {
                int[] tokens = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                pumps.Enqueue(new PetrolPump(tokens[0], tokens[1]));
                allPumps.Enqueue(new PetrolPump(tokens[0], tokens[1]));
            }


            while(pumps.Count > 0)
            {
                //Current start station: 0
                PetrolPump currentPump = pumps.Dequeue();
                int capacityOfPump = 0;
                int currentDistanceToNextStation = currentPump.Distance;
                int currentLiters = currentPump.Liters;
                bool isAValidRoute = true;
                index++;

                loopPumps = allPumps;

                while (loopPumps.Count > 0)
                {
                    PetrolPump pump = loopPumps.Dequeue();
                    int distanceToNextStation = pump.Distance;
                    int liters = pump.Liters;
                    capacityOfPump += liters;
                    capacityOfPump -= distanceToNextStation;

                    if (distanceToNextStation >= capacityOfPump)
                    {
                        isAValidRoute = false;
                        break;
                    }
                }

                if (isAValidRoute == false)
                {
                   continue;
                }

                else
                {
                   Console.WriteLine(index);
                   break;
                }
               
            }
        }
    }

    class PetrolPump
    {
        public PetrolPump(int liters, int distance)
        {
            this.Liters = liters;
            this.Distance = distance;
        }

        public int Liters { get; set; }
        public int Distance { get; set; }
    }
}
