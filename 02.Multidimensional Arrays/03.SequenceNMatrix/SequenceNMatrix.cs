/*Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
*/

using System;


class SequenceNMatrix
{
    static void Main()
    {

        //Console.Write("Enter a value for N: ");                           //Filling the value of N by the console
        //int valueN = int.Parse(Console.ReadLine());

        //Console.Write("Enter a value for M: ");                           //Filling the value of N by the console
        //int valueM = int.Parse(Console.ReadLine());
        //Console.WriteLine();

        //string[,] matrix = new string[valueN, valueM];

        //for (int row = 0; row < matrix.GetLength(0); row++)               //Filling the values of the matrix by the console
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write("matrix[{0},{1}] = ", row, col);
        //        string element = Console.ReadLine();
        //        matrix[row, col] = element;
        //    }
        //}

        string[,] matrix = new string[,] {                              
                                             {"ha","fifi","ho","hi"},
                                             {"fo","ha","hi","xx"},
                                             {"xxx","ho","ha","xx"}
                                          };

        string element = string.Empty;
        int currentcount = 1;
        int count = 1;


        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                currentcount = 1;

                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentcount++;
                }
                else
                {
                    currentcount = 1;
                }

                if (currentcount > count)
                {
                    count = currentcount;
                    element = matrix[row, col];
                }
            }
            currentcount = 1;
        }
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentcount++;
                }
                else
                {
                    currentcount = 1;
                }

                if (currentcount > count)
                {
                    count = currentcount;
                    element = matrix[row, col];
                }
            }

            currentcount = 1;
        }
        for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
        {
            if (matrix[row, col] == matrix[row + 1, col + 1])
            {
                currentcount++;
            }
            else
            {
                currentcount = 1;
            }

            if (currentcount > count)
            {
                count = currentcount;
                element = matrix[row, col];
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-6}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        Console.WriteLine(
            );
        Console.Write("Result: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(i < count - 1 ? "{0}, " : "{0}", element);
        }
        Console.WriteLine();
    }
}