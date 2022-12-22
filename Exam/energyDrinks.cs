using System;
using System.Collections.Generic;
using System.Linq;

namespace energyDrinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> milligramsCaffeine = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            List<int> energyDrinks = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int caffeineOfStamat = 0;

            Stack<int> milligramsCaffeineStack = new Stack<int>(milligramsCaffeine);
            Queue<int> energyDrinksQueue = new Queue<int>(energyDrinks);

            while(milligramsCaffeineStack.Count > 0 && energyDrinksQueue.Count > 0)
            {
                int milligramsCaffeineSingle = milligramsCaffeineStack.Peek();
                int energyDrink = energyDrinksQueue.Peek();
                int caffeineInDrink = milligramsCaffeineSingle * energyDrink;

                if(caffeineOfStamat + caffeineInDrink <= 300)
                {
                    caffeineOfStamat += caffeineInDrink;
                    milligramsCaffeineStack.Pop();
                    energyDrinksQueue.Dequeue();
                }
                else
                {
                    milligramsCaffeineStack.Pop();
                    energyDrinksQueue.Dequeue();
                    energyDrinksQueue.Enqueue(energyDrink);

                    if (caffeineOfStamat - 30 >= 0)
                    {
                        caffeineOfStamat -= 30;
                    }
                }
            }

            if(energyDrinksQueue.Count > 0)
            {
                Console.WriteLine($"Drinks left: {string.Join(", ", energyDrinksQueue)}");
            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {caffeineOfStamat} mg caffeine.");
        }
    }
}
