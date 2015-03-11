/*Problem 8. Extract sentences

Write a program that extracts from a given text all sentences containing given word.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class ExtractSentences
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();
        Console.Write("Enter word: ");
        string word = Console.ReadLine();

        string[] sentances = input.Split('.');

        foreach (var sentance in sentances)
        {
            if (sentance.Contains(' ' + word + ' '))
            {
                Console.Write(sentance + ".");
            }
        }
        Console.WriteLine();
    }
}

