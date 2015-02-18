/*Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).
*/

using System;


class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter a value for a length of the First array: ");
        int n1 = int.Parse(Console.ReadLine());

        char[] chars1 = new char[n1];

        for (int i = 0; i < chars1.Length; i++)
        {
            Console.Write("chars1[{0}] = ", i);
            chars1[i] = char.Parse(Console.ReadLine());
        }

        Console.Write("Enter a value for a length of the First array: ");
        int n2 = int.Parse(Console.ReadLine());

        char[] chars2 = new char[n2];

        for (int i = 0; i < chars2.Length; i++)
        {
            Console.Write("chars2[{0}] = ", i);
            chars2[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        if (chars1.Length == chars2.Length)
        {
            for (int i = 0; i < chars1.Length; i++)
            {
                if (chars1[i] == chars2[i])
                {
                    Console.WriteLine("chars1[{0}] == chars2[{1}]", i, i);
                }
                else
                {
                    Console.WriteLine("chars1[{0}] != chars2[{1}]", i, i);
                }
            }
        }
        else
        {
            if (chars1.Length > chars2.Length)
            {
                Console.WriteLine("chars1[{0}] > chars2[{1}]", chars1.Length, chars2.Length);
            }
            else
            {
                Console.WriteLine("chars1[{0}] < chars2[{1}]", chars1.Length, chars2.Length);
            }
        }
    }
}
