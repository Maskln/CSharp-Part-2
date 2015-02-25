/*Problem 1. Decimal to binary

Write a program to convert decimal numbers to their binary representation.
*/

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int valueN = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} = {1} ", valueN, DecimalToBinaryCon(valueN));
    }

    static string DecimalToBinaryCon(int input)
    {
        string result = "";
        if (input == 0)
        {
            result = "0";
        }
        else
        {
            while (input > 0)
            {
                result = input % 2 + result;
                input /= 2;
            }
        }

        return result;
    }
}