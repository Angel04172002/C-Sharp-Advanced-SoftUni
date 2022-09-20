using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] chessboard = new char[n, n];
            int removedKnights = 0;

            if(n <= 2)
            {
                Console.WriteLine(0);
                return;
            }

            for(int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                for(int k = 0; k < n; k++)
                {
                    chessboard[i, k] = line[k];
                }
            }


            while (true)
            {
                int countMostAttackedKnights = 0;
                int countAttackedHorses = 0;
                int rowIndexMax = 0;
                int colIndexMax = 0;

                for (int i = 0; i < chessboard.GetLength(0); i++)
                {
                    for (int k = 0; k < chessboard.GetLength(1); k++)
                    {
                        if (chessboard[i, k] == 'K')
                        {
                           countAttackedHorses =
                           CountAttackedKnights(chessboard, i, k);
                        }

                        if(countAttackedHorses > countMostAttackedKnights)
                        {
                            countMostAttackedKnights = countAttackedHorses;
                            rowIndexMax = i;
                            colIndexMax = k;
                        }
                    }
                }

                if (countMostAttackedKnights == 0)
                {
                    break;
                }

                chessboard[rowIndexMax, colIndexMax] = '0';
                removedKnights++;
            }

            Console.WriteLine(removedKnights);
        }

        
        static int CountAttackedKnights(char[,] chessboard, int i, int k)
        {
            int attackedKnights = 0;

           
            if(IsCellValid(i + 2, k + 1, chessboard))
            {
                if (chessboard[i + 2, k + 1] == 'K')
                {
                    attackedKnights++;
                }
            }

         
            if(IsCellValid(i + 1, k + 2, chessboard))
            {
                if (chessboard[i + 1, k + 2] == 'K')
                {
                    attackedKnights++;
                }
            }

          
            if (IsCellValid(i + 2, k - 1, chessboard))
            {
                if (chessboard[i + 2, k - 1] == 'K')
                {
                    attackedKnights++;
                }
            }

         
            if (IsCellValid(i + 1, k - 2, chessboard))
            {
                if (chessboard[i + 1, k - 2] == 'K')
                {
                    attackedKnights++;
                }
            }


       
            if (IsCellValid(i - 2, k + 1, chessboard))
            {
                if (chessboard[i - 2, k + 1] == 'K')
                {
                    attackedKnights++;
                }
            }


         
            if (IsCellValid(i - 2, k - 1, chessboard))
            {
                if (chessboard[i - 2, k - 1] == 'K')
                {
                    attackedKnights++;
                }
            }


          
            if (IsCellValid(i - 1, k + 2, chessboard))
            {
                if (chessboard[i - 1, k + 2] == 'K')
                {
                    attackedKnights++;
                }
            }


       
            if (IsCellValid(i - 1, k - 2, chessboard))
            {
                if (chessboard[i - 1, k - 2] == 'K')
                {
                    attackedKnights++;
                }
            }

            return attackedKnights;
            
        }

        static bool IsCellValid(int rowIndex, int colIndex, char[,] matrix)
        {
            return rowIndex >= 0 && rowIndex < matrix.GetLength(0)
                && colIndex >= 0 && colIndex < matrix.GetLength(1);
        }
    }
}
