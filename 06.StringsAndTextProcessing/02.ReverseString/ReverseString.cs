﻿/*Problem 2. Reverse string

Write a program that reads a string, reverses it and prints the result at the console.
*/

using System;


class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        char[] strArr = str.ToCharArray();

        Array.Reverse(strArr);

        Console.Write("The reversed string: ");
        Console.WriteLine(strArr);

    }
}

