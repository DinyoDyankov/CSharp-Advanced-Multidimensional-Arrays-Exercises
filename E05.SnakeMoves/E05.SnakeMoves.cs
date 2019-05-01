namespace E05.SnakeMoves
{
    using System;
    using System.Linq;

    public class SnakeMoves
    {
        public static void Main()
        {
            int[] matrixSize = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[] snake = Console.ReadLine().ToCharArray();

            string[,] snakePath = new string[matrixSize[0], matrixSize[1]];

            int snakeIndex = 0;

            for (int row = 0; row < snakePath.GetLength(0); row++)
            {
                for (int col = 0; col < snakePath.GetLength(1); col++)
                {
                    snakePath[row, col] += snake[snakeIndex];

                    if (snakeIndex == snake.Length - 1)
                    {
                        snakeIndex = -1;
                    }

                    snakeIndex++;
                }
            }

            for (int row = 0; row < snakePath.GetLength(0); row++)
            {
                for (int col = 0; col < snakePath.GetLength(1); col++)
                {
                    Console.Write($"{snakePath[row,col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
