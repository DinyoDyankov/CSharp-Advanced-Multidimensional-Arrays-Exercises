namespace P03.PrimaryDiagonal
{
    using System;
    using System.Linq;

    public class PrimaryDiagonal
    {
        public static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

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

            int diagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                diagonalSum += matrix[row, row];
            }

            Console.WriteLine(diagonalSum);
        }
    }
}
