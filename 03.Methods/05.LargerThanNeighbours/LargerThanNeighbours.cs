/*Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of 
integers is larger than its two neighbours (when such exist).
*/

using System;


class LargerThanNeighbours
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

        Console.Write("Enter a position: ");
        int position = int.Parse(Console.ReadLine());
        if (position < 0 || position > valueN - 1)
        {
            Console.WriteLine("Wrong position!");
            return;
        }

        bool result = CheckPositions(numbers, position);
        Console.WriteLine("The value of position {0} is larger than its neighbors: {1}", position, result);

    }

    static bool CheckPositions(int[] numbers, int position)
    {
        bool isLarger;
        if (position == 0)
        {
            isLarger = numbers[position] > numbers[position + 1];
        }
        else if (position == numbers.Length - 1)
        {
            isLarger = numbers[position] > numbers[position - 1];
        }
        else
        {
            isLarger = (numbers[position] > numbers[position - 1]) && (numbers[position] > numbers[position + 1]);
        }

        return isLarger;
    }
}
