/*Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
*/

using System;


class AppearenceCount
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

        Console.WriteLine();

        Console.Write("Enter a vlaue for check: ");
        int valueCheck = int.Parse(Console.ReadLine());

        int result = CountOfValue(numbers, valueCheck);

        Console.WriteLine();

        Console.WriteLine("There are {0} times value {1} in the array!", result, valueCheck);

    }

    static int CountOfValue(int[] numbers, int valueCheck)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (valueCheck == numbers[i])
            {
                count++;
            }
        }
        return count;
    }
}
