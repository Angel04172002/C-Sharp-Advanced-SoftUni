using System;
using System.Linq;
using System.Collections.Generic;

namespace fashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> clothes = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Stack<int> stackOfClothes = new Stack<int>(clothes);
            int capacityOfRack = int.Parse(Console.ReadLine());
            int sumOfClothes = 0;
            int rackCount = 1;

            while(stackOfClothes.Count > 0)
            {
                if (sumOfClothes + stackOfClothes.Peek() < capacityOfRack)
                {
                    sumOfClothes += stackOfClothes.Pop();
                }

                else if (stackOfClothes.Count != 0)
                {
                    if ((sumOfClothes + stackOfClothes.Peek() == capacityOfRack || 
                        sumOfClothes + stackOfClothes.Peek() > capacityOfRack) && stackOfClothes.Count > 0)
                    {
                         sumOfClothes = 0;
                         rackCount++; 
                    }             
                }
            }

            Console.WriteLine(rackCount);
        }
    }
}
