namespace E03.MaximalSum
{
    using System;
    using System.Linq;

    public class MaximalSum
    {
        public static void Main()
        {
            int [] matrixSize = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elementsOfMatrix = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elementsOfMatrix[col];
                }
            }

            int matrixSum = 0;
            int matrixRowIndex = 0;
            int matrixColIndex = 0;

            for (int row = 0; row <= matrix.GetLength(0) - 3; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - 3; col++)
                {
                    int matrixCurrentSum = 0;

                    matrixCurrentSum = matrix[row, col]
                        + matrix[row, col + 1]
                        + matrix[row, col + 2]
                        + matrix[row + 1, col]
                        + matrix[row + 1, col + 1]
                        + matrix[row + 1, col + 2]
                        + matrix[row + 2, col]
                        + matrix[row + 2, col + 1]
                        + matrix[row + 2, col + 2];

                    if (matrixCurrentSum > matrixSum)
                    {
                        matrixSum = matrixCurrentSum;
                        matrixRowIndex = row;
                        matrixColIndex = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {matrixSum}");

            for (int row = matrixRowIndex; row < matrixRowIndex + 3; row++)
            {
                for (int col = matrixColIndex; col < matrixColIndex + 3; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
