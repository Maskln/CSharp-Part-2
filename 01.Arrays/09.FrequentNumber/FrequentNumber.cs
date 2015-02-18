/*Problem 9. Frequent number

Write a program that finds the most frequent number in an array.
*/

using System;


class FrequentNumber
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

        int countedValue = 0;
        int count = 1;
        int maxCount = 1;
        Array.Sort(numbs);

        for (int i = 0; i < n - 1; i++)
        {
            if (numbs[i] == numbs[i + 1])
            {
                count++;
                
            }
            else
            {
                count = 1;
            }
            if (count > maxCount)
            {
                maxCount = count;
                countedValue = numbs[i];
            }

        }

        Console.WriteLine();

        if (maxCount > 1)
        {
            Console.WriteLine("The Value is: {0}, repeat times: {1}", countedValue, maxCount);
        }
        else
        {
            Console.WriteLine("No values");
        }

        
    }
}

