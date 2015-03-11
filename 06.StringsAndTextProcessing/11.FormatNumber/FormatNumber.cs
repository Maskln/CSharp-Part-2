﻿/*Problem 11. Format number

Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.
*/

using System;


    class FormatNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter number");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Decimal number: {0}", input);
            Console.WriteLine("Hexadecimal number: {0:X}", input);
            Console.WriteLine("Percentage: {0:p}", input);
            Console.WriteLine("Scientific notation: {0:e}", input);
        }
    }

