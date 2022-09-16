using System;
using System.Collections.Generic;
using System.Linq;

namespace fastFood.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            List<int> quantityOfOrders = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Queue<int> queueOfOrders = new Queue<int>(quantityOfOrders);
            bool isSucceeded = true;

            Console.WriteLine(queueOfOrders.Max());


            while(queueOfOrders.Count > 0)
            {
                int currentOrder = queueOfOrders.Peek();

                if(foodQuantity - currentOrder >= 0)
                {
                    int removedOrder = queueOfOrders.Dequeue();
                    foodQuantity -= removedOrder;
                }

                else
                {
                    isSucceeded = false;
                    break;
                }
            }

            if(isSucceeded)
            {
                Console.WriteLine("Orders complete");
            }

            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queueOfOrders)}");
            }
        }
    }
}
