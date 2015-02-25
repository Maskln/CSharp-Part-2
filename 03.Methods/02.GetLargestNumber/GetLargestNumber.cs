/*Problem 2. Get largest number

Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
*/

using System;


class GetLargestNumber
{
    static void Main()
    {
        Console.Write("Enter the first value: ");
        int value1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second value: ");
        int value2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third value: ");
        int value3 = int.Parse(Console.ReadLine());

        int largestVal = GetMax(GetMax(value1, value2), value3);

        Console.WriteLine();
        Console.WriteLine("The Largest Value is: {0}", largestVal);

    }

    private static int GetMax(int value1, int value2)
    {
        if (value1 > value2)
        {
            return value1;
        }
        else if (value1 < value2)
        {
            return value2;
        }
        else
        {
            return value1;
        }

    }
}
