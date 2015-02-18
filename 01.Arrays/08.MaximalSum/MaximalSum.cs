/*Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.

Can you do it with only one loop (with single scan through the elements of the array)?
*/

using System;


class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter a value for a length of the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbs = new int[n];

        for (int i = 0; i < numbs.Length; i++)
        {
            Console.Write("numbs[{0}] = ", i);
            numbs[i] = int.Parse(Console.ReadLine());
        }

        int currSum = numbs[0];
        int firstInd = 0;
        int lastInd = 0;
        int temp = 0;
        int maxSum = numbs[0];

        for (int i = 0; i < n; i++)
        {
            if (currSum <= 0)
            {
                firstInd = i;
                currSum = 0;
            }

            currSum += numbs[i];

            if (currSum > maxSum)
            {
                maxSum = currSum;
                temp = firstInd;
                lastInd = i;
            }
        }


        Console.Write("The best sequance is: ");
        for (int i = firstInd; i <= lastInd; i++)
        {
            Console.Write(numbs[i] + ", ");
        }
        Console.WriteLine();
        Console.WriteLine("The max sum is: {0}", maxSum);
    }
}

