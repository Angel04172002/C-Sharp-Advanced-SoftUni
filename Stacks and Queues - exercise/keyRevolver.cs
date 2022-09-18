using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyRevolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            List<int> listBullets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> listLocks = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int valueOfIntelligence = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(listBullets);
            Queue<int> locks = new Queue<int>(listLocks);

            int currentSize = sizeOfGunBarrel;

            while(bullets.Count > 0 && locks.Count > 0)
            {
                int removedBullet = bullets.Pop();
                currentSize--;
                valueOfIntelligence -= priceOfBullet;

                if(removedBullet <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if(currentSize == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    currentSize = sizeOfGunBarrel;
                }
            }

            if(locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${valueOfIntelligence}");
            }
        }
    }
}
