/*Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:
*/

using System;


class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter a value for columns and rows: ");
        int valueN = int.Parse(Console.ReadLine());
        int digitA = 1;

        // a)
        Console.WriteLine("a)");

        int[,] matrixA = new int[valueN, valueN];

        for (int col = 0; col < matrixA.GetLength(0); col++)
        {
            for (int row = 0; row < matrixA.GetLength(1); row++)
            {
                matrixA[col, row] = digitA;
                digitA++;
            }
        }


        for (int col = 0; col < matrixA.GetLength(0); col++)
        {
            for (int row = 0; row < matrixA.GetLength(1); row++)
            {
                Console.Write("{0, 4}", matrixA[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // b)
        Console.WriteLine("b)");

        int digitB = 1;

        int[,] matrixB = new int[valueN, valueN];

        for (int col = 0; col < matrixB.GetLength(0); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrixB.GetLength(1); row++)
                {
                    matrixB[col, row] = digitB;
                    digitB++;
                }
            }
            else
            {
                for (int row = matrixB.GetLength(1) - 1; row >= 0; row--)
                {
                    matrixB[col, row] = digitB;
                    digitB++;
                }
            }

        }

        for (int col = 0; col < matrixB.GetLength(0); col++)
        {
            for (int row = 0; row < matrixB.GetLength(1); row++)
            {
                Console.Write("{0, 4}", matrixB[row, col]);
            }
            Console.WriteLine();
        }


        // c)
        Console.WriteLine("c)");

        int[,] matrixC = new int[valueN, valueN];

        int rows = 0;
        int cols = 0;
        int value = 1;

        
        for (int i = matrixC.GetLength(0) - 1; i >= 0; i--)
        {
            rows = i;
            cols = 0;
            while (rows < matrixC.GetLength(0) && cols < matrixC.GetLength(1))
            {
                matrixC[rows++, cols++] = value++;
            }
        }


        for (int j = 1; j < matrixC.GetLength(0); j++)
        {
            rows = j;
            cols = 0;
            while (rows < matrixC.GetLength(0) && cols < matrixC.GetLength(1))
            {
                matrixC[cols++, rows++] = value++;
            }
        }

        for (rows = 0; rows < matrixC.GetLength(0); rows++)
        {
            for (cols = 0; cols < matrixC.GetLength(1); cols++)
            {
                Console.Write("{0, 4}", matrixC[rows, cols]);
            }
            Console.WriteLine();

        }
    }
}

