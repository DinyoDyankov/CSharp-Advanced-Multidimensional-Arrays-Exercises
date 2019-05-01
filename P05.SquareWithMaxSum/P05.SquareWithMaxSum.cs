namespace P05.SquareWithMaxSum
{
    using System;
    using System.Linq;

    public class SquareWithMaxSum
    {
        public static void Main()
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elementsOfMatrixInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elementsOfMatrixInput[col];
                }
            }

            int topLeftRow = 0;
            int topLeftCol = 0;
            int topMatrixSum = int.MinValue;

            for (int row = 0; row <= matrix.GetLength(0) - 2; row++)
            {
                int currentTopRow = row;

                for (int col = 0; col <= matrix.GetLength(1) - 2; col++)
                {
                    int currentTopCol = col;
                    int currentMatrixSum = 0;

                    currentMatrixSum += matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (topMatrixSum < currentMatrixSum)
                    {
                        topMatrixSum = currentMatrixSum;
                        topLeftRow = currentTopRow;
                        topLeftCol = currentTopCol;
                    }
                    else if (topMatrixSum == currentMatrixSum)
                    {
                        if (topLeftRow > currentTopRow && topLeftCol > currentTopCol)
                        {
                            topLeftRow = currentTopRow;
                            topLeftCol = currentTopCol;
                        }
                    }
                }
            }
            Console.WriteLine($"{string.Join(' ', matrix[topLeftRow, topLeftCol])} {string.Join(' ', matrix[topLeftRow, topLeftCol + 1])}");
            Console.WriteLine($"{string.Join(' ', matrix[topLeftRow + 1, topLeftCol])} {string.Join(' ', matrix[topLeftRow + 1, topLeftCol + 1])}");
            Console.WriteLine(topMatrixSum);
        }
    }
}
