using System;
using System.Collections.Generic;
using System.Linq;

namespace songsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> songs = Console.ReadLine().Split(", ").ToList();
            Queue<string> songsQueue = new Queue<string>(songs);

            while(songsQueue.Count > 0)
            {
                string[] tokens = Console.ReadLine().Split(" ");
                string command = tokens[0];

                if(command == "Play")
                {
                    songsQueue.Dequeue();
                }

                else if(command == "Add")
                {
                    string nameOfSong = string.Join(" ", tokens.Skip(1));

                    if(songsQueue.Contains(nameOfSong) == false)
                    {
                        songsQueue.Enqueue(nameOfSong);
                    }

                    else
                    {
                        Console.WriteLine($"{nameOfSong} is already contained!");
                    }
                }

                else if(command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
