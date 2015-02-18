/*Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).
*/

using System;


class FindSumInArray
{
    static void Main()
    {
        Console.Write("Enter a value for the sum \"S\": ");
        int sum = int.Parse(Console.ReadLine());

        Console.Write("Enter a value for a length of the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbs = new int[n];

        for (int i = 0; i < numbs.Length; i++)
        {
            Console.Write("numbs[{0}] = ", i);
            numbs[i] = int.Parse(Console.ReadLine());
        }
        int currentSum = 0;
        int indexStart = 0;

        Console.Write("The result is: ");

        for (int i = 0; i < numbs.Length - 1; i++)
        {
            currentSum += numbs[i];
            indexStart = i;

            for (int j = i + 1; j < n; j++)
            {
                currentSum += numbs[j];

                if (currentSum == sum)
                {
                    for (int k = indexStart; k <= j; k++)
                    {
                        Console.Write("{0}, ", numbs[k]);
                    }
                    break;
                }

            }
            currentSum = 0;
        }
        Console.WriteLine();
    }
}
