/*Problem 2. Enter numbers

Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/

using System;


class EnterNumbers
{
    static void Main()
    {
        try
        {
            int start = 1;
            int end = 100;

            ReadNumber(start, end);
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (ArgumentOutOfRangeException ie)
        {
            Console.WriteLine(ie.Message);
        }

    }

    private static void ReadNumber(int start, int end)
    {

        for (int i = 0; i < 10; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

    }
}

