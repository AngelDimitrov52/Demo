﻿using System;
using System.Linq;

namespace _03.PrimaryDiagonals
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowCols, rowCols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sum += matrix[row, row];
            }
            Console.WriteLine(sum);
        }
    }
}
