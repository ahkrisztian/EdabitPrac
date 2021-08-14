using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit.SehrSchwer
{
    public static class PrintGrid
    {
        //Write a method that accepts two integer parameters rows and cols.
        //The output is a 2d array of numbers displayed in column-major order,
        //meaning the numbers shown increase sequentially down each column and wrap to the top of the next column
        //to the right once the bottom of the current column is reached.

        //PrintGrid(3, 6) ➞ new int[,] { 
        //new int[] { 1, 4, 7, 10, 13, 16 },
        //new int[] { 2, 5, 8, 11, 14, 17 },
        //new int[] { 3, 6, 9, 12, 15, 18 }]

        //PrintGrid(5, 3) ➞ new int[,] {
        //new int[] { 1, 6, 11 },
        //new int[] { 2, 7, 12 },
        //new int[] { 3, 8, 13 },
        //new int[] { 4, 9, 14 },
        //new int[] { 5, 10, 15 }]

        public static string Grids(int rows, int cols)
        {
            int[,] array = new int[rows, cols];

            int counter = 1;

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    array[j, i] = counter;
                    counter++;
                }
            }

             return PrintOutGrids(array, rows, cols);
        }

        public static string PrintOutGrids(int[,] Printgrids, int rows, int cols)
        {
            List<string> arrays = new List<string>();

            for (int i = 0; i < rows; i++)
            {
                List<string> temp = new List<string>();

                for (int j = 0; j < cols; j++)
                {
                    temp.Add($"{ Printgrids[i, j]}");
                }

                arrays.Add(String.Join(" ", temp));
            }

            return String.Join("\n", arrays);
        }

    }
}
