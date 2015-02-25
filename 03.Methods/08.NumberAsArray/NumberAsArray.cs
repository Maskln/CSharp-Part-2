/*Problem 8. Number as array

Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
*/

using System;


class NumberAsArray
{
    static void Main()
    {
        Console.Write("Enter a vlaue for a range of the array: ");
        int valueN = int.Parse(Console.ReadLine());

        int[] numbers = new int[valueN];

        for (int i = 0; i < numbers.Length; i++)
        {

            Console.Write("number[{0}]= ", i);
            int element = int.Parse(Console.ReadLine());
            numbers[i] = element;
        }

        Console.Write("Which number do you want to count?: ");
        int valueNum = int.Parse(Console.ReadLine());

        int count = NumberTimesInArray(numbers, valueNum);
        Console.WriteLine("The integer {0} is placed {1} times in the array!", valueNum, count);

    }

    static int NumberTimesInArray(int[] array, int number)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }
}
