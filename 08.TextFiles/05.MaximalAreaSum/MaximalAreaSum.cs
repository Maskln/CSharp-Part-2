﻿/*Problem 5. Maximal area sum

Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
*/

using System;
using System.Linq;
using System.Text;
using System.IO;


class MaximalAreaSum
{
    static int[,] ReadMatrix()
    {

        using (StreamReader reader = new StreamReader(@"../../text1.txt"))
        {
            int n = int.Parse(reader.ReadLine());
            int[,] matrix = new int[n, n];
            string rowInfo;

            for (int row = 0; row < n; row++)
            {
                rowInfo = reader.ReadLine();
                string[] rowCells = rowInfo.Split(' ');
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(rowCells[col]);
                }
            }
            return matrix;
        }
    }

    static int MaxSum(int[,] matrix)
    {
        int maxSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)     //Finding max sum
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }
        return maxSum;
    }

    static void PrintResult(int maxSum)
    {
        using (StreamWriter result = new StreamWriter(@"../../result.txt"))
        {
            result.WriteLine(maxSum);
        }
    }

    static void Main()
    {

        PrintResult(MaxSum(ReadMatrix()));

    }
}
