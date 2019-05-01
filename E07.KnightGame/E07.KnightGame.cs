namespace E07.KnightGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KnightGame
    {
        public static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                char[] elementsOfTheMatrix = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] += elementsOfTheMatrix[col];
                }
            }

            int removedKnights = 0;

            while (true)
            {
                int knightRow = -1;
                int knightCol = -1;
                int knightTotalFights = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row,col] == 'K')
                        {
                            int currentKnightRow = row;
                            int currentKnightCol = col;

                            int currentKnightFights = KnightFighting(matrix, row, col);

                            if (currentKnightFights > knightTotalFights)
                            {
                                knightRow = currentKnightRow;
                                knightCol = currentKnightCol;
                                knightTotalFights = currentKnightFights;
                            }
                        }
                    }
                }

                if (knightTotalFights != 0)
                {
                    matrix[knightRow, knightCol] = '0';
                    removedKnights++;
                }
                else
                {
                    break;
                } 
            }

            Console.WriteLine(removedKnights);
        }

        public static int KnightFighting(char[,] matrix, int row, int col)
        {
            int currentKnightTotalFights = 0;

            if (KnightMoveIsValid(matrix, row - 2, col - 1) && matrix[row - 2, col - 1] == 'K') // horse 1st move
            {
                currentKnightTotalFights++;
            }
            if (KnightMoveIsValid(matrix, row - 2, col + 1) && matrix[row - 2, col + 1] == 'K') // horse 2nd move
            {
                currentKnightTotalFights++;
            }
            if (KnightMoveIsValid(matrix, row + 2, col - 1) && matrix[row + 2, col - 1] == 'K') // horse 3rd move
            {
                currentKnightTotalFights++;
            }
            if (KnightMoveIsValid(matrix, row + 2, col + 1) && matrix[row + 2, col + 1] == 'K') // horse 4th move
            {
                currentKnightTotalFights++;
            }

            if (KnightMoveIsValid(matrix, row - 1, col - 2) && matrix[row - 1, col - 2] == 'K') // horse 5th move
            {
                currentKnightTotalFights++;
            }
            if (KnightMoveIsValid(matrix, row + 1, col - 2) && matrix[row + 1, col - 2] == 'K') // horse 6th move
            {
                currentKnightTotalFights++;
            }
            if (KnightMoveIsValid(matrix, row - 1, col + 2) && matrix[row - 1, col + 2] == 'K') // horse 7th move
            {
                currentKnightTotalFights++;
            }
            if (KnightMoveIsValid(matrix, row + 1, col + 2) && matrix[row + 1, col + 2] == 'K') // horse 8th move
            {
                currentKnightTotalFights++;
            }

            return currentKnightTotalFights;
        }

        public static bool KnightMoveIsValid(char[,] matrix, int row, int col)
        {
            if (row < 0 || row > matrix.GetLength(0) - 1 || col < 0 || col > matrix.GetLength(1) - 1)
            {
                return false;
            }

            return true;
        }
    }
}
