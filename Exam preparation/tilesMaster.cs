using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tilesMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listWhiteTiles = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> listGreyTiles = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Stack<int> whiteTiles = new Stack<int>(listWhiteTiles);
            Queue<int> greyTiles = new Queue<int>(listGreyTiles);
            Dictionary<string, int> locationTileAreas = new Dictionary<string, int>();
            locationTileAreas.Add("Floor", 0);
            locationTileAreas.Add("Sink", 40);
            locationTileAreas.Add("Oven", 50);
            locationTileAreas.Add("Countertop", 60);
            locationTileAreas.Add("Wall", 70);
            Dictionary<string, int> realLocations = new Dictionary<string, int>();
            realLocations.Add("Floor", 0);
            realLocations.Add("Sink", 0);
            realLocations.Add("Oven", 0);
            realLocations.Add("Countertop", 0);
            realLocations.Add("Wall", 0);

            while (whiteTiles.Count > 0 && greyTiles.Count > 0)
            {
                int greyTile = greyTiles.Dequeue();
                int whiteTile = whiteTiles.Pop();

                if(greyTile == whiteTile)
                {
                    int sumTiles = greyTile + whiteTile;

                    if(locationTileAreas.ContainsValue(sumTiles))
                    {
                        foreach(var pair in locationTileAreas)
                        {
                            if(pair.Value == sumTiles)
                            {
                                if (sumTiles > 0)
                                {
                                    realLocations[pair.Key]++;
                                    break;
                                }
                            }
                        }
                    }

                    else if(locationTileAreas.ContainsValue(sumTiles) == false)
                    {
                        if (sumTiles > 0)
                        {
                            realLocations["Floor"]++;
                        }
                    }
                }
                else
                {
                    whiteTile /= 2;
                    whiteTiles.Push(whiteTile);
                    greyTiles.Enqueue(greyTile);
                }
            }


            if(whiteTiles.Count == 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else if(whiteTiles.Count >= 1)
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteTiles)}");
            }


            if (greyTiles.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else if (greyTiles.Count >= 1)
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");
            }

            var descendingByNumLocations = realLocations
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);


            if (descendingByNumLocations["Floor"] > 0)
            {
                Console.WriteLine($"Floor: {descendingByNumLocations["Floor"]}");
            }

            var sortedAscendingAlphabeticallyLocations = descendingByNumLocations
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach(var pair in sortedAscendingAlphabeticallyLocations)
            {
                if(pair.Value > 0 && pair.Key != "Floor")
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value}");
                }
            }
        }
    }
}
