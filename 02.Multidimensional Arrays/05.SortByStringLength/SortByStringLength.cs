/*Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts the array
by the length of its elements (the number of characters composing them).
*/

using System;


class SortByStringLength
{
    static void Main()
    {
        Console.Write("Enter a vlaue for the number of elements in the array: ");
        int valueN = int.Parse(Console.ReadLine());

        string[] words = new string[valueN];

        for (int i = 0; i < words.Length; i++)
        {
            Console.Write("words[{0}]= ", i);
            string element = Console.ReadLine();
            words[i] = element;
        }

        Console.WriteLine();
        Console.WriteLine("The sorted Array by length!");
        Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine("word[{0}]= {1}", i, words[i]);
        }

    }

}

