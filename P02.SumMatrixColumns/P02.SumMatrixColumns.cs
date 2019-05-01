namespace P02.SumMatrixColumns
{
    using System;
    using System.Linq;

    public class SumMatrixColumns
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[input[0], input[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int [] digitsInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = digitsInput[col];
                }
            }

            int columnSum = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    columnSum += matrix[row,col];
                }

                Console.WriteLine(columnSum);
                columnSum = 0;
            }
        }
    }
}
