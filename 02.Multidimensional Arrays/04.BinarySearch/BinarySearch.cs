/*Problem 4. Binary search

Write a program, that reads from the console an array of N integers and an integer K, 
sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
*/

using System;


class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter value for a Range of the array: ");
        int valueN = int.Parse(Console.ReadLine());

        Console.Write("Enter a value for K: ");
        int valueK = int.Parse(Console.ReadLine());

        int[] numbers = new int[valueN];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            int element = int.Parse(Console.ReadLine());
            numbers[i] = element;
        }
        Console.WriteLine();

        Array.Sort(numbers);

        int index = Array.BinarySearch(numbers, valueK);

        if (index >= 0)
        {
            Console.WriteLine("numbers[{0}] = {1}", index, numbers[index]);
        }
        else
        {
            index = Math.Abs(index) - 2;
            if (index >= 0)
            {
                Console.WriteLine("numbers[{0}] = {1}", index, numbers[index]);
            }
            else
            {
                Console.WriteLine("The are no less or equal values than {0}", valueK);
            }
        }

    }
}

