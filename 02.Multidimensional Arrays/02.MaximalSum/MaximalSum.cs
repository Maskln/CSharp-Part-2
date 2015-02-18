/*Problem 2. Maximal sum

Write a program that reads a rectangular matrix of size N x M and
finds in it the square 3 x 3 that has maximal sum of its elements.
*/

using System;


    class MaximalSum
    {
        static void Main()
        {

            //Console.Write("Enter a value for N: ");                           //Filling the value of N by the console
            //int valueN = int.Parse(Console.ReadLine());

            //Console.Write("Enter a value for M: ");                           //Filling the value of N by the console
            //int valueM = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //if (valueN < 3 || valueM < 3)
            //{
            //    Console.WriteLine("N and M must be bigger than 3!");
            //    return;
            //}

            //int[,] matrix = new int[valueN, valueM];

            //for (int row = 0; row < matrix.GetLength(0); row++)               //Filling the values of the matrix by the console
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write("matrix[{0},{1}] = ", row, col);
            //        int element = int.Parse(Console.ReadLine());
            //        matrix[row, col] = element;
            //    }
            //}

            int[,] matrix = new int[4, 5] {   {1, 2, 3, 4, 5},                  // N = 4 ; M = 5
                                              {6, 7, 8, 9, 10},
                                              {11, 12, 13, 14, 15},
                                              {16, 17, 18, 19, 20} 
                                           };
            
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] 
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] 
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                   
                    if (bestSum < sum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine("Maximal Sum= {0}", bestSum);
            Console.WriteLine();
            Console.WriteLine(" {0, 3} {1, 3} {2, 3}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
            Console.WriteLine(" {0, 3} {1, 3} {2, 3}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
            Console.WriteLine(" {0, 3} {1, 3} {2, 3}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
            Console.WriteLine();
        }
    }
