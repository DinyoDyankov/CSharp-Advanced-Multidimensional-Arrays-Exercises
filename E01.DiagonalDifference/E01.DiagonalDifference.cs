namespace E01.DiagonalDifference
{
    using System;
    using System.Linq;

    public class DiagonalDifference
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

            int sumPrimaryDiagonal = 0;
            int sumSecondaryDiagonal = 0;

            int primaryIndex = 0;
            int secondaryIndex = matrix.GetLength(0) - 1;

            while (primaryIndex != matrix.GetLength(1))
            {
                sumPrimaryDiagonal += matrix[primaryIndex, primaryIndex];
                sumSecondaryDiagonal += matrix[primaryIndex, secondaryIndex];

                primaryIndex++;
                secondaryIndex--;
            }

            Console.WriteLine(Math.Abs(sumPrimaryDiagonal-sumSecondaryDiagonal));
        }
    }
}
