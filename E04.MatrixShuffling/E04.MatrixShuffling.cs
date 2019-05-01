namespace E04.MatrixShuffling
{
    using System;
    using System.Linq;

    public class MatrixShuffling
    {
        public static void Main()
        {
            int[] matrixSize = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] elementsOfMatrix = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elementsOfMatrix[col];
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] partOfCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (partOfCommand[0] == "swap" && partOfCommand.Length == 5)
                {
                    int firstRowToSwap = int.Parse(partOfCommand[1]);
                    int firstColToSwap = int.Parse(partOfCommand[2]);
                    int secondRowToSwap = int.Parse(partOfCommand[3]);
                    int secondColToSwap = int.Parse(partOfCommand[4]);

                    if (matrix.GetLength(0) < firstRowToSwap || 
                        matrix.GetLength(0) < secondRowToSwap || 
                        matrix.GetLength(1) < firstColToSwap || 
                        matrix.GetLength(1) < secondColToSwap)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string currentElementToSwap = string.Empty;

                        currentElementToSwap = matrix[firstRowToSwap, firstColToSwap];

                        matrix[firstRowToSwap, firstColToSwap] = matrix[secondRowToSwap, secondColToSwap];

                        matrix[secondRowToSwap, secondColToSwap] = currentElementToSwap;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write($"{matrix[row,col]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
