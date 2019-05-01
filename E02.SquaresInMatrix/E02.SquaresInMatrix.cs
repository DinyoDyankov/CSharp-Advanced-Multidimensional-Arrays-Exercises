namespace E02.SquaresInMatrix
{
    using System;
    using System.Linq;

    public class SquaresInMatrix
    {
        public static void Main()
        {
            int[] matrixSize = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] elementsOfMatrix = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elementsOfMatrix[col];
                }
            }

            int counter = 0;

            for (int row = 0; row <= matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - 2; col++)
                {
                    if (matrix[row, col] == matrix[row,col + 1] && 
                        matrix[row + 1, col] == matrix[row + 1, col + 1] && 
                        matrix[row,col] == matrix[row + 1,col + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
