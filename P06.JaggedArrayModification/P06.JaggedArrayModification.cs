namespace P06.JaggedArrayModification
{
    using System;
    using System.Linq;

    public class JaggedArrayModification
    {
        public static void Main()
        {
            int matrixRows = int.Parse(Console.ReadLine());

            int[][] jagg = new int[matrixRows][];

            for (int row = 0; row < jagg.Length; row++)
            {
                int[] elementsOfJaggMatrix = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jagg[row] = elementsOfJaggMatrix;
            }

            string commandInput = string.Empty;

            while ((commandInput = Console.ReadLine()) != "END")
            {
                string[] currentCommand = commandInput.Split();
                string command = currentCommand[0];
                int row = int.Parse(currentCommand[1]);
                int col = int.Parse(currentCommand[2]);
                int value = int.Parse(currentCommand[3]);

                if (jagg.Length - 1 < row || row < 0 || col > jagg[row].Length - 1 || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (command == "Add")
                {
                    jagg[row][col] += value;
                }
                else if (command == "Subtract")
                {
                    jagg[row][col] -= value;
                }
            }

            foreach (var row in jagg)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
