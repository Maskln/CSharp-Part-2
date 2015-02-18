/*Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.
*/

using System;


class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter a value for a length of the First array: ");
        int n1 = int.Parse(Console.ReadLine());

        int[] numbs1 = new int[n1];

        for (int i = 0; i < numbs1.Length; i++)
        {
            Console.Write("numbs1[{0}] = ", i);
            numbs1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        Console.Write("Enter a value for a length of the Second array: ");
        int n2 = int.Parse(Console.ReadLine());

        int[] numbs2 = new int[n2];

        for (int i = 0; i < numbs2.Length; i++)
        {
            Console.Write("numbs2[{0}] = ", i);
            numbs2[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        if (numbs1.Length == numbs2.Length)
        {
            for (int i = 0; i < numbs1.Length; i++)
            {
                if (numbs1[i] > numbs2[i])
                {
                    Console.WriteLine("numbs1[{0}] = {1} > numbs2[{2}] = {3}", i, numbs1[i], i, numbs2[i]);
                }
                else if (numbs1[i] < numbs2[i])
                {
                    Console.WriteLine("numbs1[{0}] = {1} < numbs2[{2}] = {3}", i, numbs1[i], i, numbs2[i]);
                }
                else
                {
                    Console.WriteLine("numbs1[{0}] = {1} = numbs2[{2}] = {3}", i, numbs1[i], i, numbs2[i]);
                }
            }
        }
        else
        {
            if (numbs1.Length > numbs2.Length)
            {
                Console.WriteLine("numbs1[{0}] > numbs2[{1}]", numbs1.Length, numbs2.Length);
            }
            else
            {
                Console.WriteLine("numbs1[{0}] < numbs2[{1}]", numbs1.Length, numbs2.Length);
            }
        }




    }
}

