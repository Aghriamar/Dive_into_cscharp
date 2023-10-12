using System;

namespace Practice_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);
            int[] flattenedArray = new int[rows * cols];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    flattenedArray[index++] = a[i, j];
                }
            }
            Array.Sort(flattenedArray);
            Console.WriteLine("Отсортированный массив:");
            index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    a[i, j] = flattenedArray[index++];
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
