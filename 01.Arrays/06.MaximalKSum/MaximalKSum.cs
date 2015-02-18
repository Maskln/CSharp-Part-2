/*Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
*/

using System;


class MaximalKSum
{
    static void Main()
    {
        Console.Write("Enter a value for N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter a value for K: ");
        int k = int.Parse(Console.ReadLine());

        int maxSum = 0;

        int[] numbs = new int[n];

        for (int i = 0; i < numbs.Length; i++)
        {
            Console.Write("numbs[{0}] = ", i);
            numbs[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbs);
        Array.Reverse(numbs);

        for (int i = 0; i < k; i++)
        {
            maxSum += numbs[i];
        }

        Console.WriteLine("The sum of the highest {0} elements is {1}", k, maxSum);



    }
}

