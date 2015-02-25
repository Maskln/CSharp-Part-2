/*Problem 1. Leap year

Write a program that reads a year from the console and checks whether it is a leap one.
Use System.DateTime.
*/

using System;


class LeapYear
{
    static void Main()
    {
        Console.Write("Enter an year: ");
        int valueYear = int.Parse(Console.ReadLine());

        Console.WriteLine("Is {0} year a leap?\n{1}", valueYear, DateTime.IsLeapYear(valueYear));

    }
}

