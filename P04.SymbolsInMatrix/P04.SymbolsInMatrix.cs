namespace P04.SymbolsInMatrix
{
    using System;
    using System.Linq;

    public class SymbolsInMatrix
    {
        public static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] elementsOfMatrixInput = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elementsOfMatrixInput[col];
                }
            }

            char speacialSymbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (speacialSymbol == matrix[row,col])
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{speacialSymbol} does not occur in the matrix");
        }
    }
}
