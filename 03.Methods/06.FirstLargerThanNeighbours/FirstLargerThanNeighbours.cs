/*Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.
*/

using System;


class FirstLargerThanNeighbours
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

        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int position = i;
            bool result = CheckPositions(numbers, position);

            if (result)
            {
                count++;
                Console.WriteLine("The index of the first element is {0}!", i);
                return;
            }
        }
        if (count == 0)
        {
            Console.WriteLine(-1);
        }
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

