﻿/*Problem 14. Word dictionary

A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
*/

using System;


class WordDictionary
{
    static void Main()
    {
        string[,] dict = 
            {
                {".NET", "platform for applications from Microsoft"},
                {"CLR", "managed execution environment for .NET"},
                {"namespace", "hierarchical organization of classes"}
            };

        Console.Write("Enter a word: ");
        string input = Console.ReadLine();

        string output = "Not found!";

        for (int i = 0; i < dict.GetLength(0); i++)
        {
            if (input == dict[i, 0])
            {
                output = dict[i, 1];
                break;
            }
        }
        Console.WriteLine(output);
    }
}

