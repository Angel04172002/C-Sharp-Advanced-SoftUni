using System;
using System.Linq;

namespace rallyRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            string racingNumber = Console.ReadLine();
            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];

            int startPositionX = 0;
            int startPositionY = 0;
            int newPositionX = startPositionX;
            int newPositionY = startPositionY;  

            int kilometresPassed = 0;
            bool isFinished = false;
      


            for(int i = 0; i < sizeOfMatrix; i++)
            {
                string line = Console.ReadLine();
                int index = 0;

                for (int k = 0; k < line.Length; k++)
                {
                    if (line[k] != ' ')
                    {
                        matrix[i, index] = line[k];
                        index++;
                    }
                }
            }

            string command = Console.ReadLine();

            while(command != "End")
            {
                switch(command)
                {
                        case "down":
                        {
                            matrix[newPositionX, newPositionY] = '.';
                            newPositionX++;
                            MoveCar(ref newPositionX, ref newPositionY, matrix, "down", ref kilometresPassed, ref isFinished);
                        }
                     
                        break;

                        case "left":
                        {
                            matrix[newPositionX, newPositionY] = '.';
                            newPositionY--;
                            MoveCar(ref newPositionX, ref newPositionY, matrix, "left", ref kilometresPassed, ref isFinished);
                        }
                        break;

                        case "right":
                        {
                            matrix[newPositionX, newPositionY] = '.';
                            newPositionY++;
                            MoveCar(ref newPositionX, ref newPositionY, matrix, "right", ref kilometresPassed, ref isFinished);
                        }
                        break;

                        case "up":
                        {
                            matrix[newPositionX, newPositionY] = '.';
                            newPositionX--;
                            MoveCar(ref newPositionX, ref newPositionY, matrix, "up", ref kilometresPassed, ref isFinished);  
                        }
                        break;
                }

                if(isFinished)
                {
                    matrix[newPositionX, newPositionY] = 'C';
                    Console.WriteLine($"Racing car {racingNumber} finished the stage!");
                    Console.WriteLine($"Distance covered {kilometresPassed} km.");
                    PrintMatrix(matrix);
                    return;
                }

                command = Console.ReadLine();
            }

            matrix[newPositionX, newPositionY] = 'C';
            Console.WriteLine($"Racing car {racingNumber} DNF.");
            Console.WriteLine($"Distance covered {kilometresPassed} km.");
            PrintMatrix(matrix);
        }
 static void MoveCar(ref int newPositionX, ref int newPositionY, char[,] matrix, string direction,
            ref int kilometresPassed, ref bool isFinished)
        {
 
            if(direction == "down")
            {
         
   
                    if (matrix[newPositionX, newPositionY] == 'F')
                    {
                        kilometresPassed += 10;
                        matrix[newPositionX, newPositionY] = 'C';
                        isFinished = true;
                        return;
                    }

                    else if (matrix[newPositionX, newPositionY] == 'T')
                    {
                        PassTunnel(matrix, ref newPositionX, ref newPositionY, ref kilometresPassed);
                    }
                else if (matrix[newPositionX, newPositionY] == '.')
                {
                    kilometresPassed += 10;
                }

            }
            else if (direction == "left")
            {
              
     
                    if (matrix[newPositionX, newPositionY] == 'F')
                    {
                        kilometresPassed += 10;
                        matrix[newPositionX, newPositionY] = 'C';
                        isFinished = true;
                        return;
                    }

                    else if (matrix[newPositionX, newPositionY] == 'T')
                    {
                        PassTunnel(matrix, ref newPositionX, ref newPositionY, ref kilometresPassed);
                    }
                else if (matrix[newPositionX, newPositionY] == '.')
                {
                    kilometresPassed += 10;
                }

            }
             else if (direction == "right")
            {
             

                
                    if (matrix[newPositionX, newPositionY] == 'F')
                    {
                        kilometresPassed += 10;
                        matrix[newPositionX, newPositionY] = 'C';
                        isFinished = true;
                        return;
                    }

                    else if (matrix[newPositionX, newPositionY] == 'T')
                    {
                        PassTunnel(matrix, ref newPositionX, ref newPositionY, ref kilometresPassed);
                    }
                    else if (matrix[newPositionX, newPositionY] == '.')
                    {
                        kilometresPassed += 10;
                    }
                
            }
            else if (direction == "up")
            {
             
               
                    if (matrix[newPositionX, newPositionY] == 'F')
                    {
                        kilometresPassed += 10;
                        matrix[newPositionX, newPositionY] = 'C';
                        isFinished = true;
                        return;
                    }

                    else if (matrix[newPositionX, newPositionY] == 'T')
                    {
                        PassTunnel(matrix, ref newPositionX, ref newPositionY, ref kilometresPassed);
                    }
                else if (matrix[newPositionX, newPositionY] == '.')
                {
                    kilometresPassed += 10;
                }

            }
        }


        static void PassTunnel(char[,] matrix, ref int newPositionX, ref int newPositionY, ref int kilometres)
        {
            int positionTunnelX = 0;
            int positionTunnelY = 0;  
            
         
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i, k] == 'T' && i != newPositionX && k != newPositionY)
                    {
                        positionTunnelX = i;
                        positionTunnelY = k;
                    }
                }
            }

            matrix[newPositionX, newPositionY] = '.';
            matrix[positionTunnelX, positionTunnelY] = 'C';
            newPositionX = positionTunnelX;
            newPositionY = positionTunnelY;
            kilometres += 30;
        }


        /*static bool AreValidIndexes(int newPositionX, int newPositionY, char[,] matrix)
        {
            return newPositionX >= 0 && newPositionX < matrix.GetLength(0)
                && newPositionY >= 0 && newPositionY < matrix.GetLength(1);
        }*/
        static void PrintMatrix(char[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write($"{matrix[i, k]}");
                }

                Console.WriteLine();
            }
        }
    }
}
