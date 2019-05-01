namespace P07.PascalTriangle
{
    using System;
    using System.Linq;

    public class PascalTriangle
    {
        public static void Main()
        {
            long rows = long.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[rows][];

            pascalTriangle[0] = new long[1];
            pascalTriangle[0][0] = 1;

            long rowNumber = 2;

            //Console.WriteLine('1');

            while (rowNumber <= rows)
            {
                long[] currentRow = new long[rowNumber];
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;

                for (long col = 1; col < currentRow.Length - 1; col++)
                {
                    currentRow[col] = pascalTriangle[rowNumber - 2][col] + pascalTriangle[rowNumber - 2][col - 1];
                }

                pascalTriangle[rowNumber - 1] = currentRow;
                //Console.WriteLine(string.Join(' ', currentRow));

                rowNumber++;
            }

            foreach (var row in pascalTriangle)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
    }
}
