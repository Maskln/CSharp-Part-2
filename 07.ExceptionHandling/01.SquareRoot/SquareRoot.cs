/*Problem 1. Square root

Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.
*/

using System;


class SquareRoot
{
    static void Main()
    {
        try
        {
            uint valueSqrt = uint.Parse(Console.ReadLine());
            double result = Math.Sqrt(valueSqrt);
            Console.WriteLine("Result: {0}", result);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invelid number");
        }
        finally
        {
            Console.WriteLine("Goodbye");
        }

    }
}

