/*Problem 24. Order words

Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/

using System;
using System.Linq;

class OrderWords
{
    static void Main()
    {
        Console.Write("Enter a text: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        var sortedWords =
           from w in words
           orderby w
           select w;

        Console.Write("The sorted list of words: ");
        foreach (var w in sortedWords)
        {
            Console.Write(w + " ");
        }
        Console.WriteLine();
    }
}

