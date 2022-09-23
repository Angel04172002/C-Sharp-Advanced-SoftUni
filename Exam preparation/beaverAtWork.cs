using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace beaverAtWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startPositionX = 0;
            int startPositionY = 0;
            int newPositionX = 0;
            int newPositionY = 0;
            int woodBranchesToCollect = 0;

            int sizeOfPond = int.Parse(Console.ReadLine());
            char[,] pond = new char[sizeOfPond, sizeOfPond];
            List<char> woodBranchesList = new List<char>();

            for (int i = 0; i < pond.GetLength(0); i++)
            {
                string[] rowStrings = Console.ReadLine().Split(' ');


                for (int k = 0; k < rowStrings.Length; k++)
                { 
                    if (rowStrings[k] == " ")
                    {
                        continue;
                    }

                    pond[i, k] = char.Parse(rowStrings[k]);

                    if (pond[i, k] == 'B')
                    {
                        startPositionX = i;
                        startPositionY = k;
                    }

                    if (pond[i, k] >= 97 && pond[i, k] <= 122)
                    {
                        woodBranchesToCollect++;
                    }

                }
            }


            string command = Console.ReadLine();
            int woodBranches = 0;

            newPositionX = startPositionX;
            newPositionY = startPositionY;

            while (command != "end" && woodBranches != woodBranchesToCollect)
            {
                switch (command)
                {
                    case "up":
                        {
                            MovePlayer(command, ref startPositionX, ref startPositionY, ref newPositionX, ref newPositionY, pond, ref woodBranches, ref woodBranchesToCollect, woodBranchesList);
                        }
                        break;

                    case "down":
                        {
                            MovePlayer(command, ref startPositionX, ref startPositionY, ref newPositionX, ref newPositionY, pond, ref woodBranches, ref woodBranchesToCollect, woodBranchesList);
                        }
                        break;

                    case "right":
                        {
                            MovePlayer(command, ref startPositionX, ref startPositionY, ref newPositionX, ref newPositionY, pond, ref woodBranches, ref woodBranchesToCollect, woodBranchesList);
                        }
                        break;

                    case "left":
                        {
                            MovePlayer(command, ref startPositionX, ref startPositionY, ref newPositionX, ref newPositionY, pond, ref woodBranches, ref woodBranchesToCollect, woodBranchesList);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            if (woodBranches == woodBranchesToCollect)
            {
                Console.WriteLine($"The Beaver successfully collect {woodBranches} wood branches: {string.Join(", ", woodBranchesList)}.");
                PrintPond(pond);
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {woodBranchesToCollect - woodBranches} branches left.");
                PrintPond(pond);
            }
        }

        static void PrintPond(char[,] pond)
        {
            for (int i = 0; i < pond.GetLength(0); i++)
            {
                for (int k = 0; k < pond.GetLength(1); k++)
                {
                    if (k != pond.GetLength(1) - 1)
                    {
                        Console.Write($"{pond[i, k]} ");
                    }
                    else
                    {
                        Console.Write($"{pond[i, k]}");
                    }
                }

                Console.WriteLine();
            }
        }


        static void MovePlayer(string command, ref int startPositionX, ref int startPositionY, ref int newPositionX, ref int newPositionY,
            char[,] pond, ref int woodBranches, ref int woodBranchesToCollect, List<char> woodBranchesList)
        {
            bool isValid = true;

            if ((startPositionX == 0 && command == "up" )|| (startPositionX == pond.GetLength(0) - 1 && command == "down")
                || (startPositionY == 0 && command == "left") || (startPositionY == pond.GetLength(1) - 1 && command == "right"))
            {
                isValid = false;
            }

            if(isValid == true)
            {
                pond[startPositionX, startPositionY] = '-';
            }

            if(command == "up")
            {
                newPositionX = startPositionX - 1;
                newPositionY = startPositionY;
            }
            else if(command == "down")
            {
                newPositionX = startPositionX + 1;
                newPositionY = startPositionY;
            }
            else if(command == "right")
            {
                newPositionY = startPositionY + 1;
                newPositionX = startPositionX;
            }
            else if(command == "left")
            {
                newPositionY = startPositionY - 1;
                newPositionX = startPositionX;
            }


            if (newPositionX < 0 || newPositionY < 0 || newPositionX >= pond.GetLength(0) || newPositionY >= pond.GetLength(1))
            {
                if (woodBranches > 0)
                {
                    woodBranches--;
                    woodBranchesToCollect--;
                    woodBranchesList.RemoveAt(woodBranchesList.Count - 1);
                }
            }


            else if (pond[newPositionX, newPositionY] == 'F')
            {
                pond[newPositionX, newPositionY] = '-';

                if(IsOnLastIndex(newPositionX, newPositionY, pond))
                {
                    if(newPositionX == 0)
                    {
                        newPositionX = pond.GetLength(0) - 1;
                    }
                    else if(newPositionX == pond.GetLength(0))
                    {
                        newPositionY = 0;
                    }
                    else if(newPositionY == 0)
                    {
                        newPositionY = pond.GetLength(1) - 1;
                    }
                    else if(newPositionY == pond.GetLength(1) - 1)
                    {
                        newPositionX = 0;
                    }
                }

                else
                {
                    if(command == "up")
                    {
                        newPositionX = 0;
                    }
                    else if(command == "down")
                    {
                        newPositionX = pond.GetLength(0) - 1;
                    }
                    else if(command == "right")
                    {
                        newPositionY = pond.GetLength(1) - 1;
                    }
                    else if(command == "left")
                    {
                        newPositionY = 0;
                    }
                }

                pond[newPositionX, newPositionY] = 'B';
            }
            else if (pond[newPositionX, newPositionY] >= 97 && pond[newPositionX, newPositionY] <= 122)
            {
                woodBranches++;
                woodBranchesList.Add(pond[newPositionX, newPositionY]);
                pond[newPositionX, newPositionY] = 'B';
            }

            if (newPositionX >= 0 && newPositionX < pond.GetLength(0) && newPositionY >= 0 && newPositionY < pond.GetLength(1))
            {
                pond[newPositionX, newPositionY] = 'B';
                startPositionX = newPositionX;
                startPositionY = newPositionY;
            }
        }


        static bool IsOnLastIndex(int newPositionX, int newPositionY, char[,] pond)
        {
            bool result = newPositionX == 0 || newPositionY == 0 ||
                newPositionY == pond.GetLength(1) - 1 || newPositionX == pond.GetLength(0) - 1;

            return result;
        }
    }
}
