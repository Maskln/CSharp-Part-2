/*Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers
by using the Binary search algorithm.
*/

using System;


class BinarySearch
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
        
        Console.WriteLine();
        
        Console.Write("Enter a required value of the array: ");
        int reqValue = int.Parse(Console.ReadLine());

        Array.Sort(numbs);

        int center = numbs.Length / 2;
        int currentNum = numbs[center];
        int index = 0;

        while (reqValue != currentNum)
        {
            while (reqValue > currentNum)
            {
                center = (numbs.Length + center) / 2;
                currentNum = numbs[center];
            }
            while (reqValue < currentNum)
            {
                center = center / 2;
                currentNum = numbs[center];
            }
        }
        index = center;
        Console.WriteLine();
        Console.WriteLine("{0} = numbs[{1}]", reqValue, index);


    }
}
