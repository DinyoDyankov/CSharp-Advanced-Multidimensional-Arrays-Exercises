namespace E06.BombTheBasement
{
    using System;
    using System.Linq;

    public class BombTheBasement
    {
        public static void Main()
        {
            int[] matrixDimentions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[matrixDimentions[0], matrixDimentions[1]];

            int[] bombParameters = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int targetRow = bombParameters[0];
            int targetCol = bombParameters[1];
            int radius = bombParameters[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    double blast = Math.Sqrt(Math.Pow(row - targetRow, 2) + Math.Pow(col - targetCol, 2));

                    if (blast <= radius)
                    {
                        matrix[row, col] = 1;
                    }
                    else
                    {
                        matrix[row, col] = 0;
                    }
                }
            }

            int counterOfOnes = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                counterOfOnes = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (matrix[row,col] == 1) 
                    {
                        matrix[row, col] = 0;
                        counterOfOnes++;
                    }

                    if (counterOfOnes != 0 && row == matrix.GetLength(0) - 1)
                    {

                        for (int i = 0; i < counterOfOnes; i++)
                        {
                            matrix[i, col] = 1;
                        }
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
